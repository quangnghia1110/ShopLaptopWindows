using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_ChiTietPhieuNhap
    {
        DAL_ChiTietPhieuNhap dAL_ChiTietPhieuNhap = new DAL_ChiTietPhieuNhap();
        public DataTable LoadChiTietPhieuNhaps()
        {
            return dAL_ChiTietPhieuNhap.LoadChiTietPhieuNhaps();
        }
        public bool InsertChiTietPhieuNhap(string maLT, string maNK, string soLuongSP, string giaNhapTungSP, string thueVAT, string thanhTienTungSP)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
            chiTietPhieuNhap.MaLT = maLT;
            chiTietPhieuNhap.MaNK = maNK;
            chiTietPhieuNhap.SoLuongSP = Convert.ToInt32(soLuongSP);
            chiTietPhieuNhap.GiaNhapTungSP = Convert.ToInt32(giaNhapTungSP);
            chiTietPhieuNhap.ThueVAT = Convert.ToInt32(thueVAT);
            chiTietPhieuNhap.ThanhTienTungSP = Convert.ToInt32(thanhTienTungSP);
            return dAL_ChiTietPhieuNhap.InsertChiTietPhieuNhap(chiTietPhieuNhap);
        }
        public bool UpdateChiTietPhieuNhap(string maLT, string maNK, string soLuongSP, string giaNhapTungSP, string thueVAT, string thanhTienTungSP)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
            chiTietPhieuNhap.MaLT = maLT;
            chiTietPhieuNhap.MaNK = maNK;
            chiTietPhieuNhap.SoLuongSP = Convert.ToInt32(soLuongSP);
            chiTietPhieuNhap.GiaNhapTungSP = Convert.ToInt32(giaNhapTungSP);
            chiTietPhieuNhap.ThueVAT = Convert.ToInt32(thueVAT);
            chiTietPhieuNhap.ThanhTienTungSP = Convert.ToInt32(thanhTienTungSP);
            return dAL_ChiTietPhieuNhap.UpdateChiTietPhieuNhap(chiTietPhieuNhap);
        }
        public bool DeleteChiTietPhieuNhap(string maLT, string maNK, string soLuongSP, string giaNhapTungSP, string thueVAT, string thanhTienTungSP)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
            chiTietPhieuNhap.MaLT = maLT;
            chiTietPhieuNhap.MaNK = maNK;
            chiTietPhieuNhap.SoLuongSP = Convert.ToInt32(soLuongSP);
            chiTietPhieuNhap.GiaNhapTungSP = Convert.ToInt32(giaNhapTungSP);
            chiTietPhieuNhap.ThueVAT = Convert.ToInt32(thueVAT);
            chiTietPhieuNhap.ThanhTienTungSP = Convert.ToInt32(thanhTienTungSP);
            return dAL_ChiTietPhieuNhap.DeleteChiTietPhieuNhap(chiTietPhieuNhap);
        }

    }
}
