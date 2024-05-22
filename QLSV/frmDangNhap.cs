using QLSV_3layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaiTK;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktr_rbuoc
            //kiểm tra ràng buộc
            if (cbbLoaiTK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản","Tài khoản không thể để trống");
                return;
            }
            if(string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtTenDN.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu","Mật khẩu không thể để trống");
                txtMatKhau.Select();
                return;
            }
            #endregion
            tendangnhap = txtTenDN.Text;
            loaiTK = "";
            #region swtk
            switch (cbbLoaiTK.Text)
            {
                case "Quản trị viên":
                    loaiTK = "admin";
                        break;
                case "Giáo viên":
                    loaiTK = "gv";
                    break;
                case "Sinh viên":
                    loaiTK = "sv";
                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@loaitaikhoan",
                    value =loaiTK
                },
                new CustomParameter()
                {
                    key="@taikhoan",
                    value =txtTenDN.Text
                },
                new CustomParameter()
                {
                    key="@matkhau",
                    value =txtMatKhau.Text
                },
            };
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu","Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
