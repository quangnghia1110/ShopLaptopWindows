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
    public class DAL_HoaDon
    {
        MyConnect myConnect = new MyConnect();
        public DataTable LoadHoaDons()
        {
            DataTable dt = new DataTable();
            try
            {
                myConnect.openConnection();
                DataTable dataTable = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon", myConnect.getConnection);
                dataTable.Load(cmd.ExecuteReader());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                myConnect.closeConnection();
            }
            return dt;
        }

        public bool InsertHoaDon(string maHD, string maKH_HD, string maNV_HD, string soTienThanhToan_HD, string phuongThucThanhToan_HD, string trangThaiThanhToan_HD)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoaDon '{maHD}', '{maKH_HD}', '{maNV_HD}', {soTienThanhToan_HD}, N'{phuongThucThanhToan_HD}', N'{trangThaiThanhToan_HD}', 'INSERT'", myConnect.getConnection);
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
        public bool UpdateHoaDon(string maHD, string maKH_HD, string maNV_HD, string soTienThanhToan_HD, string phuongThucThanhToan_HD, string trangThaiThanhToan_HD)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoaDon '{maHD}', '{maKH_HD}', '{maNV_HD}', {soTienThanhToan_HD}, N'{phuongThucThanhToan_HD}', N'{trangThaiThanhToan_HD}', 'Update'", myConnect.getConnection);
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
        public bool DeleteHoaDon(string maHD, string maKH_HD, string maNV_HD, string soTienThanhToan_HD, string phuongThucThanhToan_HD, string trangThaiThanhToan_HD)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoaDon '{maHD}', '{maKH_HD}', '{maNV_HD}', {soTienThanhToan_HD}, N'{phuongThucThanhToan_HD}', N'{trangThaiThanhToan_HD}', 'Delete'", myConnect.getConnection);
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
