using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_GoiBaoHanh
    {
        MyConnect myConnect = new MyConnect();
        public DataTable LoadGoiBaoHanhs()
        {
            DataTable dataTable = new DataTable();
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GoiBaoHanh", myConnect.getConnection);
                dataTable.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally { myConnect.closeConnection(); }
            return dataTable;
        }
        public bool InsertGoiBaoHanh(string maGoiBaoHanh, string tenGoiBH, string moTaChiTiet)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiBaoHanh '{maGoiBaoHanh}', N'{tenGoiBH}', N'{moTaChiTiet}', 'Insert'", myConnect.getConnection);
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
        public bool UpdateGoiBaoHanh(string maGoiBaoHanh, string tenGoiBH, string moTaChiTiet)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiBaoHanh '{maGoiBaoHanh}', N'{tenGoiBH}', N'{moTaChiTiet}', 'Update'", myConnect.getConnection);
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
        public bool DeleteGoiBaoHanh(string maGoiBaoHanh, string tenGoiBH, string moTaChiTiet)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiBaoHanh '{maGoiBaoHanh}', N'{tenGoiBH}', N'{moTaChiTiet}', 'Delete'", myConnect.getConnection);
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
