using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ShopLaptop.BUS
{
    public class BUS_Laptop
    {
        DAL_Laptop dAL_Laptop = new DAL_Laptop();
        public DataTable LoadLaptops()
        {
            return dAL_Laptop.LoadLaptops();
        }
        public bool InsertLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin, byte[] anhLaptop)
        {
            Laptop laptop = new Laptop();
            laptop.MaLT = MaLT;
            laptop.TenLT = TenLT;
            laptop.TenHangLT = TenHangLT;
            laptop.SoLuong = Convert.ToInt32(SoLuong);
            laptop.KhoiLuong = Convert.ToDouble(KhoiLuong);
            laptop.HanBaoHanh = Convert.ToInt32(HanBaoHanh);
            laptop.MauSac = MauSac;
            laptop.DungLuongBoNho = Convert.ToInt32(DungLuongBoNho);
            laptop.ManHinh = ManHinh;
            laptop.CPU = CPU;
            laptop.QuaTangKem = QuaTangKem;
            laptop.Pin = Pin;
            laptop.anhLaptop = anhLaptop;
            return dAL_Laptop.InsertLaptop(laptop);
        }
        public bool UpdateLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin, byte[] anhLaptop)
        {
            Laptop laptop = new Laptop();
            laptop.MaLT = MaLT;
            laptop.TenLT = TenLT;
            laptop.TenHangLT = TenHangLT;
            laptop.SoLuong = Convert.ToInt32(SoLuong);
            laptop.KhoiLuong = Convert.ToDouble(KhoiLuong);
            laptop.HanBaoHanh = Convert.ToInt32(HanBaoHanh);
            laptop.MauSac = MauSac;
            laptop.DungLuongBoNho = Convert.ToInt32(DungLuongBoNho);
            laptop.ManHinh = ManHinh;
            laptop.CPU = CPU;
            laptop.QuaTangKem = QuaTangKem;
            laptop.Pin = Pin;
            laptop.anhLaptop = anhLaptop;
            return dAL_Laptop.UpdateLaptop(laptop);

        }
        public bool DeleteLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin)
        {
            Laptop laptop = new Laptop();
            laptop.MaLT = MaLT;
            laptop.TenLT = TenLT;
            laptop.TenHangLT = TenHangLT;
            laptop.SoLuong = Convert.ToInt32(SoLuong);
            laptop.KhoiLuong = Convert.ToDouble(KhoiLuong);
            laptop.HanBaoHanh = Convert.ToInt32(HanBaoHanh);
            laptop.MauSac = MauSac;
            laptop.DungLuongBoNho = Convert.ToInt32(DungLuongBoNho);
            laptop.ManHinh = ManHinh;
            laptop.CPU = CPU;
            laptop.QuaTangKem = QuaTangKem;
            laptop.Pin = Pin;
            return dAL_Laptop.DeleteLaptop(laptop);

        }
        public DataTable LoadLaptop()
        {
            return dAL_Laptop.LoadLaptop();
        }

        public int ThemLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin, byte[] anhLaptop)
        {
            
            return dAL_Laptop.ThemLaptop(MaLT, TenLT, TenHangLT, SoLuong, KhoiLuong, HanBaoHanh, MauSac, DungLuongBoNho, ManHinh, CPU, QuaTangKem, Pin, anhLaptop);
        }

        public int SuaLaptop(string MaLT, string TenLT, string TenHangLT, string SoLuong, string KhoiLuong, string HanBaoHanh, string MauSac, string DungLuongBoNho, string ManHinh, string CPU, string QuaTangKem, string Pin, byte[] anhLaptop)
        {

            return dAL_Laptop.SuaLaptop(MaLT, TenLT, TenHangLT, SoLuong, KhoiLuong, HanBaoHanh, MauSac, DungLuongBoNho, ManHinh, CPU, QuaTangKem, Pin, anhLaptop);
        }

        public int XoaLaptop(string MaLT)
        {

            return dAL_Laptop.XoaLaptop(MaLT);
        }

        public DataTable FindLaptop(string tenLT, string khoiLuong, string tenHangLT, string mauSac, string manHinh )
        {
            Laptop laptop = new Laptop();
            laptop.TenLT = tenLT;
            if (!string.IsNullOrEmpty(khoiLuong))
            {
                laptop.KhoiLuong = Convert.ToDouble(khoiLuong);
            }
            else laptop.KhoiLuong = 0;
            laptop.TenHangLT = tenHangLT;
            laptop.MauSac = mauSac;
            laptop.ManHinh = manHinh;
            return dAL_Laptop.FindLaptop(laptop);
        }
        public DataTable SelectNameTop5BuyedLaptop(string year)
        {
            return this.dAL_Laptop.SelectNameTop5BuyedLaptop(year);
        }
        public DataTable CountLaptop()
        {
            return this.dAL_Laptop.CountLaptop();
        }
    }
}
