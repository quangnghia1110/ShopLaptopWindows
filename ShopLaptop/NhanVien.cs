using FontAwesome.Sharp;
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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        

        //hiển thị danh sách nhân viên
        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);               
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhanVien.DataSource = dt;
                conn.Close();
            }
        }

        //tìm kiếm nhân viên dựa vào mã nhân viên
        private void btn_TimKiem_NhanVien_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_TimKiemNhanVien(@MaNV)", conn);
                cmd.Parameters.AddWithValue("@MaNV", txt_TimKiem_NhanVien.Text);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhanVien.DataSource = dt;
                conn.Close();
            }
        }
    }
}
