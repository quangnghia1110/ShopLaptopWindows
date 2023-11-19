using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Data.Linq;

namespace ShopLaptop.DAL
{
    public class DAL_ChiTietHoaDon
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadChiTietHoaDons()
        {
            DataTable dataTable = new DataTable();
            try 
            {
                var list = (from hoadon in db.ChiTietHoaDons 
                            select new
                            {
                                hoadon.MaLT,
                                hoadon.MaHD,
                                hoadon.SoLuongSP,
                                hoadon.GiaBanTungSP,
                                hoadon.ThueVAT,
                                hoadon.KhuyenMai,
                                hoadon.ThanhTienTungSP
                            }
                            ).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public bool InsertChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietHoaDon '{chiTietHoaDon.MaLT}', '{chiTietHoaDon.MaHD}', '{chiTietHoaDon.SoLuongSP}', {chiTietHoaDon.GiaBanTungSP}, '{chiTietHoaDon.ThueVAT}', '{chiTietHoaDon.KhuyenMai}', '{chiTietHoaDon.ThanhTienTungSP}', 'Insert' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.ChiTietHoaDons);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        public bool UpdateChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietHoaDon '{chiTietHoaDon.MaLT}', '{chiTietHoaDon.MaHD}', '{chiTietHoaDon.SoLuongSP}', {chiTietHoaDon.GiaBanTungSP}, '{chiTietHoaDon.ThueVAT}', '{chiTietHoaDon.KhuyenMai}', '{chiTietHoaDon.ThanhTienTungSP}', 'Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.ChiTietHoaDons);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        public bool DeleteChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseChiTietHoaDon '{chiTietHoaDon.MaLT}', '{chiTietHoaDon.MaHD}', '{chiTietHoaDon.SoLuongSP}', {chiTietHoaDon.GiaBanTungSP}, '{chiTietHoaDon.ThueVAT}', '{chiTietHoaDon.KhuyenMai}', '{chiTietHoaDon.ThanhTienTungSP}', 'Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.ChiTietHoaDons);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}