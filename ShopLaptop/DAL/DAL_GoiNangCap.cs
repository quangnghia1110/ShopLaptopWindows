using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_GoiNangCap
    {
        MyConnect myConnect = new MyConnect();
        public DataTable LoadGoiNangCaps()
        {
            DataTable dt = new DataTable();
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GoiNangCap", myConnect.getConnection);
                myConnect.openConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                dt = null;
            }
            finally
            {
                myConnect.closeConnection();
            }
            return dt;
        }

        public bool InsertGoiNangCap(string maGoiNangCap, string tenGoiNC, string phiNC)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiNangCap '{maGoiNangCap}', N'{tenGoiNC}', '{phiNC}', 'Insert'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            finally { myConnect.closeConnection(); }
            return isSuccess;
        }
        public bool DeleteGoiNangCap(string maGoiNangCap, string tenGoiNC, string phiNC)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiNangCap '{maGoiNangCap}', N'{tenGoiNC}', '{phiNC}', 'Delete'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            finally { myConnect.closeConnection(); }
            return isSuccess;
        }
        public bool UpdateGoiNangCap(string maGoiNangCap, string tenGoiNC, string phiNC)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiNangCap '{maGoiNangCap}', N'{tenGoiNC}', '{phiNC}', 'Update'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            finally { myConnect.closeConnection(); }
            return isSuccess;
        }

    }
}
