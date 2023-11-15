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
using System.Web.WebSockets;
using System.Windows.Forms;

namespace ShopLaptop
{
    public partial class Form_HoaDon : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_HoaDon bUS_HoaDon = new BUS_HoaDon();
        public Form_HoaDon()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgv_HoaDon.DataSource =  bUS_HoaDon.LoadHoaDons();
            dgv_HoaDon.Refresh();
        }
        private void Reset()
        {
            txt_MaHD.ResetText();
            txt_MaKH_HD.ResetText();
            txt_MaNV_HD.ResetText();
            txt_SoTienThanhToan_HD.ResetText();
            txt_PhuongThucThanhToan_HD.ResetText();
            txt_TrangThaiThanhToan_HD.ResetText();
        }

        private void btn_Show_HoaDon_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
        }

        private void btn_Them_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_HoaDon.InsertHoaDon(txt_MaHD.Text, txt_MaKH_HD.Text, txt_MaNV_HD.Text, txt_SoTienThanhToan_HD.Text, txt_PhuongThucThanhToan_HD.Text,txt_TrangThaiThanhToan_HD.Text);
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

        private void btn_Sua_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_HoaDon.UpdateHoaDon(txt_MaHD.Text, txt_MaKH_HD.Text, txt_MaNV_HD.Text, txt_SoTienThanhToan_HD.Text, txt_PhuongThucThanhToan_HD.Text, txt_TrangThaiThanhToan_HD.Text);
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

        private void btn_Xoa_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_HoaDon.DeleteHoaDon(txt_MaHD.Text, txt_MaKH_HD.Text, txt_MaNV_HD.Text, txt_SoTienThanhToan_HD.Text, txt_PhuongThucThanhToan_HD.Text, txt_TrangThaiThanhToan_HD.Text);
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

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHD.Text = dgv_HoaDon.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HD.Text = dgv_HoaDon.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV_HD.Text = dgv_HoaDon.CurrentRow.Cells[2].Value.ToString();
            txt_SoTienThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[4].Value.ToString();
            txt_PhuongThucThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[5].Value.ToString();
            txt_TrangThaiThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_TimKiem_HoaDon_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select* from func_SearchOrderByPeroid(@FromDate, @ToDate)", myconn.getConnectionAdmin);
            cmd.Parameters.AddWithValue("@FromDate", date_Tu.Value);
            cmd.Parameters.AddWithValue("@ToDate", date_Den.Value);
            DataTable dt = new DataTable();
            myconn.openConnectionAdmin();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_HoaDon.DataSource = dt;
            myconn.closeConnectionAdmin();
        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
