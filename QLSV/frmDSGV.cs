using QLSV_3layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvGiaoVien.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmGiaoVien(null).ShowDialog();
            loadDSGV();
        }

        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvGiaoVien.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGiaoVien(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvGiaoVien.Columns["btnXoa"].Index)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên:" + dgvGiaoVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + "?", "Xác nhận xóa!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (e.ColumnIndex == dgvGiaoVien.Columns["btnXoa"].Index)
                        {
                            var maGV = dgvGiaoVien.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                            var sql = "deleteGV";
                            List<CustomParameter> lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key ="@magiaovien",
                            value = maGV
                        }
                    };
                            new Database().ExeCute(sql, lstPara);
                            MessageBox.Show("Xóa giáo viên thành công!");
                            loadDSGV();
                        }
                    }
                }


            }
        }
    }
}
