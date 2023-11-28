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
    public partial class Form_BaoHanh : Form
    {
        MyConnect myconn = new MyConnect();
        BUS_GoiBaoHanh bUS_GoiBaoHanh = new BUS_GoiBaoHanh();
        BUS_HoatDongBaoHanh bUS_HoatDongBaoHanh = new BUS_HoatDongBaoHanh();
        public Form_BaoHanh()
        {
            InitializeComponent();
        }

        private void LoadDataGoiBaoHanh()
        {
            dgv_GoiBaoHanh.DataSource = bUS_GoiBaoHanh.LoadGoiBaoHanhs();
            dgv_GoiBaoHanh.Refresh();
        }
        private void LoadDataHoatDongBaoHanh()
        {
            dgv_HĐBH.DataSource = bUS_HoatDongBaoHanh.LoadHoatDongBaoHanhs();
            dgv_HĐBH.Refresh();
        }
        private void btn_Show_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            LoadDataGoiBaoHanh();
        }
        private void btn_Show_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            LoadDataHoatDongBaoHanh();
        }
        private void ResetGoiBaoHanh()
        {
            txt_MaGoiBaoHanh.ResetText();
            txt_TenGoiBH.ResetText();
            txt_MoTaChiTiet.ResetText();
        }
        private void ResetHoatDongBaoHanh()
        {
            txt_MaNV.ResetText();
            txt_MaKH.ResetText();
            txt_MaGoiBHanh.ResetText();
            txt_ChiPhiSuaChua.ResetText();
            txt_SoTienHoTro.ResetText();
            txt_ThoiGianBaoHanh.ResetText();
        }
        private void dgv_GoiBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbc_BaoHanh.SelectedTab = tbp_option_GoiBH;
            txt_MaGoiBaoHanh.Text = dgv_GoiBaoHanh.CurrentRow.Cells[0].Value.ToString();
            txt_TenGoiBH.Text = dgv_GoiBaoHanh.CurrentRow.Cells[1].Value.ToString();
            txt_MoTaChiTiet.Text = dgv_GoiBaoHanh.CurrentRow.Cells[2].Value.ToString();
        }
        private void dgv_HĐBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbc_BaoHanh.SelectedTab = tbp_HDBH;
            txt_MaNV.Text = dgv_HĐBH.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH.Text = dgv_HĐBH.CurrentRow.Cells[1].Value.ToString();
            txt_MaGoiBHanh.Text = dgv_HĐBH.CurrentRow.Cells[2].Value.ToString();
            txt_ChiPhiSuaChua.Text = dgv_HĐBH.CurrentRow.Cells[3].Value.ToString();
            txt_SoTienHoTro.Text = dgv_HĐBH.CurrentRow.Cells[4].Value.ToString();
            txt_ThoiGianBaoHanh.Text = dgv_HĐBH.CurrentRow.Cells[5].Value.ToString();
        }
        private void btn_Them_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_GoiBaoHanh.InsertGoiBaoHanh(txt_MaGoiBaoHanh.Text, txt_TenGoiBH.Text, txt_MoTaChiTiet.Text);
                LoadDataGoiBaoHanh();
                ResetGoiBaoHanh();
                if (is_success) {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btn_Sua_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_GoiBaoHanh.UpdateGoiBaoHanh(txt_MaGoiBaoHanh.Text, txt_TenGoiBH.Text, txt_MoTaChiTiet.Text);
                LoadDataGoiBaoHanh();
                ResetGoiBaoHanh();
                if (is_success)
                {
                    MessageBox.Show("Sửa gói bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbc_BaoHanh.SelectedTab = tbp_Infor_GoiBH;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btn_Xoa_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_GoiBaoHanh.DeleteGoiBaoHanh(txt_MaGoiBaoHanh.Text, txt_TenGoiBH.Text, txt_MoTaChiTiet.Text);
                LoadDataGoiBaoHanh();
                ResetGoiBaoHanh();
                if (is_success)
                {
                    MessageBox.Show("Xóa gói bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbc_BaoHanh.SelectedTab = tbp_Infor_GoiBH;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btn_Them_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_HoatDongBaoHanh.InsertHoatDongBaoHanh(txt_MaNV.Text, txt_MaKH.Text, txt_MaGoiBaoHanh.Text, txt_ChiPhiSuaChua.Text, txt_SoTienHoTro.Text, txt_SoTienHoTro.Text);
                LoadDataHoatDongBaoHanh();
                ResetHoatDongBaoHanh();
                if (is_success)
                {
                    MessageBox.Show("Thêm hoạt động bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btn_Sua_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_HoatDongBaoHanh.UpdateHoatDongBaoHanh(txt_MaNV.Text, txt_MaKH.Text, txt_MaGoiBaoHanh.Text, txt_ChiPhiSuaChua.Text, txt_SoTienHoTro.Text, txt_SoTienHoTro.Text);
                LoadDataHoatDongBaoHanh();
                ResetHoatDongBaoHanh();
                if (is_success)
                {
                    MessageBox.Show("Sửa hoạt động bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbc_BaoHanh.SelectedTab = tabPage3;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btn_Xoa_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_HoatDongBaoHanh.DeleteHoatDongBaoHanh(txt_MaNV.Text, txt_MaKH.Text, txt_MaGoiBaoHanh.Text, txt_ChiPhiSuaChua.Text, txt_SoTienHoTro.Text, txt_SoTienHoTro.Text);
                LoadDataHoatDongBaoHanh();
                ResetHoatDongBaoHanh();
                if (is_success)
                {
                    MessageBox.Show("Xóa hoạt động bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbc_BaoHanh.SelectedTab = tabPage3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            dgv_GoiBaoHanh.DataSource = this.bUS_GoiBaoHanh.FindGoiBaoHanh(txt_TimKiem_MaGoiBaoHanh.Text);
            dgv_GoiBaoHanh.Refresh();
        }

        private void btn_TimKiem_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            dgv_HĐBH.DataSource = this.bUS_HoatDongBaoHanh.FindHoatDongBaoHanh(txt_TimKiem_MaNhanVien.Text, txt_TimKiem_MaKhachHang.Text, txt_TimKiem_MaGoiBH.Text);
            dgv_HĐBH.Refresh();
        }

    }
}

