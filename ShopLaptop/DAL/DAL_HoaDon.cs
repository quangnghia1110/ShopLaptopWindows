using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
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
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadHoaDons()
        {
            DataTable dt = new DataTable();
            try
            {
                var list = (from hoadon in db.HoaDons 
                            select new 
                            {
                                hoadon.MaHD,
                                hoadon.MaKH,
                                hoadon.MaNV,
                                hoadon.NgayMuaHang,
                                hoadon.SoTienThanhToanHoaDon,
                                hoadon.PhuongThucThanhToan,
                                hoadon.TrangThaiThanhToan
                            }).ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool InsertHoaDon(HoaDon hoaDon)
        {
            bool isSuccess = false;
            try
            {
                db.ExecuteCommand($"EXEC sp_ReviseHoaDon '{hoaDon.MaHD}', '{hoaDon.MaKH}', '{hoaDon.MaNV}', {hoaDon.SoTienThanhToanHoaDon}, N'{hoaDon.PhuongThucThanhToan}', N'{hoaDon.TrangThaiThanhToan}', 'INSERT'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoaDons);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateHoaDon(HoaDon hoaDon)
        {
            bool isSuccess = false;
            try
            {
                db.ExecuteCommand($"EXEC sp_ReviseHoaDon '{hoaDon.MaHD}', '{hoaDon.MaKH}', '{hoaDon.MaNV}', {hoaDon.SoTienThanhToanHoaDon}, N'{hoaDon.PhuongThucThanhToan}', N'{hoaDon.TrangThaiThanhToan}', 'Update'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoaDons);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteHoaDon(HoaDon hoaDon)
        {
            bool isSuccess = false;
            try
            {
                db.ExecuteCommand($"EXEC sp_ReviseHoaDon '{hoaDon.MaHD}', '{hoaDon.MaKH}', '{hoaDon.MaNV}', {hoaDon.SoTienThanhToanHoaDon}, N'{hoaDon.PhuongThucThanhToan}', N'{hoaDon.TrangThaiThanhToan}', 'Delete'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoaDons);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindHoaDon(DateTime fromDate, DateTime toDate)
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list =  db.func_SearchOrderByPeroid(fromDate, toDate).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}
