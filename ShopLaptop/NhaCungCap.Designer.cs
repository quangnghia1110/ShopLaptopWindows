namespace ShopLaptop
{
    partial class NhaCungCap
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_NCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiHopTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TimKiem_NCC = new System.Windows.Forms.Label();
            this.btn_TimKiem_NCC = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.txt_TimKiem_NCC = new Guna.UI.WinForms.GunaTextBox();
            this.btn_ShowNCC = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1NCC = new Guna.UI.WinForms.GunaLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_TrangThaiHopTac = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TrangThaiHopTac = new Guna.UI.WinForms.GunaLabel();
            this.txt_SDT = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_SDT = new Guna.UI.WinForms.GunaLabel();
            this.txt_DiaChi = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_DiaChi = new Guna.UI.WinForms.GunaLabel();
            this.txt_Email = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_Email = new Guna.UI.WinForms.GunaLabel();
            this.txt_TenNCC = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TenNCC = new Guna.UI.WinForms.GunaLabel();
            this.txt_MaNCC = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_MaNCC = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsNCC = new Guna.UI.WinForms.GunaLabel();
            this.btn_XoaTab2NCC = new Guna.UI.WinForms.GunaButton();
            this.btn_SuaTab2NCC = new Guna.UI.WinForms.GunaButton();
            this.btn_ThemTab2NCC = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 883);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_NCC);
            this.tabPage1.Controls.Add(this.lbl_TimKiem_NCC);
            this.tabPage1.Controls.Add(this.btn_TimKiem_NCC);
            this.tabPage1.Controls.Add(this.txt_TimKiem_NCC);
            this.tabPage1.Controls.Add(this.btn_ShowNCC);
            this.tabPage1.Controls.Add(this.lbl_HeaderTab1NCC);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1264, 854);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_NCC
            // 
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.Email,
            this.DiaChi,
            this.SDT,
            this.TrangThaiHopTac});
            this.dgv_NCC.Location = new System.Drawing.Point(8, 158);
            this.dgv_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.RowHeadersWidth = 62;
            this.dgv_NCC.Size = new System.Drawing.Size(1249, 690);
            this.dgv_NCC.TabIndex = 29;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 150;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 8;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // TrangThaiHopTac
            // 
            this.TrangThaiHopTac.DataPropertyName = "TrangThaiHopTac";
            this.TrangThaiHopTac.HeaderText = "Trạng thái hợp tác";
            this.TrangThaiHopTac.MinimumWidth = 8;
            this.TrangThaiHopTac.Name = "TrangThaiHopTac";
            this.TrangThaiHopTac.Width = 150;
            // 
            // lbl_TimKiem_NCC
            // 
            this.lbl_TimKiem_NCC.AutoSize = true;
            this.lbl_TimKiem_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_NCC.Location = new System.Drawing.Point(891, 65);
            this.lbl_TimKiem_NCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_NCC.Name = "lbl_TimKiem_NCC";
            this.lbl_TimKiem_NCC.Size = new System.Drawing.Size(185, 18);
            this.lbl_TimKiem_NCC.TabIndex = 28;
            this.lbl_TimKiem_NCC.Text = "Nhập mã nhà cung cấp:";
            // 
            // btn_TimKiem_NCC
            // 
            this.btn_TimKiem_NCC.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_NCC.AnimationSpeed = 0.03F;
            this.btn_TimKiem_NCC.BaseColor1 = System.Drawing.Color.Yellow;
            this.btn_TimKiem_NCC.BaseColor2 = System.Drawing.Color.Cyan;
            this.btn_TimKiem_NCC.BorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_NCC.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_NCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_NCC.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NCC.Image = null;
            this.btn_TimKiem_NCC.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_NCC.Location = new System.Drawing.Point(1170, 79);
            this.btn_TimKiem_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_NCC.Name = "btn_TimKiem_NCC";
            this.btn_TimKiem_NCC.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_NCC.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_NCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NCC.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NCC.OnHoverImage = null;
            this.btn_TimKiem_NCC.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NCC.Size = new System.Drawing.Size(87, 50);
            this.btn_TimKiem_NCC.TabIndex = 26;
            this.btn_TimKiem_NCC.Text = "Tìm";
            // 
            // txt_TimKiem_NCC
            // 
            this.txt_TimKiem_NCC.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem_NCC.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_NCC.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem_NCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem_NCC.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_NCC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem_NCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem_NCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem_NCC.Location = new System.Drawing.Point(894, 87);
            this.txt_TimKiem_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem_NCC.Name = "txt_TimKiem_NCC";
            this.txt_TimKiem_NCC.PasswordChar = '\0';
            this.txt_TimKiem_NCC.Radius = 10;
            this.txt_TimKiem_NCC.SelectedText = "";
            this.txt_TimKiem_NCC.Size = new System.Drawing.Size(213, 42);
            this.txt_TimKiem_NCC.TabIndex = 25;
            // 
            // btn_ShowNCC
            // 
            this.btn_ShowNCC.AnimationHoverSpeed = 0.07F;
            this.btn_ShowNCC.AnimationSpeed = 0.03F;
            this.btn_ShowNCC.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShowNCC.BaseColor = System.Drawing.Color.Gold;
            this.btn_ShowNCC.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_ShowNCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ShowNCC.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ShowNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ShowNCC.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_ShowNCC.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ShowNCC.Location = new System.Drawing.Point(8, 77);
            this.btn_ShowNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowNCC.Name = "btn_ShowNCC";
            this.btn_ShowNCC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ShowNCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ShowNCC.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ShowNCC.OnHoverImage = null;
            this.btn_ShowNCC.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ShowNCC.Radius = 20;
            this.btn_ShowNCC.Size = new System.Drawing.Size(240, 52);
            this.btn_ShowNCC.TabIndex = 24;
            this.btn_ShowNCC.Text = "Hiển thị thông tin";
            // 
            // lbl_HeaderTab1NCC
            // 
            this.lbl_HeaderTab1NCC.AutoSize = true;
            this.lbl_HeaderTab1NCC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1NCC.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1NCC.Location = new System.Drawing.Point(460, 4);
            this.lbl_HeaderTab1NCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1NCC.Name = "lbl_HeaderTab1NCC";
            this.lbl_HeaderTab1NCC.Size = new System.Drawing.Size(285, 32);
            this.lbl_HeaderTab1NCC.TabIndex = 23;
            this.lbl_HeaderTab1NCC.Text = "Thông tin nhà cung cấp";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_TrangThaiHopTac);
            this.tabPage2.Controls.Add(this.lbl_TrangThaiHopTac);
            this.tabPage2.Controls.Add(this.txt_SDT);
            this.tabPage2.Controls.Add(this.lbl_SDT);
            this.tabPage2.Controls.Add(this.txt_DiaChi);
            this.tabPage2.Controls.Add(this.lbl_DiaChi);
            this.tabPage2.Controls.Add(this.txt_Email);
            this.tabPage2.Controls.Add(this.lbl_Email);
            this.tabPage2.Controls.Add(this.txt_TenNCC);
            this.tabPage2.Controls.Add(this.lbl_TenNCC);
            this.tabPage2.Controls.Add(this.txt_MaNCC);
            this.tabPage2.Controls.Add(this.lbl_MaNCC);
            this.tabPage2.Controls.Add(this.lbl_OptionsNCC);
            this.tabPage2.Controls.Add(this.btn_XoaTab2NCC);
            this.tabPage2.Controls.Add(this.btn_SuaTab2NCC);
            this.tabPage2.Controls.Add(this.btn_ThemTab2NCC);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1264, 854);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_TrangThaiHopTac
            // 
            this.txt_TrangThaiHopTac.BackColor = System.Drawing.Color.White;
            this.txt_TrangThaiHopTac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThaiHopTac.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiHopTac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThaiHopTac.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TrangThaiHopTac.Location = new System.Drawing.Point(465, 531);
            this.txt_TrangThaiHopTac.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrangThaiHopTac.Name = "txt_TrangThaiHopTac";
            this.txt_TrangThaiHopTac.PasswordChar = '\0';
            this.txt_TrangThaiHopTac.SelectedText = "";
            this.txt_TrangThaiHopTac.Size = new System.Drawing.Size(213, 42);
            this.txt_TrangThaiHopTac.TabIndex = 42;
            // 
            // lbl_TrangThaiHopTac
            // 
            this.lbl_TrangThaiHopTac.AutoSize = true;
            this.lbl_TrangThaiHopTac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiHopTac.Location = new System.Drawing.Point(157, 547);
            this.lbl_TrangThaiHopTac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiHopTac.Name = "lbl_TrangThaiHopTac";
            this.lbl_TrangThaiHopTac.Size = new System.Drawing.Size(177, 28);
            this.lbl_TrangThaiHopTac.TabIndex = 41;
            this.lbl_TrangThaiHopTac.Text = "Trạng thái hợp tác:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.White;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SDT.Location = new System.Drawing.Point(465, 473);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(213, 42);
            this.txt_SDT.TabIndex = 40;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(157, 489);
            this.lbl_SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(51, 28);
            this.lbl_SDT.TabIndex = 39;
            this.lbl_SDT.Text = "SDT:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.White;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_DiaChi.Location = new System.Drawing.Point(465, 419);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(213, 42);
            this.txt_DiaChi.TabIndex = 38;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(157, 435);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(77, 28);
            this.lbl_DiaChi.TabIndex = 37;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Email.Location = new System.Drawing.Point(465, 360);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(213, 42);
            this.txt_Email.TabIndex = 36;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(157, 376);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(64, 28);
            this.lbl_Email.TabIndex = 35;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.BackColor = System.Drawing.Color.White;
            this.txt_TenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenNCC.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TenNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenNCC.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TenNCC.Location = new System.Drawing.Point(465, 303);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.PasswordChar = '\0';
            this.txt_TenNCC.SelectedText = "";
            this.txt_TenNCC.Size = new System.Drawing.Size(213, 42);
            this.txt_TenNCC.TabIndex = 34;
            // 
            // lbl_TenNCC
            // 
            this.lbl_TenNCC.AutoSize = true;
            this.lbl_TenNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNCC.Location = new System.Drawing.Point(157, 319);
            this.lbl_TenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenNCC.Name = "lbl_TenNCC";
            this.lbl_TenNCC.Size = new System.Drawing.Size(172, 28);
            this.lbl_TenNCC.TabIndex = 33;
            this.lbl_TenNCC.Text = "Tên nhà cung cấp:";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.BackColor = System.Drawing.Color.White;
            this.txt_MaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNCC.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNCC.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNCC.Location = new System.Drawing.Point(465, 244);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.PasswordChar = '\0';
            this.txt_MaNCC.SelectedText = "";
            this.txt_MaNCC.Size = new System.Drawing.Size(213, 42);
            this.txt_MaNCC.TabIndex = 32;
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.AutoSize = true;
            this.lbl_MaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNCC.Location = new System.Drawing.Point(157, 260);
            this.lbl_MaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNCC.Name = "lbl_MaNCC";
            this.lbl_MaNCC.Size = new System.Drawing.Size(167, 28);
            this.lbl_MaNCC.TabIndex = 27;
            this.lbl_MaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lbl_OptionsNCC
            // 
            this.lbl_OptionsNCC.AutoSize = true;
            this.lbl_OptionsNCC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsNCC.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsNCC.Location = new System.Drawing.Point(390, 6);
            this.lbl_OptionsNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsNCC.Name = "lbl_OptionsNCC";
            this.lbl_OptionsNCC.Size = new System.Drawing.Size(396, 32);
            this.lbl_OptionsNCC.TabIndex = 23;
            this.lbl_OptionsNCC.Text = "Tùy chỉnh thông tin nhà cung cấp";
            // 
            // btn_XoaTab2NCC
            // 
            this.btn_XoaTab2NCC.AnimationHoverSpeed = 0.07F;
            this.btn_XoaTab2NCC.AnimationSpeed = 0.03F;
            this.btn_XoaTab2NCC.BackColor = System.Drawing.Color.Transparent;
            this.btn_XoaTab2NCC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XoaTab2NCC.BorderColor = System.Drawing.Color.Black;
            this.btn_XoaTab2NCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_XoaTab2NCC.FocusedColor = System.Drawing.Color.Empty;
            this.btn_XoaTab2NCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTab2NCC.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_XoaTab2NCC.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_XoaTab2NCC.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_XoaTab2NCC.Location = new System.Drawing.Point(845, 489);
            this.btn_XoaTab2NCC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaTab2NCC.Name = "btn_XoaTab2NCC";
            this.btn_XoaTab2NCC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_XoaTab2NCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_XoaTab2NCC.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_XoaTab2NCC.OnHoverImage = null;
            this.btn_XoaTab2NCC.OnPressedColor = System.Drawing.Color.Black;
            this.btn_XoaTab2NCC.Radius = 20;
            this.btn_XoaTab2NCC.Size = new System.Drawing.Size(144, 52);
            this.btn_XoaTab2NCC.TabIndex = 20;
            this.btn_XoaTab2NCC.Text = "Xóa";
            // 
            // btn_SuaTab2NCC
            // 
            this.btn_SuaTab2NCC.AnimationHoverSpeed = 0.07F;
            this.btn_SuaTab2NCC.AnimationSpeed = 0.03F;
            this.btn_SuaTab2NCC.BackColor = System.Drawing.Color.Transparent;
            this.btn_SuaTab2NCC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SuaTab2NCC.BorderColor = System.Drawing.Color.Black;
            this.btn_SuaTab2NCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SuaTab2NCC.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SuaTab2NCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTab2NCC.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_SuaTab2NCC.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_SuaTab2NCC.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_SuaTab2NCC.Location = new System.Drawing.Point(845, 367);
            this.btn_SuaTab2NCC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaTab2NCC.Name = "btn_SuaTab2NCC";
            this.btn_SuaTab2NCC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_SuaTab2NCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_SuaTab2NCC.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SuaTab2NCC.OnHoverImage = null;
            this.btn_SuaTab2NCC.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SuaTab2NCC.Radius = 20;
            this.btn_SuaTab2NCC.Size = new System.Drawing.Size(144, 52);
            this.btn_SuaTab2NCC.TabIndex = 21;
            this.btn_SuaTab2NCC.Text = "Sửa";
            // 
            // btn_ThemTab2NCC
            // 
            this.btn_ThemTab2NCC.AnimationHoverSpeed = 0.07F;
            this.btn_ThemTab2NCC.AnimationSpeed = 0.03F;
            this.btn_ThemTab2NCC.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThemTab2NCC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ThemTab2NCC.BorderColor = System.Drawing.Color.Black;
            this.btn_ThemTab2NCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ThemTab2NCC.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ThemTab2NCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTab2NCC.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_ThemTab2NCC.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_ThemTab2NCC.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ThemTab2NCC.Location = new System.Drawing.Point(845, 254);
            this.btn_ThemTab2NCC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemTab2NCC.Name = "btn_ThemTab2NCC";
            this.btn_ThemTab2NCC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ThemTab2NCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ThemTab2NCC.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ThemTab2NCC.OnHoverImage = null;
            this.btn_ThemTab2NCC.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ThemTab2NCC.Radius = 20;
            this.btn_ThemTab2NCC.Size = new System.Drawing.Size(144, 52);
            this.btn_ThemTab2NCC.TabIndex = 22;
            this.btn_ThemTab2NCC.Text = "Thêm";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 957);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_TimKiem_NCC;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_NCC;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem_NCC;
        private Guna.UI.WinForms.GunaButton btn_ShowNCC;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1NCC;
        private System.Windows.Forms.DataGridView dgv_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiHopTac;
        private Guna.UI.WinForms.GunaLineTextBox txt_TrangThaiHopTac;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiHopTac;
        private Guna.UI.WinForms.GunaLineTextBox txt_SDT;
        private Guna.UI.WinForms.GunaLabel lbl_SDT;
        private Guna.UI.WinForms.GunaLineTextBox txt_DiaChi;
        private Guna.UI.WinForms.GunaLabel lbl_DiaChi;
        private Guna.UI.WinForms.GunaLineTextBox txt_Email;
        private Guna.UI.WinForms.GunaLabel lbl_Email;
        private Guna.UI.WinForms.GunaLineTextBox txt_TenNCC;
        private Guna.UI.WinForms.GunaLabel lbl_TenNCC;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNCC;
        private Guna.UI.WinForms.GunaLabel lbl_MaNCC;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsNCC;
        private Guna.UI.WinForms.GunaButton btn_XoaTab2NCC;
        private Guna.UI.WinForms.GunaButton btn_SuaTab2NCC;
        private Guna.UI.WinForms.GunaButton btn_ThemTab2NCC;
    }
}