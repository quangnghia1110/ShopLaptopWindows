using ShopLaptop.BUS;
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
    public partial class Form_PhieuNhapKho : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_PhieuNhapKho bUS_PhieuNhapKho = new BUS_PhieuNhapKho();
        public Form_PhieuNhapKho()
        {
            InitializeComponent();
        }

        //hiển thị danh sách phiếu nhập kho
        private void btn_Show_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //tìm kiếm phiếu nhập kho dựa vào ngày nhập kho
        private void btn_TimKiem_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            dgv_PhieuNhapKho.DataSource = this.bUS_PhieuNhapKho.FindPhieuNhapKho(dt_TimKiem_PNK.Value);
            dgv_PhieuNhapKho.Refresh();
        }
        private void Reset()
        {
            txt_MaNK.ResetText();
            txt_MaNCC_PNK.ResetText();
            txt_MaNV_PNK.ResetText();
            txt_SoTienThanhToan_PNK.ResetText();
            txt_TrangThaiThanhToan_PNK.ResetText();
            txt_PhuongThucThanhToan_PNK.ResetText();
        }
        private void LoadData()
        {
            dgv_PhieuNhapKho.DataSource = bUS_PhieuNhapKho.LoadPhieuNhapKhos();
            dgv_PhieuNhapKho.Refresh();
        }
        private void btn_Them_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_PhieuNhapKho.InsertPhieuNhapKho(txt_MaNK.Text,txt_MaNCC_PNK.Text,txt_SoTienThanhToan_PNK.Text,txt_SoTienThanhToan_PNK.Text,txt_PhuongThucThanhToan_PNK.Text,txt_TrangThaiThanhToan_PNK.Text);
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

        private void btn_Sua_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_PhieuNhapKho.UpdatePhieuNhapKho(txt_MaNK.Text, txt_MaNCC_PNK.Text, txt_SoTienThanhToan_PNK.Text, txt_SoTienThanhToan_PNK.Text, txt_PhuongThucThanhToan_PNK.Text, txt_TrangThaiThanhToan_PNK.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tabControl1.SelectedTab = tab_Information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_PhieuNhapKho.DeletePhieuNhapKho(txt_MaNK.Text, txt_MaNCC_PNK.Text, txt_SoTienThanhToan_PNK.Text, txt_SoTienThanhToan_PNK.Text, txt_PhuongThucThanhToan_PNK.Text, txt_TrangThaiThanhToan_PNK.Text);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tabControl1.SelectedTab = tab_Information;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgv_PhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tab_Options;
            txt_MaNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[0].Value.ToString();
            txt_MaNCC_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[2].Value.ToString();
            txt_SoTienThanhToan_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[4].Value.ToString();
            txt_PhuongThucThanhToan_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[5].Value.ToString();
            txt_TrangThaiThanhToan_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[6].Value.ToString();
        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
