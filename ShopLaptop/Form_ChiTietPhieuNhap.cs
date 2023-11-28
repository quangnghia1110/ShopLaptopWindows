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
    public partial class Form_ChiTietPhieuNhap : Form
    {
        MyConnect myconn = new MyConnect();
        BUS_ChiTietPhieuNhap bUS_ChiTietPhieuNhap = new BUS_ChiTietPhieuNhap();
        public Form_ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void lbl_HeaderTab1PNK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_PhieuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_PhieuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_PhieuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_ChiTietPhieuNhapKho_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Reset()
        {
            txt_MaLT.ResetText();
            txt_MaNK.ResetText();
            txt_SoLuongSP.ResetText();
            txt_ThanhTienTungSP.ResetText();
            txt_ThueVAT.ResetText();
            txt_GiaNhapTungSP.ResetText();
        }
        private void LoadData()
        {
            dgv_ChiTietPhieuNhapKho.DataSource = bUS_ChiTietPhieuNhap.LoadChiTietPhieuNhaps();
            dgv_ChiTietPhieuNhapKho.Refresh();
        }
        private void btn_Them_PhieuNhapKho_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_ChiTietPhieuNhap.InsertChiTietPhieuNhap(txt_MaLT.Text,txt_MaNK.Text,txt_SoLuongSP.Text,txt_GiaNhapTungSP.Text,txt_ThueVAT.Text,txt_ThanhTienTungSP.Text);
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

        private void btn_Sua_PhieuNhapKho_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_ChiTietPhieuNhap.UpdateChiTietPhieuNhap(txt_MaLT.Text, txt_MaNK.Text, txt_SoLuongSP.Text, txt_GiaNhapTungSP.Text, txt_ThueVAT.Text, txt_ThanhTienTungSP.Text);
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

        private void btn_Xoa_PhieuNhapKho_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_ChiTietPhieuNhap.DeleteChiTietPhieuNhap(txt_MaLT.Text, txt_MaNK.Text, txt_SoLuongSP.Text, txt_GiaNhapTungSP.Text, txt_ThueVAT.Text, txt_ThanhTienTungSP.Text);
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

        private void dgv_ChiTietPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            txt_MaLT.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[0].Value.ToString();
            txt_MaNK.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuongSP.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[2].Value.ToString();
            txt_GiaNhapTungSP.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[3].Value.ToString();
            txt_ThueVAT.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[4].Value.ToString();
            txt_ThanhTienTungSP.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
