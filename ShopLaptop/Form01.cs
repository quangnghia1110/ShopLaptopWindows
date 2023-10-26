using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ShopLaptop
{
    public partial class ShopLaptop : Form
    {
        public ShopLaptop()
        {
            InitializeComponent();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.dashboard;
            gunaLabel.Text = "Trang chủ";
            container(new TrangChu());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.employee;
            gunaLabel.Text = "Nhân viên";
            container(new NhanVien());
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.laptop;
            gunaLabel.Text = "Laptop";
            container(new Laptop());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.box;
            gunaLabel.Text = "Nhà cung cấp";
            container(new NhaCungCap());
        }

        private void btnPhieuNhapKho_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.detail;
            gunaLabel.Text = "Phiếu nhập kho";
            container(new PhieuNhapKho());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.receipt;
            gunaLabel.Text = "Hóa đơn";
            container(new HoaDon());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.customer;
            gunaLabel.Text = "Khách hàng";
            container(new KhachHang());
        }

        private void btnTraGop_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.credit;
            gunaLabel.Text = "Trả góp";
            container(new TraGop());
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.warranty;
            gunaLabel.Text = "Bảo hành";
            container(new BaoHanh());
        }

        private void btnNangCap_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.upgrade;
            gunaLabel.Text = "Nâng cấp";
            container(new NangCap());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.chart;
            container(new ThongKe());
        }

        int x = 160, y = 15, a = 1;
        Random random = new Random();

      

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                gunaLabelWelcome.Location = new Point(x, y);
                if (x >= 300)
                {
                    a = -2;
                }
                if (x <= 185)
                {
                    a = 2;
                }
            }
            catch (Exception ex)
            { 
                ex.Source = "Error";
            }
        }

        

        private void container(object _form)
        {
            if(panelContent.Controls.Count > 0) 
                 panelContent.Controls.Clear();
            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }
        public void ShowForm(Form form)
        {
            if (panelContent.Controls.Count > 0)
                panelContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }
    }
}
