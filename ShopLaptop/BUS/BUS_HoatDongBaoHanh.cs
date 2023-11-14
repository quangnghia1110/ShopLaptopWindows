using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_HoatDongBaoHanh
    {
        DAL_HoatDongBaoHanh dAL_HoatDongBaoHanh = new DAL_HoatDongBaoHanh();
        public DataTable LoadHoatDongBaoHanhs()
        {
            return this.dAL_HoatDongBaoHanh.LoadHoatDongBaoHanhs();
        }

        public bool InsertGoiBaoHanh(string MaNV, string MaKH, string MaGoiBHanh, string ChiPhiSuaChua, string SoTienHoTro, string ThoiGianBaoHanh)
        {
            HoatDongBaoHanh hoatDongBaoHanh = new HoatDongBaoHanh();
            hoatDongBaoHanh.MaNV = MaNV;
            hoatDongBaoHanh.MaKH = MaKH;
            hoatDongBaoHanh.ChiPhiSuaChua = Convert.ToInt32(ChiPhiSuaChua);
            hoatDongBaoHanh.SoTienHoTro = Convert.ToInt32(SoTienHoTro);
            hoatDongBaoHanh.ThoiGianBH = Convert.ToInt32(ThoiGianBaoHanh);
            return this.dAL_HoatDongBaoHanh.InsertGoiBaoHanh(hoatDongBaoHanh);
        }
        public bool UpdateGoiBaoHanh(string MaNV, string MaKH, string MaGoiBHanh, string ChiPhiSuaChua, string SoTienHoTro, string ThoiGianBaoHanh)
        {
            HoatDongBaoHanh hoatDongBaoHanh = new HoatDongBaoHanh();
            hoatDongBaoHanh.MaNV = MaNV;
            hoatDongBaoHanh.MaKH = MaKH;
            hoatDongBaoHanh.ChiPhiSuaChua = Convert.ToInt32(ChiPhiSuaChua);
            hoatDongBaoHanh.SoTienHoTro = Convert.ToInt32(SoTienHoTro);
            hoatDongBaoHanh.ThoiGianBH = Convert.ToInt32(ThoiGianBaoHanh);
            return this.dAL_HoatDongBaoHanh.UpdateGoiBaoHanh(hoatDongBaoHanh);
        }
        public bool DeleteGoiBaoHanh(string MaNV, string MaKH, string MaGoiBHanh, string ChiPhiSuaChua, string SoTienHoTro, string ThoiGianBaoHanh)
        {
            HoatDongBaoHanh hoatDongBaoHanh = new HoatDongBaoHanh();
            hoatDongBaoHanh.MaNV = MaNV;
            hoatDongBaoHanh.MaKH = MaKH;
            hoatDongBaoHanh.ChiPhiSuaChua = Convert.ToInt32(ChiPhiSuaChua);
            hoatDongBaoHanh.SoTienHoTro = Convert.ToInt32(SoTienHoTro);
            hoatDongBaoHanh.ThoiGianBH = Convert.ToInt32(ThoiGianBaoHanh);
            return this.dAL_HoatDongBaoHanh.DeleteGoiBaoHanh(hoatDongBaoHanh);
        }

    }
}
