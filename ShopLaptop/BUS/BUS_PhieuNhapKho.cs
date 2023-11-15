using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_PhieuNhapKho
    {
        DAL_PhieuNhapKho dAL_PhieuNhapKho = new DAL_PhieuNhapKho();
        public DataTable LoadPhieuNhapKhos()
        {
            return dAL_PhieuNhapKho.LoadPhieuNhapKhos();
        }
        public bool InsertPhieuNhapKho(string MaNK, string MaNCC, string MaNV, string SoTienThanhToan, string PhuongThucThanhToan, string TrangThaiThanhToan)
        {
            PhieuNhapKho phieuNhapKho = new PhieuNhapKho();
            phieuNhapKho.MaNK = MaNK;
            phieuNhapKho.MaNCC = MaNCC;
            phieuNhapKho.MaNV = MaNV;
            phieuNhapKho.SoTienThanhToanNhapKho = Convert.ToInt32(SoTienThanhToan);
            phieuNhapKho.PhuongThucThanhToan = PhuongThucThanhToan;
            phieuNhapKho.TrangThaiThanhToan = TrangThaiThanhToan;
            return dAL_PhieuNhapKho.InsertPhieuNhapKho(phieuNhapKho);
        }
        public bool UpdatePhieuNhapKho(string MaNK, string MaNCC, string MaNV, string SoTienThanhToan, string PhuongThucThanhToan, string TrangThaiThanhToan)
        {
            PhieuNhapKho phieuNhapKho = new PhieuNhapKho();
            phieuNhapKho.MaNK = MaNK;
            phieuNhapKho.MaNCC = MaNCC;
            phieuNhapKho.MaNV = MaNV;
            phieuNhapKho.SoTienThanhToanNhapKho = Convert.ToInt32(SoTienThanhToan);
            phieuNhapKho.PhuongThucThanhToan = PhuongThucThanhToan;
            phieuNhapKho.TrangThaiThanhToan = TrangThaiThanhToan;
            return dAL_PhieuNhapKho.UpdatePhieuNhapKho(phieuNhapKho);
        }
        public bool DeletePhieuNhapKho(string MaNK, string MaNCC, string MaNV, string SoTienThanhToan, string PhuongThucThanhToan, string TrangThaiThanhToan)
        {
            PhieuNhapKho phieuNhapKho = new PhieuNhapKho();
            phieuNhapKho.MaNK = MaNK;
            phieuNhapKho.MaNCC = MaNCC;
            phieuNhapKho.MaNV = MaNV;
            phieuNhapKho.SoTienThanhToanNhapKho = Convert.ToInt32(SoTienThanhToan);
            phieuNhapKho.PhuongThucThanhToan = PhuongThucThanhToan;
            phieuNhapKho.TrangThaiThanhToan = TrangThaiThanhToan;
            return dAL_PhieuNhapKho.DeletePhieuNhapKho(phieuNhapKho);
        }
    }
}
