using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_HoatDongNangCap
    {
        DAL_HoatDongNangCap dAL_HoatDongNangCap = new DAL_HoatDongNangCap();
        public DataTable LoadHoatDongNangCaps()
        {
            return dAL_HoatDongNangCap.LoadHoatDongNangCaps();
        }
        public bool InsertHoatDongNangCap(string MaNV_HDNC, string MaKH_HDNC, string MaGoi_HDNC)
        {
            HoatDongNangCap hoatDongNangCap = new HoatDongNangCap();
            hoatDongNangCap.MaNV = MaNV_HDNC;
            hoatDongNangCap.MaKH = MaKH_HDNC;
            hoatDongNangCap.MaGoiNC = MaGoi_HDNC;
            return dAL_HoatDongNangCap.InsertHoatDongNangCap(hoatDongNangCap);
        }
        public bool UpdateHoatDongNangCap(string MaNV_HDNC, string MaKH_HDNC, string MaGoi_HDNC)
        {
            HoatDongNangCap hoatDongNangCap = new HoatDongNangCap();
            hoatDongNangCap.MaNV = MaNV_HDNC;
            hoatDongNangCap.MaKH = MaKH_HDNC;
            hoatDongNangCap.MaGoiNC = MaGoi_HDNC;
            return dAL_HoatDongNangCap.UpdateHoatDongNangCap(hoatDongNangCap);
        }
        public bool DeleteHoatDongNangCap(string MaNV_HDNC, string MaKH_HDNC, string MaGoi_HDNC)
        {
            HoatDongNangCap hoatDongNangCap = new HoatDongNangCap();
            hoatDongNangCap.MaNV = MaNV_HDNC;
            hoatDongNangCap.MaKH = MaKH_HDNC;
            hoatDongNangCap.MaGoiNC = MaGoi_HDNC;
            return dAL_HoatDongNangCap.DeleteHoatDongNangCap(hoatDongNangCap);
        }
        public DataTable FindHoatDongNangCap(string maNV, string maKH, string maGoiNC)
        {
            HoatDongNangCap hoatDongNangCap = new HoatDongNangCap();
            hoatDongNangCap.MaNV= maNV;
            hoatDongNangCap.MaKH = maKH;
            hoatDongNangCap.MaGoiNC = maGoiNC;
            return this.dAL_HoatDongNangCap.FindHoatDongNangCap(hoatDongNangCap);
        }
    }
}
