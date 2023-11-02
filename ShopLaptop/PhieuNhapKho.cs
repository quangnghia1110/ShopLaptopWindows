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
    public partial class PhieuNhapKho : Form
    {
        public PhieuNhapKho()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemPhieuNhapKho(@NgayNhapKho)", conn);
                cmd.Parameters.AddWithValue("@NgayNhapKho", dt_TimKiem_PNK.Value);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_PhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }

        private void btn_Show_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhapKho", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_PhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }
    }
}
