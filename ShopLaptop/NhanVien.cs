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

        MyConnect myconn = new MyConnect();
        

       

        public NhanVien()
        {
            InitializeComponent();
        }

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                
                conn.Open();
                string sql = "select * from NhanVien";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                dgv_NhanVien.DataSource = dt;
                conn.Close();
            }
          
        }

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
    }
}
