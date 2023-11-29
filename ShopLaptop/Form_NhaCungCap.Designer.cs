namespace ShopLaptop
{
    partial class Form_NhaCungCap
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
            this.dgv_NhaCungCap = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiHopTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TimKiem_NCC = new System.Windows.Forms.Label();
            this.btn_TimKiem_NhaCungCap = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.txt_TimKiem_NhaCungCap = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Show_NhaCungCap = new Guna.UI.WinForms.GunaButton();
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
            this.btn_Xoa_NhaCungCap = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_NhaCungCap = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_NhaCungCap = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_NhaCungCap);
            this.tabPage1.Controls.Add(this.lbl_TimKiem_NCC);
            this.tabPage1.Controls.Add(this.btn_TimKiem_NhaCungCap);
            this.tabPage1.Controls.Add(this.txt_TimKiem_NhaCungCap);
            this.tabPage1.Controls.Add(this.btn_Show_NhaCungCap);
            this.tabPage1.Controls.Add(this.lbl_HeaderTab1NCC);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Size = new System.Drawing.Size(1264, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_NhaCungCap
            // 
            this.dgv_NhaCungCap.AllowUserToAddRows = false;
            this.dgv_NhaCungCap.AllowUserToDeleteRows = false;
            this.dgv_NhaCungCap.AllowUserToResizeColumns = false;
            this.dgv_NhaCungCap.AllowUserToResizeRows = false;
            this.dgv_NhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_NhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhaCungCap.ColumnHeadersHeight = 80;
            this.dgv_NhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.Email,
            this.DiaChi,
            this.SDT,
            this.TrangThaiHopTac});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhaCungCap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhaCungCap.EnableHeadersVisualStyles = false;
            this.dgv_NhaCungCap.Location = new System.Drawing.Point(8, 159);
            this.dgv_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NhaCungCap.Name = "dgv_NhaCungCap";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhaCungCap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhaCungCap.RowHeadersWidth = 62;
            this.dgv_NhaCungCap.ShowCellErrors = false;
            this.dgv_NhaCungCap.ShowCellToolTips = false;
            this.dgv_NhaCungCap.ShowEditingIcon = false;
            this.dgv_NhaCungCap.ShowRowErrors = false;
            this.dgv_NhaCungCap.Size = new System.Drawing.Size(1248, 671);
            this.dgv_NhaCungCap.TabIndex = 29;
            this.dgv_NhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhaCungCap_CellContentClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 8;
            this.TenNCC.Name = "TenNCC";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // TrangThaiHopTac
            // 
            this.TrangThaiHopTac.DataPropertyName = "TrangThaiHopTac";
            this.TrangThaiHopTac.HeaderText = "Trạng thái hợp tác";
            this.TrangThaiHopTac.MinimumWidth = 8;
            this.TrangThaiHopTac.Name = "TrangThaiHopTac";
            // 
            // lbl_TimKiem_NCC
            // 
            this.lbl_TimKiem_NCC.AutoSize = true;
            this.lbl_TimKiem_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_NCC.Location = new System.Drawing.Point(859, 64);
            this.lbl_TimKiem_NCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_NCC.Name = "lbl_TimKiem_NCC";
            this.lbl_TimKiem_NCC.Size = new System.Drawing.Size(185, 18);
            this.lbl_TimKiem_NCC.TabIndex = 28;
            this.lbl_TimKiem_NCC.Text = "Nhập mã nhà cung cấp:";
            // 
            // btn_TimKiem_NhaCungCap
            // 
            this.btn_TimKiem_NhaCungCap.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_NhaCungCap.AnimationSpeed = 0.03F;
            this.btn_TimKiem_NhaCungCap.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NhaCungCap.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NhaCungCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NhaCungCap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_NhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NhaCungCap.Image = null;
            this.btn_TimKiem_NhaCungCap.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_NhaCungCap.Location = new System.Drawing.Point(1169, 79);
            this.btn_TimKiem_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_NhaCungCap.Name = "btn_TimKiem_NhaCungCap";
            this.btn_TimKiem_NhaCungCap.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_NhaCungCap.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_NhaCungCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NhaCungCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NhaCungCap.OnHoverImage = null;
            this.btn_TimKiem_NhaCungCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NhaCungCap.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_NhaCungCap.TabIndex = 26;
            this.btn_TimKiem_NhaCungCap.Text = "Tìm";
            this.btn_TimKiem_NhaCungCap.Click += new System.EventHandler(this.btn_TimKiem_NhaCungCap_Click);
            // 
            // txt_TimKiem_NhaCungCap
            // 
            this.txt_TimKiem_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem_NhaCungCap.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_NhaCungCap.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem_NhaCungCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem_NhaCungCap.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_NhaCungCap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem_NhaCungCap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem_NhaCungCap.Location = new System.Drawing.Point(863, 86);
            this.txt_TimKiem_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem_NhaCungCap.Name = "txt_TimKiem_NhaCungCap";
            this.txt_TimKiem_NhaCungCap.PasswordChar = '\0';
            this.txt_TimKiem_NhaCungCap.Radius = 10;
            this.txt_TimKiem_NhaCungCap.SelectedText = "";
            this.txt_TimKiem_NhaCungCap.Size = new System.Drawing.Size(255, 42);
            this.txt_TimKiem_NhaCungCap.TabIndex = 25;
            // 
            // btn_Show_NhaCungCap
            // 
            this.btn_Show_NhaCungCap.AnimationHoverSpeed = 0.07F;
            this.btn_Show_NhaCungCap.AnimationSpeed = 0.03F;
            this.btn_Show_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_NhaCungCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_NhaCungCap.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_NhaCungCap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_NhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_Show_NhaCungCap.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_NhaCungCap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_NhaCungCap.Location = new System.Drawing.Point(8, 76);
            this.btn_Show_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_NhaCungCap.Name = "btn_Show_NhaCungCap";
            this.btn_Show_NhaCungCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_NhaCungCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_NhaCungCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_NhaCungCap.OnHoverImage = null;
            this.btn_Show_NhaCungCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_NhaCungCap.Radius = 20;
            this.btn_Show_NhaCungCap.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_NhaCungCap.TabIndex = 24;
            this.btn_Show_NhaCungCap.Text = "Hiển thị thông tin";
            this.btn_Show_NhaCungCap.Click += new System.EventHandler(this.btn_Show_NhaCungCap_Click);
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
            this.tabPage2.Controls.Add(this.btn_Xoa_NhaCungCap);
            this.tabPage2.Controls.Add(this.btn_Sua_NhaCungCap);
            this.tabPage2.Controls.Add(this.btn_Them_NhaCungCap);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Size = new System.Drawing.Size(1264, 851);
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
            this.txt_TrangThaiHopTac.Location = new System.Drawing.Point(529, 457);
            this.txt_TrangThaiHopTac.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrangThaiHopTac.Name = "txt_TrangThaiHopTac";
            this.txt_TrangThaiHopTac.PasswordChar = '\0';
            this.txt_TrangThaiHopTac.SelectedText = "";
            this.txt_TrangThaiHopTac.Size = new System.Drawing.Size(403, 42);
            this.txt_TrangThaiHopTac.TabIndex = 42;
            // 
            // lbl_TrangThaiHopTac
            // 
            this.lbl_TrangThaiHopTac.AutoSize = true;
            this.lbl_TrangThaiHopTac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiHopTac.Location = new System.Drawing.Point(291, 471);
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
            this.txt_SDT.Location = new System.Drawing.Point(529, 407);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(403, 42);
            this.txt_SDT.TabIndex = 40;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(291, 421);
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
            this.txt_DiaChi.Location = new System.Drawing.Point(529, 357);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(403, 42);
            this.txt_DiaChi.TabIndex = 38;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(291, 371);
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
            this.txt_Email.Location = new System.Drawing.Point(529, 307);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(403, 42);
            this.txt_Email.TabIndex = 36;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(291, 321);
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
            this.txt_TenNCC.Location = new System.Drawing.Point(529, 257);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.PasswordChar = '\0';
            this.txt_TenNCC.SelectedText = "";
            this.txt_TenNCC.Size = new System.Drawing.Size(403, 42);
            this.txt_TenNCC.TabIndex = 34;
            // 
            // lbl_TenNCC
            // 
            this.lbl_TenNCC.AutoSize = true;
            this.lbl_TenNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNCC.Location = new System.Drawing.Point(291, 271);
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
            this.txt_MaNCC.Location = new System.Drawing.Point(529, 207);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.PasswordChar = '\0';
            this.txt_MaNCC.SelectedText = "";
            this.txt_MaNCC.Size = new System.Drawing.Size(403, 42);
            this.txt_MaNCC.TabIndex = 32;
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.AutoSize = true;
            this.lbl_MaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNCC.Location = new System.Drawing.Point(291, 221);
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
            this.lbl_OptionsNCC.Location = new System.Drawing.Point(403, 59);
            this.lbl_OptionsNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsNCC.Name = "lbl_OptionsNCC";
            this.lbl_OptionsNCC.Size = new System.Drawing.Size(396, 32);
            this.lbl_OptionsNCC.TabIndex = 23;
            this.lbl_OptionsNCC.Text = "Tùy chỉnh thông tin nhà cung cấp";
            // 
            // btn_Xoa_NhaCungCap
            // 
            this.btn_Xoa_NhaCungCap.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_NhaCungCap.AnimationSpeed = 0.03F;
            this.btn_Xoa_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa_NhaCungCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Xoa_NhaCungCap.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_NhaCungCap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_NhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_NhaCungCap.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_Xoa_NhaCungCap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_NhaCungCap.Location = new System.Drawing.Point(757, 580);
            this.btn_Xoa_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_NhaCungCap.Name = "btn_Xoa_NhaCungCap";
            this.btn_Xoa_NhaCungCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_NhaCungCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_NhaCungCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_NhaCungCap.OnHoverImage = null;
            this.btn_Xoa_NhaCungCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_NhaCungCap.Radius = 6;
            this.btn_Xoa_NhaCungCap.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_NhaCungCap.TabIndex = 20;
            this.btn_Xoa_NhaCungCap.Text = "Xóa";
            this.btn_Xoa_NhaCungCap.Click += new System.EventHandler(this.btn_Xoa_NhaCungCap_Click);
            // 
            // btn_Sua_NhaCungCap
            // 
            this.btn_Sua_NhaCungCap.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_NhaCungCap.AnimationSpeed = 0.03F;
            this.btn_Sua_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_NhaCungCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Sua_NhaCungCap.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_NhaCungCap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_NhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_NhaCungCap.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_Sua_NhaCungCap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_NhaCungCap.Location = new System.Drawing.Point(495, 580);
            this.btn_Sua_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_NhaCungCap.Name = "btn_Sua_NhaCungCap";
            this.btn_Sua_NhaCungCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_NhaCungCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_NhaCungCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_NhaCungCap.OnHoverImage = null;
            this.btn_Sua_NhaCungCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_NhaCungCap.Radius = 6;
            this.btn_Sua_NhaCungCap.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_NhaCungCap.TabIndex = 21;
            this.btn_Sua_NhaCungCap.Text = "Sửa";
            this.btn_Sua_NhaCungCap.Click += new System.EventHandler(this.btn_Sua_NhaCungCap_Click);
            // 
            // btn_Them_NhaCungCap
            // 
            this.btn_Them_NhaCungCap.AnimationHoverSpeed = 0.07F;
            this.btn_Them_NhaCungCap.AnimationSpeed = 0.03F;
            this.btn_Them_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_NhaCungCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_NhaCungCap.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_NhaCungCap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_NhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_Them_NhaCungCap.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_NhaCungCap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_NhaCungCap.Location = new System.Drawing.Point(231, 580);
            this.btn_Them_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_NhaCungCap.Name = "btn_Them_NhaCungCap";
            this.btn_Them_NhaCungCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_NhaCungCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_NhaCungCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_NhaCungCap.OnHoverImage = null;
            this.btn_Them_NhaCungCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_NhaCungCap.Radius = 6;
            this.btn_Them_NhaCungCap.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_NhaCungCap.TabIndex = 22;
            this.btn_Them_NhaCungCap.Text = "Thêm";
            this.btn_Them_NhaCungCap.Click += new System.EventHandler(this.btn_Them_NhaCungCap_Click);
            // 
            // Form_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1518, 935);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Form_NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_TimKiem_NCC;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_NhaCungCap;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem_NhaCungCap;
        private Guna.UI.WinForms.GunaButton btn_Show_NhaCungCap;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1NCC;
        private System.Windows.Forms.DataGridView dgv_NhaCungCap;
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
        private Guna.UI.WinForms.GunaButton btn_Xoa_NhaCungCap;
        private Guna.UI.WinForms.GunaButton btn_Sua_NhaCungCap;
        private Guna.UI.WinForms.GunaButton btn_Them_NhaCungCap;
    }
}