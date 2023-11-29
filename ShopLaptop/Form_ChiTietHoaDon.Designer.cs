
namespace ShopLaptop
{
    partial class Form_ChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChiTietHoaDon));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanTungSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienTungSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Show_ChiTietHD = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1PNK = new Guna.UI.WinForms.GunaLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_KhuyenMai = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsPNK = new Guna.UI.WinForms.GunaLabel();
            this.txt_ThanhTienTungSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_ThueVAT = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_GiaBanTungSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaHD = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SoLuongSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaLT = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TrangThaiThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PhuongThucThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SoTienThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNCC_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNK = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_CTHD = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_CTHD = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_CTHD = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(-5, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_ChiTietHD);
            this.tabPage1.Controls.Add(this.btn_Show_ChiTietHD);
            this.tabPage1.Controls.Add(this.lbl_HeaderTab1PNK);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.AllowUserToAddRows = false;
            this.dgv_ChiTietHD.AllowUserToDeleteRows = false;
            this.dgv_ChiTietHD.AllowUserToResizeColumns = false;
            this.dgv_ChiTietHD.AllowUserToResizeRows = false;
            this.dgv_ChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ChiTietHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ChiTietHD.ColumnHeadersHeight = 80;
            this.dgv_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.MaHD,
            this.SoLuongSP,
            this.GiaBanTungSP,
            this.ThueVAT,
            this.KhuyenMai,
            this.ThanhTienTungSP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChiTietHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ChiTietHD.EnableHeadersVisualStyles = false;
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(8, 150);
            this.dgv_ChiTietHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.RowHeadersWidth = 51;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(1249, 677);
            this.dgv_ChiTietHD.TabIndex = 19;
            this.dgv_ChiTietHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietHD_CellContentClick);
            // 
            // MaLT
            // 
            this.MaLT.DataPropertyName = "MaLT";
            this.MaLT.HeaderText = "Mã Laptop";
            this.MaLT.MinimumWidth = 6;
            this.MaLT.Name = "MaLT";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // SoLuongSP
            // 
            this.SoLuongSP.DataPropertyName = "SoLuongSP";
            this.SoLuongSP.HeaderText = "Số lượng sản phẩm";
            this.SoLuongSP.MinimumWidth = 6;
            this.SoLuongSP.Name = "SoLuongSP";
            // 
            // GiaBanTungSP
            // 
            this.GiaBanTungSP.DataPropertyName = "GiaBanTungSP";
            this.GiaBanTungSP.HeaderText = "Giá bán từng sản phẩm";
            this.GiaBanTungSP.MinimumWidth = 6;
            this.GiaBanTungSP.Name = "GiaBanTungSP";
            // 
            // ThueVAT
            // 
            this.ThueVAT.DataPropertyName = "ThueVAT";
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.MinimumWidth = 6;
            this.ThueVAT.Name = "ThueVAT";
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Khuyến mãi";
            this.KhuyenMai.MinimumWidth = 6;
            this.KhuyenMai.Name = "KhuyenMai";
            // 
            // ThanhTienTungSP
            // 
            this.ThanhTienTungSP.DataPropertyName = "ThanhTienTungSP";
            this.ThanhTienTungSP.HeaderText = "Thành tiền từng sản phẩm";
            this.ThanhTienTungSP.MinimumWidth = 6;
            this.ThanhTienTungSP.Name = "ThanhTienTungSP";
            // 
            // btn_Show_ChiTietHD
            // 
            this.btn_Show_ChiTietHD.AnimationHoverSpeed = 0.07F;
            this.btn_Show_ChiTietHD.AnimationSpeed = 0.03F;
            this.btn_Show_ChiTietHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_ChiTietHD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_ChiTietHD.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_ChiTietHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_ChiTietHD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_ChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_ChiTietHD.ForeColor = System.Drawing.Color.White;
            this.btn_Show_ChiTietHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_Show_ChiTietHD.Image")));
            this.btn_Show_ChiTietHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_ChiTietHD.Location = new System.Drawing.Point(8, 70);
            this.btn_Show_ChiTietHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_ChiTietHD.Name = "btn_Show_ChiTietHD";
            this.btn_Show_ChiTietHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_ChiTietHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_ChiTietHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_ChiTietHD.OnHoverImage = null;
            this.btn_Show_ChiTietHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_ChiTietHD.Radius = 20;
            this.btn_Show_ChiTietHD.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_ChiTietHD.TabIndex = 18;
            this.btn_Show_ChiTietHD.Text = "Hiển thị thông tin";
            this.btn_Show_ChiTietHD.Click += new System.EventHandler(this.btn_Show_ChiTietHD_Click);
            // 
            // lbl_HeaderTab1PNK
            // 
            this.lbl_HeaderTab1PNK.AutoSize = true;
            this.lbl_HeaderTab1PNK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1PNK.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1PNK.Location = new System.Drawing.Point(427, 17);
            this.lbl_HeaderTab1PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1PNK.Name = "lbl_HeaderTab1PNK";
            this.lbl_HeaderTab1PNK.Size = new System.Drawing.Size(196, 32);
            this.lbl_HeaderTab1PNK.TabIndex = 17;
            this.lbl_HeaderTab1PNK.Text = "Chi tiết hóa đơn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_KhuyenMai);
            this.tabPage2.Controls.Add(this.gunaLabel1);
            this.tabPage2.Controls.Add(this.lbl_OptionsPNK);
            this.tabPage2.Controls.Add(this.txt_ThanhTienTungSP);
            this.tabPage2.Controls.Add(this.txt_ThueVAT);
            this.tabPage2.Controls.Add(this.txt_GiaBanTungSP);
            this.tabPage2.Controls.Add(this.txt_MaHD);
            this.tabPage2.Controls.Add(this.txt_SoLuongSP);
            this.tabPage2.Controls.Add(this.txt_MaLT);
            this.tabPage2.Controls.Add(this.lbl_TrangThaiThanhToan_PNK);
            this.tabPage2.Controls.Add(this.lbl_PhuongThucThanhToan_PNK);
            this.tabPage2.Controls.Add(this.lbl_SoTienThanhToan_PNK);
            this.tabPage2.Controls.Add(this.lbl_MaNV_PNK);
            this.tabPage2.Controls.Add(this.lbl_MaNCC_PNK);
            this.tabPage2.Controls.Add(this.lbl_MaNK);
            this.tabPage2.Controls.Add(this.btn_Xoa_CTHD);
            this.tabPage2.Controls.Add(this.btn_Sua_CTHD);
            this.tabPage2.Controls.Add(this.btn_Them_CTHD);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1249, 851);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.BackColor = System.Drawing.Color.White;
            this.txt_KhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KhuyenMai.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_KhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_KhuyenMai.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_KhuyenMai.Location = new System.Drawing.Point(563, 450);
            this.txt_KhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.PasswordChar = '\0';
            this.txt_KhuyenMai.SelectedText = "";
            this.txt_KhuyenMai.Size = new System.Drawing.Size(397, 37);
            this.txt_KhuyenMai.TabIndex = 37;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(240, 459);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 28);
            this.gunaLabel1.TabIndex = 36;
            this.gunaLabel1.Text = "Khuyến mãi:";
            // 
            // lbl_OptionsPNK
            // 
            this.lbl_OptionsPNK.AutoSize = true;
            this.lbl_OptionsPNK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsPNK.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsPNK.Location = new System.Drawing.Point(380, 60);
            this.lbl_OptionsPNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsPNK.Name = "lbl_OptionsPNK";
            this.lbl_OptionsPNK.Size = new System.Drawing.Size(422, 32);
            this.lbl_OptionsPNK.TabIndex = 35;
            this.lbl_OptionsPNK.Text = "Tùy chỉnh thông tin chi tiết hóa đơn";
            // 
            // txt_ThanhTienTungSP
            // 
            this.txt_ThanhTienTungSP.BackColor = System.Drawing.Color.White;
            this.txt_ThanhTienTungSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThanhTienTungSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ThanhTienTungSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThanhTienTungSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_ThanhTienTungSP.Location = new System.Drawing.Point(563, 495);
            this.txt_ThanhTienTungSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThanhTienTungSP.Name = "txt_ThanhTienTungSP";
            this.txt_ThanhTienTungSP.PasswordChar = '\0';
            this.txt_ThanhTienTungSP.SelectedText = "";
            this.txt_ThanhTienTungSP.Size = new System.Drawing.Size(397, 37);
            this.txt_ThanhTienTungSP.TabIndex = 29;
            // 
            // txt_ThueVAT
            // 
            this.txt_ThueVAT.BackColor = System.Drawing.Color.White;
            this.txt_ThueVAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThueVAT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ThueVAT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThueVAT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_ThueVAT.Location = new System.Drawing.Point(563, 405);
            this.txt_ThueVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThueVAT.Name = "txt_ThueVAT";
            this.txt_ThueVAT.PasswordChar = '\0';
            this.txt_ThueVAT.SelectedText = "";
            this.txt_ThueVAT.Size = new System.Drawing.Size(397, 37);
            this.txt_ThueVAT.TabIndex = 30;
            // 
            // txt_GiaBanTungSP
            // 
            this.txt_GiaBanTungSP.BackColor = System.Drawing.Color.White;
            this.txt_GiaBanTungSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GiaBanTungSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_GiaBanTungSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_GiaBanTungSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_GiaBanTungSP.Location = new System.Drawing.Point(563, 360);
            this.txt_GiaBanTungSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaBanTungSP.Name = "txt_GiaBanTungSP";
            this.txt_GiaBanTungSP.PasswordChar = '\0';
            this.txt_GiaBanTungSP.SelectedText = "";
            this.txt_GiaBanTungSP.Size = new System.Drawing.Size(397, 37);
            this.txt_GiaBanTungSP.TabIndex = 31;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BackColor = System.Drawing.Color.White;
            this.txt_MaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaHD.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaHD.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaHD.Location = new System.Drawing.Point(563, 270);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.PasswordChar = '\0';
            this.txt_MaHD.SelectedText = "";
            this.txt_MaHD.Size = new System.Drawing.Size(397, 37);
            this.txt_MaHD.TabIndex = 32;
            // 
            // txt_SoLuongSP
            // 
            this.txt_SoLuongSP.BackColor = System.Drawing.Color.White;
            this.txt_SoLuongSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuongSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoLuongSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoLuongSP.Location = new System.Drawing.Point(563, 315);
            this.txt_SoLuongSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuongSP.Name = "txt_SoLuongSP";
            this.txt_SoLuongSP.PasswordChar = '\0';
            this.txt_SoLuongSP.SelectedText = "";
            this.txt_SoLuongSP.Size = new System.Drawing.Size(397, 37);
            this.txt_SoLuongSP.TabIndex = 33;
            // 
            // txt_MaLT
            // 
            this.txt_MaLT.BackColor = System.Drawing.Color.White;
            this.txt_MaLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaLT.Location = new System.Drawing.Point(563, 225);
            this.txt_MaLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLT.Name = "txt_MaLT";
            this.txt_MaLT.PasswordChar = '\0';
            this.txt_MaLT.SelectedText = "";
            this.txt_MaLT.Size = new System.Drawing.Size(397, 37);
            this.txt_MaLT.TabIndex = 34;
            // 
            // lbl_TrangThaiThanhToan_PNK
            // 
            this.lbl_TrangThaiThanhToan_PNK.AutoSize = true;
            this.lbl_TrangThaiThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiThanhToan_PNK.Location = new System.Drawing.Point(240, 504);
            this.lbl_TrangThaiThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiThanhToan_PNK.Name = "lbl_TrangThaiThanhToan_PNK";
            this.lbl_TrangThaiThanhToan_PNK.Size = new System.Drawing.Size(247, 28);
            this.lbl_TrangThaiThanhToan_PNK.TabIndex = 23;
            this.lbl_TrangThaiThanhToan_PNK.Text = "Thành tiền từng sản phẩm:";
            // 
            // lbl_PhuongThucThanhToan_PNK
            // 
            this.lbl_PhuongThucThanhToan_PNK.AutoSize = true;
            this.lbl_PhuongThucThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhuongThucThanhToan_PNK.Location = new System.Drawing.Point(240, 414);
            this.lbl_PhuongThucThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhuongThucThanhToan_PNK.Name = "lbl_PhuongThucThanhToan_PNK";
            this.lbl_PhuongThucThanhToan_PNK.Size = new System.Drawing.Size(102, 28);
            this.lbl_PhuongThucThanhToan_PNK.TabIndex = 24;
            this.lbl_PhuongThucThanhToan_PNK.Text = "Thuế VAT:";
            // 
            // lbl_SoTienThanhToan_PNK
            // 
            this.lbl_SoTienThanhToan_PNK.AutoSize = true;
            this.lbl_SoTienThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienThanhToan_PNK.Location = new System.Drawing.Point(240, 373);
            this.lbl_SoTienThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTienThanhToan_PNK.Name = "lbl_SoTienThanhToan_PNK";
            this.lbl_SoTienThanhToan_PNK.Size = new System.Drawing.Size(234, 28);
            this.lbl_SoTienThanhToan_PNK.TabIndex = 25;
            this.lbl_SoTienThanhToan_PNK.Text = "Giá nhập từng sản phẩm:";
            // 
            // lbl_MaNV_PNK
            // 
            this.lbl_MaNV_PNK.AutoSize = true;
            this.lbl_MaNV_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV_PNK.Location = new System.Drawing.Point(236, 324);
            this.lbl_MaNV_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV_PNK.Name = "lbl_MaNV_PNK";
            this.lbl_MaNV_PNK.Size = new System.Drawing.Size(185, 28);
            this.lbl_MaNV_PNK.TabIndex = 26;
            this.lbl_MaNV_PNK.Text = "Số lượng sản phẩm:";
            // 
            // lbl_MaNCC_PNK
            // 
            this.lbl_MaNCC_PNK.AutoSize = true;
            this.lbl_MaNCC_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNCC_PNK.Location = new System.Drawing.Point(240, 279);
            this.lbl_MaNCC_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNCC_PNK.Name = "lbl_MaNCC_PNK";
            this.lbl_MaNCC_PNK.Size = new System.Drawing.Size(121, 28);
            this.lbl_MaNCC_PNK.TabIndex = 27;
            this.lbl_MaNCC_PNK.Text = "Mã hóa đơn:";
            // 
            // lbl_MaNK
            // 
            this.lbl_MaNK.AutoSize = true;
            this.lbl_MaNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNK.Location = new System.Drawing.Point(240, 234);
            this.lbl_MaNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNK.Name = "lbl_MaNK";
            this.lbl_MaNK.Size = new System.Drawing.Size(108, 28);
            this.lbl_MaNK.TabIndex = 28;
            this.lbl_MaNK.Text = "Mã Laptop:";
            // 
            // btn_Xoa_CTHD
            // 
            this.btn_Xoa_CTHD.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_CTHD.AnimationSpeed = 0.03F;
            this.btn_Xoa_CTHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa_CTHD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Xoa_CTHD.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_CTHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_CTHD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_CTHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_CTHD.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_CTHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa_CTHD.Image")));
            this.btn_Xoa_CTHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_CTHD.Location = new System.Drawing.Point(740, 612);
            this.btn_Xoa_CTHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_CTHD.Name = "btn_Xoa_CTHD";
            this.btn_Xoa_CTHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_CTHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_CTHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_CTHD.OnHoverImage = null;
            this.btn_Xoa_CTHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_CTHD.Radius = 6;
            this.btn_Xoa_CTHD.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_CTHD.TabIndex = 20;
            this.btn_Xoa_CTHD.Text = "Xóa";
            this.btn_Xoa_CTHD.Click += new System.EventHandler(this.btn_Xoa_CTHD_Click);
            // 
            // btn_Sua_CTHD
            // 
            this.btn_Sua_CTHD.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_CTHD.AnimationSpeed = 0.03F;
            this.btn_Sua_CTHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_CTHD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Sua_CTHD.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_CTHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_CTHD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_CTHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_CTHD.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_CTHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua_CTHD.Image")));
            this.btn_Sua_CTHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_CTHD.Location = new System.Drawing.Point(476, 612);
            this.btn_Sua_CTHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_CTHD.Name = "btn_Sua_CTHD";
            this.btn_Sua_CTHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_CTHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_CTHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_CTHD.OnHoverImage = null;
            this.btn_Sua_CTHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_CTHD.Radius = 6;
            this.btn_Sua_CTHD.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_CTHD.TabIndex = 21;
            this.btn_Sua_CTHD.Text = "Sửa";
            this.btn_Sua_CTHD.Click += new System.EventHandler(this.btn_Sua_CTHD_Click);
            // 
            // btn_Them_CTHD
            // 
            this.btn_Them_CTHD.AnimationHoverSpeed = 0.07F;
            this.btn_Them_CTHD.AnimationSpeed = 0.03F;
            this.btn_Them_CTHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_CTHD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_CTHD.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_CTHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_CTHD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_CTHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_CTHD.ForeColor = System.Drawing.Color.White;
            this.btn_Them_CTHD.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_CTHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_CTHD.Location = new System.Drawing.Point(212, 612);
            this.btn_Them_CTHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_CTHD.Name = "btn_Them_CTHD";
            this.btn_Them_CTHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_CTHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_CTHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_CTHD.OnHoverImage = null;
            this.btn_Them_CTHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_CTHD.Radius = 6;
            this.btn_Them_CTHD.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_CTHD.TabIndex = 22;
            this.btn_Them_CTHD.Text = "Thêm";
            this.btn_Them_CTHD.Click += new System.EventHandler(this.btn_Them_CTHD_Click);
            // 
            // Form_ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 998);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanTungSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienTungSP;
        private Guna.UI.WinForms.GunaButton btn_Show_ChiTietHD;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_KhuyenMai;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsPNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_ThanhTienTungSP;
        private Guna.UI.WinForms.GunaLineTextBox txt_ThueVAT;
        private Guna.UI.WinForms.GunaLineTextBox txt_GiaBanTungSP;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaHD;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoLuongSP;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaLT;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_PhuongThucThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_SoTienThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNCC_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNK;
        private Guna.UI.WinForms.GunaButton btn_Xoa_CTHD;
        private Guna.UI.WinForms.GunaButton btn_Sua_CTHD;
        private Guna.UI.WinForms.GunaButton btn_Them_CTHD;
    }
}