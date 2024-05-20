using QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();


        }

        private void LoadDSSV()
        {
            //load danh sach sv
            dgvSinhVien.DataSource = new Database().SelectData("EXEC SelectAllSinhVien");
            //dat ten cot
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã sinh viên";

            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
        }





        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //double click -> form update SV
            //MSSV 
            if (e.RowIndex >=0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                //truyền msv vào form sinh viên
                new frmSinhVien(msv).ShowDialog();
                //sau khi form SV đóng -> load ds SV
                LoadDSSV();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();//nếu thêm mới sv -> mã sv = null 
            LoadDSSV();
        }
    }
}