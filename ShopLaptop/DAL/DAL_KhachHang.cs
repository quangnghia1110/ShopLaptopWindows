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
    public class DAL_KhachHang
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadKhachHangs()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from khachHang in db.KhachHangs 
                            select new
                            {
                                khachHang.MaKH,
                                khachHang.LoaiKH,
                                khachHang.HoTenKH,
                                khachHang.SoCCCD,
                                khachHang.SDT,
                                khachHang.TongSoTienDaGD
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertKhachHang(KhachHang khachHang)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseKhachHang '{khachHang.MaKH}', '{khachHang.LoaiKH}', N'{khachHang.HoTenKH}', '{khachHang.SoCCCD}', '{khachHang.SDT}', '{khachHang.TongSoTienDaGD}','Insert' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.KhachHangs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateKhachHang(KhachHang khachHang)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseKhachHang '{khachHang.MaKH}', '{khachHang.LoaiKH}', N'{khachHang.HoTenKH}', '{khachHang.SoCCCD}', '{khachHang.SDT}', '{khachHang.TongSoTienDaGD}','Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.KhachHangs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteKhachHang(KhachHang khachHang)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseKhachHang '{khachHang.MaKH}', '{khachHang.LoaiKH}', N'{khachHang.HoTenKH}', '{khachHang.SoCCCD}', '{khachHang.SDT}', '{khachHang.TongSoTienDaGD}','Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.KhachHangs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }

        public DataTable FindKhachHang(KhachHang khachHang)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.fn_TimKiemKhachHang(khachHang.HoTenKH, khachHang.SoCCCD, khachHang.SDT).ToList();
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
