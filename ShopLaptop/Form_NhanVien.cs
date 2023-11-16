using FontAwesome.Sharp;
using ShopLaptop.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace ShopLaptop
{
    public partial class Form_NhanVien : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        public Form_NhanVien()
        {
            InitializeComponent();
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
        private void LoadData()
        {
            dgv_NhanVien.DataSource = bUS_NhanVien.LoadNhanViens();
            dgv_NhanVien.Refresh();
        }
        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_HoTenNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            txt_SDTNV.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_EmailNV.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_PasswordNV.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThaiTaiKhoanNV.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
        }        

        //hiển thị danh sách nhân viên
        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //tìm kiếm nhân viên dựa vào mã nhân viên
        private void btn_TimKiem_NhanVien_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = this.bUS_NhanVien.FindNhanVien(txt_TimKiem_NhanVien.Text);
            dgv_NhanVien.Refresh();
        }

        private void btn_Them_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_NhanVien.InsertNhanVien(txt_MaNV.Text,txt_HoTenNV.Text,txt_SDTNV.Text,txt_EmailNV.Text,txt_PasswordNV.Text,txt_TrangThaiTaiKhoanNV.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_NhanVien.UpdateNhanVien(txt_MaNV.Text, txt_HoTenNV.Text, txt_SDTNV.Text, txt_EmailNV.Text, txt_PasswordNV.Text, txt_TrangThaiTaiKhoanNV.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_NhanVien.DeleteNhanVien(txt_MaNV.Text, txt_HoTenNV.Text, txt_SDTNV.Text, txt_EmailNV.Text, txt_PasswordNV.Text, txt_TrangThaiTaiKhoanNV.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void tab_Information_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
