using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_NhaCungCap
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadNhaCungCaps()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from nhaCungCap in db.NhaCungCaps select nhaCungCap).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertNhaCungCap(NhaCungCap nhaCungCap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseNhaCungCap '{nhaCungCap.MaNCC}', N'{nhaCungCap.TenNCC}', '{nhaCungCap.Email}', N'{nhaCungCap.DiaChi}', '{nhaCungCap.SDT}', N'{nhaCungCap.TrangThaiHopTac}', 'INSERT' ");
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
        public bool UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseNhaCungCap '{nhaCungCap.MaNCC}', N'{nhaCungCap.TenNCC}', '{nhaCungCap.Email}', N'{nhaCungCap.DiaChi}', '{nhaCungCap.SDT}', N'{nhaCungCap.TrangThaiHopTac}', 'Update' ");
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
        public bool DeleteNhaCungCap(NhaCungCap nhaCungCap)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseNhaCungCap '{nhaCungCap.MaNCC}', N'{nhaCungCap.TenNCC}', '{nhaCungCap.Email}', N'{nhaCungCap.DiaChi}', '{nhaCungCap.SDT}', N'{nhaCungCap.TrangThaiHopTac}', 'Delete' ");
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
