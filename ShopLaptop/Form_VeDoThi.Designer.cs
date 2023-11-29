namespace ShopLaptop
{
    partial class Form_VeDoThi
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
            this.btn_DoThiTheoNam_Refresh = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.linechart_HoaDonTheoThang = new LiveCharts.Wpf.CartesianChart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_DoanhThu = new System.Windows.Forms.TabPage();
            this.tab_LoiNhuan = new System.Windows.Forms.TabPage();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_LoiNhuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_LoiNhuan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_LoiNhuan_Xuat = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_HoaDon = new LiveCharts.Wpf.CartesianChart();
            this.btn_SoLuongHoaDon_Load = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.elementHost4 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_PhieuNhap = new LiveCharts.Wpf.CartesianChart();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.elementHost5 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_SPConHang = new LiveCharts.Wpf.CartesianChart();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_SPBanChay_Year = new System.Windows.Forms.TextBox();
            this.elementHost6 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_SPBanChay = new LiveCharts.Wpf.CartesianChart();
            this.btn_SPBanChay_Load = new System.Windows.Forms.Button();
            this.tab_Tra_Gop = new System.Windows.Forms.TabPage();
            this.dgv_TraGop_DaoHan = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaiSuatHangThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianTraGop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDaoHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_NgayHienTai = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txt_PTThanhToan = new System.Windows.Forms.TextBox();
            this.elementHost8 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_PTThanhToan = new LiveCharts.Wpf.CartesianChart();
            this.btn_PTThanhToan_Load = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_DoanhThu.SuspendLayout();
            this.tab_LoiNhuan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tab_Tra_Gop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraGop_DaoHan)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DoThiTheoNam_Refresh
            // 
            this.btn_DoThiTheoNam_Refresh.Location = new System.Drawing.Point(1042, 90);
            this.btn_DoThiTheoNam_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoThiTheoNam_Refresh.Name = "btn_DoThiTheoNam_Refresh";
            this.btn_DoThiTheoNam_Refresh.Size = new System.Drawing.Size(106, 50);
            this.btn_DoThiTheoNam_Refresh.TabIndex = 3;
            this.btn_DoThiTheoNam_Refresh.Text = "Refresh";
            this.btn_DoThiTheoNam_Refresh.UseVisualStyleBackColor = true;
            this.btn_DoThiTheoNam_Refresh.Click += new System.EventHandler(this.btn_DoThiTheoNam_Load_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(6, 27);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(985, 796);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.linechart_HoaDonTheoThang;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tab_DoanhThu);
            this.tabControl.Controls.Add(this.tab_LoiNhuan);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tab_Tra_Gop);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(20, 10);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 860);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab_DoanhThu
            // 
            this.tab_DoanhThu.Controls.Add(this.elementHost1);
            this.tab_DoanhThu.Controls.Add(this.btn_DoThiTheoNam_Refresh);
            this.tab_DoanhThu.Location = new System.Drawing.Point(4, 4);
            this.tab_DoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_DoanhThu.Name = "tab_DoanhThu";
            this.tab_DoanhThu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_DoanhThu.Size = new System.Drawing.Size(1256, 827);
            this.tab_DoanhThu.TabIndex = 0;
            this.tab_DoanhThu.Text = "Doanh thu";
            this.tab_DoanhThu.UseVisualStyleBackColor = true;
            // 
            // tab_LoiNhuan
            // 
            this.tab_LoiNhuan.Controls.Add(this.gunaLabel5);
            this.tab_LoiNhuan.Controls.Add(this.txt_LoiNhuan);
            this.tab_LoiNhuan.Controls.Add(this.label6);
            this.tab_LoiNhuan.Controls.Add(this.dt_LoiNhuan);
            this.tab_LoiNhuan.Controls.Add(this.label5);
            this.tab_LoiNhuan.Controls.Add(this.btn_LoiNhuan_Xuat);
            this.tab_LoiNhuan.Location = new System.Drawing.Point(4, 4);
            this.tab_LoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_LoiNhuan.Name = "tab_LoiNhuan";
            this.tab_LoiNhuan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_LoiNhuan.Size = new System.Drawing.Size(1256, 827);
            this.tab_LoiNhuan.TabIndex = 1;
            this.tab_LoiNhuan.Text = "Lợi nhuận";
            this.tab_LoiNhuan.UseVisualStyleBackColor = true;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel5.Location = new System.Drawing.Point(535, 80);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(127, 32);
            this.gunaLabel5.TabIndex = 50;
            this.gunaLabel5.Text = "Lợi nhuận";
            // 
            // txt_LoiNhuan
            // 
            this.txt_LoiNhuan.Location = new System.Drawing.Point(541, 324);
            this.txt_LoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LoiNhuan.Name = "txt_LoiNhuan";
            this.txt_LoiNhuan.Size = new System.Drawing.Size(335, 27);
            this.txt_LoiNhuan.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tổng lợi nhuận:";
            // 
            // dt_LoiNhuan
            // 
            this.dt_LoiNhuan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_LoiNhuan.Location = new System.Drawing.Point(371, 248);
            this.dt_LoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_LoiNhuan.Name = "dt_LoiNhuan";
            this.dt_LoiNhuan.Size = new System.Drawing.Size(359, 27);
            this.dt_LoiNhuan.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Chọn ngày:";
            // 
            // btn_LoiNhuan_Xuat
            // 
            this.btn_LoiNhuan_Xuat.AnimationHoverSpeed = 0.07F;
            this.btn_LoiNhuan_Xuat.AnimationSpeed = 0.03F;
            this.btn_LoiNhuan_Xuat.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_LoiNhuan_Xuat.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_LoiNhuan_Xuat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_LoiNhuan_Xuat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_LoiNhuan_Xuat.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LoiNhuan_Xuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LoiNhuan_Xuat.ForeColor = System.Drawing.Color.White;
            this.btn_LoiNhuan_Xuat.Image = null;
            this.btn_LoiNhuan_Xuat.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_LoiNhuan_Xuat.Location = new System.Drawing.Point(789, 225);
            this.btn_LoiNhuan_Xuat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoiNhuan_Xuat.Name = "btn_LoiNhuan_Xuat";
            this.btn_LoiNhuan_Xuat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_LoiNhuan_Xuat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_LoiNhuan_Xuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_LoiNhuan_Xuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LoiNhuan_Xuat.OnHoverImage = null;
            this.btn_LoiNhuan_Xuat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LoiNhuan_Xuat.Size = new System.Drawing.Size(87, 50);
            this.btn_LoiNhuan_Xuat.TabIndex = 45;
            this.btn_LoiNhuan_Xuat.Text = "Xuất";
            this.btn_LoiNhuan_Xuat.Click += new System.EventHandler(this.btn_LoiNhuan_Xuat_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.elementHost3);
            this.tabPage1.Controls.Add(this.btn_SoLuongHoaDon_Load);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1256, 827);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Số lượng hoá đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(6, 54);
            this.elementHost3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(980, 769);
            this.elementHost3.TabIndex = 6;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.chart_HoaDon;
            // 
            // btn_SoLuongHoaDon_Load
            // 
            this.btn_SoLuongHoaDon_Load.Location = new System.Drawing.Point(1049, 122);
            this.btn_SoLuongHoaDon_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SoLuongHoaDon_Load.Name = "btn_SoLuongHoaDon_Load";
            this.btn_SoLuongHoaDon_Load.Size = new System.Drawing.Size(105, 56);
            this.btn_SoLuongHoaDon_Load.TabIndex = 5;
            this.btn_SoLuongHoaDon_Load.Text = "Refresh";
            this.btn_SoLuongHoaDon_Load.UseVisualStyleBackColor = true;
            this.btn_SoLuongHoaDon_Load.Click += new System.EventHandler(this.btn_SoLuongHoaDon_Load_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.elementHost4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1256, 827);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Số lượng phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // elementHost4
            // 
            this.elementHost4.Location = new System.Drawing.Point(6, 54);
            this.elementHost4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(980, 769);
            this.elementHost4.TabIndex = 6;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.chart_PhieuNhap;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1042, 96);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.elementHost5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1256, 827);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Sản phẩm còn hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // elementHost5
            // 
            this.elementHost5.Location = new System.Drawing.Point(6, 54);
            this.elementHost5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(980, 769);
            this.elementHost5.TabIndex = 6;
            this.elementHost5.Text = "elementHost5";
            this.elementHost5.Child = this.chart_SPConHang;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1030, 87);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_SPBanChay_Year);
            this.tabPage4.Controls.Add(this.elementHost6);
            this.tabPage4.Controls.Add(this.btn_SPBanChay_Load);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1256, 827);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Sản phẩm bán chạy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_SPBanChay_Year
            // 
            this.txt_SPBanChay_Year.Location = new System.Drawing.Point(1020, 137);
            this.txt_SPBanChay_Year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SPBanChay_Year.Name = "txt_SPBanChay_Year";
            this.txt_SPBanChay_Year.Size = new System.Drawing.Size(182, 27);
            this.txt_SPBanChay_Year.TabIndex = 8;
            this.txt_SPBanChay_Year.TextChanged += new System.EventHandler(this.txt_SPBanChay_Year_TextChanged);
            // 
            // elementHost6
            // 
            this.elementHost6.Location = new System.Drawing.Point(6, 54);
            this.elementHost6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost6.Name = "elementHost6";
            this.elementHost6.Size = new System.Drawing.Size(980, 769);
            this.elementHost6.TabIndex = 6;
            this.elementHost6.Text = "elementHost6";
            this.elementHost6.Child = this.chart_SPBanChay;
            // 
            // btn_SPBanChay_Load
            // 
            this.btn_SPBanChay_Load.Location = new System.Drawing.Point(1089, 191);
            this.btn_SPBanChay_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SPBanChay_Load.Name = "btn_SPBanChay_Load";
            this.btn_SPBanChay_Load.Size = new System.Drawing.Size(113, 60);
            this.btn_SPBanChay_Load.TabIndex = 5;
            this.btn_SPBanChay_Load.Text = "Load";
            this.btn_SPBanChay_Load.UseVisualStyleBackColor = true;
            this.btn_SPBanChay_Load.Click += new System.EventHandler(this.btn_SPBanChay_Load_Click);
            // 
            // tab_Tra_Gop
            // 
            this.tab_Tra_Gop.Controls.Add(this.dgv_TraGop_DaoHan);
            this.tab_Tra_Gop.Controls.Add(this.label17);
            this.tab_Tra_Gop.Controls.Add(this.txt_NgayHienTai);
            this.tab_Tra_Gop.Controls.Add(this.gunaLabel2);
            this.tab_Tra_Gop.Location = new System.Drawing.Point(4, 4);
            this.tab_Tra_Gop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Tra_Gop.Name = "tab_Tra_Gop";
            this.tab_Tra_Gop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Tra_Gop.Size = new System.Drawing.Size(1256, 827);
            this.tab_Tra_Gop.TabIndex = 6;
            this.tab_Tra_Gop.Text = "Trả góp";
            this.tab_Tra_Gop.UseVisualStyleBackColor = true;
            // 
            // dgv_TraGop_DaoHan
            // 
            this.dgv_TraGop_DaoHan.AllowUserToAddRows = false;
            this.dgv_TraGop_DaoHan.AllowUserToDeleteRows = false;
            this.dgv_TraGop_DaoHan.AllowUserToResizeColumns = false;
            this.dgv_TraGop_DaoHan.AllowUserToResizeRows = false;
            this.dgv_TraGop_DaoHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TraGop_DaoHan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TraGop_DaoHan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TraGop_DaoHan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_TraGop_DaoHan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TraGop_DaoHan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TraGop_DaoHan.ColumnHeadersHeight = 80;
            this.dgv_TraGop_DaoHan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.LaiSuatHangThang,
            this.TienTraTruoc,
            this.TienConLai,
            this.ThoiGianTraGop,
            this.NgayBatDau,
            this.NgayDaoHan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TraGop_DaoHan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TraGop_DaoHan.EnableHeadersVisualStyles = false;
            this.dgv_TraGop_DaoHan.Location = new System.Drawing.Point(27, 163);
            this.dgv_TraGop_DaoHan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_TraGop_DaoHan.Name = "dgv_TraGop_DaoHan";
            this.dgv_TraGop_DaoHan.RowHeadersWidth = 62;
            this.dgv_TraGop_DaoHan.Size = new System.Drawing.Size(1183, 656);
            this.dgv_TraGop_DaoHan.TabIndex = 42;
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
            // LaiSuatHangThang
            // 
            this.LaiSuatHangThang.DataPropertyName = "LaiSuatHangThang";
            this.LaiSuatHangThang.HeaderText = "Lãi suất hàng tháng";
            this.LaiSuatHangThang.MinimumWidth = 8;
            this.LaiSuatHangThang.Name = "LaiSuatHangThang";
            // 
            // TienTraTruoc
            // 
            this.TienTraTruoc.DataPropertyName = "TienTraTruoc";
            this.TienTraTruoc.HeaderText = "Tiền trả trước";
            this.TienTraTruoc.MinimumWidth = 8;
            this.TienTraTruoc.Name = "TienTraTruoc";
            // 
            // TienConLai
            // 
            this.TienConLai.DataPropertyName = "TienConLai";
            this.TienConLai.HeaderText = "Tiền còn lại";
            this.TienConLai.MinimumWidth = 8;
            this.TienConLai.Name = "TienConLai";
            // 
            // ThoiGianTraGop
            // 
            this.ThoiGianTraGop.DataPropertyName = "ThoiGianTraGop";
            this.ThoiGianTraGop.HeaderText = "Thời gian trả góp";
            this.ThoiGianTraGop.MinimumWidth = 8;
            this.ThoiGianTraGop.Name = "ThoiGianTraGop";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 8;
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayDaoHan
            // 
            this.NgayDaoHan.DataPropertyName = "NgayDaoHan";
            this.NgayDaoHan.HeaderText = "Ngày đáo hạn";
            this.NgayDaoHan.MinimumWidth = 6;
            this.NgayDaoHan.Name = "NgayDaoHan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(855, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 20);
            this.label17.TabIndex = 41;
            this.label17.Text = "Ngày hiện tại:";
            // 
            // txt_NgayHienTai
            // 
            this.txt_NgayHienTai.BackColor = System.Drawing.Color.White;
            this.txt_NgayHienTai.Location = new System.Drawing.Point(1042, 77);
            this.txt_NgayHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgayHienTai.Name = "txt_NgayHienTai";
            this.txt_NgayHienTai.ReadOnly = true;
            this.txt_NgayHienTai.Size = new System.Drawing.Size(141, 27);
            this.txt_NgayHienTai.TabIndex = 40;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel2.Location = new System.Drawing.Point(433, 16);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(321, 32);
            this.gunaLabel2.TabIndex = 39;
            this.gunaLabel2.Text = "Danh sách trả góp đáo hạn";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txt_PTThanhToan);
            this.tabPage6.Controls.Add(this.elementHost8);
            this.tabPage6.Controls.Add(this.btn_PTThanhToan_Load);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Size = new System.Drawing.Size(1256, 827);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Phương thức thanh toán";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_PTThanhToan
            // 
            this.txt_PTThanhToan.Location = new System.Drawing.Point(1022, 103);
            this.txt_PTThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PTThanhToan.Name = "txt_PTThanhToan";
            this.txt_PTThanhToan.Size = new System.Drawing.Size(185, 27);
            this.txt_PTThanhToan.TabIndex = 7;
            // 
            // elementHost8
            // 
            this.elementHost8.Location = new System.Drawing.Point(6, 54);
            this.elementHost8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost8.Name = "elementHost8";
            this.elementHost8.Size = new System.Drawing.Size(980, 769);
            this.elementHost8.TabIndex = 6;
            this.elementHost8.Text = "elementHost8";
            this.elementHost8.Child = this.chart_PTThanhToan;
            // 
            // btn_PTThanhToan_Load
            // 
            this.btn_PTThanhToan_Load.Location = new System.Drawing.Point(1101, 170);
            this.btn_PTThanhToan_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PTThanhToan_Load.Name = "btn_PTThanhToan_Load";
            this.btn_PTThanhToan_Load.Size = new System.Drawing.Size(106, 60);
            this.btn_PTThanhToan_Load.TabIndex = 5;
            this.btn_PTThanhToan_Load.Text = "Refresh";
            this.btn_PTThanhToan_Load.UseVisualStyleBackColor = true;
            this.btn_PTThanhToan_Load.Click += new System.EventHandler(this.btn_PTThanhToan_Load_Click);
            // 
            // Form_VeDoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 893);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_VeDoThi";
            this.Text = "Form_VeDoThi";
            this.tabControl.ResumeLayout(false);
            this.tab_DoanhThu.ResumeLayout(false);
            this.tab_LoiNhuan.ResumeLayout(false);
            this.tab_LoiNhuan.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tab_Tra_Gop.ResumeLayout(false);
            this.tab_Tra_Gop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraGop_DaoHan)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienThanhToanHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuongThucThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_DoThiTheoNam_Refresh;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart linechart_HoaDonTheoThang;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_DoanhThu;
        private System.Windows.Forms.TabPage tab_LoiNhuan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tab_Tra_Gop;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private LiveCharts.Wpf.CartesianChart chart_HoaDon;
        private System.Windows.Forms.Button btn_SoLuongHoaDon_Load;
        private System.Windows.Forms.Integration.ElementHost elementHost4;
        private LiveCharts.Wpf.CartesianChart chart_PhieuNhap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Integration.ElementHost elementHost5;
        private LiveCharts.Wpf.CartesianChart chart_SPConHang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Integration.ElementHost elementHost6;
        private LiveCharts.Wpf.CartesianChart chart_SPBanChay;
        private System.Windows.Forms.Button btn_SPBanChay_Load;
        private System.Windows.Forms.Integration.ElementHost elementHost8;
        private LiveCharts.Wpf.CartesianChart chart_PTThanhToan;
        private System.Windows.Forms.Button btn_PTThanhToan_Load;
        private System.Windows.Forms.TextBox txt_SPBanChay_Year;
        private System.Windows.Forms.TextBox txt_PTThanhToan;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.TextBox txt_LoiNhuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_LoiNhuan;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_LoiNhuan_Xuat;
        private System.Windows.Forms.DataGridView dgv_TraGop_DaoHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaiSuatHangThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianTraGop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDaoHan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_NgayHienTai;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}