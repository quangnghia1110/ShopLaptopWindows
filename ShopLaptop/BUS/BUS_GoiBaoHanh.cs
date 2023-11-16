using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_GoiBaoHanh
    {
        DAL_GoiBaoHanh dAL_GoiBaoHanh = new DAL_GoiBaoHanh();

        public DataTable LoadGoiBaoHanhs()
        {
            return dAL_GoiBaoHanh.LoadGoiBaoHanhs();
        }

        public bool InsertGoiBaoHanh(string maGoiBaoHanh, string tenGoiBH, string moTaChiTiet)
        {
            GoiBaoHanh goiBaoHanh = new GoiBaoHanh();
            goiBaoHanh.MaGoiBH = maGoiBaoHanh;
            goiBaoHanh.TenGoiBH = tenGoiBH;
            goiBaoHanh.MoTaChiTiet = moTaChiTiet;
            return dAL_GoiBaoHanh.InsertGoiBaoHanh(goiBaoHanh);
        }
        public bool UpdateGoiBaoHanh(string maGoiBaoHanh, string tenGoiBH, string moTaChiTiet)
        {
            GoiBaoHanh goiBaoHanh = new GoiBaoHanh();
            goiBaoHanh.MaGoiBH = maGoiBaoHanh;
            goiBaoHanh.TenGoiBH = tenGoiBH;
            goiBaoHanh.MoTaChiTiet = moTaChiTiet;
            return dAL_GoiBaoHanh.UpdateGoiBaoHanh(goiBaoHanh);
        }
        public bool DeleteGoiBaoHanh(string maGoiBaoHanh, string tenGoiBH, string moTaChiTiet)
        {
            GoiBaoHanh goiBaoHanh = new GoiBaoHanh();
            goiBaoHanh.MaGoiBH = maGoiBaoHanh;
            goiBaoHanh.TenGoiBH = tenGoiBH;
            goiBaoHanh.MoTaChiTiet = moTaChiTiet;
            return dAL_GoiBaoHanh.DeleteGoiBaoHanh(goiBaoHanh);
        }
        public DataTable FindGoiBaoHanh(string maGoiBH)
        {
            GoiBaoHanh goiBaoHanh = new GoiBaoHanh();
            goiBaoHanh.MaGoiBH = maGoiBH;
            return dAL_GoiBaoHanh.FindGoiBaoHanh(goiBaoHanh);
        }
    }
}
