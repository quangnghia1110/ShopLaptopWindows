using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_TraGop
    {
        DAL_TraGop dAL_TraGop = new DAL_TraGop();
        public DataTable LoadTraGops()
        {
            return dAL_TraGop.LoadTraGops();
        }
        public bool InsertTraGop(string MaHD, string MaKH, string LaiSuatHangThang, string TienTraTruoc, string TienConLai, string ThoiGianTraGop, DateTime NgayBatDau)
        {
            TraGop traGop = new TraGop();
            traGop.MaHD = MaHD;
            traGop.MaKH = MaKH;
            traGop.LaiSuatHangThang = Convert.ToInt32(LaiSuatHangThang);
            traGop.TienTraTruoc = Convert.ToInt32(TienTraTruoc);
            traGop.TienConLai = Convert.ToInt32(TienConLai);
            traGop.ThoiGianTraGop = Convert.ToInt32(ThoiGianTraGop);
            traGop.NgayBatDau = NgayBatDau;
            return dAL_TraGop.InsertTraGop(traGop);
        }
        public bool DeleteTraGop(string MaHD, string MaKH, string LaiSuatHangThang, string TienTraTruoc, string TienConLai, string ThoiGianTraGop, DateTime NgayBatDau)
        {
            TraGop traGop = new TraGop();
            traGop.MaHD = MaHD;
            traGop.MaKH = MaKH;
            traGop.LaiSuatHangThang = Convert.ToInt32(LaiSuatHangThang);
            traGop.TienTraTruoc = Convert.ToInt32(TienTraTruoc);
            traGop.TienConLai = Convert.ToInt32(TienConLai);
            traGop.ThoiGianTraGop = Convert.ToInt32(ThoiGianTraGop);
            traGop.NgayBatDau = NgayBatDau;
            return dAL_TraGop.DeleteTraGop(traGop);
        }
        public bool UpdateTraGop(string MaHD, string MaKH, string LaiSuatHangThang, string TienTraTruoc, string TienConLai, string ThoiGianTraGop, DateTime NgayBatDau)
        {
            TraGop traGop = new TraGop();
            traGop.MaHD = MaHD;
            traGop.MaKH = MaKH;
            traGop.LaiSuatHangThang = Convert.ToInt32(LaiSuatHangThang);
            traGop.TienTraTruoc = Convert.ToInt32(TienTraTruoc);
            traGop.TienConLai = Convert.ToInt32(TienConLai);
            traGop.ThoiGianTraGop = Convert.ToInt32(ThoiGianTraGop);
            traGop.NgayBatDau = NgayBatDau;
            return dAL_TraGop.UpdateTraGop(traGop);
        }
        public DataTable FindTraGop(string maHD, string maKH, string laiSuatHangThang)
        {
            TraGop traGop = new TraGop()
            {
                MaHD = maHD,
                MaKH = maKH,
                LaiSuatHangThang = string.IsNullOrEmpty(laiSuatHangThang) ? 0 : Convert.ToInt32(laiSuatHangThang)
            };
            return dAL_TraGop.FindTraGop(traGop);
        }

    }
}
