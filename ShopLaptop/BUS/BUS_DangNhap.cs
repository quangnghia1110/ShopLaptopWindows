using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLaptop.DAL;

namespace ShopLaptop.BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dAL_DangNhap = new DAL_DangNhap();

        public NhanVien Login(string username, string password)
        {
            return dAL_DangNhap.Login(username, password);
        }
        public bool ChangePassword(string username, string oldPass, string newPass)
        {
            return dAL_DangNhap.ChangePassword(username, oldPass, newPass);
        }
    }
}
