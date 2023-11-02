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
    public partial class HienThiThongKeTongQuan : Form
    {
        public HienThiThongKeTongQuan()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //tính doanh thu
        private void btn_DoanhThu_Xuat_Click(object sender, EventArgs e)
        {
            //tính doanh thu theo ngày, tháng, năm nhập vào
            if (txt_DoanhThu_Ngay != null && txt_DoanhThu_Thang != null && txt_DoanhThu_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhDoanhThuNgay(@Ngay, @Thang, @Nam)", conn);
                    cmd.Parameters.AddWithValue("@Ngay", txt_DoanhThu_Ngay.Text);
                    cmd.Parameters.AddWithValue("@Thang", txt_DoanhThu_Thang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txt_DoanhThu_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_DoanhThu_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

            //tính doanh thu theo tháng, năm nhập vào
            if (string.IsNullOrEmpty(txt_DoanhThu_Ngay.Text) && txt_DoanhThu_Thang != null && txt_DoanhThu_Nam != null)            
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhDoanhThuThang(@Thang, @Nam)", conn);
                    cmd.Parameters.AddWithValue("@Thang", txt_DoanhThu_Thang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txt_DoanhThu_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_DoanhThu_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

            //tính doanh thu theo năm nhập vào
            if (string.IsNullOrEmpty(txt_DoanhThu_Ngay.Text) && string.IsNullOrEmpty(txt_DoanhThu_Thang.Text) && txt_DoanhThu_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhDoanhThuNam(@Nam)", conn);
                    cmd.Parameters.AddWithValue("@Nam", txt_DoanhThu_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_DoanhThu_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

        }

        //tính lợi nhuận theo ngày đã chọn
        private void btn_LoiNhuan_Xuat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhLoiNhuanNgay(@Ngay)", conn);
                cmd.Parameters.AddWithValue("@Ngay", dt_LoiNhuan.Value);
                conn.Open();
                object result = cmd.ExecuteScalar();
                txt_LoiNhuan.Text = result.ToString();
                conn.Close();
            }
        }

        private void btn_HoaDon_Xuat_Click(object sender, EventArgs e)
        {

            //tính số lượng hóa đơn theo ngày, tháng, năm nhập vào
            if (txt_HoaDon_Ngay != null && txt_HoaDon_Thang != null && txt_HoaDon_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhSLHoaDonNgay(@Ngay, @Thang, @Nam)", conn);
                    cmd.Parameters.AddWithValue("@Ngay", txt_HoaDon_Ngay.Text);
                    cmd.Parameters.AddWithValue("@Thang", txt_HoaDon_Thang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txt_HoaDon_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_HoaDon_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

            //tính số lượng hóa đơn theo tháng, năm nhập vào
            if (string.IsNullOrEmpty(txt_HoaDon_Ngay.Text) && txt_HoaDon_Thang != null && txt_HoaDon_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhSLHoaDonThang(@Thang, @Nam)", conn);
                    cmd.Parameters.AddWithValue("@Thang", txt_HoaDon_Thang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txt_HoaDon_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_HoaDon_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

            //tính số lượng hóa đơn theo năm nhập vào
            if (string.IsNullOrEmpty(txt_HoaDon_Ngay.Text) && string.IsNullOrEmpty(txt_HoaDon_Thang.Text) && txt_HoaDon_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhSLHoaDonNam(@Nam)", conn);
                    cmd.Parameters.AddWithValue("@Nam", txt_HoaDon_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_HoaDon_Tong.Text = result.ToString();
                    conn.Close();
                }
            }
        }

        private void btn_PhieuNhap_Xuat_Click(object sender, EventArgs e)
        {
            //tính số lượng phiếu nhập theo ngày, tháng, năm nhập vào
            if (txt_PhieuNhap_Ngay != null && txt_PhieuNhap_Thang != null && txt_PhieuNhap_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhSLNhapKhoNgay(@Ngay, @Thang, @Nam)", conn);
                    cmd.Parameters.AddWithValue("@Ngay", txt_PhieuNhap_Ngay.Text);
                    cmd.Parameters.AddWithValue("@Thang", txt_PhieuNhap_Thang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txt_PhieuNhap_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_PhieuNhap_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

            //tính số lượng phiếu nhập theo tháng, năm nhập vào
            if (string.IsNullOrEmpty(txt_PhieuNhap_Ngay.Text) && txt_PhieuNhap_Thang != null && txt_PhieuNhap_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhSLNhapKhoThang(@Thang, @Nam)", conn);
                    cmd.Parameters.AddWithValue("@Thang", txt_PhieuNhap_Thang.Text);
                    cmd.Parameters.AddWithValue("@Nam", txt_PhieuNhap_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_PhieuNhap_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

            //tính số lượng phiếu nhập theo năm nhập vào
            if (string.IsNullOrEmpty(txt_PhieuNhap_Ngay.Text) && string.IsNullOrEmpty(txt_PhieuNhap_Thang.Text) && txt_PhieuNhap_Nam != null)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhSLNhapKhoNam(@Nam)", conn);
                    cmd.Parameters.AddWithValue("@Nam", txt_PhieuNhap_Nam.Text);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    txt_PhieuNhap_Tong.Text = result.ToString();
                    conn.Close();
                }
            }

        }
    }
}
