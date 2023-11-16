using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dAL_KhachHang= new DAL_KhachHang();
        public DataTable LoadKhachHangs()
        {
            return dAL_KhachHang.LoadKhachHangs();
        }
        public bool InsertKhachHang(string MaKH, string LoaiKH, string HoTenKH, string SoCCCD, string SDT, string TongSoTienDaGiaoDich)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = MaKH;
            khachHang.LoaiKH = Convert.ToInt32(LoaiKH);
            khachHang.HoTenKH = HoTenKH;
            khachHang.SoCCCD = SoCCCD;
            khachHang.SDT = SDT;
            khachHang.TongSoTienDaGD = Convert.ToInt32(TongSoTienDaGiaoDich);
            return dAL_KhachHang.InsertKhachHang(khachHang);
        }
        public bool UpdateKhachHang(string MaKH, string LoaiKH, string HoTenKH, string SoCCCD, string SDT, string TongSoTienDaGiaoDich)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = MaKH;
            khachHang.LoaiKH = Convert.ToInt32(LoaiKH);
            khachHang.HoTenKH = HoTenKH;
            khachHang.SoCCCD = SoCCCD;
            khachHang.SDT = SDT;
            khachHang.TongSoTienDaGD = Convert.ToInt32(TongSoTienDaGiaoDich);
            return dAL_KhachHang.UpdateKhachHang(khachHang);
        }
        public bool DeleteKhachHang(string MaKH, string LoaiKH, string HoTenKH, string SoCCCD, string SDT, string TongSoTienDaGiaoDich)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = MaKH;
            khachHang.LoaiKH = Convert.ToInt32(LoaiKH);
            khachHang.HoTenKH = HoTenKH;
            khachHang.SoCCCD = SoCCCD;
            khachHang.SDT = SDT;
            khachHang.TongSoTienDaGD = Convert.ToInt32(TongSoTienDaGiaoDich);
            return dAL_KhachHang.DeleteKhachHang(khachHang);
        }
        public DataTable FindKhachHang(string hoTenKH, string soCCCD, string sDT)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.HoTenKH = hoTenKH;
            khachHang.SoCCCD = soCCCD;
            khachHang.SDT = sDT;
            return dAL_KhachHang.FindKhachHang(khachHang);
        }



    }
}
