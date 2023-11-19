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
    public class DAL_GoiBaoHanh
    {
        MyConnect myConnect = new MyConnect();
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadGoiBaoHanhs()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from goibaohanh  in db.GoiBaoHanhs
                            select new
                            {
                                goibaohanh.MaGoiBH,
                                goibaohanh.TenGoiBH,
                                goibaohanh.MoTaChiTiet
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertGoiBaoHanh(GoiBaoHanh goiBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseGoiBaoHanh '{goiBaoHanh.MaGoiBH}', N'{goiBaoHanh.TenGoiBH}', N'{goiBaoHanh.MoTaChiTiet}', 'Insert'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.GoiBaoHanhs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateGoiBaoHanh(GoiBaoHanh goiBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseGoiBaoHanh '{goiBaoHanh.MaGoiBH}', N'{goiBaoHanh.TenGoiBH}', N'{goiBaoHanh.MoTaChiTiet}', 'Update'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.GoiBaoHanhs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;
        }
        public bool DeleteGoiBaoHanh(GoiBaoHanh goiBaoHanh)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseGoiBaoHanh '{goiBaoHanh.MaGoiBH}', N'{goiBaoHanh.TenGoiBH}', N'{goiBaoHanh.MoTaChiTiet}', 'Delete'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.GoiBaoHanhs);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindGoiBaoHanh(GoiBaoHanh goiBaoHanh)
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = db.func_SearchBaoHanhByID(goiBaoHanh.MaGoiBH).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}
