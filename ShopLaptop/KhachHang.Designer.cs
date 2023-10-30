namespace ShopLaptop
{
    partial class KhachHang
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
            this.lbl_HeaderTab1KH = new Guna.UI.WinForms.GunaLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Information = new System.Windows.Forms.TabPage();
            this.lbl_TimKiem_HD = new System.Windows.Forms.Label();
            this.btn_TimKiem_KhachHang = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.txt_TimKiem_KhachHang = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Show_KhachHnag = new Guna.UI.WinForms.GunaButton();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienDaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Options = new System.Windows.Forms.TabPage();
            this.txt_SDT = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SoCCCD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_LoaiKH = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_HoTenKH = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaKH = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaKH = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsKH = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_KhacHang = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_KhacHang = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_KhacHang = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tab_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.tab_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_HeaderTab1KH
            // 
            this.lbl_HeaderTab1KH.AutoSize = true;
            this.lbl_HeaderTab1KH.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1KH.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1KH.Location = new System.Drawing.Point(500, 4);
            this.lbl_HeaderTab1KH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1KH.Name = "lbl_HeaderTab1KH";
            this.lbl_HeaderTab1KH.Size = new System.Drawing.Size(262, 32);
            this.lbl_HeaderTab1KH.TabIndex = 0;
            this.lbl_HeaderTab1KH.Text = "Thông tin khách hàng";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tab_Information);
            this.tabControl1.Controls.Add(this.tab_Options);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 883);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Information
            // 
            this.tab_Information.Controls.Add(this.lbl_TimKiem_HD);
            this.tab_Information.Controls.Add(this.btn_TimKiem_KhachHang);
            this.tab_Information.Controls.Add(this.txt_TimKiem_KhachHang);
            this.tab_Information.Controls.Add(this.btn_Show_KhachHnag);
            this.tab_Information.Controls.Add(this.dgv_KhachHang);
            this.tab_Information.Controls.Add(this.lbl_HeaderTab1KH);
            this.tab_Information.Location = new System.Drawing.Point(4, 4);
            this.tab_Information.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Information.Name = "tab_Information";
            this.tab_Information.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Information.Size = new System.Drawing.Size(1264, 854);
            this.tab_Information.TabIndex = 0;
            this.tab_Information.Text = "Information";
            this.tab_Information.UseVisualStyleBackColor = true;
            // 
            // lbl_TimKiem_HD
            // 
            this.lbl_TimKiem_HD.AutoSize = true;
            this.lbl_TimKiem_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_HD.Location = new System.Drawing.Point(910, 65);
            this.lbl_TimKiem_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_HD.Name = "lbl_TimKiem_HD";
            this.lbl_TimKiem_HD.Size = new System.Drawing.Size(171, 18);
            this.lbl_TimKiem_HD.TabIndex = 26;
            this.lbl_TimKiem_HD.Text = "Nhập mã khách hàng:";
            // 
            // btn_TimKiem_KhachHang
            // 
            this.btn_TimKiem_KhachHang.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_KhachHang.AnimationSpeed = 0.03F;
            this.btn_TimKiem_KhachHang.BaseColor1 = System.Drawing.Color.Yellow;
            this.btn_TimKiem_KhachHang.BaseColor2 = System.Drawing.Color.Cyan;
            this.btn_TimKiem_KhachHang.BorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_KhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_KhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_KhachHang.Image = null;
            this.btn_TimKiem_KhachHang.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_KhachHang.Location = new System.Drawing.Point(1169, 79);
            this.btn_TimKiem_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_KhachHang.Name = "btn_TimKiem_KhachHang";
            this.btn_TimKiem_KhachHang.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_KhachHang.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_KhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_KhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_KhachHang.OnHoverImage = null;
            this.btn_TimKiem_KhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_KhachHang.Size = new System.Drawing.Size(87, 50);
            this.btn_TimKiem_KhachHang.TabIndex = 25;
            this.btn_TimKiem_KhachHang.Text = "Tìm";
            // 
            // txt_TimKiem_KhachHang
            // 
            this.txt_TimKiem_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem_KhachHang.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_KhachHang.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem_KhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem_KhachHang.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_KhachHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem_KhachHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem_KhachHang.Location = new System.Drawing.Point(894, 87);
            this.txt_TimKiem_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem_KhachHang.Name = "txt_TimKiem_KhachHang";
            this.txt_TimKiem_KhachHang.PasswordChar = '\0';
            this.txt_TimKiem_KhachHang.Radius = 10;
            this.txt_TimKiem_KhachHang.SelectedText = "";
            this.txt_TimKiem_KhachHang.Size = new System.Drawing.Size(213, 42);
            this.txt_TimKiem_KhachHang.TabIndex = 24;
            // 
            // btn_Show_KhachHnag
            // 
            this.btn_Show_KhachHnag.AnimationHoverSpeed = 0.07F;
            this.btn_Show_KhachHnag.AnimationSpeed = 0.03F;
            this.btn_Show_KhachHnag.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_KhachHnag.BaseColor = System.Drawing.Color.Gold;
            this.btn_Show_KhachHnag.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_KhachHnag.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_KhachHnag.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_KhachHnag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_KhachHnag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Show_KhachHnag.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_KhachHnag.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_KhachHnag.Location = new System.Drawing.Point(8, 77);
            this.btn_Show_KhachHnag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_KhachHnag.Name = "btn_Show_KhachHnag";
            this.btn_Show_KhachHnag.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_KhachHnag.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_KhachHnag.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_KhachHnag.OnHoverImage = null;
            this.btn_Show_KhachHnag.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_KhachHnag.Radius = 20;
            this.btn_Show_KhachHnag.Size = new System.Drawing.Size(239, 52);
            this.btn_Show_KhachHnag.TabIndex = 23;
            this.btn_Show_KhachHnag.Text = "Hiển thị thông tin";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.LoaiKH,
            this.HoTenKH,
            this.SoCCCD,
            this.SDT,
            this.TongSoTienDaGD});
            this.dgv_KhachHang.Location = new System.Drawing.Point(8, 158);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1248, 688);
            this.dgv_KhachHang.TabIndex = 8;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // LoaiKH
            // 
            this.LoaiKH.DataPropertyName = "LoaiKH";
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.MinimumWidth = 6;
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.Width = 125;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Họ tên khách hàng";
            this.HoTenKH.MinimumWidth = 6;
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.Width = 125;
            // 
            // SoCCCD
            // 
            this.SoCCCD.DataPropertyName = "SoCCCD";
            this.SoCCCD.HeaderText = "Số CCCD";
            this.SoCCCD.MinimumWidth = 6;
            this.SoCCCD.Name = "SoCCCD";
            this.SoCCCD.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // TongSoTienDaGD
            // 
            this.TongSoTienDaGD.DataPropertyName = "TongSoTienDaGD";
            this.TongSoTienDaGD.HeaderText = "Tổng tiền giao dịch";
            this.TongSoTienDaGD.MinimumWidth = 6;
            this.TongSoTienDaGD.Name = "TongSoTienDaGD";
            this.TongSoTienDaGD.Width = 125;
            // 
            // tab_Options
            // 
            this.tab_Options.Controls.Add(this.txt_SDT);
            this.tab_Options.Controls.Add(this.txt_SoCCCD);
            this.tab_Options.Controls.Add(this.txt_LoaiKH);
            this.tab_Options.Controls.Add(this.txt_HoTenKH);
            this.tab_Options.Controls.Add(this.txt_MaKH);
            this.tab_Options.Controls.Add(this.gunaLabel5);
            this.tab_Options.Controls.Add(this.gunaLabel4);
            this.tab_Options.Controls.Add(this.gunaLabel3);
            this.tab_Options.Controls.Add(this.gunaLabel2);
            this.tab_Options.Controls.Add(this.lbl_MaKH);
            this.tab_Options.Controls.Add(this.lbl_OptionsKH);
            this.tab_Options.Controls.Add(this.btn_Xoa_KhacHang);
            this.tab_Options.Controls.Add(this.btn_Sua_KhacHang);
            this.tab_Options.Controls.Add(this.btn_Them_KhacHang);
            this.tab_Options.Location = new System.Drawing.Point(4, 4);
            this.tab_Options.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Options.Name = "tab_Options";
            this.tab_Options.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Options.Size = new System.Drawing.Size(1264, 854);
            this.tab_Options.TabIndex = 1;
            this.tab_Options.Text = "Options";
            this.tab_Options.UseVisualStyleBackColor = true;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.White;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SDT.Location = new System.Drawing.Point(486, 495);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(213, 37);
            this.txt_SDT.TabIndex = 3;
            // 
            // txt_SoCCCD
            // 
            this.txt_SoCCCD.BackColor = System.Drawing.Color.White;
            this.txt_SoCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoCCCD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoCCCD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoCCCD.Location = new System.Drawing.Point(486, 440);
            this.txt_SoCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoCCCD.Name = "txt_SoCCCD";
            this.txt_SoCCCD.PasswordChar = '\0';
            this.txt_SoCCCD.SelectedText = "";
            this.txt_SoCCCD.Size = new System.Drawing.Size(213, 37);
            this.txt_SoCCCD.TabIndex = 3;
            // 
            // txt_LoaiKH
            // 
            this.txt_LoaiKH.BackColor = System.Drawing.Color.White;
            this.txt_LoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoaiKH.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_LoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LoaiKH.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_LoaiKH.Location = new System.Drawing.Point(486, 318);
            this.txt_LoaiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiKH.Name = "txt_LoaiKH";
            this.txt_LoaiKH.PasswordChar = '\0';
            this.txt_LoaiKH.SelectedText = "";
            this.txt_LoaiKH.Size = new System.Drawing.Size(213, 37);
            this.txt_LoaiKH.TabIndex = 3;
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.BackColor = System.Drawing.Color.White;
            this.txt_HoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTenKH.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_HoTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTenKH.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_HoTenKH.Location = new System.Drawing.Point(486, 373);
            this.txt_HoTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.PasswordChar = '\0';
            this.txt_HoTenKH.SelectedText = "";
            this.txt_HoTenKH.Size = new System.Drawing.Size(213, 37);
            this.txt_HoTenKH.TabIndex = 3;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.Color.White;
            this.txt_MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaKH.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaKH.Location = new System.Drawing.Point(486, 260);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.PasswordChar = '\0';
            this.txt_MaKH.SelectedText = "";
            this.txt_MaKH.Size = new System.Drawing.Size(213, 37);
            this.txt_MaKH.TabIndex = 3;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(186, 501);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(130, 28);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "Số điện thoại:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(186, 440);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Số CCCD:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(186, 373);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(182, 28);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Họ tên khách hàng:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(186, 318);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(160, 28);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Loại khách hàng:";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH.Location = new System.Drawing.Point(186, 266);
            this.lbl_MaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(151, 28);
            this.lbl_MaKH.TabIndex = 2;
            this.lbl_MaKH.Text = "Mã khách hàng:";
            // 
            // lbl_OptionsKH
            // 
            this.lbl_OptionsKH.AutoSize = true;
            this.lbl_OptionsKH.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsKH.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsKH.Location = new System.Drawing.Point(412, 4);
            this.lbl_OptionsKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsKH.Name = "lbl_OptionsKH";
            this.lbl_OptionsKH.Size = new System.Drawing.Size(373, 32);
            this.lbl_OptionsKH.TabIndex = 1;
            this.lbl_OptionsKH.Text = "Tùy chỉnh thông tin khách hàng";
            // 
            // btn_Xoa_KhacHang
            // 
            this.btn_Xoa_KhacHang.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_KhacHang.AnimationSpeed = 0.03F;
            this.btn_Xoa_KhacHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa_KhacHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Xoa_KhacHang.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_KhacHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_KhacHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_KhacHang.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Xoa_KhacHang.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_Xoa_KhacHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_KhacHang.Location = new System.Drawing.Point(874, 495);
            this.btn_Xoa_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_KhacHang.Name = "btn_Xoa_KhacHang";
            this.btn_Xoa_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_KhacHang.OnHoverImage = null;
            this.btn_Xoa_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.Radius = 20;
            this.btn_Xoa_KhacHang.Size = new System.Drawing.Size(144, 52);
            this.btn_Xoa_KhacHang.TabIndex = 0;
            this.btn_Xoa_KhacHang.Text = "Xóa";
            // 
            // btn_Sua_KhacHang
            // 
            this.btn_Sua_KhacHang.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_KhacHang.AnimationSpeed = 0.03F;
            this.btn_Sua_KhacHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_KhacHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Sua_KhacHang.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_KhacHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_KhacHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_KhacHang.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Sua_KhacHang.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_Sua_KhacHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_KhacHang.Location = new System.Drawing.Point(874, 373);
            this.btn_Sua_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_KhacHang.Name = "btn_Sua_KhacHang";
            this.btn_Sua_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_KhacHang.OnHoverImage = null;
            this.btn_Sua_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.Radius = 20;
            this.btn_Sua_KhacHang.Size = new System.Drawing.Size(144, 52);
            this.btn_Sua_KhacHang.TabIndex = 0;
            this.btn_Sua_KhacHang.Text = "Sửa";
            // 
            // btn_Them_KhacHang
            // 
            this.btn_Them_KhacHang.AnimationHoverSpeed = 0.07F;
            this.btn_Them_KhacHang.AnimationSpeed = 0.03F;
            this.btn_Them_KhacHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_KhacHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Them_KhacHang.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_KhacHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_KhacHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_KhacHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_KhacHang.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Them_KhacHang.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_KhacHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_KhacHang.Location = new System.Drawing.Point(874, 260);
            this.btn_Them_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_KhacHang.Name = "btn_Them_KhacHang";
            this.btn_Them_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_KhacHang.OnHoverImage = null;
            this.btn_Them_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_KhacHang.Radius = 20;
            this.btn_Them_KhacHang.Size = new System.Drawing.Size(144, 52);
            this.btn_Them_KhacHang.TabIndex = 0;
            this.btn_Them_KhacHang.Text = "Thêm";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 899);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.tabControl1.ResumeLayout(false);
            this.tab_Information.ResumeLayout(false);
            this.tab_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.tab_Options.ResumeLayout(false);
            this.tab_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1KH;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Information;
        private System.Windows.Forms.TabPage tab_Options;
        private Guna.UI.WinForms.GunaButton btn_Them_KhacHang;
        private Guna.UI.WinForms.GunaButton btn_Sua_KhacHang;
        private Guna.UI.WinForms.GunaButton btn_Xoa_KhacHang;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsKH;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaKH;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lbl_MaKH;
        private Guna.UI.WinForms.GunaLineTextBox txt_SDT;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoCCCD;
        private Guna.UI.WinForms.GunaLineTextBox txt_LoaiKH;
        private Guna.UI.WinForms.GunaLineTextBox txt_HoTenKH;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTienDaGD;
        private System.Windows.Forms.Label lbl_TimKiem_HD;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_KhachHang;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem_KhachHang;
        private Guna.UI.WinForms.GunaButton btn_Show_KhachHnag;
    }
}