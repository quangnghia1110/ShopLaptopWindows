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
    public class DAL_NhanVien
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadNhanViens()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from nhanVien in db.NhanViens select nhanVien).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertNhanVien(NhanVien nhanVien)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseNhanVien '{nhanVien.MaNV}', N'{nhanVien.HoTenNV}', '{nhanVien.SDT}', '{nhanVien.Email}', '{nhanVien.Passwd}', N'{nhanVien.TrangThaiTaiKhoan}', 'INSERT'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseNhanVien '{nhanVien.MaNV}', N'{nhanVien.HoTenNV}', '{nhanVien.SDT}', '{nhanVien.Email}', '{nhanVien.Passwd}', N'{nhanVien.TrangThaiTaiKhoan}', 'Update'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteNhanVien(NhanVien nhanVien)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseNhanVien '{nhanVien.MaNV}', N'{nhanVien.HoTenNV}', '{nhanVien.SDT}', '{nhanVien.Email}', '{nhanVien.Passwd}', N'{nhanVien.TrangThaiTaiKhoan}', 'Delete'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
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
