using QLSV_3layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc(string manh)
        {
            this.manh = manh;
            InitializeComponent();
        }
        private string manh;
        private string nguoithuchien = "admin";
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var stc = int.Parse(txtSoTC.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSoTC.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
                txtSoTC.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {

                MessageBox.Show("Tên môn học không được để trống");
                txtTenMonHoc.Select();
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(manh))
            {
                sql = "insertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = manh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                sql = "updateMH";
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtTenMonHoc.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txtSoTC.Text
            });
            var rs = new Database().ExeCute(sql,lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(manh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(manh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "cập nhật môn học";
                var r = new Database().Select("exec selectMH '" + manh + "'");
                txtTenMonHoc.Text = r["tenmonhoc"].ToString();
                txtSoTC.Text = r["sotinchi"].ToString();
            }
        }
    }
}
