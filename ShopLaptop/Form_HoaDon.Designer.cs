namespace ShopLaptop
{
    partial class Form_HoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tab_Options = new System.Windows.Forms.TabPage();
            this.btn_XuatHD = new Guna.UI.WinForms.GunaButton();
            this.txt_TrangThaiThanhToan_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_PhuongThucThanhToan_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SoTienThanhToan_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaKH_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNV_HD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaHD = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TrangThaiThanhToan_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PhuongThucThanhToan_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SoTienThanhToan_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaKH_HD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaHD = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsHD = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_HoaDon = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_HoaDon = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_HoaDon = new Guna.UI.WinForms.GunaButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Information = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Den = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date_Tu = new System.Windows.Forms.DateTimePicker();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThanhToanHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem_HoaDon = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btn_Show_HoaDon = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1HD = new Guna.UI.WinForms.GunaLabel();
            this.tab_Options.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
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
            this.tab_Options.Controls.Add(this.btn_XuatHD);
            this.tab_Options.Controls.Add(this.txt_TrangThaiThanhToan_HD);
            this.tab_Options.Controls.Add(this.txt_PhuongThucThanhToan_HD);
            this.tab_Options.Controls.Add(this.txt_SoTienThanhToan_HD);
            this.tab_Options.Controls.Add(this.txt_MaKH_HD);
            this.tab_Options.Controls.Add(this.txt_MaNV_HD);
            this.tab_Options.Controls.Add(this.txt_MaHD);
            this.tab_Options.Controls.Add(this.lbl_TrangThaiThanhToan_HD);
            this.tab_Options.Controls.Add(this.lbl_PhuongThucThanhToan_HD);
            this.tab_Options.Controls.Add(this.lbl_SoTienThanhToan_HD);
            this.tab_Options.Controls.Add(this.lbl_MaNV_HD);
            this.tab_Options.Controls.Add(this.lbl_MaKH_HD);
            this.tab_Options.Controls.Add(this.lbl_MaHD);
            this.tab_Options.Controls.Add(this.lbl_OptionsHD);
            this.tab_Options.Controls.Add(this.btn_Xoa_HoaDon);
            this.tab_Options.Controls.Add(this.btn_Sua_HoaDon);
            this.tab_Options.Controls.Add(this.btn_Them_HoaDon);
            this.tab_Options.Location = new System.Drawing.Point(4, 4);
            this.tab_Options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Options.Name = "tab_Options";
            this.tab_Options.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Options.Size = new System.Drawing.Size(1264, 851);
            this.tab_Options.TabIndex = 1;
            this.tab_Options.Text = "Options";
            this.tab_Options.UseVisualStyleBackColor = true;
            this.tab_Options.Click += new System.EventHandler(this.tab_Options_Click);
            // 
            // btn_XuatHD
            // 
            this.btn_XuatHD.AnimationHoverSpeed = 0.07F;
            this.btn_XuatHD.AnimationSpeed = 0.03F;
            this.btn_XuatHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_XuatHD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_XuatHD.BorderColor = System.Drawing.Color.Black;
            this.btn_XuatHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_XuatHD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_XuatHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatHD.ForeColor = System.Drawing.Color.White;
            this.btn_XuatHD.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_XuatHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_XuatHD.Location = new System.Drawing.Point(506, 667);
            this.btn_XuatHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_XuatHD.Name = "btn_XuatHD";
            this.btn_XuatHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_XuatHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_XuatHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_XuatHD.OnHoverImage = null;
            this.btn_XuatHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_XuatHD.Radius = 6;
            this.btn_XuatHD.Size = new System.Drawing.Size(240, 52);
            this.btn_XuatHD.TabIndex = 4;
            this.btn_XuatHD.Text = "Xuất";
            this.btn_XuatHD.Click += new System.EventHandler(this.btn_XuatHD_Click);
            // 
            // txt_TrangThaiThanhToan_HD
            // 
            this.txt_TrangThaiThanhToan_HD.BackColor = System.Drawing.Color.White;
            this.txt_TrangThaiThanhToan_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThaiThanhToan_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThaiThanhToan_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TrangThaiThanhToan_HD.Location = new System.Drawing.Point(601, 463);
            this.txt_TrangThaiThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TrangThaiThanhToan_HD.Name = "txt_TrangThaiThanhToan_HD";
            this.txt_TrangThaiThanhToan_HD.PasswordChar = '\0';
            this.txt_TrangThaiThanhToan_HD.SelectedText = "";
            this.txt_TrangThaiThanhToan_HD.Size = new System.Drawing.Size(401, 42);
            this.txt_TrangThaiThanhToan_HD.TabIndex = 3;
            // 
            // txt_PhuongThucThanhToan_HD
            // 
            this.txt_PhuongThucThanhToan_HD.BackColor = System.Drawing.Color.White;
            this.txt_PhuongThucThanhToan_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PhuongThucThanhToan_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PhuongThucThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PhuongThucThanhToan_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_PhuongThucThanhToan_HD.Location = new System.Drawing.Point(601, 413);
            this.txt_PhuongThucThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PhuongThucThanhToan_HD.Name = "txt_PhuongThucThanhToan_HD";
            this.txt_PhuongThucThanhToan_HD.PasswordChar = '\0';
            this.txt_PhuongThucThanhToan_HD.SelectedText = "";
            this.txt_PhuongThucThanhToan_HD.Size = new System.Drawing.Size(401, 42);
            this.txt_PhuongThucThanhToan_HD.TabIndex = 3;
            // 
            // txt_SoTienThanhToan_HD
            // 
            this.txt_SoTienThanhToan_HD.BackColor = System.Drawing.Color.White;
            this.txt_SoTienThanhToan_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoTienThanhToan_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoTienThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoTienThanhToan_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoTienThanhToan_HD.Location = new System.Drawing.Point(601, 363);
            this.txt_SoTienThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SoTienThanhToan_HD.Name = "txt_SoTienThanhToan_HD";
            this.txt_SoTienThanhToan_HD.PasswordChar = '\0';
            this.txt_SoTienThanhToan_HD.SelectedText = "";
            this.txt_SoTienThanhToan_HD.Size = new System.Drawing.Size(401, 42);
            this.txt_SoTienThanhToan_HD.TabIndex = 3;
            // 
            // txt_MaKH_HD
            // 
            this.txt_MaKH_HD.BackColor = System.Drawing.Color.White;
            this.txt_MaKH_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaKH_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaKH_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaKH_HD.Location = new System.Drawing.Point(601, 263);
            this.txt_MaKH_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaKH_HD.Name = "txt_MaKH_HD";
            this.txt_MaKH_HD.PasswordChar = '\0';
            this.txt_MaKH_HD.SelectedText = "";
            this.txt_MaKH_HD.Size = new System.Drawing.Size(401, 42);
            this.txt_MaKH_HD.TabIndex = 3;
            // 
            // txt_MaNV_HD
            // 
            this.txt_MaNV_HD.BackColor = System.Drawing.Color.White;
            this.txt_MaNV_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV_HD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNV_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNV_HD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNV_HD.Location = new System.Drawing.Point(601, 313);
            this.txt_MaNV_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaNV_HD.Name = "txt_MaNV_HD";
            this.txt_MaNV_HD.PasswordChar = '\0';
            this.txt_MaNV_HD.SelectedText = "";
            this.txt_MaNV_HD.Size = new System.Drawing.Size(401, 42);
            this.txt_MaNV_HD.TabIndex = 3;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BackColor = System.Drawing.Color.White;
            this.txt_MaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaHD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaHD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaHD.Location = new System.Drawing.Point(601, 213);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.PasswordChar = '\0';
            this.txt_MaHD.SelectedText = "";
            this.txt_MaHD.Size = new System.Drawing.Size(401, 42);
            this.txt_MaHD.TabIndex = 3;
            // 
            // lbl_TrangThaiThanhToan_HD
            // 
            this.lbl_TrangThaiThanhToan_HD.AutoSize = true;
            this.lbl_TrangThaiThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiThanhToan_HD.Location = new System.Drawing.Point(260, 477);
            this.lbl_TrangThaiThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiThanhToan_HD.Name = "lbl_TrangThaiThanhToan_HD";
            this.lbl_TrangThaiThanhToan_HD.Size = new System.Drawing.Size(207, 28);
            this.lbl_TrangThaiThanhToan_HD.TabIndex = 2;
            this.lbl_TrangThaiThanhToan_HD.Text = "Trạng thái thanh toán:";
            // 
            // lbl_PhuongThucThanhToan_HD
            // 
            this.lbl_PhuongThucThanhToan_HD.AutoSize = true;
            this.lbl_PhuongThucThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhuongThucThanhToan_HD.Location = new System.Drawing.Point(260, 427);
            this.lbl_PhuongThucThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhuongThucThanhToan_HD.Name = "lbl_PhuongThucThanhToan_HD";
            this.lbl_PhuongThucThanhToan_HD.Size = new System.Drawing.Size(229, 28);
            this.lbl_PhuongThucThanhToan_HD.TabIndex = 2;
            this.lbl_PhuongThucThanhToan_HD.Text = "Phương thức thanh toán:";
            // 
            // lbl_SoTienThanhToan_HD
            // 
            this.lbl_SoTienThanhToan_HD.AutoSize = true;
            this.lbl_SoTienThanhToan_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienThanhToan_HD.Location = new System.Drawing.Point(260, 377);
            this.lbl_SoTienThanhToan_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTienThanhToan_HD.Name = "lbl_SoTienThanhToan_HD";
            this.lbl_SoTienThanhToan_HD.Size = new System.Drawing.Size(254, 28);
            this.lbl_SoTienThanhToan_HD.TabIndex = 2;
            this.lbl_SoTienThanhToan_HD.Text = "Số tiền thanh toán hóa đơn:";
            // 
            // lbl_MaNV_HD
            // 
            this.lbl_MaNV_HD.AutoSize = true;
            this.lbl_MaNV_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV_HD.Location = new System.Drawing.Point(260, 327);
            this.lbl_MaNV_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV_HD.Name = "lbl_MaNV_HD";
            this.lbl_MaNV_HD.Size = new System.Drawing.Size(134, 28);
            this.lbl_MaNV_HD.TabIndex = 2;
            this.lbl_MaNV_HD.Text = "Mã nhân viên:";
            // 
            // lbl_MaKH_HD
            // 
            this.lbl_MaKH_HD.AutoSize = true;
            this.lbl_MaKH_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH_HD.Location = new System.Drawing.Point(260, 277);
            this.lbl_MaKH_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaKH_HD.Name = "lbl_MaKH_HD";
            this.lbl_MaKH_HD.Size = new System.Drawing.Size(151, 28);
            this.lbl_MaKH_HD.TabIndex = 2;
            this.lbl_MaKH_HD.Text = "Mã khách hàng:";
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(260, 227);
            this.lbl_MaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(121, 28);
            this.lbl_MaHD.TabIndex = 2;
            this.lbl_MaHD.Text = "Mã hóa đơn:";
            // 
            // lbl_OptionsHD
            // 
            this.lbl_OptionsHD.AutoSize = true;
            this.lbl_OptionsHD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsHD.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsHD.Location = new System.Drawing.Point(440, 63);
            this.lbl_OptionsHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsHD.Name = "lbl_OptionsHD";
            this.lbl_OptionsHD.Size = new System.Drawing.Size(337, 32);
            this.lbl_OptionsHD.TabIndex = 1;
            this.lbl_OptionsHD.Text = "Tùy chỉnh thông tin hóa đơn";
            // 
            // btn_Xoa_HoaDon
            // 
            this.btn_Xoa_HoaDon.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_HoaDon.AnimationSpeed = 0.03F;
            this.btn_Xoa_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa_HoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Xoa_HoaDon.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_HoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_HoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_HoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_HoaDon.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_Xoa_HoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_HoaDon.Location = new System.Drawing.Point(778, 590);
            this.btn_Xoa_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa_HoaDon.Name = "btn_Xoa_HoaDon";
            this.btn_Xoa_HoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_HoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_HoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_HoaDon.OnHoverImage = null;
            this.btn_Xoa_HoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_HoaDon.Radius = 6;
            this.btn_Xoa_HoaDon.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_HoaDon.TabIndex = 0;
            this.btn_Xoa_HoaDon.Text = "Xóa";
            this.btn_Xoa_HoaDon.Click += new System.EventHandler(this.btn_Xoa_HoaDon_Click);
            // 
            // btn_Sua_HoaDon
            // 
            this.btn_Sua_HoaDon.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_HoaDon.AnimationSpeed = 0.03F;
            this.btn_Sua_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_HoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Sua_HoaDon.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_HoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_HoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_HoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_HoaDon.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_Sua_HoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_HoaDon.Location = new System.Drawing.Point(506, 590);
            this.btn_Sua_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua_HoaDon.Name = "btn_Sua_HoaDon";
            this.btn_Sua_HoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_HoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_HoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_HoaDon.OnHoverImage = null;
            this.btn_Sua_HoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_HoaDon.Radius = 6;
            this.btn_Sua_HoaDon.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_HoaDon.TabIndex = 0;
            this.btn_Sua_HoaDon.Text = "Sửa";
            this.btn_Sua_HoaDon.Click += new System.EventHandler(this.btn_Sua_HoaDon_Click);
            // 
            // btn_Them_HoaDon
            // 
            this.btn_Them_HoaDon.AnimationHoverSpeed = 0.07F;
            this.btn_Them_HoaDon.AnimationSpeed = 0.03F;
            this.btn_Them_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_HoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_HoaDon.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_HoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_HoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_HoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_Them_HoaDon.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_HoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_HoaDon.Location = new System.Drawing.Point(236, 590);
            this.btn_Them_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them_HoaDon.Name = "btn_Them_HoaDon";
            this.btn_Them_HoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_HoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_HoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_HoaDon.OnHoverImage = null;
            this.btn_Them_HoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_HoaDon.Radius = 6;
            this.btn_Them_HoaDon.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_HoaDon.TabIndex = 0;
            this.btn_Them_HoaDon.Text = "Thêm";
            this.btn_Them_HoaDon.Click += new System.EventHandler(this.btn_Them_HoaDon_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tab_Information);
            this.tabControl1.Controls.Add(this.tab_Options);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_Information
            // 
            this.tab_Information.Controls.Add(this.label2);
            this.tab_Information.Controls.Add(this.date_Den);
            this.tab_Information.Controls.Add(this.label1);
            this.tab_Information.Controls.Add(this.date_Tu);
            this.tab_Information.Controls.Add(this.dgv_HoaDon);
            this.tab_Information.Controls.Add(this.btn_TimKiem_HoaDon);
            this.tab_Information.Controls.Add(this.btn_Show_HoaDon);
            this.tab_Information.Controls.Add(this.lbl_HeaderTab1HD);
            this.tab_Information.Location = new System.Drawing.Point(4, 4);
            this.tab_Information.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Information.Name = "tab_Information";
            this.tab_Information.Size = new System.Drawing.Size(1264, 827);
            this.tab_Information.TabIndex = 0;
            this.tab_Information.Text = "Information";
            this.tab_Information.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(802, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đến:";
            // 
            // date_Den
            // 
            this.date_Den.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Den.Location = new System.Drawing.Point(877, 100);
            this.date_Den.Name = "date_Den";
            this.date_Den.Size = new System.Drawing.Size(234, 27);
            this.date_Den.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Từ:";
            // 
            // date_Tu
            // 
            this.date_Tu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Tu.Location = new System.Drawing.Point(535, 101);
            this.date_Tu.Name = "date_Tu";
            this.date_Tu.Size = new System.Drawing.Size(234, 27);
            this.date_Tu.TabIndex = 15;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AllowUserToAddRows = false;
            this.dgv_HoaDon.AllowUserToDeleteRows = false;
            this.dgv_HoaDon.AllowUserToOrderColumns = true;
            this.dgv_HoaDon.AllowUserToResizeColumns = false;
            this.dgv_HoaDon.AllowUserToResizeRows = false;
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_HoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HoaDon.ColumnHeadersHeight = 80;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayMuaHang,
            this.SoTienThanhToanHoaDon,
            this.PhuongThucThanhToan,
            this.TrangThaiThanhToan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HoaDon.EnableHeadersVisualStyles = false;
            this.dgv_HoaDon.Location = new System.Drawing.Point(8, 158);
            this.dgv_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HoaDon.RowHeadersWidth = 62;
            this.dgv_HoaDon.ShowCellErrors = false;
            this.dgv_HoaDon.ShowCellToolTips = false;
            this.dgv_HoaDon.ShowEditingIcon = false;
            this.dgv_HoaDon.ShowRowErrors = false;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1245, 672);
            this.dgv_HoaDon.TabIndex = 8;
            this.dgv_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // NgayMuaHang
            // 
            this.NgayMuaHang.DataPropertyName = "NgayMuaHang";
            this.NgayMuaHang.HeaderText = "Ngày mua hàng";
            this.NgayMuaHang.MinimumWidth = 8;
            this.NgayMuaHang.Name = "NgayMuaHang";
            // 
            // SoTienThanhToanHoaDon
            // 
            this.SoTienThanhToanHoaDon.DataPropertyName = "SoTienThanhToanHoaDon";
            this.SoTienThanhToanHoaDon.HeaderText = "Số tiền thanh toán";
            this.SoTienThanhToanHoaDon.MinimumWidth = 8;
            this.SoTienThanhToanHoaDon.Name = "SoTienThanhToanHoaDon";
            // 
            // PhuongThucThanhToan
            // 
            this.PhuongThucThanhToan.DataPropertyName = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.HeaderText = "Phương thức thanh toán";
            this.PhuongThucThanhToan.MinimumWidth = 8;
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            // 
            // TrangThaiThanhToan
            // 
            this.TrangThaiThanhToan.DataPropertyName = "TrangThaiThanhToan";
            this.TrangThaiThanhToan.HeaderText = "Trạng thái thanh toán";
            this.TrangThaiThanhToan.MinimumWidth = 8;
            this.TrangThaiThanhToan.Name = "TrangThaiThanhToan";
            // 
            // btn_TimKiem_HoaDon
            // 
            this.btn_TimKiem_HoaDon.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_HoaDon.AnimationSpeed = 0.03F;
            this.btn_TimKiem_HoaDon.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_HoaDon.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_HoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_HoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_HoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_HoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_HoaDon.Image = null;
            this.btn_TimKiem_HoaDon.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_HoaDon.Location = new System.Drawing.Point(1148, 80);
            this.btn_TimKiem_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimKiem_HoaDon.Name = "btn_TimKiem_HoaDon";
            this.btn_TimKiem_HoaDon.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_HoaDon.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_HoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_HoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_HoaDon.OnHoverImage = null;
            this.btn_TimKiem_HoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_HoaDon.Size = new System.Drawing.Size(87, 50);
            this.btn_TimKiem_HoaDon.TabIndex = 7;
            this.btn_TimKiem_HoaDon.Text = "Tìm";
            this.btn_TimKiem_HoaDon.Click += new System.EventHandler(this.btn_TimKiem_HoaDon_Click);
            // 
            // btn_Show_HoaDon
            // 
            this.btn_Show_HoaDon.AnimationHoverSpeed = 0.07F;
            this.btn_Show_HoaDon.AnimationSpeed = 0.03F;
            this.btn_Show_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_HoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_HoaDon.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_HoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_HoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_HoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_Show_HoaDon.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_HoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_HoaDon.Location = new System.Drawing.Point(8, 78);
            this.btn_Show_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Show_HoaDon.Name = "btn_Show_HoaDon";
            this.btn_Show_HoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_HoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_HoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_HoaDon.OnHoverImage = null;
            this.btn_Show_HoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_HoaDon.Radius = 20;
            this.btn_Show_HoaDon.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_HoaDon.TabIndex = 2;
            this.btn_Show_HoaDon.Text = "Hiển thị thông tin";
            this.btn_Show_HoaDon.Click += new System.EventHandler(this.btn_Show_HoaDon_Click);
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
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 882);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_HoaDon";
            this.Text = "HoaDon";
            this.tab_Options.ResumeLayout(false);
            this.tab_Options.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Information.ResumeLayout(false);
            this.tab_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TabPage tab_Options;
        private Guna.UI.WinForms.GunaLineTextBox txt_TrangThaiThanhToan_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_PhuongThucThanhToan_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoTienThanhToan_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaKH_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNV_HD;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaHD;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiThanhToan_HD;
        private Guna.UI.WinForms.GunaLabel lbl_PhuongThucThanhToan_HD;
        private Guna.UI.WinForms.GunaLabel lbl_SoTienThanhToan_HD;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV_HD;
        private Guna.UI.WinForms.GunaLabel lbl_MaKH_HD;
        private Guna.UI.WinForms.GunaLabel lbl_MaHD;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsHD;
        private Guna.UI.WinForms.GunaButton btn_Xoa_HoaDon;
        private Guna.UI.WinForms.GunaButton btn_Sua_HoaDon;
        private Guna.UI.WinForms.GunaButton btn_Them_HoaDon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Information;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThanhToanHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiThanhToan;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_HoaDon;
        private Guna.UI.WinForms.GunaButton btn_Show_HoaDon;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1HD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Den;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_Tu;
        private Guna.UI.WinForms.GunaButton btn_XuatHD;
    }
}