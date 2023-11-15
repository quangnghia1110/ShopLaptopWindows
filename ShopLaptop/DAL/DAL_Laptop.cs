using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_Laptop
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadLaptops()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from laptop in db.Laptops select laptop).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertLaptop(Laptop laptop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseLaptop '{laptop.MaLT}', N'{laptop.TenLT}', N'{laptop.TenHangLT}', {laptop.SoLuong}, {laptop.KhoiLuong}, {laptop.HanBaoHanh}, N'{laptop.MauSac}', {laptop.DungLuongBoNho}, N'{laptop.ManHinh}', N'{laptop.CPU}', N'{laptop.QuaTangKem}', N'{laptop.Pin}', 'INSERT' ");
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
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseLaptop '{laptop.MaLT}', N'{laptop.TenLT}', N'{laptop.TenHangLT}', {laptop.SoLuong}, {laptop.KhoiLuong}, {laptop.HanBaoHanh}, N'{laptop.MauSac}', {laptop.DungLuongBoNho}, N'{laptop.ManHinh}', N'{laptop.CPU}', N'{laptop.QuaTangKem}', N'{laptop.Pin}', 'Update' ");
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
