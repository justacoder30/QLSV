using QLSV_3layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(mgv))  
            {
                this.Text = "Thêm mới giáo Viên";

            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên";
                //lay thong tin chi tiet 
                var r = new Database().Select("selectGV '" +  int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaySinh.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rbtNu.Checked = true;
                }
                else
                {
                    rbtNam.Checked = true;
                }
                txtDiaChi.Text = r["diachi"].ToString();
                txtDienThoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();


            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime ngaysinh;
            List<CustomParameter> lstPara = new List<CustomParameter>();   
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                mtbNgaySinh.Select();
                return;
            }

            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithucthi
                });
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithucthi
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = txtHo.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = txtTenDem.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = txtTen.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = rbtNam.Checked ? "0" : "1"
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = txtEmail.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = txtDienThoai.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = txtDiaChi.Text
            });

            var rs = new Database().ExeCute(sql,lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật giáo viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }
    }
}
