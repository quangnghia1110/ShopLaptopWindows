﻿namespace ShopLaptop
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tab_Options = new System.Windows.Forms.TabPage();
            this.btn_ThemTab2HD = new Guna.UI.WinForms.GunaButton();
            this.btn_SuaTab2HD = new Guna.UI.WinForms.GunaButton();
            this.btn_XoaTab2HD = new Guna.UI.WinForms.GunaButton();
            this.lbl_OptionsHD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaHD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaKH_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_NgayMuaHang_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SoTienThanhToan_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PhuongThucThanhToan_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_TrangThaiThanhToan_HD = new Guna.UI.WinForms.GunaLabel();
            this.txt_MaHD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNV_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaKH_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SoTienThanhToan_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_PhuongThucThanhToan_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_TrangThaiThanhToan_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.dtp_NgayMuaHang_HD = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lbl_HeaderTab1HD = new Guna.UI.WinForms.GunaLabel();
            this.btn_ShowHD = new Guna.UI.WinForms.GunaButton();
            this.txt_TimKiem_HD = new Guna.UI.WinForms.GunaTextBox();
            this.btn_TimKiem_HD = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.dgv_HD = new System.Windows.Forms.DataGridView();
            this.TrangThaiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThanhToanHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TimKiem_HD = new System.Windows.Forms.Label();
            this.tab_Information = new System.Windows.Forms.TabPage();
            this.tab_Options.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).BeginInit();
            this.tab_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(435, 30);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel1.TabIndex = 0;
            // 
            // tab_Options
            // 
            this.tab_Options.Controls.Add(this.dtp_NgayMuaHang_HD);
            this.tab_Options.Controls.Add(this.txt_TrangThaiThanhToan_HD);
            this.tab_Options.Controls.Add(this.txt_PhuongThucThanhToan_HD);
            this.tab_Options.Controls.Add(this.txt_SoTienThanhToan_HD);
            this.tab_Options.Controls.Add(this.txt_MaKH_HD);
            this.tab_Options.Controls.Add(this.txt_MaNV_HD);
            this.tab_Options.Controls.Add(this.txt_MaHD);
            this.tab_Options.Controls.Add(this.lbl_TrangThaiThanhToan_HD);
            this.tab_Options.Controls.Add(this.lbl_PhuongThucThanhToan_HD);
            this.tab_Options.Controls.Add(this.lbl_SoTienThanhToan_HD);
            this.tab_Options.Controls.Add(this.lbl_NgayMuaHang_HD);
            this.tab_Options.Controls.Add(this.lbl_MaNV_HD);
            this.tab_Options.Controls.Add(this.lbl_MaKH_HD);
            this.tab_Options.Controls.Add(this.lbl_MaHD);
            this.tab_Options.Controls.Add(this.lbl_OptionsHD);
            this.tab_Options.Controls.Add(this.btn_XoaTab2HD);
            this.tab_Options.Controls.Add(this.btn_SuaTab2HD);
            this.tab_Options.Controls.Add(this.btn_ThemTab2HD);
            this.tab_Options.Location = new System.Drawing.Point(4, 4);
            this.tab_Options.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Options.Name = "tab_Options";
            this.tab_Options.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Options.Size = new System.Drawing.Size(1264, 854);
            this.tab_Options.TabIndex = 1;
            this.tab_Options.Text = "Options";
            this.tab_Options.UseVisualStyleBackColor = true;
            this.tab_Options.Click += new System.EventHandler(this.tab_Options_Click);
            // 
            // btn_ThemTab2HD
            // 
            this.btn_ThemTab2HD.AnimationHoverSpeed = 0.07F;
            this.btn_ThemTab2HD.AnimationSpeed = 0.03F;
            this.btn_ThemTab2HD.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThemTab2HD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ThemTab2HD.BorderColor = System.Drawing.Color.Black;
            this.btn_ThemTab2HD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ThemTab2HD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ThemTab2HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTab2HD.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_ThemTab2HD.Image = global::ShopLaptop.Properties.Resources.icons8_bill_50;
            this.btn_ThemTab2HD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ThemTab2HD.Location = new System.Drawing.Point(881, 228);
            this.btn_ThemTab2HD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemTab2HD.Name = "btn_ThemTab2HD";
            this.btn_ThemTab2HD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ThemTab2HD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ThemTab2HD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ThemTab2HD.OnHoverImage = null;
            this.btn_ThemTab2HD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ThemTab2HD.Radius = 20;
            this.btn_ThemTab2HD.Size = new System.Drawing.Size(144, 52);
            this.btn_ThemTab2HD.TabIndex = 0;
            this.btn_ThemTab2HD.Text = "Thêm";
            // 
            // btn_SuaTab2HD
            // 
            this.btn_SuaTab2HD.AnimationHoverSpeed = 0.07F;
            this.btn_SuaTab2HD.AnimationSpeed = 0.03F;
            this.btn_SuaTab2HD.BackColor = System.Drawing.Color.Transparent;
            this.btn_SuaTab2HD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SuaTab2HD.BorderColor = System.Drawing.Color.Black;
            this.btn_SuaTab2HD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SuaTab2HD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SuaTab2HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTab2HD.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SuaTab2HD.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_SuaTab2HD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_SuaTab2HD.Location = new System.Drawing.Point(881, 354);
            this.btn_SuaTab2HD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaTab2HD.Name = "btn_SuaTab2HD";
            this.btn_SuaTab2HD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_SuaTab2HD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_SuaTab2HD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SuaTab2HD.OnHoverImage = null;
            this.btn_SuaTab2HD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SuaTab2HD.Radius = 20;
            this.btn_SuaTab2HD.Size = new System.Drawing.Size(144, 52);
            this.btn_SuaTab2HD.TabIndex = 0;
            this.btn_SuaTab2HD.Text = "Sửa";
            // 
            // btn_XoaTab2HD
            // 
            this.btn_XoaTab2HD.AnimationHoverSpeed = 0.07F;
            this.btn_XoaTab2HD.AnimationSpeed = 0.03F;
            this.btn_XoaTab2HD.BackColor = System.Drawing.Color.Transparent;
            this.btn_XoaTab2HD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XoaTab2HD.BorderColor = System.Drawing.Color.Black;
            this.btn_XoaTab2HD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_XoaTab2HD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_XoaTab2HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTab2HD.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_XoaTab2HD.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_XoaTab2HD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_XoaTab2HD.Location = new System.Drawing.Point(881, 484);
            this.btn_XoaTab2HD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaTab2HD.Name = "btn_XoaTab2HD";
            this.btn_XoaTab2HD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_XoaTab2HD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_XoaTab2HD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_XoaTab2HD.OnHoverImage = null;
            this.btn_XoaTab2HD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_XoaTab2HD.Radius = 20;
            this.btn_XoaTab2HD.Size = new System.Drawing.Size(144, 52);
            this.btn_XoaTab2HD.TabIndex = 0;
            this.btn_XoaTab2HD.Text = "Xóa";
            // 
            // lbl_OptionsHD
            // 
            this.lbl_OptionsHD.AutoSize = true;
            this.lbl_OptionsHD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsHD.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsHD.Location = new System.Drawing.Point(460, 4);
            this.lbl_OptionsHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsHD.Name = "lbl_OptionsHD";
            this.lbl_OptionsHD.Size = new System.Drawing.Size(337, 32);
            this.lbl_OptionsHD.TabIndex = 1;
            this.lbl_OptionsHD.Text = "Tùy chỉnh thông tin hóa đơn";
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(186, 194);
            this.lbl_MaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(121, 28);
            this.lbl_MaHD.TabIndex = 2;
            this.lbl_MaHD.Text = "Mã hóa đơn:";
            // 
            // lbl_MaKH_HD
            // 
            this.lbl_MaKH_HD.AutoSize = true;
            this.lbl_MaKH_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH_HD.Location = new System.Drawing.Point(186, 242);
            this.lbl_MaKH_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaKH_HD.Name = "lbl_MaKH_HD";
            this.lbl_MaKH_HD.Size = new System.Drawing.Size(151, 28);
            this.lbl_MaKH_HD.TabIndex = 2;
            this.lbl_MaKH_HD.Text = "Mã khách hàng:";
            // 
            // lbl_MaNV_HD
            // 
            this.lbl_MaNV_HD.AutoSize = true;
            this.lbl_MaNV_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV_HD.Location = new System.Drawing.Point(186, 292);
            this.lbl_MaNV_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV_HD.Name = "lbl_MaNV_HD";
            this.lbl_MaNV_HD.Size = new System.Drawing.Size(134, 28);
            this.lbl_MaNV_HD.TabIndex = 2;
            this.lbl_MaNV_HD.Text = "Mã nhân viên:";
            // 
            // lbl_NgayMuaHang_HD
            // 
            this.lbl_NgayMuaHang_HD.AutoSize = true;
            this.lbl_NgayMuaHang_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayMuaHang_HD.Location = new System.Drawing.Point(186, 342);
            this.lbl_NgayMuaHang_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayMuaHang_HD.Name = "lbl_NgayMuaHang_HD";
            this.lbl_NgayMuaHang_HD.Size = new System.Drawing.Size(158, 28);
            this.lbl_NgayMuaHang_HD.TabIndex = 2;
            this.lbl_NgayMuaHang_HD.Text = "Ngày mua hàng:";
            // 
            // lbl_SoTienThanhToan_HD
            // 
            this.lbl_SoTienThanhToan_HD.AutoSize = true;
            this.lbl_SoTienThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienThanhToan_HD.Location = new System.Drawing.Point(186, 392);
            this.lbl_SoTienThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTienThanhToan_HD.Name = "lbl_SoTienThanhToan_HD";
            this.lbl_SoTienThanhToan_HD.Size = new System.Drawing.Size(254, 28);
            this.lbl_SoTienThanhToan_HD.TabIndex = 2;
            this.lbl_SoTienThanhToan_HD.Text = "Số tiền thanh toán hóa đơn:";
            // 
            // lbl_PhuongThucThanhToan_HD
            // 
            this.lbl_PhuongThucThanhToan_HD.AutoSize = true;
            this.lbl_PhuongThucThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhuongThucThanhToan_HD.Location = new System.Drawing.Point(186, 442);
            this.lbl_PhuongThucThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhuongThucThanhToan_HD.Name = "lbl_PhuongThucThanhToan_HD";
            this.lbl_PhuongThucThanhToan_HD.Size = new System.Drawing.Size(229, 28);
            this.lbl_PhuongThucThanhToan_HD.TabIndex = 2;
            this.lbl_PhuongThucThanhToan_HD.Text = "Phương thức thanh toán:";
            // 
            // lbl_TrangThaiThanhToan_HD
            // 
            this.lbl_TrangThaiThanhToan_HD.AutoSize = true;
            this.lbl_TrangThaiThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiThanhToan_HD.Location = new System.Drawing.Point(186, 494);
            this.lbl_TrangThaiThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiThanhToan_HD.Name = "lbl_TrangThaiThanhToan_HD";
            this.lbl_TrangThaiThanhToan_HD.Size = new System.Drawing.Size(207, 28);
            this.lbl_TrangThaiThanhToan_HD.TabIndex = 2;
            this.lbl_TrangThaiThanhToan_HD.Text = "Trạng thái thanh toán:";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BackColor = System.Drawing.Color.White;
            this.txt_MaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaHD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaHD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaHD.Location = new System.Drawing.Point(506, 180);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.PasswordChar = '\0';
            this.txt_MaHD.SelectedText = "";
            this.txt_MaHD.Size = new System.Drawing.Size(213, 42);
            this.txt_MaHD.TabIndex = 3;
            // 
            // txt_MaNV_HD
            // 
            this.txt_MaNV_HD.BackColor = System.Drawing.Color.White;
            this.txt_MaNV_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNV_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNV_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNV_HD.Location = new System.Drawing.Point(503, 278);
            this.txt_MaNV_HD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNV_HD.Name = "txt_MaNV_HD";
            this.txt_MaNV_HD.PasswordChar = '\0';
            this.txt_MaNV_HD.SelectedText = "";
            this.txt_MaNV_HD.Size = new System.Drawing.Size(213, 42);
            this.txt_MaNV_HD.TabIndex = 3;
            // 
            // txt_MaKH_HD
            // 
            this.txt_MaKH_HD.BackColor = System.Drawing.Color.White;
            this.txt_MaKH_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaKH_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaKH_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaKH_HD.Location = new System.Drawing.Point(506, 228);
            this.txt_MaKH_HD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH_HD.Name = "txt_MaKH_HD";
            this.txt_MaKH_HD.PasswordChar = '\0';
            this.txt_MaKH_HD.SelectedText = "";
            this.txt_MaKH_HD.Size = new System.Drawing.Size(213, 42);
            this.txt_MaKH_HD.TabIndex = 3;
            // 
            // txt_SoTienThanhToan_HD
            // 
            this.txt_SoTienThanhToan_HD.BackColor = System.Drawing.Color.White;
            this.txt_SoTienThanhToan_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoTienThanhToan_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoTienThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoTienThanhToan_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoTienThanhToan_HD.Location = new System.Drawing.Point(506, 378);
            this.txt_SoTienThanhToan_HD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoTienThanhToan_HD.Name = "txt_SoTienThanhToan_HD";
            this.txt_SoTienThanhToan_HD.PasswordChar = '\0';
            this.txt_SoTienThanhToan_HD.SelectedText = "";
            this.txt_SoTienThanhToan_HD.Size = new System.Drawing.Size(213, 42);
            this.txt_SoTienThanhToan_HD.TabIndex = 3;
            // 
            // txt_PhuongThucThanhToan_HD
            // 
            this.txt_PhuongThucThanhToan_HD.BackColor = System.Drawing.Color.White;
            this.txt_PhuongThucThanhToan_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PhuongThucThanhToan_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PhuongThucThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PhuongThucThanhToan_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_PhuongThucThanhToan_HD.Location = new System.Drawing.Point(506, 428);
            this.txt_PhuongThucThanhToan_HD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhuongThucThanhToan_HD.Name = "txt_PhuongThucThanhToan_HD";
            this.txt_PhuongThucThanhToan_HD.PasswordChar = '\0';
            this.txt_PhuongThucThanhToan_HD.SelectedText = "";
            this.txt_PhuongThucThanhToan_HD.Size = new System.Drawing.Size(213, 42);
            this.txt_PhuongThucThanhToan_HD.TabIndex = 3;
            // 
            // txt_TrangThaiThanhToan_HD
            // 
            this.txt_TrangThaiThanhToan_HD.BackColor = System.Drawing.Color.White;
            this.txt_TrangThaiThanhToan_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThaiThanhToan_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThaiThanhToan_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TrangThaiThanhToan_HD.Location = new System.Drawing.Point(506, 480);
            this.txt_TrangThaiThanhToan_HD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrangThaiThanhToan_HD.Name = "txt_TrangThaiThanhToan_HD";
            this.txt_TrangThaiThanhToan_HD.PasswordChar = '\0';
            this.txt_TrangThaiThanhToan_HD.SelectedText = "";
            this.txt_TrangThaiThanhToan_HD.Size = new System.Drawing.Size(213, 42);
            this.txt_TrangThaiThanhToan_HD.TabIndex = 3;
            // 
            // dtp_NgayMuaHang_HD
            // 
            this.dtp_NgayMuaHang_HD.BaseColor = System.Drawing.Color.White;
            this.dtp_NgayMuaHang_HD.BorderColor = System.Drawing.Color.Silver;
            this.dtp_NgayMuaHang_HD.CustomFormat = null;
            this.dtp_NgayMuaHang_HD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_NgayMuaHang_HD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuaHang_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayMuaHang_HD.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayMuaHang_HD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuaHang_HD.Location = new System.Drawing.Point(503, 330);
            this.dtp_NgayMuaHang_HD.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayMuaHang_HD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayMuaHang_HD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayMuaHang_HD.Name = "dtp_NgayMuaHang_HD";
            this.dtp_NgayMuaHang_HD.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgayMuaHang_HD.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuaHang_HD.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgayMuaHang_HD.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgayMuaHang_HD.Size = new System.Drawing.Size(216, 40);
            this.dtp_NgayMuaHang_HD.TabIndex = 5;
            this.dtp_NgayMuaHang_HD.Text = "2023-10-25";
            this.dtp_NgayMuaHang_HD.Value = new System.DateTime(2023, 10, 25, 16, 31, 54, 988);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tab_Information);
            this.tabControl1.Controls.Add(this.tab_Options);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 883);
            this.tabControl1.TabIndex = 2;
            // 
            // lbl_HeaderTab1HD
            // 
            this.lbl_HeaderTab1HD.AutoSize = true;
            this.lbl_HeaderTab1HD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1HD.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1HD.Location = new System.Drawing.Point(468, 4);
            this.lbl_HeaderTab1HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1HD.Name = "lbl_HeaderTab1HD";
            this.lbl_HeaderTab1HD.Size = new System.Drawing.Size(226, 32);
            this.lbl_HeaderTab1HD.TabIndex = 0;
            this.lbl_HeaderTab1HD.Text = "Thông tin hóa đơn";
            // 
            // btn_ShowHD
            // 
            this.btn_ShowHD.AnimationHoverSpeed = 0.07F;
            this.btn_ShowHD.AnimationSpeed = 0.03F;
            this.btn_ShowHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowHD.BaseColor = System.Drawing.Color.Gold;
            this.btn_ShowHD.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_ShowHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ShowHD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ShowHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ShowHD.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_ShowHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ShowHD.Location = new System.Drawing.Point(8, 77);
            this.btn_ShowHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowHD.Name = "btn_ShowHD";
            this.btn_ShowHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ShowHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ShowHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ShowHD.OnHoverImage = null;
            this.btn_ShowHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ShowHD.Radius = 20;
            this.btn_ShowHD.Size = new System.Drawing.Size(240, 52);
            this.btn_ShowHD.TabIndex = 2;
            this.btn_ShowHD.Text = "Hiển thị thông tin";
            // 
            // txt_TimKiem_HD
            // 
            this.txt_TimKiem_HD.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem_HD.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_HD.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem_HD.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_HD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem_HD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem_HD.Location = new System.Drawing.Point(894, 86);
            this.txt_TimKiem_HD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem_HD.Name = "txt_TimKiem_HD";
            this.txt_TimKiem_HD.PasswordChar = '\0';
            this.txt_TimKiem_HD.Radius = 10;
            this.txt_TimKiem_HD.SelectedText = "";
            this.txt_TimKiem_HD.Size = new System.Drawing.Size(213, 42);
            this.txt_TimKiem_HD.TabIndex = 4;
            // 
            // btn_TimKiem_HD
            // 
            this.btn_TimKiem_HD.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_HD.AnimationSpeed = 0.03F;
            this.btn_TimKiem_HD.BaseColor1 = System.Drawing.Color.Yellow;
            this.btn_TimKiem_HD.BaseColor2 = System.Drawing.Color.Cyan;
            this.btn_TimKiem_HD.BorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_HD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_HD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_HD.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_HD.Image = null;
            this.btn_TimKiem_HD.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_HD.Location = new System.Drawing.Point(1173, 79);
            this.btn_TimKiem_HD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_HD.Name = "btn_TimKiem_HD";
            this.btn_TimKiem_HD.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_HD.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_HD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_HD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_HD.OnHoverImage = null;
            this.btn_TimKiem_HD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_HD.Size = new System.Drawing.Size(87, 50);
            this.btn_TimKiem_HD.TabIndex = 7;
            this.btn_TimKiem_HD.Text = "Tìm";
            // 
            // dgv_HD
            // 
            this.dgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayMuaHang,
            this.SoTienThanhToanHoaDon,
            this.PhuongThucThanhToan,
            this.TrangThaiThanhToan});
            this.dgv_HD.Location = new System.Drawing.Point(8, 158);
            this.dgv_HD.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_HD.Name = "dgv_HD";
            this.dgv_HD.RowHeadersWidth = 62;
            this.dgv_HD.Size = new System.Drawing.Size(1252, 692);
            this.dgv_HD.TabIndex = 8;
            // 
            // TrangThaiThanhToan
            // 
            this.TrangThaiThanhToan.DataPropertyName = "TrangThaiThanhToan";
            this.TrangThaiThanhToan.HeaderText = "Trạng thái thanh toán";
            this.TrangThaiThanhToan.MinimumWidth = 8;
            this.TrangThaiThanhToan.Name = "TrangThaiThanhToan";
            this.TrangThaiThanhToan.Width = 150;
            // 
            // PhuongThucThanhToan
            // 
            this.PhuongThucThanhToan.DataPropertyName = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.HeaderText = "Phương thức thanh toán";
            this.PhuongThucThanhToan.MinimumWidth = 8;
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.Width = 150;
            // 
            // SoTienThanhToanHoaDon
            // 
            this.SoTienThanhToanHoaDon.DataPropertyName = "SoTienThanhToanHoaDon";
            this.SoTienThanhToanHoaDon.HeaderText = "Số tiền thanh toán";
            this.SoTienThanhToanHoaDon.MinimumWidth = 8;
            this.SoTienThanhToanHoaDon.Name = "SoTienThanhToanHoaDon";
            this.SoTienThanhToanHoaDon.Width = 150;
            // 
            // NgayMuaHang
            // 
            this.NgayMuaHang.DataPropertyName = "NgayMuaHang";
            this.NgayMuaHang.HeaderText = "Ngày mua hàng";
            this.NgayMuaHang.MinimumWidth = 8;
            this.NgayMuaHang.Name = "NgayMuaHang";
            this.NgayMuaHang.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 150;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 150;
            // 
            // lbl_TimKiem_HD
            // 
            this.lbl_TimKiem_HD.AutoSize = true;
            this.lbl_TimKiem_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_HD.Location = new System.Drawing.Point(891, 64);
            this.lbl_TimKiem_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_HD.Name = "lbl_TimKiem_HD";
            this.lbl_TimKiem_HD.Size = new System.Drawing.Size(146, 18);
            this.lbl_TimKiem_HD.TabIndex = 10;
            this.lbl_TimKiem_HD.Text = "Nhập mã hóa đơn:";
            // 
            // tab_Information
            // 
            this.tab_Information.Controls.Add(this.lbl_TimKiem_HD);
            this.tab_Information.Controls.Add(this.dgv_HD);
            this.tab_Information.Controls.Add(this.btn_TimKiem_HD);
            this.tab_Information.Controls.Add(this.txt_TimKiem_HD);
            this.tab_Information.Controls.Add(this.btn_ShowHD);
            this.tab_Information.Controls.Add(this.lbl_HeaderTab1HD);
            this.tab_Information.Location = new System.Drawing.Point(4, 4);
            this.tab_Information.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Information.Name = "tab_Information";
            this.tab_Information.Size = new System.Drawing.Size(1264, 854);
            this.tab_Information.TabIndex = 0;
            this.tab_Information.Text = "Information";
            this.tab_Information.UseVisualStyleBackColor = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 940);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.tab_Options.ResumeLayout(false);
            this.tab_Options.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).EndInit();
            this.tab_Information.ResumeLayout(false);
            this.tab_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TabPage tab_Options;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_NgayMuaHang_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_TrangThaiThanhToan_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_PhuongThucThanhToan_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoTienThanhToan_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaKH_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNV_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaHD;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiThanhToan_HD;
        private Guna.UI.WinForms.GunaLabel lbl_PhuongThucThanhToan_HD;
        private Guna.UI.WinForms.GunaLabel lbl_SoTienThanhToan_HD;
        private Guna.UI.WinForms.GunaLabel lbl_NgayMuaHang_HD;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV_HD;
        private Guna.UI.WinForms.GunaLabel lbl_MaKH_HD;
        private Guna.UI.WinForms.GunaLabel lbl_MaHD;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsHD;
        private Guna.UI.WinForms.GunaButton btn_XoaTab2HD;
        private Guna.UI.WinForms.GunaButton btn_SuaTab2HD;
        private Guna.UI.WinForms.GunaButton btn_ThemTab2HD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Information;
        private System.Windows.Forms.Label lbl_TimKiem_HD;
        private System.Windows.Forms.DataGridView dgv_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThanhToanHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiThanhToan;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_HD;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem_HD;
        private Guna.UI.WinForms.GunaButton btn_ShowHD;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1HD;
    }
}