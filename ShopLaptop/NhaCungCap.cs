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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        //hiển thị danh sách nhà cung cấp
        private void btn_Show_NhaCungCap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhaCungCap.DataSource = dt;
                conn.Close();
            }
        }
        
        //tìm kiếm NCC dựa vào Mã NCC
        private void btn_TimKiem_NhaCungCap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemNhaCungCap(@MaNCC)", conn);
                cmd.Parameters.AddWithValue("@MaNCC", txt_TimKiem_NhaCungCap.Text);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhaCungCap.DataSource = dt;
                conn.Close();
            }
        }
    }
}
