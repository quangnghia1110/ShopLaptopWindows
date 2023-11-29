namespace ShopLaptop
{
    partial class Form_Laptop
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TimKiemLT_ManHinh = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TimKiemLT_MauSac = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TimKiemLT_KhoiLuong = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiemLT_TenHangLT = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimKiemLT_TenLT = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_Laptop = new System.Windows.Forms.DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DungLuongBoNho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuaTangKem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhLaptop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem_Laptop = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btn_Show_Laptop = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1LT = new Guna.UI.WinForms.GunaLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picAnhLaptop = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Guna.UI.WinForms.GunaButton();
            this.lbImage = new Guna.UI.WinForms.GunaLabel();
            this.txt_QuaTangKem = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Pin = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CPU = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txt_ManHinh = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DungLuongBoNho = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_MauSac = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_HanBaoHanh = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txt_KhoiLuong = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_SoLuong = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_TenHangLT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_TenLT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_MaLT = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_MaNV = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsLT = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_KhacHang = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_KhacHang = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_Laptop = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Laptop)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_TimKiemLT_ManHinh);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_TimKiemLT_MauSac);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_TimKiemLT_KhoiLuong);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_TimKiemLT_TenHangLT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_TimKiemLT_TenLT);
            this.tabPage1.Controls.Add(this.dgv_Laptop);
            this.tabPage1.Controls.Add(this.btn_TimKiem_Laptop);
            this.tabPage1.Controls.Add(this.btn_Show_Laptop);
            this.tabPage1.Controls.Add(this.lbl_HeaderTab1LT);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Size = new System.Drawing.Size(1264, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(992, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhập kích thước màn hình:";
            // 
            // txt_TimKiemLT_ManHinh
            // 
            this.txt_TimKiemLT_ManHinh.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemLT_ManHinh.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_ManHinh.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemLT_ManHinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemLT_ManHinh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_ManHinh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemLT_ManHinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemLT_ManHinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemLT_ManHinh.Location = new System.Drawing.Point(995, 190);
            this.txt_TimKiemLT_ManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemLT_ManHinh.Name = "txt_TimKiemLT_ManHinh";
            this.txt_TimKiemLT_ManHinh.PasswordChar = '\0';
            this.txt_TimKiemLT_ManHinh.Radius = 10;
            this.txt_TimKiemLT_ManHinh.SelectedText = "";
            this.txt_TimKiemLT_ManHinh.Size = new System.Drawing.Size(229, 42);
            this.txt_TimKiemLT_ManHinh.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(755, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nhập màu sắc:";
            // 
            // txt_TimKiemLT_MauSac
            // 
            this.txt_TimKiemLT_MauSac.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemLT_MauSac.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_MauSac.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemLT_MauSac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemLT_MauSac.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_MauSac.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemLT_MauSac.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemLT_MauSac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemLT_MauSac.Location = new System.Drawing.Point(757, 190);
            this.txt_TimKiemLT_MauSac.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemLT_MauSac.Name = "txt_TimKiemLT_MauSac";
            this.txt_TimKiemLT_MauSac.PasswordChar = '\0';
            this.txt_TimKiemLT_MauSac.Radius = 10;
            this.txt_TimKiemLT_MauSac.SelectedText = "";
            this.txt_TimKiemLT_MauSac.Size = new System.Drawing.Size(229, 42);
            this.txt_TimKiemLT_MauSac.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nhập khối lượng:";
            // 
            // txt_TimKiemLT_KhoiLuong
            // 
            this.txt_TimKiemLT_KhoiLuong.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemLT_KhoiLuong.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_KhoiLuong.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemLT_KhoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemLT_KhoiLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_KhoiLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemLT_KhoiLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemLT_KhoiLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemLT_KhoiLuong.Location = new System.Drawing.Point(519, 190);
            this.txt_TimKiemLT_KhoiLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemLT_KhoiLuong.Name = "txt_TimKiemLT_KhoiLuong";
            this.txt_TimKiemLT_KhoiLuong.PasswordChar = '\0';
            this.txt_TimKiemLT_KhoiLuong.Radius = 10;
            this.txt_TimKiemLT_KhoiLuong.SelectedText = "";
            this.txt_TimKiemLT_KhoiLuong.Size = new System.Drawing.Size(229, 42);
            this.txt_TimKiemLT_KhoiLuong.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nhập tên hãng:";
            // 
            // txt_TimKiemLT_TenHangLT
            // 
            this.txt_TimKiemLT_TenHangLT.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemLT_TenHangLT.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_TenHangLT.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemLT_TenHangLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemLT_TenHangLT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_TenHangLT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemLT_TenHangLT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemLT_TenHangLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemLT_TenHangLT.Location = new System.Drawing.Point(281, 190);
            this.txt_TimKiemLT_TenHangLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemLT_TenHangLT.Name = "txt_TimKiemLT_TenHangLT";
            this.txt_TimKiemLT_TenHangLT.PasswordChar = '\0';
            this.txt_TimKiemLT_TenHangLT.Radius = 10;
            this.txt_TimKiemLT_TenHangLT.SelectedText = "";
            this.txt_TimKiemLT_TenHangLT.Size = new System.Drawing.Size(229, 42);
            this.txt_TimKiemLT_TenHangLT.TabIndex = 25;
            this.txt_TimKiemLT_TenHangLT.TextChanged += new System.EventHandler(this.txt_TimKiemLT_TenHangLT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nhập tên laptop:";
            // 
            // txt_TimKiemLT_TenLT
            // 
            this.txt_TimKiemLT_TenLT.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiemLT_TenLT.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_TenLT.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiemLT_TenLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemLT_TenLT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiemLT_TenLT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiemLT_TenLT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemLT_TenLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemLT_TenLT.Location = new System.Drawing.Point(43, 190);
            this.txt_TimKiemLT_TenLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemLT_TenLT.Name = "txt_TimKiemLT_TenLT";
            this.txt_TimKiemLT_TenLT.PasswordChar = '\0';
            this.txt_TimKiemLT_TenLT.Radius = 10;
            this.txt_TimKiemLT_TenLT.SelectedText = "";
            this.txt_TimKiemLT_TenLT.Size = new System.Drawing.Size(229, 42);
            this.txt_TimKiemLT_TenLT.TabIndex = 23;
            // 
            // dgv_Laptop
            // 
            this.dgv_Laptop.AllowUserToAddRows = false;
            this.dgv_Laptop.AllowUserToDeleteRows = false;
            this.dgv_Laptop.AllowUserToResizeColumns = false;
            this.dgv_Laptop.AllowUserToResizeRows = false;
            this.dgv_Laptop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Laptop.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Laptop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Laptop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Laptop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Laptop.ColumnHeadersHeight = 80;
            this.dgv_Laptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.TenLT,
            this.TenHangLT,
            this.SoLuong,
            this.KhoiLuong,
            this.HanBaoHanh,
            this.Mausac,
            this.DungLuongBoNho,
            this.ManHinh,
            this.CPU,
            this.Pin,
            this.QuaTangKem,
            this.anhLaptop});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Laptop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Laptop.EnableHeadersVisualStyles = false;
            this.dgv_Laptop.Location = new System.Drawing.Point(16, 250);
            this.dgv_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Laptop.Name = "dgv_Laptop";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Laptop.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Laptop.RowHeadersWidth = 62;
            this.dgv_Laptop.ShowCellErrors = false;
            this.dgv_Laptop.ShowCellToolTips = false;
            this.dgv_Laptop.ShowEditingIcon = false;
            this.dgv_Laptop.ShowRowErrors = false;
            this.dgv_Laptop.Size = new System.Drawing.Size(1240, 582);
            this.dgv_Laptop.TabIndex = 21;
            this.dgv_Laptop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Laptop_CellContentClick);
            // 
            // MaLT
            // 
            this.MaLT.DataPropertyName = "MaLT";
            this.MaLT.HeaderText = "Mã laptop";
            this.MaLT.MinimumWidth = 8;
            this.MaLT.Name = "MaLT";
            // 
            // TenLT
            // 
            this.TenLT.DataPropertyName = "TenLT";
            this.TenLT.HeaderText = "Tên laptop";
            this.TenLT.MinimumWidth = 8;
            this.TenLT.Name = "TenLT";
            // 
            // TenHangLT
            // 
            this.TenHangLT.DataPropertyName = "TenHangLT";
            this.TenHangLT.HeaderText = "Tên hãng laptop";
            this.TenHangLT.MinimumWidth = 8;
            this.TenHangLT.Name = "TenHangLT";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // KhoiLuong
            // 
            this.KhoiLuong.DataPropertyName = "KhoiLuong";
            this.KhoiLuong.HeaderText = "Khối lượng";
            this.KhoiLuong.MinimumWidth = 8;
            this.KhoiLuong.Name = "KhoiLuong";
            // 
            // HanBaoHanh
            // 
            this.HanBaoHanh.DataPropertyName = "HanBaoHanh";
            this.HanBaoHanh.HeaderText = "Hạn bảo hành";
            this.HanBaoHanh.MinimumWidth = 8;
            this.HanBaoHanh.Name = "HanBaoHanh";
            // 
            // Mausac
            // 
            this.Mausac.DataPropertyName = "Mausac";
            this.Mausac.HeaderText = "Màu sắc";
            this.Mausac.MinimumWidth = 8;
            this.Mausac.Name = "Mausac";
            // 
            // DungLuongBoNho
            // 
            this.DungLuongBoNho.DataPropertyName = "DungLuongBoNho";
            this.DungLuongBoNho.HeaderText = "Dung lượng bộ nhớ";
            this.DungLuongBoNho.MinimumWidth = 8;
            this.DungLuongBoNho.Name = "DungLuongBoNho";
            // 
            // ManHinh
            // 
            this.ManHinh.DataPropertyName = "ManHinh";
            this.ManHinh.HeaderText = "Màn hình";
            this.ManHinh.MinimumWidth = 8;
            this.ManHinh.Name = "ManHinh";
            // 
            // CPU
            // 
            this.CPU.DataPropertyName = "CPU";
            this.CPU.HeaderText = "CPU";
            this.CPU.MinimumWidth = 8;
            this.CPU.Name = "CPU";
            // 
            // Pin
            // 
            this.Pin.DataPropertyName = "Pin";
            this.Pin.HeaderText = "Pin";
            this.Pin.MinimumWidth = 8;
            this.Pin.Name = "Pin";
            // 
            // QuaTangKem
            // 
            this.QuaTangKem.DataPropertyName = "QuaTangKem";
            this.QuaTangKem.HeaderText = "Quà tặng kèm";
            this.QuaTangKem.MinimumWidth = 8;
            this.QuaTangKem.Name = "QuaTangKem";
            // 
            // anhLaptop
            // 
            this.anhLaptop.DataPropertyName = "anhLaptop";
            this.anhLaptop.HeaderText = "Ảnh Laptop";
            this.anhLaptop.MinimumWidth = 6;
            this.anhLaptop.Name = "anhLaptop";
            // 
            // btn_TimKiem_Laptop
            // 
            this.btn_TimKiem_Laptop.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_Laptop.AnimationSpeed = 0.03F;
            this.btn_TimKiem_Laptop.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_Laptop.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_Laptop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_Laptop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_Laptop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_Laptop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_Laptop.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_Laptop.Image = null;
            this.btn_TimKiem_Laptop.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_Laptop.Location = new System.Drawing.Point(1169, 79);
            this.btn_TimKiem_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_Laptop.Name = "btn_TimKiem_Laptop";
            this.btn_TimKiem_Laptop.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_Laptop.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_Laptop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_Laptop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_Laptop.OnHoverImage = null;
            this.btn_TimKiem_Laptop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_Laptop.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_Laptop.TabIndex = 20;
            this.btn_TimKiem_Laptop.Text = "Tìm";
            this.btn_TimKiem_Laptop.Click += new System.EventHandler(this.btn_TimKiem_Laptop_Click);
            // 
            // btn_Show_Laptop
            // 
            this.btn_Show_Laptop.AnimationHoverSpeed = 0.07F;
            this.btn_Show_Laptop.AnimationSpeed = 0.03F;
            this.btn_Show_Laptop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_Laptop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_Laptop.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_Laptop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_Laptop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_Laptop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Laptop.ForeColor = System.Drawing.Color.White;
            this.btn_Show_Laptop.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_Laptop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_Laptop.Location = new System.Drawing.Point(8, 76);
            this.btn_Show_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_Laptop.Name = "btn_Show_Laptop";
            this.btn_Show_Laptop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_Laptop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_Laptop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_Laptop.OnHoverImage = null;
            this.btn_Show_Laptop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_Laptop.Radius = 20;
            this.btn_Show_Laptop.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_Laptop.TabIndex = 18;
            this.btn_Show_Laptop.Text = "Hiển thị thông tin";
            this.btn_Show_Laptop.Click += new System.EventHandler(this.btn_Show_Laptop_Click);
            // 
            // lbl_HeaderTab1LT
            // 
            this.lbl_HeaderTab1LT.AutoSize = true;
            this.lbl_HeaderTab1LT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1LT.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1LT.Location = new System.Drawing.Point(499, 5);
            this.lbl_HeaderTab1LT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1LT.Name = "lbl_HeaderTab1LT";
            this.lbl_HeaderTab1LT.Size = new System.Drawing.Size(206, 32);
            this.lbl_HeaderTab1LT.TabIndex = 17;
            this.lbl_HeaderTab1LT.Text = "Thông tin laptop";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picAnhLaptop);
            this.tabPage2.Controls.Add(this.btnUpload);
            this.tabPage2.Controls.Add(this.lbImage);
            this.tabPage2.Controls.Add(this.txt_QuaTangKem);
            this.tabPage2.Controls.Add(this.gunaLabel8);
            this.tabPage2.Controls.Add(this.txt_Pin);
            this.tabPage2.Controls.Add(this.gunaLabel9);
            this.tabPage2.Controls.Add(this.txt_CPU);
            this.tabPage2.Controls.Add(this.gunaLabel10);
            this.tabPage2.Controls.Add(this.txt_ManHinh);
            this.tabPage2.Controls.Add(this.gunaLabel11);
            this.tabPage2.Controls.Add(this.txt_DungLuongBoNho);
            this.tabPage2.Controls.Add(this.gunaLabel4);
            this.tabPage2.Controls.Add(this.txt_MauSac);
            this.tabPage2.Controls.Add(this.gunaLabel5);
            this.tabPage2.Controls.Add(this.txt_HanBaoHanh);
            this.tabPage2.Controls.Add(this.gunaLabel6);
            this.tabPage2.Controls.Add(this.txt_KhoiLuong);
            this.tabPage2.Controls.Add(this.gunaLabel7);
            this.tabPage2.Controls.Add(this.txt_SoLuong);
            this.tabPage2.Controls.Add(this.gunaLabel2);
            this.tabPage2.Controls.Add(this.txt_TenHangLT);
            this.tabPage2.Controls.Add(this.gunaLabel3);
            this.tabPage2.Controls.Add(this.txt_TenLT);
            this.tabPage2.Controls.Add(this.gunaLabel1);
            this.tabPage2.Controls.Add(this.txt_MaLT);
            this.tabPage2.Controls.Add(this.lbl_MaNV);
            this.tabPage2.Controls.Add(this.lbl_OptionsLT);
            this.tabPage2.Controls.Add(this.btn_Xoa_KhacHang);
            this.tabPage2.Controls.Add(this.btn_Sua_KhacHang);
            this.tabPage2.Controls.Add(this.btn_Them_Laptop);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Size = new System.Drawing.Size(1264, 851);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // picAnhLaptop
            // 
            this.picAnhLaptop.Location = new System.Drawing.Point(836, 194);
            this.picAnhLaptop.Margin = new System.Windows.Forms.Padding(4);
            this.picAnhLaptop.Name = "picAnhLaptop";
            this.picAnhLaptop.Size = new System.Drawing.Size(419, 326);
            this.picAnhLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhLaptop.TabIndex = 58;
            this.picAnhLaptop.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.AnimationHoverSpeed = 0.07F;
            this.btnUpload.AnimationSpeed = 0.03F;
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnUpload.BorderColor = System.Drawing.Color.Black;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpload.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = null;
            this.btnUpload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpload.Location = new System.Drawing.Point(941, 130);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpload.OnHoverImage = null;
            this.btnUpload.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpload.OnPressedDepth = 6;
            this.btnUpload.Radius = 6;
            this.btnUpload.Size = new System.Drawing.Size(179, 52);
            this.btnUpload.TabIndex = 57;
            this.btnUpload.Text = "Chọn hình ảnh";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImage.Location = new System.Drawing.Point(831, 144);
            this.lbImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(96, 28);
            this.lbImage.TabIndex = 56;
            this.lbImage.Text = "Hình ảnh:";
            // 
            // txt_QuaTangKem
            // 
            this.txt_QuaTangKem.BackColor = System.Drawing.Color.White;
            this.txt_QuaTangKem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuaTangKem.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_QuaTangKem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QuaTangKem.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_QuaTangKem.Location = new System.Drawing.Point(324, 681);
            this.txt_QuaTangKem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QuaTangKem.Name = "txt_QuaTangKem";
            this.txt_QuaTangKem.PasswordChar = '\0';
            this.txt_QuaTangKem.SelectedText = "";
            this.txt_QuaTangKem.Size = new System.Drawing.Size(459, 42);
            this.txt_QuaTangKem.TabIndex = 55;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(69, 694);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(141, 28);
            this.gunaLabel8.TabIndex = 54;
            this.gunaLabel8.Text = "Quà tặng kèm:";
            // 
            // txt_Pin
            // 
            this.txt_Pin.BackColor = System.Drawing.Color.White;
            this.txt_Pin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pin.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Pin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Pin.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Pin.Location = new System.Drawing.Point(324, 630);
            this.txt_Pin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '\0';
            this.txt_Pin.SelectedText = "";
            this.txt_Pin.Size = new System.Drawing.Size(459, 42);
            this.txt_Pin.TabIndex = 53;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(69, 645);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(44, 28);
            this.gunaLabel9.TabIndex = 52;
            this.gunaLabel9.Text = "Pin:";
            // 
            // txt_CPU
            // 
            this.txt_CPU.BackColor = System.Drawing.Color.White;
            this.txt_CPU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CPU.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_CPU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CPU.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_CPU.Location = new System.Drawing.Point(324, 581);
            this.txt_CPU.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.PasswordChar = '\0';
            this.txt_CPU.SelectedText = "";
            this.txt_CPU.Size = new System.Drawing.Size(459, 42);
            this.txt_CPU.TabIndex = 51;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(69, 594);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(55, 28);
            this.gunaLabel10.TabIndex = 50;
            this.gunaLabel10.Text = "CPU:";
            // 
            // txt_ManHinh
            // 
            this.txt_ManHinh.BackColor = System.Drawing.Color.White;
            this.txt_ManHinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ManHinh.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ManHinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ManHinh.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_ManHinh.Location = new System.Drawing.Point(324, 530);
            this.txt_ManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ManHinh.Name = "txt_ManHinh";
            this.txt_ManHinh.PasswordChar = '\0';
            this.txt_ManHinh.SelectedText = "";
            this.txt_ManHinh.Size = new System.Drawing.Size(459, 42);
            this.txt_ManHinh.TabIndex = 49;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(69, 544);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(98, 28);
            this.gunaLabel11.TabIndex = 48;
            this.gunaLabel11.Text = "Màn hình:";
            // 
            // txt_DungLuongBoNho
            // 
            this.txt_DungLuongBoNho.BackColor = System.Drawing.Color.White;
            this.txt_DungLuongBoNho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DungLuongBoNho.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DungLuongBoNho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DungLuongBoNho.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_DungLuongBoNho.Location = new System.Drawing.Point(324, 480);
            this.txt_DungLuongBoNho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DungLuongBoNho.Name = "txt_DungLuongBoNho";
            this.txt_DungLuongBoNho.PasswordChar = '\0';
            this.txt_DungLuongBoNho.SelectedText = "";
            this.txt_DungLuongBoNho.Size = new System.Drawing.Size(459, 42);
            this.txt_DungLuongBoNho.TabIndex = 47;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(69, 495);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(186, 28);
            this.gunaLabel4.TabIndex = 46;
            this.gunaLabel4.Text = "Dung lượng bộ nhớ:";
            // 
            // txt_MauSac
            // 
            this.txt_MauSac.BackColor = System.Drawing.Color.White;
            this.txt_MauSac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MauSac.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MauSac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MauSac.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MauSac.Location = new System.Drawing.Point(324, 431);
            this.txt_MauSac.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MauSac.Name = "txt_MauSac";
            this.txt_MauSac.PasswordChar = '\0';
            this.txt_MauSac.SelectedText = "";
            this.txt_MauSac.Size = new System.Drawing.Size(459, 42);
            this.txt_MauSac.TabIndex = 45;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(69, 444);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(88, 28);
            this.gunaLabel5.TabIndex = 44;
            this.gunaLabel5.Text = "Màu sắc:";
            // 
            // txt_HanBaoHanh
            // 
            this.txt_HanBaoHanh.BackColor = System.Drawing.Color.White;
            this.txt_HanBaoHanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HanBaoHanh.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_HanBaoHanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HanBaoHanh.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_HanBaoHanh.Location = new System.Drawing.Point(324, 380);
            this.txt_HanBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HanBaoHanh.Name = "txt_HanBaoHanh";
            this.txt_HanBaoHanh.PasswordChar = '\0';
            this.txt_HanBaoHanh.SelectedText = "";
            this.txt_HanBaoHanh.Size = new System.Drawing.Size(459, 42);
            this.txt_HanBaoHanh.TabIndex = 43;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(69, 394);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(141, 28);
            this.gunaLabel6.TabIndex = 42;
            this.gunaLabel6.Text = "Hạn bảo hành:";
            // 
            // txt_KhoiLuong
            // 
            this.txt_KhoiLuong.BackColor = System.Drawing.Color.White;
            this.txt_KhoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KhoiLuong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_KhoiLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_KhoiLuong.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_KhoiLuong.Location = new System.Drawing.Point(324, 330);
            this.txt_KhoiLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KhoiLuong.Name = "txt_KhoiLuong";
            this.txt_KhoiLuong.PasswordChar = '\0';
            this.txt_KhoiLuong.SelectedText = "";
            this.txt_KhoiLuong.Size = new System.Drawing.Size(459, 42);
            this.txt_KhoiLuong.TabIndex = 41;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(69, 345);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(111, 28);
            this.gunaLabel7.TabIndex = 40;
            this.gunaLabel7.Text = "Khối lượng:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BackColor = System.Drawing.Color.White;
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoLuong.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoLuong.Location = new System.Drawing.Point(324, 281);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PasswordChar = '\0';
            this.txt_SoLuong.SelectedText = "";
            this.txt_SoLuong.Size = new System.Drawing.Size(459, 42);
            this.txt_SoLuong.TabIndex = 39;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(69, 294);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 28);
            this.gunaLabel2.TabIndex = 38;
            this.gunaLabel2.Text = "Số lượng:";
            // 
            // txt_TenHangLT
            // 
            this.txt_TenHangLT.BackColor = System.Drawing.Color.White;
            this.txt_TenHangLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenHangLT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TenHangLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenHangLT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TenHangLT.Location = new System.Drawing.Point(324, 230);
            this.txt_TenHangLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenHangLT.Name = "txt_TenHangLT";
            this.txt_TenHangLT.PasswordChar = '\0';
            this.txt_TenHangLT.SelectedText = "";
            this.txt_TenHangLT.Size = new System.Drawing.Size(459, 42);
            this.txt_TenHangLT.TabIndex = 37;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(69, 245);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(159, 28);
            this.gunaLabel3.TabIndex = 36;
            this.gunaLabel3.Text = "Tên hãng laptop:";
            // 
            // txt_TenLT
            // 
            this.txt_TenLT.BackColor = System.Drawing.Color.White;
            this.txt_TenLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TenLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenLT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TenLT.Location = new System.Drawing.Point(324, 181);
            this.txt_TenLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLT.Name = "txt_TenLT";
            this.txt_TenLT.PasswordChar = '\0';
            this.txt_TenLT.SelectedText = "";
            this.txt_TenLT.Size = new System.Drawing.Size(459, 42);
            this.txt_TenLT.TabIndex = 35;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(69, 194);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(109, 28);
            this.gunaLabel1.TabIndex = 34;
            this.gunaLabel1.Text = "Tên laptop:";
            // 
            // txt_MaLT
            // 
            this.txt_MaLT.BackColor = System.Drawing.Color.White;
            this.txt_MaLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaLT.Location = new System.Drawing.Point(324, 130);
            this.txt_MaLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLT.Name = "txt_MaLT";
            this.txt_MaLT.PasswordChar = '\0';
            this.txt_MaLT.SelectedText = "";
            this.txt_MaLT.Size = new System.Drawing.Size(459, 42);
            this.txt_MaLT.TabIndex = 33;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(69, 144);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(104, 28);
            this.lbl_MaNV.TabIndex = 28;
            this.lbl_MaNV.Text = "Mã laptop:";
            // 
            // lbl_OptionsLT
            // 
            this.lbl_OptionsLT.AutoSize = true;
            this.lbl_OptionsLT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsLT.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsLT.Location = new System.Drawing.Point(467, 65);
            this.lbl_OptionsLT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsLT.Name = "lbl_OptionsLT";
            this.lbl_OptionsLT.Size = new System.Drawing.Size(317, 32);
            this.lbl_OptionsLT.TabIndex = 23;
            this.lbl_OptionsLT.Text = "Tùy chỉnh thông tin laptop\r\n";
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
            this.btn_Xoa_KhacHang.Location = new System.Drawing.Point(763, 766);
            this.btn_Xoa_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_KhacHang.Name = "btn_Xoa_KhacHang";
            this.btn_Xoa_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_KhacHang.OnHoverImage = null;
            this.btn_Xoa_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_KhacHang.OnPressedDepth = 6;
            this.btn_Xoa_KhacHang.Radius = 6;
            this.btn_Xoa_KhacHang.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_KhacHang.TabIndex = 20;
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
            this.btn_Sua_KhacHang.Location = new System.Drawing.Point(497, 766);
            this.btn_Sua_KhacHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_KhacHang.Name = "btn_Sua_KhacHang";
            this.btn_Sua_KhacHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_KhacHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_KhacHang.OnHoverImage = null;
            this.btn_Sua_KhacHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_KhacHang.OnPressedDepth = 6;
            this.btn_Sua_KhacHang.Radius = 6;
            this.btn_Sua_KhacHang.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_KhacHang.TabIndex = 21;
            this.btn_Sua_KhacHang.Text = "Sửa";
            this.btn_Sua_KhacHang.Click += new System.EventHandler(this.btn_Sua_KhacHang_Click);
            // 
            // btn_Them_Laptop
            // 
            this.btn_Them_Laptop.AnimationHoverSpeed = 0.07F;
            this.btn_Them_Laptop.AnimationSpeed = 0.03F;
            this.btn_Them_Laptop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_Laptop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_Laptop.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_Laptop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_Laptop.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_Laptop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_Laptop.ForeColor = System.Drawing.Color.White;
            this.btn_Them_Laptop.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_Laptop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_Laptop.Location = new System.Drawing.Point(231, 766);
            this.btn_Them_Laptop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_Laptop.Name = "btn_Them_Laptop";
            this.btn_Them_Laptop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_Laptop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_Laptop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_Laptop.OnHoverImage = null;
            this.btn_Them_Laptop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_Laptop.OnPressedDepth = 6;
            this.btn_Them_Laptop.Radius = 6;
            this.btn_Them_Laptop.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_Laptop.TabIndex = 22;
            this.btn_Them_Laptop.Text = "Thêm";
            this.btn_Them_Laptop.Click += new System.EventHandler(this.btn_Them_KhacHang_Click);
            // 
            // Form_Laptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 939);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Form_Laptop";
            this.Text = "Laptop";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Laptop)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLaptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Laptop;
        private Guna.UI.WinForms.GunaButton btn_Show_Laptop;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1LT;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaLT;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsLT;
        private Guna.UI.WinForms.GunaButton btn_Xoa_KhacHang;
        private Guna.UI.WinForms.GunaButton btn_Sua_KhacHang;
        private Guna.UI.WinForms.GunaButton btn_Them_Laptop;
        private Guna.UI.WinForms.GunaLineTextBox txt_DungLuongBoNho;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox txt_MauSac;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLineTextBox txt_HanBaoHanh;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLineTextBox txt_KhoiLuong;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoLuong;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txt_TenHangLT;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox txt_TenLT;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_QuaTangKem;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLineTextBox txt_Pin;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLineTextBox txt_CPU;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLineTextBox txt_ManHinh;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_Laptop;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemLT_TenHangLT;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemLT_TenLT;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemLT_ManHinh;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemLT_MauSac;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiemLT_KhoiLuong;
        private System.Windows.Forms.PictureBox picAnhLaptop;
        private Guna.UI.WinForms.GunaButton btnUpload;
        private Guna.UI.WinForms.GunaLabel lbImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mausac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DungLuongBoNho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuaTangKem;
        private System.Windows.Forms.DataGridViewTextBoxColumn anhLaptop;
    }
}