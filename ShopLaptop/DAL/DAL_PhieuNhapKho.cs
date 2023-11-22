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
    public class DAL_PhieuNhapKho
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        public DataTable LoadPhieuNhapKhos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from phieu in db.PhieuNhapKhos
                            select new
                            {
                                phieu.MaNK,
                                phieu.MaNCC,
                                phieu.MaNV,
                                phieu.NgayNhapKho,
                                phieu.SoTienThanhToanNhapKho,
                                phieu.PhuongThucThanhToan,
                                phieu.TrangThaiThanhToan
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public bool InsertPhieuNhapKho(PhieuNhapKho phieuNhapKho)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_RevisePhieuNhapKho '{phieuNhapKho.MaNK}', '{phieuNhapKho.MaNCC}', '{phieuNhapKho.MaNV}', {phieuNhapKho.SoTienThanhToanNhapKho}, N'{phieuNhapKho.PhuongThucThanhToan}', N'{phieuNhapKho.TrangThaiThanhToan}', 'INSERT' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.PhieuNhapKhos);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdatePhieuNhapKho(PhieuNhapKho phieuNhapKho)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_RevisePhieuNhapKho '{phieuNhapKho.MaNK}', '{phieuNhapKho.MaNCC}', '{phieuNhapKho.MaNV}', {phieuNhapKho.SoTienThanhToanNhapKho}, N'{phieuNhapKho.PhuongThucThanhToan}', N'{phieuNhapKho.TrangThaiThanhToan}', 'Update' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.PhieuNhapKhos);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeletePhieuNhapKho(PhieuNhapKho phieuNhapKho)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC sp_RevisePhieuNhapKho '{phieuNhapKho.MaNK}', '{phieuNhapKho.MaNCC}', '{phieuNhapKho.MaNV}', {phieuNhapKho.SoTienThanhToanNhapKho}, N'{phieuNhapKho.PhuongThucThanhToan}', N'{phieuNhapKho.TrangThaiThanhToan}', 'Delete' ");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.PhieuNhapKhos);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable FindPhieuNhapKho(PhieuNhapKho phieuNhapKho)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.fn_TimKiemPhieuNhapKho(phieuNhapKho.NgayNhapKho).ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }
        public int CountPhieuNhapKhoOnMonthAndYear(int month, int year)
        {
            int result = 0;
            try
            {
                result= db.PhieuNhapKhos
                                .Where(phieu => phieu.NgayNhapKho.Value.Month == month && phieu.NgayNhapKho.Value.Year == year)
                                .Select(phieu => phieu).Count();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return result;
        }
        public int[] SelectDistinctYear()
        {
            var list = new int[] { };
            try
            {
                list = (from phieu in db.PhieuNhapKhos
                        select phieu.NgayNhapKho.Value.Year
                            ).Distinct().ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return list;
        }
    }
}
