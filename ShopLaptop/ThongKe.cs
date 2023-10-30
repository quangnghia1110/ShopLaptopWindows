using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btn_ThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            containerTongQuan(new HienThiThongKe());
        }

        private void btn_ThongKeLoiNhuan_Click(object sender, EventArgs e)
        {
            containerTongQuan(new HienThiThongKe());
        }

        private void btn_ThongKeSoLuongHoaDon_Click(object sender, EventArgs e)
        {
            containerTongQuan(new HienThiThongKe());
        }

        private void btn_ThongKeSoLuongPhieuNhap_Click(object sender, EventArgs e)
        {
            containerTongQuan(new HienThiThongKe());
        }

        private void btn_ThongKeSanPhamConHang_Click(object sender, EventArgs e)
        {
            containerTongQuan(new HienThiThongKe());
        }

        private void btn_ThongKeSanPhamBanChay_Click(object sender, EventArgs e)
        {
            containerTongQuan(new HienThiThongKe());
        }
        private void btn_ThongKeTienMat_Click(object sender, EventArgs e)
        {
            containerPhuongThucThanhToan(new HienThiThongKe());
        }

        private void btn_ThongKeChuyenKhoan_Click(object sender, EventArgs e)
        {
            containerPhuongThucThanhToan(new HienThiThongKe());
        }
        private void containerTongQuan(object _form)
        {
            if(tabPageThongKeTongQuan.Controls.Count > 0) 
                 tabPageThongKeTongQuan.Controls.Clear();
            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPageThongKeTongQuan.Controls.Add(form);
            tabPageThongKeTongQuan.Tag = form;
            form.Show();
        }
        private void containerPhuongThucThanhToan(object _form)
        {
            if (tabPagePhuongThucThanhToan.Controls.Count > 0)
                tabPagePhuongThucThanhToan.Controls.Clear();
            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPagePhuongThucThanhToan.Controls.Add(form);
            tabPagePhuongThucThanhToan.Tag = form;
            form.Show();
        }

        
    }
}
