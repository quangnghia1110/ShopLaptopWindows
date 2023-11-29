namespace ShopLaptop
{
    partial class Form_PhieuNhapKho
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Information = new System.Windows.Forms.TabPage();
            this.dt_TimKiem_PNK = new System.Windows.Forms.DateTimePicker();
            this.lbl_TimKiem_PNK = new System.Windows.Forms.Label();
            this.dgv_PhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThanhToanNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem_PhieuNhapKho = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btn_Show_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1PNK = new Guna.UI.WinForms.GunaLabel();
            this.tab_Options = new System.Windows.Forms.TabPage();
            this.txt_TrangThaiThanhToan_PNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_PhuongThucThanhToan_PNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SoTienThanhToan_PNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNCC_PNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNV_PNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TrangThaiThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PhuongThucThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SoTienThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNCC_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsPNK = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tabControl1.SuspendLayout();
            this.tab_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).BeginInit();
            this.tab_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tab_Information);
            this.tabControl1.Controls.Add(this.tab_Options);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_Information
            // 
            this.tab_Information.Controls.Add(this.dt_TimKiem_PNK);
            this.tab_Information.Controls.Add(this.lbl_TimKiem_PNK);
            this.tab_Information.Controls.Add(this.dgv_PhieuNhapKho);
            this.tab_Information.Controls.Add(this.btn_TimKiem_PhieuNhapKho);
            this.tab_Information.Controls.Add(this.btn_Show_PhieuNhapKho);
            this.tab_Information.Controls.Add(this.lbl_HeaderTab1PNK);
            this.tab_Information.Location = new System.Drawing.Point(4, 4);
            this.tab_Information.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Information.Name = "tab_Information";
            this.tab_Information.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Information.Size = new System.Drawing.Size(1264, 827);
            this.tab_Information.TabIndex = 0;
            this.tab_Information.Text = "Information";
            this.tab_Information.UseVisualStyleBackColor = true;
            // 
            // dt_TimKiem_PNK
            // 
            this.dt_TimKiem_PNK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_TimKiem_PNK.Location = new System.Drawing.Point(873, 101);
            this.dt_TimKiem_PNK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_TimKiem_PNK.Name = "dt_TimKiem_PNK";
            this.dt_TimKiem_PNK.Size = new System.Drawing.Size(213, 27);
            this.dt_TimKiem_PNK.TabIndex = 10;
            // 
            // lbl_TimKiem_PNK
            // 
            this.lbl_TimKiem_PNK.AutoSize = true;
            this.lbl_TimKiem_PNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_PNK.Location = new System.Drawing.Point(870, 76);
            this.lbl_TimKiem_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_PNK.Name = "lbl_TimKiem_PNK";
            this.lbl_TimKiem_PNK.Size = new System.Drawing.Size(166, 18);
            this.lbl_TimKiem_PNK.TabIndex = 9;
            this.lbl_TimKiem_PNK.Text = "Nhập ngày nhập kho:";
            // 
            // dgv_PhieuNhapKho
            // 
            this.dgv_PhieuNhapKho.AllowUserToAddRows = false;
            this.dgv_PhieuNhapKho.AllowUserToDeleteRows = false;
            this.dgv_PhieuNhapKho.AllowUserToResizeColumns = false;
            this.dgv_PhieuNhapKho.AllowUserToResizeRows = false;
            this.dgv_PhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PhieuNhapKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PhieuNhapKho.ColumnHeadersHeight = 80;
            this.dgv_PhieuNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNK,
            this.MaNCC,
            this.MaNV,
            this.NgayNhapKho,
            this.SoTienThanhToanNhapKho,
            this.PhuongThucThanhToan,
            this.TrangThaiThanhToan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PhieuNhapKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PhieuNhapKho.EnableHeadersVisualStyles = false;
            this.dgv_PhieuNhapKho.Location = new System.Drawing.Point(8, 159);
            this.dgv_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PhieuNhapKho.Name = "dgv_PhieuNhapKho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuNhapKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PhieuNhapKho.RowHeadersWidth = 51;
            this.dgv_PhieuNhapKho.ShowCellErrors = false;
            this.dgv_PhieuNhapKho.ShowCellToolTips = false;
            this.dgv_PhieuNhapKho.ShowEditingIcon = false;
            this.dgv_PhieuNhapKho.ShowRowErrors = false;
            this.dgv_PhieuNhapKho.Size = new System.Drawing.Size(1248, 672);
            this.dgv_PhieuNhapKho.TabIndex = 8;
            this.dgv_PhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhapKho_CellContentClick);
            // 
            // MaNK
            // 
            this.MaNK.DataPropertyName = "MaNK";
            this.MaNK.HeaderText = "Mã nhập kho";
            this.MaNK.MinimumWidth = 6;
            this.MaNK.Name = "MaNK";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.DataPropertyName = "NgayNhapKho";
            this.NgayNhapKho.HeaderText = "Ngày nhập kho";
            this.NgayNhapKho.MinimumWidth = 6;
            this.NgayNhapKho.Name = "NgayNhapKho";
            // 
            // SoTienThanhToanNhapKho
            // 
            this.SoTienThanhToanNhapKho.DataPropertyName = "SoTienThanhToanNhapKho";
            this.SoTienThanhToanNhapKho.HeaderText = "Số tiền thanh toán";
            this.SoTienThanhToanNhapKho.MinimumWidth = 6;
            this.SoTienThanhToanNhapKho.Name = "SoTienThanhToanNhapKho";
            // 
            // PhuongThucThanhToan
            // 
            this.PhuongThucThanhToan.DataPropertyName = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.HeaderText = "Phương thức thanh toán";
            this.PhuongThucThanhToan.MinimumWidth = 6;
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            // 
            // TrangThaiThanhToan
            // 
            this.TrangThaiThanhToan.DataPropertyName = "TrangThaiThanhToan";
            this.TrangThaiThanhToan.HeaderText = "Trạng thái thanh toán";
            this.TrangThaiThanhToan.MinimumWidth = 6;
            this.TrangThaiThanhToan.Name = "TrangThaiThanhToan";
            // 
            // btn_TimKiem_PhieuNhapKho
            // 
            this.btn_TimKiem_PhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_PhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_TimKiem_PhieuNhapKho.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_PhieuNhapKho.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_PhieuNhapKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_PhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_PhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_PhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_PhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_PhieuNhapKho.Image = null;
            this.btn_TimKiem_PhieuNhapKho.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_PhieuNhapKho.Location = new System.Drawing.Point(1169, 81);
            this.btn_TimKiem_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_PhieuNhapKho.Name = "btn_TimKiem_PhieuNhapKho";
            this.btn_TimKiem_PhieuNhapKho.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_PhieuNhapKho.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_PhieuNhapKho.OnHoverImage = null;
            this.btn_TimKiem_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_PhieuNhapKho.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_PhieuNhapKho.TabIndex = 7;
            this.btn_TimKiem_PhieuNhapKho.Text = "Tìm";
            this.btn_TimKiem_PhieuNhapKho.Click += new System.EventHandler(this.btn_TimKiem_PhieuNhapKho_Click);
            // 
            // btn_Show_PhieuNhapKho
            // 
            this.btn_Show_PhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_Show_PhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_Show_PhieuNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_PhieuNhapKho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_PhieuNhapKho.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_PhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_PhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_PhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_PhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_Show_PhieuNhapKho.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_PhieuNhapKho.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_PhieuNhapKho.Location = new System.Drawing.Point(8, 76);
            this.btn_Show_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_PhieuNhapKho.Name = "btn_Show_PhieuNhapKho";
            this.btn_Show_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_PhieuNhapKho.OnHoverImage = null;
            this.btn_Show_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_PhieuNhapKho.Radius = 20;
            this.btn_Show_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_PhieuNhapKho.TabIndex = 2;
            this.btn_Show_PhieuNhapKho.Text = "Hiển thị thông tin";
            this.btn_Show_PhieuNhapKho.Click += new System.EventHandler(this.btn_Show_PhieuNhapKho_Click);
            // 
            // lbl_HeaderTab1PNK
            // 
            this.lbl_HeaderTab1PNK.AutoSize = true;
            this.lbl_HeaderTab1PNK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1PNK.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1PNK.Location = new System.Drawing.Point(460, 4);
            this.lbl_HeaderTab1PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1PNK.Name = "lbl_HeaderTab1PNK";
            this.lbl_HeaderTab1PNK.Size = new System.Drawing.Size(191, 32);
            this.lbl_HeaderTab1PNK.TabIndex = 0;
            this.lbl_HeaderTab1PNK.Text = "Phiếu nhập kho";
            // 
            // tab_Options
            // 
            this.tab_Options.Controls.Add(this.txt_TrangThaiThanhToan_PNK);
            this.tab_Options.Controls.Add(this.txt_PhuongThucThanhToan_PNK);
            this.tab_Options.Controls.Add(this.txt_SoTienThanhToan_PNK);
            this.tab_Options.Controls.Add(this.txt_MaNCC_PNK);
            this.tab_Options.Controls.Add(this.txt_MaNV_PNK);
            this.tab_Options.Controls.Add(this.txt_MaNK);
            this.tab_Options.Controls.Add(this.lbl_TrangThaiThanhToan_PNK);
            this.tab_Options.Controls.Add(this.lbl_PhuongThucThanhToan_PNK);
            this.tab_Options.Controls.Add(this.lbl_SoTienThanhToan_PNK);
            this.tab_Options.Controls.Add(this.lbl_MaNV_PNK);
            this.tab_Options.Controls.Add(this.lbl_MaNCC_PNK);
            this.tab_Options.Controls.Add(this.lbl_MaNK);
            this.tab_Options.Controls.Add(this.lbl_OptionsPNK);
            this.tab_Options.Controls.Add(this.btn_Xoa_PhieuNhapKho);
            this.tab_Options.Controls.Add(this.btn_Sua_PhieuNhapKho);
            this.tab_Options.Controls.Add(this.btn_Them_PhieuNhapKho);
            this.tab_Options.Location = new System.Drawing.Point(4, 4);
            this.tab_Options.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Options.Name = "tab_Options";
            this.tab_Options.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Options.Size = new System.Drawing.Size(1264, 851);
            this.tab_Options.TabIndex = 1;
            this.tab_Options.Text = "Options";
            this.tab_Options.UseVisualStyleBackColor = true;
            this.tab_Options.Click += new System.EventHandler(this.tab_Options_Click);
            // 
            // txt_TrangThaiThanhToan_PNK
            // 
            this.txt_TrangThaiThanhToan_PNK.BackColor = System.Drawing.Color.White;
            this.txt_TrangThaiThanhToan_PNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThaiThanhToan_PNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThaiThanhToan_PNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TrangThaiThanhToan_PNK.Location = new System.Drawing.Point(625, 431);
            this.txt_TrangThaiThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrangThaiThanhToan_PNK.Name = "txt_TrangThaiThanhToan_PNK";
            this.txt_TrangThaiThanhToan_PNK.PasswordChar = '\0';
            this.txt_TrangThaiThanhToan_PNK.SelectedText = "";
            this.txt_TrangThaiThanhToan_PNK.Size = new System.Drawing.Size(354, 37);
            this.txt_TrangThaiThanhToan_PNK.TabIndex = 3;
            // 
            // txt_PhuongThucThanhToan_PNK
            // 
            this.txt_PhuongThucThanhToan_PNK.BackColor = System.Drawing.Color.White;
            this.txt_PhuongThucThanhToan_PNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PhuongThucThanhToan_PNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PhuongThucThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PhuongThucThanhToan_PNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_PhuongThucThanhToan_PNK.Location = new System.Drawing.Point(625, 386);
            this.txt_PhuongThucThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhuongThucThanhToan_PNK.Name = "txt_PhuongThucThanhToan_PNK";
            this.txt_PhuongThucThanhToan_PNK.PasswordChar = '\0';
            this.txt_PhuongThucThanhToan_PNK.SelectedText = "";
            this.txt_PhuongThucThanhToan_PNK.Size = new System.Drawing.Size(354, 37);
            this.txt_PhuongThucThanhToan_PNK.TabIndex = 3;
            // 
            // txt_SoTienThanhToan_PNK
            // 
            this.txt_SoTienThanhToan_PNK.BackColor = System.Drawing.Color.White;
            this.txt_SoTienThanhToan_PNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoTienThanhToan_PNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoTienThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoTienThanhToan_PNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoTienThanhToan_PNK.Location = new System.Drawing.Point(625, 341);
            this.txt_SoTienThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoTienThanhToan_PNK.Name = "txt_SoTienThanhToan_PNK";
            this.txt_SoTienThanhToan_PNK.PasswordChar = '\0';
            this.txt_SoTienThanhToan_PNK.SelectedText = "";
            this.txt_SoTienThanhToan_PNK.Size = new System.Drawing.Size(354, 37);
            this.txt_SoTienThanhToan_PNK.TabIndex = 3;
            // 
            // txt_MaNCC_PNK
            // 
            this.txt_MaNCC_PNK.BackColor = System.Drawing.Color.White;
            this.txt_MaNCC_PNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNCC_PNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNCC_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNCC_PNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNCC_PNK.Location = new System.Drawing.Point(625, 251);
            this.txt_MaNCC_PNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNCC_PNK.Name = "txt_MaNCC_PNK";
            this.txt_MaNCC_PNK.PasswordChar = '\0';
            this.txt_MaNCC_PNK.SelectedText = "";
            this.txt_MaNCC_PNK.Size = new System.Drawing.Size(354, 37);
            this.txt_MaNCC_PNK.TabIndex = 3;
            // 
            // txt_MaNV_PNK
            // 
            this.txt_MaNV_PNK.BackColor = System.Drawing.Color.White;
            this.txt_MaNV_PNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV_PNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNV_PNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNV_PNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNV_PNK.Location = new System.Drawing.Point(625, 296);
            this.txt_MaNV_PNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNV_PNK.Name = "txt_MaNV_PNK";
            this.txt_MaNV_PNK.PasswordChar = '\0';
            this.txt_MaNV_PNK.SelectedText = "";
            this.txt_MaNV_PNK.Size = new System.Drawing.Size(354, 37);
            this.txt_MaNV_PNK.TabIndex = 3;
            // 
            // txt_MaNK
            // 
            this.txt_MaNK.BackColor = System.Drawing.Color.White;
            this.txt_MaNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNK.Location = new System.Drawing.Point(625, 200);
            this.txt_MaNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNK.Name = "txt_MaNK";
            this.txt_MaNK.PasswordChar = '\0';
            this.txt_MaNK.SelectedText = "";
            this.txt_MaNK.Size = new System.Drawing.Size(354, 37);
            this.txt_MaNK.TabIndex = 3;
            // 
            // lbl_TrangThaiThanhToan_PNK
            // 
            this.lbl_TrangThaiThanhToan_PNK.AutoSize = true;
            this.lbl_TrangThaiThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiThanhToan_PNK.Location = new System.Drawing.Point(264, 440);
            this.lbl_TrangThaiThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiThanhToan_PNK.Name = "lbl_TrangThaiThanhToan_PNK";
            this.lbl_TrangThaiThanhToan_PNK.Size = new System.Drawing.Size(207, 28);
            this.lbl_TrangThaiThanhToan_PNK.TabIndex = 2;
            this.lbl_TrangThaiThanhToan_PNK.Text = "Trạng thái thanh toán:";
            // 
            // lbl_PhuongThucThanhToan_PNK
            // 
            this.lbl_PhuongThucThanhToan_PNK.AutoSize = true;
            this.lbl_PhuongThucThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhuongThucThanhToan_PNK.Location = new System.Drawing.Point(264, 395);
            this.lbl_PhuongThucThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhuongThucThanhToan_PNK.Name = "lbl_PhuongThucThanhToan_PNK";
            this.lbl_PhuongThucThanhToan_PNK.Size = new System.Drawing.Size(229, 28);
            this.lbl_PhuongThucThanhToan_PNK.TabIndex = 2;
            this.lbl_PhuongThucThanhToan_PNK.Text = "Phương thức thanh toán:";
            // 
            // lbl_SoTienThanhToan_PNK
            // 
            this.lbl_SoTienThanhToan_PNK.AutoSize = true;
            this.lbl_SoTienThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienThanhToan_PNK.Location = new System.Drawing.Point(264, 350);
            this.lbl_SoTienThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTienThanhToan_PNK.Name = "lbl_SoTienThanhToan_PNK";
            this.lbl_SoTienThanhToan_PNK.Size = new System.Drawing.Size(264, 28);
            this.lbl_SoTienThanhToan_PNK.TabIndex = 2;
            this.lbl_SoTienThanhToan_PNK.Text = "Số tiền thanh toán nhập kho:";
            // 
            // lbl_MaNV_PNK
            // 
            this.lbl_MaNV_PNK.AutoSize = true;
            this.lbl_MaNV_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV_PNK.Location = new System.Drawing.Point(264, 305);
            this.lbl_MaNV_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV_PNK.Name = "lbl_MaNV_PNK";
            this.lbl_MaNV_PNK.Size = new System.Drawing.Size(134, 28);
            this.lbl_MaNV_PNK.TabIndex = 2;
            this.lbl_MaNV_PNK.Text = "Mã nhân viên:";
            // 
            // lbl_MaNCC_PNK
            // 
            this.lbl_MaNCC_PNK.AutoSize = true;
            this.lbl_MaNCC_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNCC_PNK.Location = new System.Drawing.Point(264, 260);
            this.lbl_MaNCC_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNCC_PNK.Name = "lbl_MaNCC_PNK";
            this.lbl_MaNCC_PNK.Size = new System.Drawing.Size(167, 28);
            this.lbl_MaNCC_PNK.TabIndex = 2;
            this.lbl_MaNCC_PNK.Text = "Mã nhà cung cấp:";
            // 
            // lbl_MaNK
            // 
            this.lbl_MaNK.AutoSize = true;
            this.lbl_MaNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNK.Location = new System.Drawing.Point(267, 209);
            this.lbl_MaNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNK.Name = "lbl_MaNK";
            this.lbl_MaNK.Size = new System.Drawing.Size(131, 28);
            this.lbl_MaNK.TabIndex = 2;
            this.lbl_MaNK.Text = "Mã nhập kho:";
            // 
            // lbl_OptionsPNK
            // 
            this.lbl_OptionsPNK.AutoSize = true;
            this.lbl_OptionsPNK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsPNK.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsPNK.Location = new System.Drawing.Point(380, 60);
            this.lbl_OptionsPNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsPNK.Name = "lbl_OptionsPNK";
            this.lbl_OptionsPNK.Size = new System.Drawing.Size(420, 32);
            this.lbl_OptionsPNK.TabIndex = 1;
            this.lbl_OptionsPNK.Text = "Tùy chỉnh thông tin phiếu nhập kho";
            // 
            // btn_Xoa_PhieuNhapKho
            // 
            this.btn_Xoa_PhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_PhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_Xoa_PhieuNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa_PhieuNhapKho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Xoa_PhieuNhapKho.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_PhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_PhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_PhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_PhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_PhieuNhapKho.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_Xoa_PhieuNhapKho.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_PhieuNhapKho.Location = new System.Drawing.Point(772, 557);
            this.btn_Xoa_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_PhieuNhapKho.Name = "btn_Xoa_PhieuNhapKho";
            this.btn_Xoa_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_PhieuNhapKho.OnHoverImage = null;
            this.btn_Xoa_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_PhieuNhapKho.Radius = 6;
            this.btn_Xoa_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_PhieuNhapKho.TabIndex = 0;
            this.btn_Xoa_PhieuNhapKho.Text = "Xóa";
            this.btn_Xoa_PhieuNhapKho.Click += new System.EventHandler(this.btn_Xoa_PhieuNhapKho_Click);
            // 
            // btn_Sua_PhieuNhapKho
            // 
            this.btn_Sua_PhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_PhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_Sua_PhieuNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_PhieuNhapKho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Sua_PhieuNhapKho.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_PhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_PhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_PhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_PhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_PhieuNhapKho.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_Sua_PhieuNhapKho.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_PhieuNhapKho.Location = new System.Drawing.Point(501, 557);
            this.btn_Sua_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_PhieuNhapKho.Name = "btn_Sua_PhieuNhapKho";
            this.btn_Sua_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_PhieuNhapKho.OnHoverImage = null;
            this.btn_Sua_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_PhieuNhapKho.Radius = 6;
            this.btn_Sua_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_PhieuNhapKho.TabIndex = 0;
            this.btn_Sua_PhieuNhapKho.Text = "Sửa";
            this.btn_Sua_PhieuNhapKho.Click += new System.EventHandler(this.btn_Sua_PhieuNhapKho_Click);
            // 
            // btn_Them_PhieuNhapKho
            // 
            this.btn_Them_PhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_Them_PhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_Them_PhieuNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_PhieuNhapKho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_PhieuNhapKho.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_PhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_PhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_PhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_PhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_Them_PhieuNhapKho.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_PhieuNhapKho.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_PhieuNhapKho.Location = new System.Drawing.Point(231, 557);
            this.btn_Them_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_PhieuNhapKho.Name = "btn_Them_PhieuNhapKho";
            this.btn_Them_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_PhieuNhapKho.OnHoverImage = null;
            this.btn_Them_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_PhieuNhapKho.Radius = 6;
            this.btn_Them_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_PhieuNhapKho.TabIndex = 0;
            this.btn_Them_PhieuNhapKho.Text = "Thêm";
            this.btn_Them_PhieuNhapKho.Click += new System.EventHandler(this.btn_Them_PhieuNhapKho_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(435, 31);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel1.TabIndex = 3;
            // 
            // Form_PhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 940);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_PhieuNhapKho";
            this.Text = "PhieuNhapKho";
            this.tabControl1.ResumeLayout(false);
            this.tab_Information.ResumeLayout(false);
            this.tab_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapKho)).EndInit();
            this.tab_Options.ResumeLayout(false);
            this.tab_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Information;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_PhieuNhapKho;
        private Guna.UI.WinForms.GunaButton btn_Show_PhieuNhapKho;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1PNK;
        private System.Windows.Forms.TabPage tab_Options;
        private Guna.UI.WinForms.GunaLineTextBox txt_TrangThaiThanhToan_PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_PhuongThucThanhToan_PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoTienThanhToan_PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNCC_PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNV_PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNK;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_PhuongThucThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_SoTienThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNCC_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNK;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsPNK;
        private Guna.UI.WinForms.GunaButton btn_Xoa_PhieuNhapKho;
        private Guna.UI.WinForms.GunaButton btn_Sua_PhieuNhapKho;
        private Guna.UI.WinForms.GunaButton btn_Them_PhieuNhapKho;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dgv_PhieuNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThanhToanNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiThanhToan;
        private System.Windows.Forms.Label lbl_TimKiem_PNK;
        private System.Windows.Forms.DateTimePicker dt_TimKiem_PNK;
    }
}