using FontAwesome.Sharp;
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
//using System.Data.SqlClient;

namespace ShopLaptop
{
    public partial class Form_NhanVien : Form
    {
        MyConnect myconn=new MyConnect();
        BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        public Form_NhanVien()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txt_MaNV.ResetText();
            txt_HoTenNV.ResetText();
            txt_SDTNV.ResetText();
            txt_TrangThaiTaiKhoanNV.ResetText();
            txt_EmailNV.ResetText();
            txt_PasswordNV.ResetText();
            picAnhNV.Image = null;
        }

       private void LoadData()
        {
            DataTable dt = bUS_NhanVien.LoadNhanVien();
            dgv_NhanVien.DataSource = dt;
        }

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tab_Options;
            txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_HoTenNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            txt_SDTNV.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_EmailNV.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_PasswordNV.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThaiTaiKhoanNV.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
            picAnhNV.Image = ByteToImage((byte[])dgv_NhanVien.CurrentRow.Cells[6].Value);
        }        

        //hiển thị danh sách nhân viên
        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //tìm kiếm nhân viên dựa vào mã nhân viên
        private void btn_TimKiem_NhanVien_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = this.bUS_NhanVien.FindNhanVien(txt_TimKiem_NhanVien.Text);
            dgv_NhanVien.Refresh();
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
        
        private void btn_Them_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] anhdg = null;
                if (picAnhNV.Image != null)
                {
                    anhdg = ImageToByte(picAnhNV.Image);
                }
                int is_success = bUS_NhanVien.ThemNhanVien(txt_MaNV.Text, txt_HoTenNV.Text, txt_SDTNV.Text, txt_EmailNV.Text, txt_PasswordNV.Text, txt_TrangThaiTaiKhoanNV.Text, anhdg);
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

       
        private void btn_Sua_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] anhdg = null;
                if (picAnhNV.Image != null)
                {
                    anhdg = ImageToByte(picAnhNV.Image);
                }
                int is_success = bUS_NhanVien.SuaNhanVien(txt_MaNV.Text, txt_HoTenNV.Text, txt_SDTNV.Text, txt_EmailNV.Text, txt_PasswordNV.Text, txt_TrangThaiTaiKhoanNV.Text, anhdg);
                LoadData();
                Reset();
                if (is_success != 0)
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
      
        private void btn_Xoa_NhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int is_success = bUS_NhanVien.XoaNhanVien(txt_MaNV.Text);
                LoadData();
                Reset();
                if (is_success != 0)
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

        private void tab_Information_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;)|*.jpg;*.jpge", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hien thi hinh anh toi picture
                    picAnhNV.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
