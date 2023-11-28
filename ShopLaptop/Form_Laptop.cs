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
using System.IO;

namespace ShopLaptop
{
    public partial class Form_Laptop : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_Laptop bUS_Laptop = new BUS_Laptop();
        public Form_Laptop()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txt_MaLT.ResetText();
            txt_MauSac.ResetText();
            txt_Pin.ResetText();
            txt_ManHinh.ResetText();
            txt_CPU.ResetText();
            txt_DungLuongBoNho.ResetText();
            txt_TenHangLT.ResetText();
            txt_TenLT.ResetText();
            txt_SoLuong.ResetText();
            txt_KhoiLuong.ResetText();
            txt_QuaTangKem.ResetText();
            txt_HanBaoHanh.ResetText();
            picAnhLaptop.Image = null;
        }
        private void LoadData()
        {
            dgv_Laptop.DataSource = bUS_Laptop.LoadLaptop();
            dgv_Laptop.Refresh();
        }
        //hiển thị danh sách laptop
        private void btn_Show_Laptop_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //tìm kiếm laptop dựa theo các thuộc tính Tên LT, Tên Hãng LT, Khối lượng, Màu sắc, Màn Hình
        private void btn_TimKiem_Laptop_Click(object sender, EventArgs e)
        {
            dgv_Laptop.DataSource = this.bUS_Laptop.FindLaptop(txt_TimKiemLT_TenLT.Text, txt_TimKiemLT_KhoiLuong.Text, txt_TimKiemLT_TenHangLT.Text, txt_TimKiemLT_MauSac.Text, txt_TimKiemLT_ManHinh.Text);
        }

        private void dgv_Laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            txt_MaLT.Text = dgv_Laptop.CurrentRow.Cells[0].Value.ToString();
            txt_TenLT.Text = dgv_Laptop.CurrentRow.Cells[1].Value.ToString();
            txt_TenHangLT.Text = dgv_Laptop.CurrentRow.Cells[2].Value.ToString();
            txt_SoLuong.Text = dgv_Laptop.CurrentRow.Cells[3].Value.ToString();
            txt_KhoiLuong.Text = dgv_Laptop.CurrentRow.Cells[4].Value.ToString();
            txt_HanBaoHanh.Text = dgv_Laptop.CurrentRow.Cells[5].Value.ToString();
            txt_MauSac.Text = dgv_Laptop.CurrentRow.Cells[6].Value.ToString();
            txt_DungLuongBoNho.Text = dgv_Laptop.CurrentRow.Cells[7].Value.ToString();
            txt_ManHinh.Text = dgv_Laptop.CurrentRow.Cells[8].Value.ToString();
            txt_CPU.Text = dgv_Laptop.CurrentRow.Cells[9].Value.ToString();
            txt_QuaTangKem.Text = dgv_Laptop.CurrentRow.Cells[10].Value.ToString();
            txt_Pin.Text = dgv_Laptop.CurrentRow.Cells[11].Value.ToString();
            picAnhLaptop.Image = ByteToImage((byte[])dgv_Laptop.CurrentRow.Cells[12].Value);
        }

        public static byte[] ImageToByte(Image img)
        {
            try
            {
                if (img == null) { return null; }
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        // Chuyen kieu byte sang Image
        public static Image ByteToImage(byte[] imgData)
        {
            try
            {
                using (var ms = new MemoryStream(imgData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        
        private void btn_Them_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] anhLaptop = null;
                if (picAnhLaptop.Image != null)
                {
                    anhLaptop = ImageToByte(picAnhLaptop.Image);
                }
                int is_success = bUS_Laptop.ThemLaptop(txt_MaLT.Text,txt_TenLT.Text,txt_TenHangLT.Text,txt_SoLuong.Text,txt_KhoiLuong.Text,txt_HanBaoHanh.Text,txt_MauSac.Text,txt_DungLuongBoNho.Text,txt_ManHinh.Text,txt_CPU.Text,txt_QuaTangKem.Text,txt_Pin.Text, anhLaptop);
                LoadData();
                Reset();
                if (is_success != 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

      
        private void btn_Sua_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] anhLaptop = null;
                if (picAnhLaptop.Image != null)
                {
                    anhLaptop = ImageToByte(picAnhLaptop.Image);
                }
                int is_success = bUS_Laptop.SuaLaptop(txt_MaLT.Text, txt_TenLT.Text, txt_TenHangLT.Text, txt_SoLuong.Text, txt_KhoiLuong.Text, txt_HanBaoHanh.Text, txt_MauSac.Text, txt_DungLuongBoNho.Text, txt_ManHinh.Text, txt_CPU.Text, txt_QuaTangKem.Text, txt_Pin.Text, anhLaptop);
                LoadData();
                Reset();
                if (is_success != 0)
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

        
        private void btn_Xoa_KhacHang_Click(object sender, EventArgs e)
        {
            try
            {
                int is_success = bUS_Laptop.XoaLaptop(txt_MaLT.Text);
                LoadData();
                Reset();
                if (is_success != 0)
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

        private void txt_TimKiemLT_TenHangLT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;)|*.jpg;*.jpge", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hien thi hinh anh toi picture
                    picAnhLaptop.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
