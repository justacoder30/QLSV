using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public class Database
    {
        private string connetionString = @"Data Source=127.0.0.1;Initial Catalog=QLSinhVien;User ID = sa;Password =17052016";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public Database() 
        {
            try
            {
                conn = new SqlConnection(connetionString);
                

            }catch (Exception ex)
            {
                MessageBox.Show("Connected failed:"+ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstParameter)
        {
            try
            {
                conn.Open();
                
                cmd = new SqlCommand(sql, conn);//nd sql duoc truyen vao
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
