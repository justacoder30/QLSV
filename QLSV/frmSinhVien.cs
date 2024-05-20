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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(msv))//nếu msv không có -> thêm mới sinh viên
            {
                this.Text = "Thêm mới sinh viên";

            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                //lay thong tin chi tiet 
                var r = new Database().Select(string.Format("selectSV '" + msv + "'"));
                //MessageBox.Show(r[0].ToString());//thanh cong
                //set cac gtr vao commponent cua form
                txtHo.Text = r["ho"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaySinh.Text = r["ngaysinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1) 
                {
                    rbtNu.Checked = true;
                }
                else 
                { rbtNam.Checked = true;
                }

                txtQueQuan.Text = r["quequan"].ToString();
                txtDiaChi.Text = r["diachi"].ToString();
                txtDienThoai.Text= r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();


            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //TH1: msv = null -> them moi
            //TH2: cap nhat
            /*y tuong:
              thêm mới và cập nhật đều cần các giái trị trừ cập nhật cần chú ý msv
             

            */
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTenDem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch(Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                mtbNgaySinh.Select();
                return;
            }

            string gioitinh = rbtNu.Checked ? "1" : "0";

            string quequan = txtQueQuan.Text;
            string diachi = txtDiaChi.Text;
            string dienthoai = txtDienThoai.Text;
            string email = txtEmail.Text;


            //khai bao
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))//them moi
            {
                sql = "ThemMoiSV";
                
            }
            else//cap nhat
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho,

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh,

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan,

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi,

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai,

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email,

            });


            var rs = new Database().ExeCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql và ds các tham số
            if (rs == 1)//thanh cong
            {
                if(string.IsNullOrEmpty(msv))//them moi
                {
                    MessageBox.Show("Thêm mới sinh viên thành công!");
                }
                else//cập nhật
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!");
                }
                this.Dispose();//đóng sau thông báo

            }
            else//khong thanh cong
            {
                MessageBox.Show("Thực thi thất bại!");
            }


        }
    }
}
