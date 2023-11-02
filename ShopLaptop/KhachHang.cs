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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void btn_Show_KhachHnag_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_KhachHang.DataSource = dt;
                conn.Close();
            }
        }

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
    }
}
