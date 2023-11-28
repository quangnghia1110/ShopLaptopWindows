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
    public partial class Form_NhaCungCap : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_NhaCungCap bUS_NhaCungCap = new BUS_NhaCungCap();
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }

        //hiển thị danh sách nhà cung cấp
        private void btn_Show_NhaCungCap_Click(object sender, EventArgs e)
        {
            dgv_NhaCungCap.DataSource = bUS_NhaCungCap.LoadNhaCungCaps();
            dgv_NhaCungCap.Refresh();
        }
        
        //tìm kiếm NCC dựa vào Mã NCC
        private void btn_TimKiem_NhaCungCap_Click(object sender, EventArgs e)
        {
            dgv_NhaCungCap.DataSource = this.bUS_NhaCungCap.FindNhaCungCap(txt_TimKiem_NhaCungCap.Text);
            dgv_NhaCungCap.Refresh();
        }
        private void Reset()
        {
            txt_MaNCC.ResetText();
            txt_TenNCC.ResetText();
            txt_Email.ResetText();
            txt_DiaChi.ResetText();
            txt_SDT.ResetText();
            txt_TrangThaiHopTac.ResetText();
        }
        private void LoadData()
        {
            dgv_NhaCungCap.DataSource =  bUS_NhaCungCap.LoadNhaCungCaps();
            dgv_NhaCungCap.Refresh();
        }
        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            txt_MaNCC.Text = dgv_NhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txt_TenNCC.Text = dgv_NhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txt_Email.Text = dgv_NhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dgv_NhaCungCap.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dgv_NhaCungCap.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThaiHopTac.Text = dgv_NhaCungCap.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Them_NhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_NhaCungCap.InsertNhaCungCap(txt_MaNCC.Text,txt_TenNCC.Text,txt_Email.Text,txt_DiaChi.Text,txt_SDT.Text,txt_TrangThaiHopTac.Text);
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

        private void btn_Sua_NhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_NhaCungCap.UpdateNhaCungCap(txt_MaNCC.Text, txt_TenNCC.Text, txt_Email.Text, txt_DiaChi.Text, txt_SDT.Text, txt_TrangThaiHopTac.Text);
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

        private void btn_Xoa_NhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_NhaCungCap.DeleteNhaCungCap(txt_MaNCC.Text, txt_TenNCC.Text, txt_Email.Text, txt_DiaChi.Text, txt_SDT.Text, txt_TrangThaiHopTac.Text);
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

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
