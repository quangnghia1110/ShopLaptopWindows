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
    public partial class Form_TraGop : Form
    {
        MyConnect myconn = new MyConnect();
        BUS_TraGop bUS_TraGop = new BUS_TraGop();
        public Form_TraGop()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgv_TraGop.DataSource = bUS_TraGop.LoadTraGops();
            dgv_TraGop.Refresh();
        }
        private void Reset()
        {
            txt_MaHD.ResetText();
            txt_MaKH_HD.ResetText();
            txt_LaiSuatHangThang.ResetText();
            txt_TienTraTruoc_HD.ResetText();
            txt_TienConLai_TG.ResetText();
            txt_ThoiGianTraGop.ResetText();
            Date_NgayBatDau.Value = DateTime.Now;
        }
        private void txt_TimKiem_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_OptionsHD_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_TraGop_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_TraGop_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_TraGop.InsertTraGop(txt_MaHD.Text,txt_MaKH_HD.Text,txt_LaiSuatHangThang.Text,txt_TienTraTruoc_HD.Text,txt_TienConLai_TG.Text,txt_ThoiGianTraGop.Text,Date_NgayBatDau.Value);
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
        private void btn_Sua_TraGop_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_TraGop.UpdateTraGop(txt_MaHD.Text, txt_MaKH_HD.Text, txt_LaiSuatHangThang.Text, txt_TienTraTruoc_HD.Text, txt_TienConLai_TG.Text, txt_ThoiGianTraGop.Text, Date_NgayBatDau.Value);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tab_TraGop.SelectedTab = tab_Information_TraGop;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btn_Xoa_TraGop_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_TraGop.DeleteTraGop(txt_MaHD.Text, txt_MaKH_HD.Text, txt_LaiSuatHangThang.Text, txt_TienTraTruoc_HD.Text, txt_TienConLai_TG.Text, txt_ThoiGianTraGop.Text, Date_NgayBatDau.Value);
                LoadData();
                Reset();
                if (is_success)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tab_TraGop.SelectedTab = tab_Information_TraGop;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void dgv_TraGop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tab_TraGop.SelectedTab = tab_Option_TraGop;
            txt_MaHD.Text = dgv_TraGop.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HD.Text = dgv_TraGop.CurrentRow.Cells[1].Value.ToString();
            txt_LaiSuatHangThang.Text = dgv_TraGop.CurrentRow.Cells[2].Value.ToString();
            txt_TienTraTruoc_HD.Text = dgv_TraGop.CurrentRow.Cells[3].Value.ToString();
            txt_TienConLai_TG.Text = dgv_TraGop.CurrentRow.Cells[4].Value.ToString();
            txt_ThoiGianTraGop.Text = dgv_TraGop.CurrentRow.Cells[5].Value.ToString();
            Date_NgayBatDau.Value = Convert.ToDateTime(dgv_TraGop.CurrentRow.Cells[6].Value);
        }

        private void btn_TimKiem_TraGop_Click(object sender, EventArgs e)
        {
            dgv_TraGop.DataSource = this.bUS_TraGop.FindTraGop(txt_TimKiem_MaHD.Text, txt_Tk_MaKH.Text, txt_TK_LaiSuat.Text);
            dgv_TraGop.Refresh();
        }

        private void tab_Option_TraGop_Click(object sender, EventArgs e)
        {

        }

    }
}
