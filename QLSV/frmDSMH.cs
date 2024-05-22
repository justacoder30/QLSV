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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var manh = dgvMonHoc.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new frmMonHoc(manh).ShowDialog();
                LoadDSMH();
            }
        }
        private string tukhoa = "";
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmMonHoc(null).ShowDialog();
            LoadDSMH();
        }
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvMonHoc.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvMonHoc.Columns["mamonhoc"].HeaderText = "Mã MH";
            dgvMonHoc.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvMonHoc.Columns["sotinchi"].HeaderText = "Số TC";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSMH() ;    
        } 
    }
}
