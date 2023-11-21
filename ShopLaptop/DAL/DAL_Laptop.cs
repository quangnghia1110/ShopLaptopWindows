using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ShopLaptop.DAL
{
    public class DAL_Laptop
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
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
    }
}
