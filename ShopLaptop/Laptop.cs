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
    public partial class Laptop : Form
    {
        public Laptop()
        {
            InitializeComponent();
        }

        //hiển thị danh sách laptop
        private void btn_Show_Laptop_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Laptop", conn);

                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_Laptop.DataSource = dt;
                conn.Close();
            }
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
    }
}
