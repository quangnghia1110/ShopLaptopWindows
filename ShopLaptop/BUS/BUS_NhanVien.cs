using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dAL_NhanVien = new DAL_NhanVien();
        public DataTable LoadNhanViens()
        {
            return dAL_NhanVien.LoadNhanViens();
        }
        public bool InsertNhanVien(string MaNV, string HoTenNV, string SDT, string Email, string Passwd, string TrangThaiTaiKhoan)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = MaNV;
            nhanVien.HoTenNV = HoTenNV;
            nhanVien.SDT = SDT;
            nhanVien.Email = Email;
            nhanVien.Passwd = Passwd;
            nhanVien.TrangThaiTaiKhoan = TrangThaiTaiKhoan;
            return dAL_NhanVien.InsertNhanVien(nhanVien);

        }
        public bool UpdateNhanVien(string MaNV, string HoTenNV, string SDT, string Email, string Passwd, string TrangThaiTaiKhoan)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = MaNV;
            nhanVien.HoTenNV = HoTenNV;
            nhanVien.SDT = SDT;
            nhanVien.Email = Email;
            nhanVien.Passwd = Passwd;
            nhanVien.TrangThaiTaiKhoan = TrangThaiTaiKhoan;
            return dAL_NhanVien.UpdateNhanVien(nhanVien);
        }
        public bool DeleteNhanVien(string MaNV, string HoTenNV, string SDT, string Email, string Passwd, string TrangThaiTaiKhoan)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = MaNV;
            nhanVien.HoTenNV = HoTenNV;
            nhanVien.SDT = SDT;
            nhanVien.Email = Email;
            nhanVien.Passwd = Passwd;
            nhanVien.TrangThaiTaiKhoan = TrangThaiTaiKhoan;
            return dAL_NhanVien.DeleteNhanVien(nhanVien);
        }
    }
}
