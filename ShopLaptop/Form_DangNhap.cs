using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopLaptop.BUS;

namespace ShopLaptop
{
    public partial class Form_DangNhap : Form
    {
        BUS_DangNhap bUS_DangNhap = new BUS_DangNhap();
        public static string username;
        public static string password;
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUser.Text;
            password = txtPassword.Text;
            NhanVien nv = bUS_DangNhap.Login(txtUser.Text, txtPassword.Text);
            txtUser.Select();
            txtPassword.ResetText();
            if (nv != null)
            {
                ShopLaptop f = new ShopLaptop();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản hoặc mật khẩu", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exitWarn;
            exitWarn = MessageBox.Show("Bạn có muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exitWarn == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
