using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_ChiTietHoaDon
    {
        MyConnect myConnect = new MyConnect();
        public DataTable LoadChiTietHoaDons()
        {
            try
            {
                this.myConnect.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon",
                    myConnect.getConnection);

                DataTable dt = new DataTable();
                myConnect.openConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                myConnect.closeConnection();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool AddChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            bool isInsertSuccessfully = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand(
                    $"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Insert' ",
                    myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isInsertSuccessfully = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isInsertSuccessfully = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isInsertSuccessfully = false;
            }
            finally { myConnect.closeConnection(); }
            return isInsertSuccessfully;
        }

        public bool EditChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            bool isEditSuccessfully = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Update'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isEditSuccessfully = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isEditSuccessfully = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isEditSuccessfully = false;
            }
            finally { myConnect.closeConnection(); }
            return isEditSuccessfully;
        }

        public bool XoaChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            bool isDeleteSuccessfully = false;
            try
            {
                myConnect.openConnection();
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Delete'", myConnect.getConnection);
                cmd.ExecuteNonQuery();
                isDeleteSuccessfully = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isDeleteSuccessfully =  false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isDeleteSuccessfully = false;
            }
            finally { myConnect.closeConnection(); }
            return isDeleteSuccessfully;
        }
    }
}