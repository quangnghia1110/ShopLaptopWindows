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
                tabControl1.SelectedTab = tab_Information;
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
                tabControl1.SelectedTab = tab_Information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tab_Options;
            txt_MaHD.Text = dgv_HoaDon.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HD.Text = dgv_HoaDon.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV_HD.Text = dgv_HoaDon.CurrentRow.Cells[2].Value.ToString();
            txt_SoTienThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[4].Value.ToString();
            txt_PhuongThucThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[5].Value.ToString();
            txt_TrangThaiThanhToan_HD.Text = dgv_HoaDon.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_TimKiem_HoaDon_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = this.bUS_HoaDon.FindHoaDon(date_Tu.Value, date_Den.Value);
            dgv_HoaDon.Refresh();
        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("sp_PrintHoaDon", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaHD", txt_MaHD.Text.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                rpt_HoaDon xuathoadon = new rpt_HoaDon();
                xuathoadon.SetDataSource(dt);

                Form_PrintHoaDon f = new Form_PrintHoaDon();
                f.crv_HoaDon.ReportSource = xuathoadon;
                f.ShowDialog();
            }
        }
    }
}
