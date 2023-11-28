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
    public partial class Form_CaiDat : Form
    {
        BUS_DangNhap bUS_DangNhap = new BUS_DangNhap();
        public Form_CaiDat()
        {
            InitializeComponent();
            txtUser.Text = Form_DangNhap.username;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_success = bUS_DangNhap.ChangePassword(txtUser.Text, txtOldPassword.Text, txtNewPassword.Text);
                txtUser.ResetText();
                txtOldPassword.ResetText();
                txtNewPassword.ResetText();
                if (is_success)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
