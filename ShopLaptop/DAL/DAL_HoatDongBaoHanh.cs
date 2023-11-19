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
    public class DAL_HoatDongBaoHanh
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadHoatDongBaoHanhs()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from hoatdongbaohanh in db.HoatDongBaoHanhs 
                            select new
                            {
                                hoatdongbaohanh.MaNV,
                                hoatdongbaohanh.MaKH,
                                hoatdongbaohanh.MaGoiBH,
                                hoatdongbaohanh.ChiPhiSuaChua,
                                hoatdongbaohanh.SoTienHoTro,
                                hoatdongbaohanh.ThoiGianBH,
                                hoatdongbaohanh.NgayBatDauBH
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertHoatDongBaoHanh(HoatDongBaoHanh hoatDongBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongBaoHanh '{hoatDongBaoHanh.MaNV}','{hoatDongBaoHanh.MaKH}','{hoatDongBaoHanh.MaGoiBH}', '{hoatDongBaoHanh.ChiPhiSuaChua}', '{hoatDongBaoHanh.SoTienHoTro}', '{hoatDongBaoHanh.ThoiGianBH}', 'Insert' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoatDongBaoHanhs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateHoatDongBaoHanh(HoatDongBaoHanh hoatDongBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongBaoHanh '{hoatDongBaoHanh.MaNV}','{hoatDongBaoHanh.MaKH}','{hoatDongBaoHanh.MaGoiBH}', '{hoatDongBaoHanh.ChiPhiSuaChua}', '{hoatDongBaoHanh.SoTienHoTro}', '{hoatDongBaoHanh.ThoiGianBH}', 'Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoatDongBaoHanhs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteHoatDongBaoHanh(HoatDongBaoHanh hoatDongBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongBaoHanh '{hoatDongBaoHanh.MaNV}','{hoatDongBaoHanh.MaKH}','{hoatDongBaoHanh.MaGoiBH}', '{hoatDongBaoHanh.ChiPhiSuaChua}', '{hoatDongBaoHanh.SoTienHoTro}', '{hoatDongBaoHanh.ThoiGianBH}', 'Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoatDongBaoHanhs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindHoatDongBaoHanh(HoatDongBaoHanh hoatdongbaohanh)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.func_SearHoatDongBaoHanh(hoatdongbaohanh.MaNV, hoatdongbaohanh.MaKH, hoatdongbaohanh.MaGoiBH).ToList();
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
