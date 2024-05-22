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
    public partial class frmDSLopHoc : Form
    {
        public frmDSLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSLopHoc_Load(object sender, EventArgs e)
        {
            loadDSLopHoc();
        }
        private void loadDSLopHoc()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql,lstPara);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            loadDSLopHoc();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();
            loadDSLopHoc();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                new frmLopHoc(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                loadDSLopHoc();
            }
        }
    }
}
