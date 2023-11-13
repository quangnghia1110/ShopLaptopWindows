using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopLaptop.BUS;

namespace ShopLaptop
{
    public partial class Form_ChiTietHoaDon : Form
    {
        MyConnect myconn = new MyConnect();
        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        public Form_ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void btn_Show_ChiTietHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_ChiTietHD.DataSource = dt;
                conn.Close();
            }
        }
        private void LoadData()
        {
            this.dgv_ChiTietHD.DataSource = bus_ChiTietHoaDon.LoadChiTietHoaDons();
        }
        private void Reset()
        {
            txt_MaLT.ResetText();
            txt_MaHD.ResetText();
            txt_SoLuongSP.ResetText();
            txt_ThanhTienTungSP.ResetText();
            txt_KhuyenMai.ResetText();
            txt_ThueVAT.ResetText();
            txt_GiaBanTungSP.ResetText();
        }

        private void btn_Them_CTHD_Click(object sender, EventArgs e)
        {
            bus_ChiTietHoaDon.InsertChiTietHoaDon(txt_MaLT.Text, txt_MaHD.Text, txt_SoLuongSP.Text,
                txt_GiaBanTungSP.Text, txt_ThueVAT.Text, txt_KhuyenMai.Text, txt_ThanhTienTungSP.Text);
        }

        private void btn_Sua_CTHD_Click(object sender, EventArgs e)
        {
            bus_ChiTietHoaDon.UpdateChiTietHoaDon(txt_MaLT.Text, txt_MaHD.Text, txt_SoLuongSP.Text,
                            txt_GiaBanTungSP.Text, txt_ThueVAT.Text, txt_KhuyenMai.Text, txt_ThanhTienTungSP.Text);
        }

        private void btn_Xoa_CTHD_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaLT.Text}', '{txt_MaHD.Text}', '{txt_SoLuongSP.Text}', {txt_GiaBanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Delete' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void dgv_ChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLT.Text = dgv_ChiTietHD.CurrentRow.Cells[0].Value.ToString();
            txt_MaHD.Text = dgv_ChiTietHD.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuongSP.Text = dgv_ChiTietHD.CurrentRow.Cells[2].Value.ToString();
            txt_GiaBanTungSP.Text = dgv_ChiTietHD.CurrentRow.Cells[3].Value.ToString();
            txt_ThueVAT.Text = dgv_ChiTietHD.CurrentRow.Cells[4].Value.ToString();
            txt_KhuyenMai.Text = dgv_ChiTietHD.CurrentRow.Cells[5].Value.ToString();
            txt_ThanhTienTungSP.Text = dgv_ChiTietHD.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
