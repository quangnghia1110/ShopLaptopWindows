using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_GoiNangCap
    {
        DAL_GoiNangCap dAL_GoiNangCap = new DAL_GoiNangCap();
        public DataTable LoadGoiNangCaps()
        {
            return dAL_GoiNangCap.LoadGoiNangCaps();
        }
        public bool InsertGoiNangCap(string maGoiNangCap, string tenGoiNC, string phiNC)
        {
            GoiNangCap goiNangCap = new GoiNangCap();
            goiNangCap.MaGoiNC = maGoiNangCap;
            goiNangCap.TenGoiNC = tenGoiNC;
            goiNangCap.PhiNC = Convert.ToInt32(phiNC);
            return dAL_GoiNangCap.InsertGoiNangCap(goiNangCap);
        }
        public bool DeleteGoiNangCap(string maGoiNangCap, string tenGoiNC, string phiNC)
        {
            GoiNangCap goiNangCap = new GoiNangCap();
            goiNangCap.MaGoiNC = maGoiNangCap;
            goiNangCap.TenGoiNC = tenGoiNC;
            goiNangCap.PhiNC = Convert.ToInt32(phiNC);
            return dAL_GoiNangCap.DeleteGoiNangCap(goiNangCap);
        }
        public bool UpdateGoiNangCap(string maGoiNangCap, string tenGoiNC, string phiNC)
        {
            GoiNangCap goiNangCap = new GoiNangCap();
            goiNangCap.MaGoiNC = maGoiNangCap;
            goiNangCap.TenGoiNC = tenGoiNC;
            goiNangCap.PhiNC = Convert.ToInt32(phiNC);
            return dAL_GoiNangCap.UpdateGoiNangCap(goiNangCap);
        }
        public DataTable FindGoiNangCap(string maGoiNC)
        {
            GoiNangCap goiNangCap = new GoiNangCap();
            goiNangCap.MaGoiNC = maGoiNC;
            return dAL_GoiNangCap.FindGoiNangCap(goiNangCap) as DataTable;
        }


    }
}
