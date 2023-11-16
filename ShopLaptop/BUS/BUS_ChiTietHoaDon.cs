using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dal_ChiTietHoaDon = new DAL_ChiTietHoaDon();
        public  DataTable LoadChiTietHoaDons()
        {
            return dal_ChiTietHoaDon.LoadChiTietHoaDons();
        }
        public bool InsertChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            chiTietHoaDon.MaLT = maLT;
            chiTietHoaDon.MaHD = maHD;
            chiTietHoaDon.SoLuongSP = Convert.ToInt32(soLuongSP);
            chiTietHoaDon.GiaBanTungSP = Convert.ToInt32(giaBanTungSP);
            chiTietHoaDon.ThueVAT = Convert.ToInt32(thueVAT);
            chiTietHoaDon.KhuyenMai = Convert.ToInt32(khuyenMai);
            chiTietHoaDon.ThanhTienTungSP = Convert.ToInt32(thanhTienTungSP);
            return dal_ChiTietHoaDon.InsertChiTietHoaDon(chiTietHoaDon);
        }
        public bool UpdateChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            chiTietHoaDon.MaLT = maLT;
            chiTietHoaDon.MaHD = maHD;
            chiTietHoaDon.SoLuongSP = Convert.ToInt32(soLuongSP);
            chiTietHoaDon.GiaBanTungSP = Convert.ToInt32(giaBanTungSP);
            chiTietHoaDon.ThueVAT = Convert.ToInt32(thueVAT);
            chiTietHoaDon.KhuyenMai = Convert.ToInt32(khuyenMai);
            chiTietHoaDon.ThanhTienTungSP = Convert.ToInt32(thanhTienTungSP);
            return dal_ChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon);
        }
        public bool DeleteChiTietHoaDon(string maLT, string maHD, string soLuongSP, string giaBanTungSP, string thueVAT, string khuyenMai, string thanhTienTungSP)
        {
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            chiTietHoaDon.MaLT = maLT;
            chiTietHoaDon.MaHD = maHD;
            chiTietHoaDon.SoLuongSP = Convert.ToInt32(soLuongSP);
            chiTietHoaDon.GiaBanTungSP = Convert.ToInt32(giaBanTungSP);
            chiTietHoaDon.ThueVAT = Convert.ToInt32(thueVAT);
            chiTietHoaDon.KhuyenMai = Convert.ToInt32(khuyenMai);
            chiTietHoaDon.ThanhTienTungSP = Convert.ToInt32(thanhTienTungSP);
            return dal_ChiTietHoaDon.DeleteChiTietHoaDon(chiTietHoaDon);
        }
    }
}
