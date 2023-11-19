using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace ShopLaptop.DAL
{
    public class DAL_GoiNangCap
    {
        MyConnect myConnect = new MyConnect();
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadGoiNangCaps()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from goinangcap in db.GoiNangCaps 
                            select new
                            {
                                goinangcap.MaGoiNC,
                                goinangcap.TenGoiNC,
                                goinangcap.HoatDongNangCaps,
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public bool InsertGoiNangCap(GoiNangCap goiNangCap)
        {
            bool isSuccess = false;
            try
            {
                db.ExecuteCommand($"EXEC sp_ReviseGoiNangCap '{goiNangCap.MaGoiNC}', N'{goiNangCap.TenGoiNC}', '{goiNangCap.PhiNC}', 'Insert'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.GoiNangCaps);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteGoiNangCap(GoiNangCap goiNangCap)
        {
            bool isSuccess = false;
            try
            {
                db.ExecuteCommand($"EXEC sp_ReviseGoiNangCap '{goiNangCap.MaGoiNC}', N'{goiNangCap.TenGoiNC}', '{goiNangCap.PhiNC}', 'Delete'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.GoiNangCaps);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateGoiNangCap(GoiNangCap goiNangCap)
        {
            bool isSuccess = false;
            try
            {
                db.ExecuteCommand($"EXEC sp_ReviseGoiNangCap '{goiNangCap.MaGoiNC}', N'{goiNangCap.TenGoiNC}', '{goiNangCap.PhiNC}', 'Update'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.GoiNangCaps);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindGoiNangCap(GoiNangCap goiNangCap)
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = db.func_SearchNangCapByID(goiNangCap.MaGoiNC).ToList();
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
