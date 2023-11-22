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
        public DataTable FindHoaDonOnYear(string year)
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from hoadon in db.HoaDons
                            where hoadon.NgayMuaHang.Value.Year == Convert.ToInt32(year)
                            group hoadon by hoadon.NgayMuaHang.Value.Month into g
                            orderby g.Key
                            select new
                            {
                                Month = g.Key,
                                Total = g.Sum(hd =>hd.SoTienThanhToanHoaDon)
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
        public int[] SelectDistinctYear()
        {
            var list = new int[] { };
            try
            {
                list =  (from hoadon in db.HoaDons
                            select hoadon.NgayMuaHang.Value.Year
                            ).Distinct().ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return list;
        }
        public int SumSoTienOnMonthAndYear(int month, int year) 
        {
            int result = 0;
            try
            {
                var query = (from hoadon in db.HoaDons
                             where hoadon.NgayMuaHang.Value.Month == month
                                     && hoadon.NgayMuaHang.Value.Year == year
                             select hoadon.SoTienThanhToanHoaDon
                            ).FirstOrDefault();
                if (query != null)
                {
                    result = query.Value;
                }
                else result = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return result;
        }
        public int CountSoLuongHoaDonOnMonthAndYear(int month,int year)
        {
            int result = 0;
            try
            {
                result = db.HoaDons
                            .Where(hoadon => hoadon.NgayMuaHang.Value.Month == month && hoadon.NgayMuaHang.Value.Year == year)
                            .Select(hoadon => hoadon.SoTienThanhToanHoaDon)
                            .Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return result;
        }
        public DataTable CountPhuongThucThanhToanOnMonthAndYear(int year)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = (from hoadon in db.HoaDons
                            where hoadon.NgayMuaHang.HasValue &&
                                  hoadon.NgayMuaHang.Value.Year == year
                            group hoadon by new
                            {
                                hoadon.PhuongThucThanhToan,
                                Month = hoadon.NgayMuaHang.Value.Month
                            } into g
                            select new
                            {
                                PhuongThucThanhToan = g.Key.PhuongThucThanhToan,
                                Total = g.Count(),
                                Month = g.Key.Month
                            }).ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt ;
        }
    }
}
