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
            LoadData();
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
            try
            {
                bool is_success = bus_ChiTietHoaDon.InsertChiTietHoaDon(txt_MaLT.Text, txt_MaHD.Text, txt_SoLuongSP.Text,
                                txt_GiaBanTungSP.Text, txt_ThueVAT.Text, txt_KhuyenMai.Text, txt_ThanhTienTungSP.Text);
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

        private void btn_Sua_CTHD_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bus_ChiTietHoaDon.UpdateChiTietHoaDon(txt_MaLT.Text, txt_MaHD.Text, txt_SoLuongSP.Text,
                            txt_GiaBanTungSP.Text, txt_ThueVAT.Text, txt_KhuyenMai.Text, txt_ThanhTienTungSP.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tabControl1.SelectedTab = tabPage1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_CTHD_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bus_ChiTietHoaDon.DeleteChiTietHoaDon(txt_MaLT.Text, txt_MaHD.Text, txt_SoLuongSP.Text,
                            txt_GiaBanTungSP.Text, txt_ThueVAT.Text, txt_KhuyenMai.Text, txt_ThanhTienTungSP.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tabControl1.SelectedTab = tabPage1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgv_ChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
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
