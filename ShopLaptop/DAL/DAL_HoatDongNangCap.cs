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
    public  class DAL_HoatDongNangCap
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadHoatDongNangCaps()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from hdnc in db.HoatDongNangCaps
                            select new
                            {
                                hdnc.MaNV,
                                hdnc.MaKH,
                                hdnc.MaGoiNC
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;

        }
        public bool InsertHoatDongNangCap(HoatDongNangCap hoatDongNangCap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongNangCap '{hoatDongNangCap.MaNV }','{hoatDongNangCap.MaKH}','{hoatDongNangCap.MaGoiNC}', 'Insert' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoatDongNangCaps);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateHoatDongNangCap(HoatDongNangCap hoatDongNangCap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongNangCap '{hoatDongNangCap.MaNV}','{hoatDongNangCap.MaKH}','{hoatDongNangCap.MaGoiNC}', 'Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoatDongNangCaps);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteHoatDongNangCap(HoatDongNangCap hoatDongNangCap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseHoatDongNangCap '{hoatDongNangCap.MaNV}','{hoatDongNangCap.MaKH}','{hoatDongNangCap.MaGoiNC}', 'Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.HoatDongNangCaps);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindHoatDongNangCap(HoatDongNangCap hoatDongNangCap)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.func_SearHoatDongNangCap(hoatDongNangCap.MaNV, hoatDongNangCap.MaKH, hoatDongNangCap.MaGoiNC).ToList();
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
