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
            this.btn_DoThiTheoNam_Refresh = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.linechart_HoaDonTheoThang = new LiveCharts.Wpf.CartesianChart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_DoanhThu = new System.Windows.Forms.TabPage();
            this.tab_LoiNhuan = new System.Windows.Forms.TabPage();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_LoiNhuan = new LiveCharts.Wpf.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.elementHost7 = new System.Windows.Forms.Integration.ElementHost();
            this.chart_SPTraGop = new LiveCharts.Wpf.CartesianChart();
            this.button6 = new System.Windows.Forms.Button();
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
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DoThiTheoNam_Refresh
            // 
            this.btn_DoThiTheoNam_Refresh.Location = new System.Drawing.Point(1057, 119);
            this.btn_DoThiTheoNam_Refresh.Name = "btn_DoThiTheoNam_Refresh";
            this.btn_DoThiTheoNam_Refresh.Size = new System.Drawing.Size(75, 43);
            this.btn_DoThiTheoNam_Refresh.TabIndex = 3;
            this.btn_DoThiTheoNam_Refresh.Text = "Refresh";
            this.btn_DoThiTheoNam_Refresh.UseVisualStyleBackColor = true;
            this.btn_DoThiTheoNam_Refresh.Click += new System.EventHandler(this.btn_DoThiTheoNam_Load_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(30, 34);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(774, 450);
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
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Location = new System.Drawing.Point(23, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1181, 618);
            this.tabControl.TabIndex = 5;
            // 
            // tab_DoanhThu
            // 
            this.tab_DoanhThu.Controls.Add(this.elementHost1);
            this.tab_DoanhThu.Controls.Add(this.btn_DoThiTheoNam_Refresh);
            this.tab_DoanhThu.Location = new System.Drawing.Point(4, 4);
            this.tab_DoanhThu.Name = "tab_DoanhThu";
            this.tab_DoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DoanhThu.Size = new System.Drawing.Size(1173, 585);
            this.tab_DoanhThu.TabIndex = 0;
            this.tab_DoanhThu.Text = "Doanh thu";
            this.tab_DoanhThu.UseVisualStyleBackColor = true;
            // 
            // tab_LoiNhuan
            // 
            this.tab_LoiNhuan.Controls.Add(this.elementHost2);
            this.tab_LoiNhuan.Controls.Add(this.button1);
            this.tab_LoiNhuan.Location = new System.Drawing.Point(4, 4);
            this.tab_LoiNhuan.Name = "tab_LoiNhuan";
            this.tab_LoiNhuan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_LoiNhuan.Size = new System.Drawing.Size(1173, 585);
            this.tab_LoiNhuan.TabIndex = 1;
            this.tab_LoiNhuan.Text = "Lợi nhuận";
            this.tab_LoiNhuan.UseVisualStyleBackColor = true;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(35, 67);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(774, 450);
            this.elementHost2.TabIndex = 6;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.chart_LoiNhuan;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1064, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.elementHost3);
            this.tabPage1.Controls.Add(this.btn_SoLuongHoaDon_Load);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 585);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Số lượng hoá đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // elementHost3
            // 
            this.elementHost3.Location = new System.Drawing.Point(35, 67);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(774, 450);
            this.elementHost3.TabIndex = 6;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.chart_HoaDon;
            // 
            // btn_SoLuongHoaDon_Load
            // 
            this.btn_SoLuongHoaDon_Load.Location = new System.Drawing.Point(1062, 152);
            this.btn_SoLuongHoaDon_Load.Name = "btn_SoLuongHoaDon_Load";
            this.btn_SoLuongHoaDon_Load.Size = new System.Drawing.Size(75, 43);
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
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1173, 585);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Số lượng phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // elementHost4
            // 
            this.elementHost4.Location = new System.Drawing.Point(35, 67);
            this.elementHost4.Name = "elementHost4";
            this.elementHost4.Size = new System.Drawing.Size(774, 450);
            this.elementHost4.TabIndex = 6;
            this.elementHost4.Text = "elementHost4";
            this.elementHost4.Child = this.chart_PhieuNhap;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1062, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.elementHost5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1173, 585);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Sản phẩm còn hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // elementHost5
            // 
            this.elementHost5.Location = new System.Drawing.Point(35, 67);
            this.elementHost5.Name = "elementHost5";
            this.elementHost5.Size = new System.Drawing.Size(774, 450);
            this.elementHost5.TabIndex = 6;
            this.elementHost5.Text = "elementHost5";
            this.elementHost5.Child = this.chart_SPConHang;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1062, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
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
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1173, 585);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Sản phẩm bán chạy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_SPBanChay_Year
            // 
            this.txt_SPBanChay_Year.Location = new System.Drawing.Point(867, 172);
            this.txt_SPBanChay_Year.Name = "txt_SPBanChay_Year";
            this.txt_SPBanChay_Year.Size = new System.Drawing.Size(270, 26);
            this.txt_SPBanChay_Year.TabIndex = 8;
            // 
            // elementHost6
            // 
            this.elementHost6.Location = new System.Drawing.Point(35, 67);
            this.elementHost6.Name = "elementHost6";
            this.elementHost6.Size = new System.Drawing.Size(774, 450);
            this.elementHost6.TabIndex = 6;
            this.elementHost6.Text = "elementHost6";
            this.elementHost6.Child = this.chart_SPBanChay;
            // 
            // btn_SPBanChay_Load
            // 
            this.btn_SPBanChay_Load.Location = new System.Drawing.Point(1062, 252);
            this.btn_SPBanChay_Load.Name = "btn_SPBanChay_Load";
            this.btn_SPBanChay_Load.Size = new System.Drawing.Size(75, 43);
            this.btn_SPBanChay_Load.TabIndex = 5;
            this.btn_SPBanChay_Load.Text = "Load";
            this.btn_SPBanChay_Load.UseVisualStyleBackColor = true;
            this.btn_SPBanChay_Load.Click += new System.EventHandler(this.btn_SPBanChay_Load_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.elementHost7);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1173, 585);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Trả góp";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // elementHost7
            // 
            this.elementHost7.Location = new System.Drawing.Point(35, 67);
            this.elementHost7.Name = "elementHost7";
            this.elementHost7.Size = new System.Drawing.Size(774, 450);
            this.elementHost7.TabIndex = 6;
            this.elementHost7.Text = "elementHost7";
            this.elementHost7.Child = this.chart_SPTraGop;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1062, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txt_PTThanhToan);
            this.tabPage6.Controls.Add(this.elementHost8);
            this.tabPage6.Controls.Add(this.btn_PTThanhToan_Load);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1173, 585);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Phương thức thanh toán";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_PTThanhToan
            // 
            this.txt_PTThanhToan.Location = new System.Drawing.Point(873, 67);
            this.txt_PTThanhToan.Name = "txt_PTThanhToan";
            this.txt_PTThanhToan.Size = new System.Drawing.Size(264, 26);
            this.txt_PTThanhToan.TabIndex = 7;
            // 
            // elementHost8
            // 
            this.elementHost8.Location = new System.Drawing.Point(35, 67);
            this.elementHost8.Name = "elementHost8";
            this.elementHost8.Size = new System.Drawing.Size(774, 450);
            this.elementHost8.TabIndex = 6;
            this.elementHost8.Text = "elementHost8";
            this.elementHost8.Child = this.chart_PTThanhToan;
            // 
            // btn_PTThanhToan_Load
            // 
            this.btn_PTThanhToan_Load.Location = new System.Drawing.Point(1062, 152);
            this.btn_PTThanhToan_Load.Name = "btn_PTThanhToan_Load";
            this.btn_PTThanhToan_Load.Size = new System.Drawing.Size(75, 43);
            this.btn_PTThanhToan_Load.TabIndex = 5;
            this.btn_PTThanhToan_Load.Text = "Refresh";
            this.btn_PTThanhToan_Load.UseVisualStyleBackColor = true;
            this.btn_PTThanhToan_Load.Click += new System.EventHandler(this.btn_PTThanhToan_Load_Click);
            // 
            // Form_VeDoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 642);
            this.Controls.Add(this.tabControl);
            this.Name = "Form_VeDoThi";
            this.Text = "Form_VeDoThi";
            this.tabControl.ResumeLayout(false);
            this.tab_DoanhThu.ResumeLayout(false);
            this.tab_LoiNhuan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.CartesianChart chart_LoiNhuan;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Integration.ElementHost elementHost7;
        private LiveCharts.Wpf.CartesianChart chart_SPTraGop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Integration.ElementHost elementHost8;
        private LiveCharts.Wpf.CartesianChart chart_PTThanhToan;
        private System.Windows.Forms.Button btn_PTThanhToan_Load;
        private System.Windows.Forms.TextBox txt_SPBanChay_Year;
        private System.Windows.Forms.TextBox txt_PTThanhToan;
    }
}