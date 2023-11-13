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
    public class DAL_ChiTietPhieuNhap
    {
        MyConnect myConnect = new MyConnect();
        public DataTable LoadChiTietPhieuNhaps()
        {
            DataTable dt = new DataTable();
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap", myConnect.getConnection);
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
        public bool AddChiTietPhieuNhap(string maLT, string maNK, string soLuongSP, string giaNhapTungSP, string thueVAT, string thanhTienTungSP)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{maLT}', '{maNK}', '{soLuongSP}', {giaNhapTungSP}, N'{thueVAT}', '{thanhTienTungSP}', 'Insert'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess= false;
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                myConnect.closeConnection() ;
            }
            return isSuccess;
        }
        public bool UpdateChiTietPhieuNhap(string maLT, string maNK, string soLuongSP, string giaNhapTungSP, string thueVAT, string thanhTienTungSP)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{maLT}', '{maNK}', '{soLuongSP}', {giaNhapTungSP}, N'{thueVAT}', '{thanhTienTungSP}', 'Update'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                myConnect.closeConnection();
            }
            return isSuccess;
        }
        public bool DeleteChiTietPhieuNhap(string maLT, string maNK, string soLuongSP, string giaNhapTungSP, string thueVAT, string thanhTienTungSP)
        {
            bool isSuccess = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{maLT}', '{maNK}', '{soLuongSP}', {giaNhapTungSP}, N'{thueVAT}', '{thanhTienTungSP}', 'Delete'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                myConnect.closeConnection();
            }
            return isSuccess;
        }
    }
}
