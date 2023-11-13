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
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadChiTietHoaDons()
        {
            DataTable dataTable = new DataTable();
            try 
            {
                DataTable dt = new DataTable();
                var list = (from hoadon in db.ChiTietHoaDons select hoadon).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public bool AddChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            bool isSuccess = false;
            try
            {
                //myConnect.openConnection();
                //SqlCommand cmd = new SqlCommand(
                //    $"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Insert' ",
                //    myConnect.getConnection);
                //cmd.ExecuteNonQuery();
                //isSuccess = true;
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Insert' ");
                db.SubmitChanges();
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        public bool EditChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            bool isSuccess = false;
            try
            {
                //myConnect.openConnection();
                //SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Update'", myConnect.getConnection);
                //cmd.ExecuteNonQuery();
                //isEditSuccessfully = true;
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Update' ");
                db.SubmitChanges();
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        public bool XoaChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            bool isSuccess = false;
            try
            {
                //myConnect.openConnection();
                //SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Delete'", myConnect.getConnection);
                //cmd.ExecuteNonQuery();
                //isSuccess = true;
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietHoaDon '{maLT}', '{maHD}', '{soLuongSP}', {giaBanTungSP}, '{thueVAT}', '{khuyenMai}', '{thanhTienTungSP}', 'Delete' ");
                db.SubmitChanges();
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess =  false;
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