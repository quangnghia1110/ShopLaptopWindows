namespace ShopLaptop
{
    partial class Form_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_HeaderTab1KH = new Guna.UI.WinForms.GunaLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Information = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiemKH_CCCD = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimKiemKH_HoTenKH = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_TimKiem_HD = new System.Windows.Forms.Label();
            this.btn_TimKiem_KhachHang = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.txt_TimKiemKH_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Show_KhachHang = new Guna.UI.WinForms.GunaButton();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienDaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Options = new System.Windows.Forms.TabPage();
            this.txt_TongSoTienDaGiaoDich = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Information
            // 
            this.tab_Information.Controls.Add(this.label2);
            this.tab_Information.Controls.Add(this.txt_TimKiemKH_CCCD);
            this.tab_Information.Controls.Add(this.label1);
            this.tab_Information.Controls.Add(this.txt_TimKiemKH_HoTenKH);
            this.tab_Information.Controls.Add(this.lbl_TimKiem_HD);
            this.tab_Information.Controls.Add(this.btn_TimKiem_KhachHang);
            this.tab_Information.Controls.Add(this.txt_TimKiemKH_SDT);
            this.tab_Information.Controls.Add(this.btn_Show_KhachHang);
            this.tab_Information.Controls.Add(this.dgv_KhachHang);
            this.tab_Information.Controls.Add(this.lbl_HeaderTab1KH);
            this.tab_Information.Location = new System.Drawing.Point(4, 4);
            this.tab_Information.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Information.Name = "tab_Information";
            this.tab_Information.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Information.Size = new System.Drawing.Size(1264, 827);
            this.tab_Information.TabIndex = 0;
            this.tab_Information.Text = "Information";
            this.tab_Information.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(891, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nhập SĐT:";
            // 
            // txt_TimKiemKH_CCCD
            // 
            this.txt_TimKiemKH_CCCD.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemKH_CCCD.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemKH_CCCD.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemKH_CCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemKH_CCCD.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemKH_CCCD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_CCCD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemKH_CCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemKH_CCCD.Location = new System.Drawing.Point(631, 87);
            this.txt_TimKiemKH_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemKH_CCCD.Name = "txt_TimKiemKH_CCCD";
            this.txt_TimKiemKH_CCCD.PasswordChar = '\0';
            this.txt_TimKiemKH_CCCD.Radius = 10;
            this.txt_TimKiemKH_CCCD.SelectedText = "";
            this.txt_TimKiemKH_CCCD.Size = new System.Drawing.Size(255, 42);
            this.txt_TimKiemKH_CCCD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nhập họ tên KH:";
            // 
            // txt_TimKiemKH_HoTenKH
            // 
            this.txt_TimKiemKH_HoTenKH.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemKH_HoTenKH.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemKH_HoTenKH.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemKH_HoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemKH_HoTenKH.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemKH_HoTenKH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_HoTenKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemKH_HoTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemKH_HoTenKH.Location = new System.Drawing.Point(368, 88);
            this.txt_TimKiemKH_HoTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemKH_HoTenKH.Name = "txt_TimKiemKH_HoTenKH";
            this.txt_TimKiemKH_HoTenKH.PasswordChar = '\0';
            this.txt_TimKiemKH_HoTenKH.Radius = 10;
            this.txt_TimKiemKH_HoTenKH.SelectedText = "";
            this.txt_TimKiemKH_HoTenKH.Size = new System.Drawing.Size(255, 42);
            this.txt_TimKiemKH_HoTenKH.TabIndex = 27;
            // 
            // lbl_TimKiem_HD
            // 
            this.lbl_TimKiem_HD.AutoSize = true;
            this.lbl_TimKiem_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_HD.Location = new System.Drawing.Point(628, 66);
            this.lbl_TimKiem_HD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_HD.Name = "lbl_TimKiem_HD";
            this.lbl_TimKiem_HD.Size = new System.Drawing.Size(105, 18);
            this.lbl_TimKiem_HD.TabIndex = 26;
            this.lbl_TimKiem_HD.Text = "Nhập CCCD:";
            // 
            // btn_TimKiem_KhachHang
            // 
            this.btn_TimKiem_KhachHang.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_KhachHang.AnimationSpeed = 0.03F;
            this.btn_TimKiem_KhachHang.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_KhachHang.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_KhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
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
            this.btn_TimKiem_KhachHang.Click += new System.EventHandler(this.btn_TimKiem_KhachHang_Click);
            // 
            // txt_TimKiemKH_SDT
            // 
            this.txt_TimKiemKH_SDT.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemKH_SDT.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemKH_SDT.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemKH_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemKH_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemKH_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemKH_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemKH_SDT.Location = new System.Drawing.Point(894, 88);
            this.txt_TimKiemKH_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemKH_SDT.Name = "txt_TimKiemKH_SDT";
            this.txt_TimKiemKH_SDT.PasswordChar = '\0';
            this.txt_TimKiemKH_SDT.Radius = 10;
            this.txt_TimKiemKH_SDT.SelectedText = "";
            this.txt_TimKiemKH_SDT.Size = new System.Drawing.Size(255, 42);
            this.txt_TimKiemKH_SDT.TabIndex = 24;
            // 
            // btn_Show_KhachHang
            // 
            this.btn_Show_KhachHang.AnimationHoverSpeed = 0.07F;
            this.btn_Show_KhachHang.AnimationSpeed = 0.03F;
            this.btn_Show_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_KhachHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_KhachHang.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_KhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_KhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_Show_KhachHang.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_KhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_KhachHang.Location = new System.Drawing.Point(8, 78);
            this.btn_Show_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_KhachHang.Name = "btn_Show_KhachHang";
            this.btn_Show_KhachHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_KhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_KhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_KhachHang.OnHoverImage = null;
            this.btn_Show_KhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_KhachHang.Radius = 20;
            this.btn_Show_KhachHang.Size = new System.Drawing.Size(239, 52);
            this.btn_Show_KhachHang.TabIndex = 23;
            this.btn_Show_KhachHang.Text = "Hiển thị thông tin";
            this.btn_Show_KhachHang.Click += new System.EventHandler(this.btn_Show_KhachHang_Click);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.AllowUserToOrderColumns = true;
            this.dgv_KhachHang.AllowUserToResizeColumns = false;
            this.dgv_KhachHang.AllowUserToResizeRows = false;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_KhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_KhachHang.ColumnHeadersHeight = 80;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.LoaiKH,
            this.HoTenKH,
            this.SoCCCD,
            this.SDT,
            this.TongSoTienDaGD});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_KhachHang.EnableHeadersVisualStyles = false;
            this.dgv_KhachHang.Location = new System.Drawing.Point(8, 158);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_KhachHang.RowHeadersWidth = 62;
            this.dgv_KhachHang.ShowCellErrors = false;
            this.dgv_KhachHang.ShowCellToolTips = false;
            this.dgv_KhachHang.ShowEditingIcon = false;
            this.dgv_KhachHang.ShowRowErrors = false;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1248, 669);
            this.dgv_KhachHang.TabIndex = 8;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // LoaiKH
            // 
            this.LoaiKH.DataPropertyName = "LoaiKH";
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.MinimumWidth = 6;
            this.LoaiKH.Name = "LoaiKH";
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Họ tên khách hàng";
            this.HoTenKH.MinimumWidth = 6;
            this.HoTenKH.Name = "HoTenKH";
            // 
            // SoCCCD
            // 
            this.SoCCCD.DataPropertyName = "SoCCCD";
            this.SoCCCD.HeaderText = "Số CCCD";
            this.SoCCCD.MinimumWidth = 6;
            this.SoCCCD.Name = "SoCCCD";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // TongSoTienDaGD
            // 
            this.TongSoTienDaGD.DataPropertyName = "TongSoTienDaGD";
            this.TongSoTienDaGD.HeaderText = "Tổng tiền giao dịch";
            this.TongSoTienDaGD.MinimumWidth = 6;
            this.TongSoTienDaGD.Name = "TongSoTienDaGD";
            // 
            // tab_Options
            // 
            this.tab_Options.Controls.Add(this.txt_TongSoTienDaGiaoDich);
            this.tab_Options.Controls.Add(this.gunaLabel1);
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
            this.tab_Options.Size = new System.Drawing.Size(1264, 849);
            this.tab_Options.TabIndex = 1;
            this.tab_Options.Text = "Options";
            this.tab_Options.UseVisualStyleBackColor = true;
            // 
            // txt_TongSoTienDaGiaoDich
            // 
            this.txt_TongSoTienDaGiaoDich.BackColor = System.Drawing.Color.White;
            this.txt_TongSoTienDaGiaoDich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TongSoTienDaGiaoDich.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TongSoTienDaGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TongSoTienDaGiaoDich.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TongSoTienDaGiaoDich.Location = new System.Drawing.Point(587, 448);
            this.txt_TongSoTienDaGiaoDich.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongSoTienDaGiaoDich.Name = "txt_TongSoTienDaGiaoDich";
            this.txt_TongSoTienDaGiaoDich.PasswordChar = '\0';
            this.txt_TongSoTienDaGiaoDich.SelectedText = "";
            this.txt_TongSoTienDaGiaoDich.Size = new System.Drawing.Size(391, 37);
            this.txt_TongSoTienDaGiaoDich.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(273, 457);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(237, 28);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Tổng số tiền đã giao dịch:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.White;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SDT.Location = new System.Drawing.Point(587, 403);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(391, 37);
            this.txt_SDT.TabIndex = 3;
            // 
            // txt_SoCCCD
            // 
            this.txt_SoCCCD.BackColor = System.Drawing.Color.White;
            this.txt_SoCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoCCCD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoCCCD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoCCCD.Location = new System.Drawing.Point(587, 358);
            this.txt_SoCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoCCCD.Name = "txt_SoCCCD";
            this.txt_SoCCCD.PasswordChar = '\0';
            this.txt_SoCCCD.SelectedText = "";
            this.txt_SoCCCD.Size = new System.Drawing.Size(391, 37);
            this.txt_SoCCCD.TabIndex = 3;
            // 
            // txt_LoaiKH
            // 
            this.txt_LoaiKH.BackColor = System.Drawing.Color.White;
            this.txt_LoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoaiKH.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_LoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LoaiKH.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_LoaiKH.Location = new System.Drawing.Point(587, 268);
            this.txt_LoaiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiKH.Name = "txt_LoaiKH";
            this.txt_LoaiKH.PasswordChar = '\0';
            this.txt_LoaiKH.SelectedText = "";
            this.txt_LoaiKH.Size = new System.Drawing.Size(391, 37);
            this.txt_LoaiKH.TabIndex = 3;
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.BackColor = System.Drawing.Color.White;
            this.txt_HoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTenKH.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_HoTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTenKH.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_HoTenKH.Location = new System.Drawing.Point(587, 313);
            this.txt_HoTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.PasswordChar = '\0';
            this.txt_HoTenKH.SelectedText = "";
            this.txt_HoTenKH.Size = new System.Drawing.Size(391, 37);
            this.txt_HoTenKH.TabIndex = 3;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.Color.White;
            this.txt_MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaKH.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaKH.Location = new System.Drawing.Point(587, 223);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.PasswordChar = '\0';
            this.txt_MaKH.SelectedText = "";
            this.txt_MaKH.Size = new System.Drawing.Size(391, 37);
            this.txt_MaKH.TabIndex = 3;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(273, 412);
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
            this.gunaLabel4.Location = new System.Drawing.Point(273, 367);
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
            this.gunaLabel3.Location = new System.Drawing.Point(273, 322);
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
            this.gunaLabel2.Location = new System.Drawing.Point(273, 277);
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
            this.lbl_MaKH.Location = new System.Drawing.Point(273, 232);
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
            this.lbl_OptionsKH.Location = new System.Drawing.Point(426, 67);
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
            this.btn_Xoa_KhacHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Xoa_KhacHang.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_KhacHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_KhacHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_KhacHang.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_KhacHang.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_Xoa_KhacHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_KhacHang.Location = new System.Drawing.Point(758, 581);
            this.btn_Xoa_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_KhacHang.Name = "btn_Xoa_KhacHang";
            this.btn_Xoa_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_KhacHang.OnHoverImage = null;
            this.btn_Xoa_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.Radius = 6;
            this.btn_Xoa_KhacHang.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_KhacHang.TabIndex = 0;
            this.btn_Xoa_KhacHang.Text = "Xóa";
            this.btn_Xoa_KhacHang.Click += new System.EventHandler(this.btn_Xoa_KhacHang_Click);
            // 
            // btn_Sua_KhacHang
            // 
            this.btn_Sua_KhacHang.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_KhacHang.AnimationSpeed = 0.03F;
            this.btn_Sua_KhacHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_KhacHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Sua_KhacHang.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_KhacHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_KhacHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_KhacHang.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_KhacHang.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_Sua_KhacHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_KhacHang.Location = new System.Drawing.Point(490, 581);
            this.btn_Sua_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_KhacHang.Name = "btn_Sua_KhacHang";
            this.btn_Sua_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_KhacHang.OnHoverImage = null;
            this.btn_Sua_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.Radius = 6;
            this.btn_Sua_KhacHang.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_KhacHang.TabIndex = 0;
            this.btn_Sua_KhacHang.Text = "Sửa";
            this.btn_Sua_KhacHang.Click += new System.EventHandler(this.btn_Sua_KhacHang_Click);
            // 
            // btn_Them_KhacHang
            // 
            this.btn_Them_KhacHang.AnimationHoverSpeed = 0.07F;
            this.btn_Them_KhacHang.AnimationSpeed = 0.03F;
            this.btn_Them_KhacHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_KhacHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_KhacHang.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_KhacHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_KhacHang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_KhacHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_KhacHang.ForeColor = System.Drawing.Color.White;
            this.btn_Them_KhacHang.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_KhacHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_KhacHang.Location = new System.Drawing.Point(225, 581);
            this.btn_Them_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_KhacHang.Name = "btn_Them_KhacHang";
            this.btn_Them_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_KhacHang.OnHoverImage = null;
            this.btn_Them_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_KhacHang.Radius = 6;
            this.btn_Them_KhacHang.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_KhacHang.TabIndex = 0;
            this.btn_Them_KhacHang.Text = "Thêm";
            this.btn_Them_KhacHang.Click += new System.EventHandler(this.btn_Them_KhacHang_Click);
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 942);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_KhachHang";
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
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemKH_SDT;
        private Guna.UI.WinForms.GunaButton btn_Show_KhachHang;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemKH_CCCD;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemKH_HoTenKH;
        private Guna.UI.WinForms.GunaLineTextBox txt_TongSoTienDaGiaoDich;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}