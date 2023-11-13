using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;

namespace ShopLaptop.DAL
{
    public class DAL_ChiTietPhieuNhap
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadChiTietPhieuNhaps()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from hoadon in db.ChiTietPhieuNhaps select hoadon).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietPhieuNhap '{chiTietPhieuNhap.MaLT}', '{chiTietPhieuNhap.MaNK}', '{chiTietPhieuNhap.SoLuongSP}', {chiTietPhieuNhap.GiaNhapTungSP}, N'{chiTietPhieuNhap.ThueVAT}', '{chiTietPhieuNhap.ThanhTienTungSP}', 'Insert'");
                db.SubmitChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess= false;
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public bool UpdateChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietPhieuNhap '{chiTietPhieuNhap.MaLT}', '{chiTietPhieuNhap.MaNK}', '{chiTietPhieuNhap.SoLuongSP}', {chiTietPhieuNhap.GiaNhapTungSP}, N'{chiTietPhieuNhap.ThueVAT}', '{chiTietPhieuNhap.ThanhTienTungSP}', 'Update'");
                db.SubmitChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public bool DeleteChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietPhieuNhap '{chiTietPhieuNhap.MaLT}', '{chiTietPhieuNhap.MaNK}', '{chiTietPhieuNhap.SoLuongSP}', {chiTietPhieuNhap.GiaNhapTungSP}, N'{chiTietPhieuNhap.ThueVAT}', '{chiTietPhieuNhap.ThanhTienTungSP}', 'Delete'");
                db.SubmitChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
    }
}
