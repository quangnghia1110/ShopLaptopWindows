using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop.DAL
{
    public class DAL_DangNhap
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();

        public NhanVien Login(string username, string password)
        {
            var nv = db.NhanViens.SingleOrDefault(x => x.Email == username && x.Passwd == password);
            return nv;
        }
        public bool ChangePassword(string username, string oldPass, string newPass)
        {
            bool isSuccess = false;
            try
            {
                var nv = db.NhanViens.FirstOrDefault(x => x.Email == username && x.Passwd == oldPass);
                if (nv != null)
                {
                    nv.Passwd = newPass;
                    db.SubmitChanges();
                    db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}
