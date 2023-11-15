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

namespace ShopLaptop
{
    public partial class Form_Laptop : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_Laptop bUS_Laptop = new BUS_Laptop();
        public Form_Laptop()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txt_MaLT.ResetText();
            txt_MauSac.ResetText();
            txt_Pin.ResetText();
            txt_ManHinh.ResetText();
            txt_CPU.ResetText();
            txt_DungLuongBoNho.ResetText();
            txt_TenHangLT.ResetText();
            txt_TenLT.ResetText();
            txt_SoLuong.ResetText();
            txt_KhoiLuong.ResetText();
            txt_QuaTangKem.ResetText();
            txt_HanBaoHanh.ResetText();
        }
        private void LoadData()
        {
            dgv_Laptop.DataSource = bUS_Laptop.LoadLaptops();
            dgv_Laptop.Refresh();
        }
        //hiển thị danh sách laptop
        private void btn_Show_Laptop_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //tìm kiếm laptop dựa theo các thuộc tính Tên LT, Tên Hãng LT, Khối lượng, Màu sắc, Màn Hình
        private void btn_TimKiem_Laptop_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemLapTop(@TenLT,@KhoiLuong, @TenHangLT, @MauSac, @ManHinh)", conn);
                cmd.Parameters.AddWithValue("@TenLT", txt_TimKiemLT_TenLT.Text);
                cmd.Parameters.AddWithValue("@KhoiLuong", txt_TimKiemLT_KhoiLuong.Text);
                cmd.Parameters.AddWithValue("@TenHangLT", txt_TimKiemLT_TenHangLT.Text);
                cmd.Parameters.AddWithValue("@MauSac", txt_TimKiemLT_MauSac.Text);
                cmd.Parameters.AddWithValue("@ManHinh", txt_TimKiemLT_ManHinh.Text);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_Laptop.DataSource = dt;
                conn.Close();
            }
        }

        private void dgv_Laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLT.Text = dgv_Laptop.CurrentRow.Cells[0].Value.ToString();
            txt_TenLT.Text = dgv_Laptop.CurrentRow.Cells[1].Value.ToString();
            txt_TenHangLT.Text = dgv_Laptop.CurrentRow.Cells[2].Value.ToString();
            txt_KhoiLuong.Text = dgv_Laptop.CurrentRow.Cells[3].Value.ToString();
            txt_HanBaoHanh.Text = dgv_Laptop.CurrentRow.Cells[4].Value.ToString();
            txt_SoLuong.Text = dgv_Laptop.CurrentRow.Cells[5].Value.ToString();
            txt_MauSac.Text = dgv_Laptop.CurrentRow.Cells[6].Value.ToString();
            txt_DungLuongBoNho.Text = dgv_Laptop.CurrentRow.Cells[7].Value.ToString();
            txt_ManHinh.Text = dgv_Laptop.CurrentRow.Cells[8].Value.ToString();
            txt_CPU.Text = dgv_Laptop.CurrentRow.Cells[9].Value.ToString();
            txt_QuaTangKem.Text = dgv_Laptop.CurrentRow.Cells[10].Value.ToString();
            txt_Pin.Text = dgv_Laptop.CurrentRow.Cells[11].ToString();
        }

        private void btn_Them_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_Laptop.InsertLaptop(txt_MaLT.Text,txt_TenLT.Text,txt_TenHangLT.Text,txt_SoLuong.Text,txt_KhoiLuong.Text,txt_HanBaoHanh.Text,txt_MauSac.Text,txt_DungLuongBoNho.Text,txt_ManHinh.Text,txt_CPU.Text,txt_QuaTangKem.Text,txt_Pin.Text);
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

        private void btn_Sua_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_Laptop.UpdateLaptop(txt_MaLT.Text, txt_TenLT.Text, txt_TenHangLT.Text, txt_SoLuong.Text, txt_KhoiLuong.Text, txt_HanBaoHanh.Text, txt_MauSac.Text, txt_DungLuongBoNho.Text, txt_ManHinh.Text, txt_CPU.Text, txt_QuaTangKem.Text, txt_Pin.Text);
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

        private void btn_Xoa_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_Laptop.DeleteLaptop(txt_MaLT.Text, txt_TenLT.Text, txt_TenHangLT.Text, txt_SoLuong.Text, txt_KhoiLuong.Text, txt_HanBaoHanh.Text, txt_MauSac.Text, txt_DungLuongBoNho.Text, txt_ManHinh.Text, txt_CPU.Text, txt_QuaTangKem.Text, txt_Pin.Text);
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

        private void txt_TimKiemLT_TenHangLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
