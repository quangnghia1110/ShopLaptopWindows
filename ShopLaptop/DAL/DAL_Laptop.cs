using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
namespace ShopLaptop.DAL
{
    public class DAL_Laptop
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        MyConnect myconn = new MyConnect();
        public DataTable LoadLaptops()
        {
            DataTable dt = new DataTable();
            try
            {   
                var query = (from laptop in db.Laptops
                                select new
                                {
                                    MaLT = laptop.MaLT,
                                    TenLT = laptop.TenLT,
                                    TenHangLT = laptop.TenHangLT,
                                    SoLuong = laptop.SoLuong,
                                    KhoiLuong = laptop.KhoiLuong,
                                    HanBaoHanh = laptop.HanBaoHanh,
                                    MauSac = laptop.MauSac,
                                    DungLuongBoNho = laptop.DungLuongBoNho,
                                    ManHinh = laptop.ManHinh,
                                    CPU = laptop.CPU,
                                    QuaTangKem = laptop.QuaTangKem,
                                    Pin = laptop.Pin,
                                }
                             ).ToList();
                dt = CustomFuncs.ConvertListToDataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }
        public bool InsertLaptop(Laptop laptop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseLaptop '{laptop.MaLT}', N'{laptop.TenLT}', N'{laptop.TenHangLT}', {laptop.SoLuong}, {laptop.KhoiLuong}, {laptop.HanBaoHanh}, N'{laptop.MauSac}', {laptop.DungLuongBoNho}, N'{laptop.ManHinh}', N'{laptop.CPU}', N'{laptop.QuaTangKem}', N'{laptop.Pin}', '{laptop.anhLaptop}', 'INSERT' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.Laptops);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
       
        public bool DeleteLaptop(Laptop laptop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseLaptop '{laptop.MaLT}', N'{laptop.TenLT}', N'{laptop.TenHangLT}', {laptop.SoLuong}, {laptop.KhoiLuong}, {laptop.HanBaoHanh}, N'{laptop.MauSac}', {laptop.DungLuongBoNho}, N'{laptop.ManHinh}', N'{laptop.CPU}', N'{laptop.QuaTangKem}', N'{laptop.Pin}', 'Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.Laptops);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        public bool UpdateLaptop(Laptop laptop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseLaptop '{laptop.MaLT}', N'{laptop.TenLT}', N'{laptop.TenHangLT}', {laptop.SoLuong}, {laptop.KhoiLuong}, {laptop.HanBaoHanh}, N'{laptop.MauSac}', {laptop.DungLuongBoNho}, N'{laptop.ManHinh}', N'{laptop.CPU}', N'{laptop.QuaTangKem}', N'{laptop.Pin}', '{laptop.anhLaptop}', 'Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.Laptops);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable LoadLaptop()
        {
            string sql = "Select * from Laptop";
            DataTable dt = new DataTable();
            myconn.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, myconn.getConnection);
            da.Fill(dt);
            myconn.closeConnection();
            return dt;
        }
        public int ThemLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin, byte[] anhLaptop)
        {
            string sql = "Insert into Laptop(MaLT, TenLT, TenHangLT, SoLuong, KhoiLuong, HanBaoHanh, MauSac, DungLuongBoNho, ManHinh, CPU, QuaTangKem, Pin, anhLaptop) Values (@MaLT, @TenLT, @TenHangLT, @SoLuong, @KhoiLuong, @HanBaoHanh, @MauSac, @DungLuongBoNho, @ManHinh, @CPU, @QuaTangKem, @Pin, @anhLaptop)";
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand(sql, myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaLT", MaLT);
            cmd.Parameters.AddWithValue("@TenLT", TenLT);
            cmd.Parameters.AddWithValue("@TenHangLT", TenHangLT);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@KhoiLuong", KhoiLuong);
            cmd.Parameters.AddWithValue("@HanBaoHanh", HanBaoHanh);
            cmd.Parameters.AddWithValue("@MauSac", MauSac);
            cmd.Parameters.AddWithValue("@DungLuongBoNho", DungLuongBoNho);
            cmd.Parameters.AddWithValue("@ManHinh", ManHinh);
            cmd.Parameters.AddWithValue("@CPU", CPU);
            cmd.Parameters.AddWithValue("@QuaTangKem", QuaTangKem);
            cmd.Parameters.AddWithValue("@Pin", Pin);
            cmd.Parameters.AddWithValue("@anhLaptop", anhLaptop);
            int res = cmd.ExecuteNonQuery();
            myconn.closeConnection();
            return res;
        }

        public int SuaLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin, byte[] anhLaptop)
        {
            string sql = "Update Laptop set TenLT = @TenLT, TenHangLT = @TenHangLT, SoLuong = @SoLuong, KhoiLuong = @KhoiLuong, HanBaoHanh = @HanBaoHanh, MauSac = @MauSac, DungLuongBoNho = @DungLuongBoNho, ManHinh = @ManHinh, CPU = @CPU, QuaTangKem = @QuaTangKem, Pin = @Pin, anhLaptop = @anhLaptop where MaLT = @MaLT";
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand(sql, myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaLT", MaLT);
            cmd.Parameters.AddWithValue("@TenLT", TenLT);
            cmd.Parameters.AddWithValue("@TenHangLT", TenHangLT);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@KhoiLuong", KhoiLuong);
            cmd.Parameters.AddWithValue("@HanBaoHanh", HanBaoHanh);
            cmd.Parameters.AddWithValue("@MauSac", MauSac);
            cmd.Parameters.AddWithValue("@DungLuongBoNho", DungLuongBoNho);
            cmd.Parameters.AddWithValue("@ManHinh", ManHinh);
            cmd.Parameters.AddWithValue("@CPU", CPU);
            cmd.Parameters.AddWithValue("@QuaTangKem", QuaTangKem);
            cmd.Parameters.AddWithValue("@Pin", Pin);
            cmd.Parameters.AddWithValue("@anhLaptop", anhLaptop);
            int res = cmd.ExecuteNonQuery();
            myconn.closeConnection();
            return res;
        }

        public int XoaLaptop(string MaLT)
        {
            string sql = "Delete Laptop where MaLT = @MaLT";
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand(sql, myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaLT", MaLT);
            int res = cmd.ExecuteNonQuery();
            myconn.closeConnection();
            return res;
        }

        public DataTable FindLaptop(Laptop laptop)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.fn_TimKiemLaptop(laptop.TenLT,laptop.KhoiLuong,laptop.TenHangLT,laptop.MauSac,laptop.ManHinh).ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable SelectNameTop5BuyedLaptop(string year)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.HoaDons
                    .Join(db.ChiTietHoaDons, hoadon => hoadon.MaHD, chiTietHoaDon => chiTietHoaDon.MaHD, (hoaDon, chiTietHoaDon) => new { HoaDon = hoaDon, ChiTietHoaDon = chiTietHoaDon })
                    .Join(db.Laptops, joinedData => joinedData.ChiTietHoaDon.MaLT, laptop => laptop.MaLT, (joinedData, laptop) => new { HoaDon = joinedData.HoaDon, ChiTietHoaDon = joinedData.ChiTietHoaDon, Laptop = laptop })
                    .Where(data => data.HoaDon.NgayMuaHang.Value.Year == Convert.ToInt32(year))
                    .GroupBy(data => new { data.Laptop.TenLT, Year = data.HoaDon.NgayMuaHang.Value.Year })
                    .Select(groupedData => new
                    {
                        TenLT = groupedData.Key.TenLT,
                        Total = groupedData.Sum(data => data.HoaDon.SoTienThanhToanHoaDon),
                    }).Take(10)
                    .ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable CountLaptop()
        {
            DataTable dt = new DataTable();
            try
            {
                var list = (from laptop in db.Laptops
                            select new
                            {
                                TenLT = laptop.TenLT,
                                SoLuong = laptop.SoLuong
                            }).ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
