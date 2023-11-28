using ShopLaptop.BUS;
using ShopLaptop.DAL;
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
    public partial class Form_KhachHang : Form
    {
        MyConnect myconn = new MyConnect();
        BUS_KhachHang bUS_KhachHang= new BUS_KhachHang();
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadKhachHangs();
        }
        private void btn_Show_KhachHang_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tab_Options;
            txt_MaKH.Text = dgv_KhachHang.CurrentRow.Cells[0].Value.ToString();
            txt_LoaiKH.Text = dgv_KhachHang.CurrentRow.Cells[1].Value.ToString();
            txt_HoTenKH.Text = dgv_KhachHang.CurrentRow.Cells[2].Value.ToString();
            txt_SoCCCD.Text = dgv_KhachHang.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dgv_KhachHang.CurrentRow.Cells[4].Value.ToString();
            txt_TongSoTienDaGiaoDich.Text = dgv_KhachHang.CurrentRow.Cells[5].Value.ToString();

        }
        private void Reset()
        {
            txt_MaKH.ResetText();
            txt_LoaiKH.ResetText();
            txt_HoTenKH.ResetText();
            txt_SoCCCD.ResetText();
            txt_SDT.ResetText();
            txt_TongSoTienDaGiaoDich.ResetText();

        }
        private void btn_Them_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_KhachHang.InsertKhachHang(txt_MaKH.Text,txt_LoaiKH.Text,txt_HoTenKH.Text,txt_SoCCCD.Text,txt_SDT.Text,txt_TongSoTienDaGiaoDich.Text);
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
                bool is_success = bUS_KhachHang.UpdateKhachHang(txt_MaKH.Text, txt_LoaiKH.Text, txt_HoTenKH.Text, txt_SoCCCD.Text, txt_SDT.Text, txt_TongSoTienDaGiaoDich.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tabControl1.SelectedTab = tab_Information;
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
                bool is_success = bUS_KhachHang.DeleteKhachHang(txt_MaKH.Text, txt_LoaiKH.Text, txt_HoTenKH.Text, txt_SoCCCD.Text, txt_SDT.Text, txt_TongSoTienDaGiaoDich.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tabControl1.SelectedTab = tab_Information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //tìm kiếm thông tin cách hàng dựa vào Họ Tên, Số CCCD, SĐT
        private void btn_TimKiem_KhachHang_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemKhachHang(@HoTenKH, @SoCCCD, @SDT)", conn);
                cmd.Parameters.AddWithValue("@HoTenKH", txt_TimKiemKH_HoTenKH.Text);
                cmd.Parameters.AddWithValue("@SoCCCD", txt_TimKiemKH_CCCD.Text);
                cmd.Parameters.AddWithValue("@SDT", txt_TimKiemKH_SDT.Text);

                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_KhachHang.DataSource = dt;
                conn.Close();
            }
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_KhachHang.DataSource = this.bUS_KhachHang.FindKhachHang(txt_TimKiemKH_HoTenKH.Text, txt_TimKiemKH_CCCD.Text, txt_TimKiemKH_SDT.Text);
            dgv_KhachHang.Refresh();
        }
    }
}