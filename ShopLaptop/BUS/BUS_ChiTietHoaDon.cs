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
        public DataTable LoadChiTietHoaDons()
        {
            DAL_ChiTietHoaDon dal = new DAL_ChiTietHoaDon();
            return dal.LoadChiTietHoaDons();
        }
    }
}
