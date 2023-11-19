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
    public class DAL_TraGop
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadTraGops()
        {
            DataTable traGops = new DataTable();
            try
            {
                var list = (from tragop in db.TraGops
                           select new
                           {
                               tragop.MaHD,
                               tragop.MaKH,
                               tragop.LaiSuatHangThang,
                               tragop.TienTraTruoc,
                               tragop.TienConLai,
                               tragop.ThoiGianTraGop,
                               tragop.NgayBatDau,
                               tragop.NgayDaoHan
                           }).ToList();
                traGops = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return traGops;
        }
        public bool InsertTraGop(TraGop traGop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseTraGop '{traGop.MaHD}', '{traGop.MaKH}', {traGop.LaiSuatHangThang}, {traGop.TienTraTruoc}, {traGop.TienConLai}, {traGop.ThoiGianTraGop}, '{traGop.NgayBatDau}', 'INSERT' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.TraGops);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateTraGop(TraGop traGop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseTraGop '{traGop.MaHD}', '{traGop.MaKH}', {traGop.LaiSuatHangThang}, {traGop.TienTraTruoc}, {traGop.TienConLai}, {traGop.ThoiGianTraGop}, '{traGop.NgayBatDau}', 'Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.TraGops);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteTraGop(TraGop traGop)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_ReviseTraGop '{traGop.MaHD}', '{traGop.MaKH}', {traGop.LaiSuatHangThang}, {traGop.TienTraTruoc}, {traGop.TienConLai}, {traGop.ThoiGianTraGop}, '{traGop.NgayBatDau}', 'Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.TraGops);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindTraGop(TraGop traGop)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.func_SearchTraGop(traGop.MaHD,traGop.MaKH,traGop.LaiSuatHangThang).ToList();
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
