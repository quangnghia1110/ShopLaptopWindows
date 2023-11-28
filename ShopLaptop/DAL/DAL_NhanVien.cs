using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ShopLaptop.DAL
{
    public class DAL_NhanVien
    {
        ShopLaptopDBDataContext db = new ShopLaptopDBDataContext();
        MyConnect myconn = new MyConnect();
        public DataTable LoadNhanViens()
        {
            DataTable dataTable = new DataTable();
            try
            {
                var list = (from nhanVien in db.NhanViens 
                            select new
                            {
                                nhanVien.MaNV,
                                nhanVien.HoTenNV,
                                nhanVien.SDT,
                                nhanVien.Email,
                                nhanVien.Passwd,
                                nhanVien.TrangThaiTaiKhoan
                            }).ToList();
                dataTable = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dataTable;
        }
        public bool InsertNhanVien(NhanVien nhanVien)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseNhanVien '{nhanVien.MaNV}', N'{nhanVien.HoTenNV}', '{nhanVien.SDT}', '{nhanVien.Email}', '{nhanVien.Passwd}', N'{nhanVien.TrangThaiTaiKhoan}', '{nhanVien.anhNV}', 'INSERT'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseNhanVien '{nhanVien.MaNV}', N'{nhanVien.HoTenNV}', '{nhanVien.SDT}', '{nhanVien.Email}', '{nhanVien.Passwd}', N'{nhanVien.TrangThaiTaiKhoan}', '{nhanVien.anhNV}', 'Update'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public bool DeleteNhanVien(NhanVien nhanVien)
        {
            bool isSuccess = false;
            try
            {
                int numberOfModifiedRow = db.ExecuteCommand($"EXEC dbo.sp_ReviseNhanVien '{nhanVien.MaNV}', N'{nhanVien.HoTenNV}', '{nhanVien.SDT}', '{nhanVien.Email}', '{nhanVien.Passwd}', N'{nhanVien.TrangThaiTaiKhoan}', 'Delete'");
                db.SubmitChanges();
                db.Refresh(RefreshMode.OverwriteCurrentValues, db.NhanViens);
                isSuccess = numberOfModifiedRow > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isSuccess = false;
            }
            return isSuccess;
        }
        public DataTable LoadNhanVien()
        {
            try
            {
                string sql = "Select * from NhanVien";
                DataTable dt = new DataTable();
                myconn.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(sql, myconn.getConnection);
                da.Fill(dt);
                myconn.closeConnection();
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
            
        }
       
        public int ThemNhanVien(string MaNV, string HoTenNV, string SDT, string Email, string Passwd, string TrangThaiTaiKhoan, byte[] anhdg)
        {
            try
            {
                string sql = "Insert into NhanVien(MaNV, HoTenNV, SDT, Email, Passwd, TrangThaiTaiKhoan, anhNV) Values (@MaNV, @HoTenNV, @SDT, @Email, @Passwd, @TrangThaiTaiKhoan, @anhNV)";
                myconn.openConnection();
                SqlCommand cmd = new SqlCommand(sql, myconn.getConnection);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", HoTenNV);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Passwd", Passwd);
                cmd.Parameters.AddWithValue("@TrangThaiTaiKhoan", TrangThaiTaiKhoan);
                cmd.Parameters.AddWithValue("@anhNV", anhdg);
                int res = cmd.ExecuteNonQuery();
                myconn.closeConnection();
                return res;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int SuaNhanVien(string MaNV, string HoTenNV, string SDT, string Email, string Passwd, string TrangThaiTaiKhoan, byte[] anhdg)
        {
            try
            {
                string sql = "Update NhanVien set HoTenNV = @HoTenNV, SDT = @SDT, Email = @Email, Passwd = @Passwd, TrangThaiTaiKhoan = @TrangThaiTaiKhoan, anhNV = @anhNV Where MaNV = @MaNV";
                myconn.openConnection();
                SqlCommand cmd = new SqlCommand(sql, myconn.getConnection);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", HoTenNV);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Passwd", Passwd);
                cmd.Parameters.AddWithValue("@TrangThaiTaiKhoan", TrangThaiTaiKhoan);
                cmd.Parameters.AddWithValue("@anhNV", anhdg);
                int res = cmd.ExecuteNonQuery();
                myconn.closeConnection();
                return res;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return 0;
            }
            
        }

        public int XoaNhanVien(String MaNV)
        {
            try
            {
                string sql = "delete NhanVien where MaNV = @MaNV ";
                myconn.openConnection();
                SqlCommand cmd = new SqlCommand(sql, myconn.getConnection);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                int res = cmd.ExecuteNonQuery();
                myconn.closeConnection();
                return res;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return 0;
            }
           
        }

        public DataTable FindNhanVien(NhanVien nhanVien)
        {
            DataTable dt = new DataTable();
            try
            {
                var list = db.fn_TimKiemNhanVien(nhanVien.MaNV).ToList();
                dt = CustomFuncs.ConvertListToDataTable(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
