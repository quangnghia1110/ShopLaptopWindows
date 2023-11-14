using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_HoatDongBaoHanh
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadHoatDongBaoHanhs()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from hoatdongbaohanh in db.HoatDongBaoHanhs select hoatdongbaohanh).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertGoiBaoHanh(HoatDongBaoHanh hoatDongBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongBaoHanh '{hoatDongBaoHanh.MaNV}','{hoatDongBaoHanh.MaKH}','{hoatDongBaoHanh.MaGoiBH}', '{hoatDongBaoHanh.ChiPhiSuaChua}', '{hoatDongBaoHanh.SoTienHoTro}', '{hoatDongBaoHanh.ThoiGianBH}', 'Insert' ");
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
        public bool UpdateGoiBaoHanh(HoatDongBaoHanh hoatDongBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongBaoHanh '{hoatDongBaoHanh.MaNV}','{hoatDongBaoHanh.MaKH}','{hoatDongBaoHanh.MaGoiBH}', '{hoatDongBaoHanh.ChiPhiSuaChua}', '{hoatDongBaoHanh.SoTienHoTro}', '{hoatDongBaoHanh.ThoiGianBH}', 'Update' ");
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
        public bool DeleteGoiBaoHanh(HoatDongBaoHanh hoatDongBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongBaoHanh '{hoatDongBaoHanh.MaNV}','{hoatDongBaoHanh.MaKH}','{hoatDongBaoHanh.MaGoiBH}', '{hoatDongBaoHanh.ChiPhiSuaChua}', '{hoatDongBaoHanh.SoTienHoTro}', '{hoatDongBaoHanh.ThoiGianBH}', 'Delete' ");
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
    }
}
