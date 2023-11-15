using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dAL_HoaDon = new DAL_HoaDon();
        public DataTable LoadHoaDons()
        {
            return dAL_HoaDon.LoadHoaDons();
        }
        public bool InsertHoaDon(string maHD, string maKH_HD, string maNV_HD, string soTienThanhToan_HD, string phuongThucThanhToan_HD, string trangThaiThanhToan_HD)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = maHD;
            hoaDon.MaKH = maKH_HD;
            hoaDon.MaNV = maNV_HD;
            hoaDon.SoTienThanhToanHoaDon = Convert.ToInt32(soTienThanhToan_HD);
            hoaDon.PhuongThucThanhToan = phuongThucThanhToan_HD;
            hoaDon.TrangThaiThanhToan = trangThaiThanhToan_HD;
            return dAL_HoaDon.InsertHoaDon(hoaDon);
        }
        public bool UpdateHoaDon(string maHD, string maKH_HD, string maNV_HD, string soTienThanhToan_HD, string phuongThucThanhToan_HD, string trangThaiThanhToan_HD)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = maHD;
            hoaDon.MaKH = maKH_HD;
            hoaDon.MaNV = maNV_HD;
            hoaDon.SoTienThanhToanHoaDon = Convert.ToInt32(soTienThanhToan_HD);
            hoaDon.PhuongThucThanhToan = phuongThucThanhToan_HD;
            hoaDon.TrangThaiThanhToan = trangThaiThanhToan_HD;
            return dAL_HoaDon.UpdateHoaDon(hoaDon);
        }
        public bool DeleteHoaDon(string maHD, string maKH_HD, string maNV_HD, string soTienThanhToan_HD, string phuongThucThanhToan_HD, string trangThaiThanhToan_HD)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = maHD;
            hoaDon.MaKH = maKH_HD;
            hoaDon.MaNV = maNV_HD;
            hoaDon.SoTienThanhToanHoaDon = Convert.ToInt32(soTienThanhToan_HD);
            hoaDon.PhuongThucThanhToan = phuongThucThanhToan_HD;
            hoaDon.TrangThaiThanhToan = trangThaiThanhToan_HD;
            return dAL_HoaDon.DeleteHoaDon(hoaDon);
        }
        public DataTable FindHoaDon(DateTime fromDate, DateTime toDate)
        {
            return dAL_HoaDon.FindHoaDon(fromDate, toDate);
        }

    }
}
