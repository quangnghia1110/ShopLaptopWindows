using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop
{
    public partial class NhanVien : Form
    {
        MyConnect myconn = new MyConnect();
        public NhanVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_NhanVien.DataSource = dataTable;
            myconn.closeConnection();            
        }
        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Reset()
        {
            txt_MaNV.ResetText();
            txt_HoTenNV.ResetText();
            txt_SDTNV.ResetText();
            txt_TrangThaiTaiKhoanNV.ResetText();
            txt_EmailNV.ResetText();
            txt_PasswordNV.ResetText();
        }
        private void btn_Them_NhanVien_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhanVien '{txt_MaNV.Text}', N'{txt_HoTenNV.Text}', '{txt_SDTNV.Text}', '{txt_EmailNV.Text}', '{txt_PasswordNV.Text}', N'{txt_TrangThaiTaiKhoanNV.Text}', 'Insert' ", myconn.getConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm nhân viên thành công!");
            myconn.closeConnection();
            Reset();
            LoadData();

        }
        private void btn_Sua_NhanVien_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhanVien '{txt_MaNV.Text}', N'{txt_HoTenNV.Text}', '{txt_SDTNV.Text}', '{txt_EmailNV.Text}', '{txt_PasswordNV.Text}', N'{txt_TrangThaiTaiKhoanNV.Text}', 'Update' ", myconn.getConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa nhân viên thành công!");
            myconn.closeConnection();
            Reset();
            LoadData();
        }
        private void btn_Xoa_NhanVien_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhanVien '{txt_MaNV.Text}', N'{txt_HoTenNV.Text}', '{txt_SDTNV.Text}', '{txt_EmailNV.Text}', '{txt_PasswordNV.Text}', N'{txt_TrangThaiTaiKhoanNV.Text}', 'Delete' ", myconn.getConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa nhân viên thành công!");
            myconn.closeConnection();
            Reset();
            LoadData();
        }
        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_HoTenNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            txt_SDTNV.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_EmailNV.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_PasswordNV.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThaiTaiKhoanNV.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
        }
    }
}