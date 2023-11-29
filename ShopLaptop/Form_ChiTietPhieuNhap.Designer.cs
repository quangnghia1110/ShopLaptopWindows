
namespace ShopLaptop
{
    partial class Form_ChiTietPhieuNhap
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
            this.dgv_ChiTietPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhapTungSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienTungSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Show_ChiTietPhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1PNK = new Guna.UI.WinForms.GunaLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_OptionsPNK = new Guna.UI.WinForms.GunaLabel();
            this.txt_ThanhTienTungSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_ThueVAT = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_GiaNhapTungSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNK = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SoLuongSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaLT = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TrangThaiThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PhuongThucThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SoTienThanhToan_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNCC_PNK = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNK = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhapKho)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(2, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_ChiTietPhieuNhapKho);
            this.tabPage1.Controls.Add(this.btn_Show_ChiTietPhieuNhapKho);
            this.tabPage1.Controls.Add(this.lbl_HeaderTab1PNK);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 827);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_ChiTietPhieuNhapKho
            // 
            this.dgv_ChiTietPhieuNhapKho.AllowUserToAddRows = false;
            this.dgv_ChiTietPhieuNhapKho.AllowUserToDeleteRows = false;
            this.dgv_ChiTietPhieuNhapKho.AllowUserToResizeColumns = false;
            this.dgv_ChiTietPhieuNhapKho.AllowUserToResizeRows = false;
            this.dgv_ChiTietPhieuNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietPhieuNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietPhieuNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ChiTietPhieuNhapKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTietPhieuNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ChiTietPhieuNhapKho.ColumnHeadersHeight = 80;
            this.dgv_ChiTietPhieuNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.MaNK,
            this.SoLuongSP,
            this.GiaNhapTungSP,
            this.ThueVAT,
            this.ThanhTienTungSP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChiTietPhieuNhapKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ChiTietPhieuNhapKho.EnableHeadersVisualStyles = false;
            this.dgv_ChiTietPhieuNhapKho.Location = new System.Drawing.Point(7, 136);
            this.dgv_ChiTietPhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ChiTietPhieuNhapKho.Name = "dgv_ChiTietPhieuNhapKho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTietPhieuNhapKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ChiTietPhieuNhapKho.RowHeadersWidth = 51;
            this.dgv_ChiTietPhieuNhapKho.ShowCellErrors = false;
            this.dgv_ChiTietPhieuNhapKho.ShowCellToolTips = false;
            this.dgv_ChiTietPhieuNhapKho.ShowEditingIcon = false;
            this.dgv_ChiTietPhieuNhapKho.ShowRowErrors = false;
            this.dgv_ChiTietPhieuNhapKho.Size = new System.Drawing.Size(1250, 698);
            this.dgv_ChiTietPhieuNhapKho.TabIndex = 16;
            this.dgv_ChiTietPhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuNhapKho_CellContentClick);
            // 
            // MaLT
            // 
            this.MaLT.DataPropertyName = "MaLT";
            this.MaLT.HeaderText = "Mã Laptop";
            this.MaLT.MinimumWidth = 6;
            this.MaLT.Name = "MaLT";
            // 
            // MaNK
            // 
            this.MaNK.DataPropertyName = "MaNK";
            this.MaNK.HeaderText = "Mã nhập kho";
            this.MaNK.MinimumWidth = 6;
            this.MaNK.Name = "MaNK";
            // 
            // SoLuongSP
            // 
            this.SoLuongSP.DataPropertyName = "SoLuongSP";
            this.SoLuongSP.HeaderText = "Số lượng sản phẩm";
            this.SoLuongSP.MinimumWidth = 6;
            this.SoLuongSP.Name = "SoLuongSP";
            // 
            // GiaNhapTungSP
            // 
            this.GiaNhapTungSP.DataPropertyName = "GiaNhapTungSP";
            this.GiaNhapTungSP.HeaderText = "Giá nhập từng sản phẩm";
            this.GiaNhapTungSP.MinimumWidth = 6;
            this.GiaNhapTungSP.Name = "GiaNhapTungSP";
            // 
            // ThueVAT
            // 
            this.ThueVAT.DataPropertyName = "ThueVAT";
            this.ThueVAT.HeaderText = "Thuế VAT";
            this.ThueVAT.MinimumWidth = 6;
            this.ThueVAT.Name = "ThueVAT";
            // 
            // ThanhTienTungSP
            // 
            this.ThanhTienTungSP.DataPropertyName = "ThanhTienTungSP";
            this.ThanhTienTungSP.HeaderText = "Thành tiền từng sản phẩm";
            this.ThanhTienTungSP.MinimumWidth = 6;
            this.ThanhTienTungSP.Name = "ThanhTienTungSP";
            // 
            // btn_Show_ChiTietPhieuNhapKho
            // 
            this.btn_Show_ChiTietPhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_Show_ChiTietPhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_Show_ChiTietPhieuNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_ChiTietPhieuNhapKho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_ChiTietPhieuNhapKho.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_ChiTietPhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_ChiTietPhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_ChiTietPhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_ChiTietPhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_Show_ChiTietPhieuNhapKho.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_ChiTietPhieuNhapKho.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_ChiTietPhieuNhapKho.Location = new System.Drawing.Point(7, 56);
            this.btn_Show_ChiTietPhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show_ChiTietPhieuNhapKho.Name = "btn_Show_ChiTietPhieuNhapKho";
            this.btn_Show_ChiTietPhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_ChiTietPhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_ChiTietPhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_ChiTietPhieuNhapKho.OnHoverImage = null;
            this.btn_Show_ChiTietPhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_ChiTietPhieuNhapKho.Radius = 20;
            this.btn_Show_ChiTietPhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_ChiTietPhieuNhapKho.TabIndex = 15;
            this.btn_Show_ChiTietPhieuNhapKho.Text = "Hiển thị thông tin";
            this.btn_Show_ChiTietPhieuNhapKho.Click += new System.EventHandler(this.btn_Show_ChiTietPhieuNhapKho_Click);
            // 
            // lbl_HeaderTab1PNK
            // 
            this.lbl_HeaderTab1PNK.AutoSize = true;
            this.lbl_HeaderTab1PNK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1PNK.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1PNK.Location = new System.Drawing.Point(426, 3);
            this.lbl_HeaderTab1PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1PNK.Name = "lbl_HeaderTab1PNK";
            this.lbl_HeaderTab1PNK.Size = new System.Drawing.Size(279, 32);
            this.lbl_HeaderTab1PNK.TabIndex = 14;
            this.lbl_HeaderTab1PNK.Text = "Chi tiết phiếu nhập kho";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_OptionsPNK);
            this.tabPage2.Controls.Add(this.txt_ThanhTienTungSP);
            this.tabPage2.Controls.Add(this.txt_ThueVAT);
            this.tabPage2.Controls.Add(this.txt_GiaNhapTungSP);
            this.tabPage2.Controls.Add(this.txt_MaNK);
            this.tabPage2.Controls.Add(this.txt_SoLuongSP);
            this.tabPage2.Controls.Add(this.txt_MaLT);
            this.tabPage2.Controls.Add(this.lbl_TrangThaiThanhToan_PNK);
            this.tabPage2.Controls.Add(this.lbl_PhuongThucThanhToan_PNK);
            this.tabPage2.Controls.Add(this.lbl_SoTienThanhToan_PNK);
            this.tabPage2.Controls.Add(this.lbl_MaNV_PNK);
            this.tabPage2.Controls.Add(this.lbl_MaNCC_PNK);
            this.tabPage2.Controls.Add(this.lbl_MaNK);
            this.tabPage2.Controls.Add(this.btn_Xoa_PhieuNhapKho);
            this.tabPage2.Controls.Add(this.btn_Sua_PhieuNhapKho);
            this.tabPage2.Controls.Add(this.btn_Them_PhieuNhapKho);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 851);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_OptionsPNK
            // 
            this.lbl_OptionsPNK.AutoSize = true;
            this.lbl_OptionsPNK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsPNK.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsPNK.Location = new System.Drawing.Point(380, 60);
            this.lbl_OptionsPNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsPNK.Name = "lbl_OptionsPNK";
            this.lbl_OptionsPNK.Size = new System.Drawing.Size(505, 32);
            this.lbl_OptionsPNK.TabIndex = 19;
            this.lbl_OptionsPNK.Text = "Tùy chỉnh thông tin chi tiết phiếu nhập kho";
            // 
            // txt_ThanhTienTungSP
            // 
            this.txt_ThanhTienTungSP.BackColor = System.Drawing.Color.White;
            this.txt_ThanhTienTungSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThanhTienTungSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ThanhTienTungSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThanhTienTungSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_ThanhTienTungSP.Location = new System.Drawing.Point(617, 494);
            this.txt_ThanhTienTungSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThanhTienTungSP.Name = "txt_ThanhTienTungSP";
            this.txt_ThanhTienTungSP.PasswordChar = '\0';
            this.txt_ThanhTienTungSP.SelectedText = "";
            this.txt_ThanhTienTungSP.Size = new System.Drawing.Size(363, 37);
            this.txt_ThanhTienTungSP.TabIndex = 13;
            // 
            // txt_ThueVAT
            // 
            this.txt_ThueVAT.BackColor = System.Drawing.Color.White;
            this.txt_ThueVAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThueVAT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ThueVAT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThueVAT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_ThueVAT.Location = new System.Drawing.Point(617, 449);
            this.txt_ThueVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThueVAT.Name = "txt_ThueVAT";
            this.txt_ThueVAT.PasswordChar = '\0';
            this.txt_ThueVAT.SelectedText = "";
            this.txt_ThueVAT.Size = new System.Drawing.Size(363, 37);
            this.txt_ThueVAT.TabIndex = 14;
            // 
            // txt_GiaNhapTungSP
            // 
            this.txt_GiaNhapTungSP.BackColor = System.Drawing.Color.White;
            this.txt_GiaNhapTungSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GiaNhapTungSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_GiaNhapTungSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_GiaNhapTungSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_GiaNhapTungSP.Location = new System.Drawing.Point(617, 404);
            this.txt_GiaNhapTungSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaNhapTungSP.Name = "txt_GiaNhapTungSP";
            this.txt_GiaNhapTungSP.PasswordChar = '\0';
            this.txt_GiaNhapTungSP.SelectedText = "";
            this.txt_GiaNhapTungSP.Size = new System.Drawing.Size(363, 37);
            this.txt_GiaNhapTungSP.TabIndex = 15;
            // 
            // txt_MaNK
            // 
            this.txt_MaNK.BackColor = System.Drawing.Color.White;
            this.txt_MaNK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNK.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNK.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNK.Location = new System.Drawing.Point(617, 314);
            this.txt_MaNK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNK.Name = "txt_MaNK";
            this.txt_MaNK.PasswordChar = '\0';
            this.txt_MaNK.SelectedText = "";
            this.txt_MaNK.Size = new System.Drawing.Size(363, 37);
            this.txt_MaNK.TabIndex = 16;
            // 
            // txt_SoLuongSP
            // 
            this.txt_SoLuongSP.BackColor = System.Drawing.Color.White;
            this.txt_SoLuongSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuongSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoLuongSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SoLuongSP.Location = new System.Drawing.Point(617, 359);
            this.txt_SoLuongSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuongSP.Name = "txt_SoLuongSP";
            this.txt_SoLuongSP.PasswordChar = '\0';
            this.txt_SoLuongSP.SelectedText = "";
            this.txt_SoLuongSP.Size = new System.Drawing.Size(363, 37);
            this.txt_SoLuongSP.TabIndex = 17;
            // 
            // txt_MaLT
            // 
            this.txt_MaLT.BackColor = System.Drawing.Color.White;
            this.txt_MaLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLT.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaLT.Location = new System.Drawing.Point(617, 269);
            this.txt_MaLT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLT.Name = "txt_MaLT";
            this.txt_MaLT.PasswordChar = '\0';
            this.txt_MaLT.SelectedText = "";
            this.txt_MaLT.Size = new System.Drawing.Size(363, 37);
            this.txt_MaLT.TabIndex = 18;
            // 
            // lbl_TrangThaiThanhToan_PNK
            // 
            this.lbl_TrangThaiThanhToan_PNK.AutoSize = true;
            this.lbl_TrangThaiThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiThanhToan_PNK.Location = new System.Drawing.Point(269, 503);
            this.lbl_TrangThaiThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiThanhToan_PNK.Name = "lbl_TrangThaiThanhToan_PNK";
            this.lbl_TrangThaiThanhToan_PNK.Size = new System.Drawing.Size(247, 28);
            this.lbl_TrangThaiThanhToan_PNK.TabIndex = 7;
            this.lbl_TrangThaiThanhToan_PNK.Text = "Thành tiền từng sản phẩm:";
            // 
            // lbl_PhuongThucThanhToan_PNK
            // 
            this.lbl_PhuongThucThanhToan_PNK.AutoSize = true;
            this.lbl_PhuongThucThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhuongThucThanhToan_PNK.Location = new System.Drawing.Point(269, 458);
            this.lbl_PhuongThucThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PhuongThucThanhToan_PNK.Name = "lbl_PhuongThucThanhToan_PNK";
            this.lbl_PhuongThucThanhToan_PNK.Size = new System.Drawing.Size(102, 28);
            this.lbl_PhuongThucThanhToan_PNK.TabIndex = 8;
            this.lbl_PhuongThucThanhToan_PNK.Text = "Thuế VAT:";
            // 
            // lbl_SoTienThanhToan_PNK
            // 
            this.lbl_SoTienThanhToan_PNK.AutoSize = true;
            this.lbl_SoTienThanhToan_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienThanhToan_PNK.Location = new System.Drawing.Point(269, 413);
            this.lbl_SoTienThanhToan_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTienThanhToan_PNK.Name = "lbl_SoTienThanhToan_PNK";
            this.lbl_SoTienThanhToan_PNK.Size = new System.Drawing.Size(234, 28);
            this.lbl_SoTienThanhToan_PNK.TabIndex = 9;
            this.lbl_SoTienThanhToan_PNK.Text = "Giá nhập từng sản phẩm:";
            // 
            // lbl_MaNV_PNK
            // 
            this.lbl_MaNV_PNK.AutoSize = true;
            this.lbl_MaNV_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV_PNK.Location = new System.Drawing.Point(269, 368);
            this.lbl_MaNV_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV_PNK.Name = "lbl_MaNV_PNK";
            this.lbl_MaNV_PNK.Size = new System.Drawing.Size(185, 28);
            this.lbl_MaNV_PNK.TabIndex = 10;
            this.lbl_MaNV_PNK.Text = "Số lượng sản phẩm:";
            // 
            // lbl_MaNCC_PNK
            // 
            this.lbl_MaNCC_PNK.AutoSize = true;
            this.lbl_MaNCC_PNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNCC_PNK.Location = new System.Drawing.Point(269, 323);
            this.lbl_MaNCC_PNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNCC_PNK.Name = "lbl_MaNCC_PNK";
            this.lbl_MaNCC_PNK.Size = new System.Drawing.Size(131, 28);
            this.lbl_MaNCC_PNK.TabIndex = 11;
            this.lbl_MaNCC_PNK.Text = "Mã nhập kho:";
            // 
            // lbl_MaNK
            // 
            this.lbl_MaNK.AutoSize = true;
            this.lbl_MaNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNK.Location = new System.Drawing.Point(269, 278);
            this.lbl_MaNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNK.Name = "lbl_MaNK";
            this.lbl_MaNK.Size = new System.Drawing.Size(108, 28);
            this.lbl_MaNK.TabIndex = 12;
            this.lbl_MaNK.Text = "Mã Laptop:";
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
            this.btn_Xoa_PhieuNhapKho.Location = new System.Drawing.Point(776, 608);
            this.btn_Xoa_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_PhieuNhapKho.Name = "btn_Xoa_PhieuNhapKho";
            this.btn_Xoa_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_PhieuNhapKho.OnHoverImage = null;
            this.btn_Xoa_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_PhieuNhapKho.Radius = 6;
            this.btn_Xoa_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_PhieuNhapKho.TabIndex = 4;
            this.btn_Xoa_PhieuNhapKho.Text = "Xóa";
            this.btn_Xoa_PhieuNhapKho.Click += new System.EventHandler(this.btn_Xoa_PhieuNhapKho_Click_1);
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
            this.btn_Sua_PhieuNhapKho.Location = new System.Drawing.Point(511, 608);
            this.btn_Sua_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_PhieuNhapKho.Name = "btn_Sua_PhieuNhapKho";
            this.btn_Sua_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_PhieuNhapKho.OnHoverImage = null;
            this.btn_Sua_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_PhieuNhapKho.Radius = 6;
            this.btn_Sua_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_PhieuNhapKho.TabIndex = 5;
            this.btn_Sua_PhieuNhapKho.Text = "Sửa";
            this.btn_Sua_PhieuNhapKho.Click += new System.EventHandler(this.btn_Sua_PhieuNhapKho_Click_1);
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
            this.btn_Them_PhieuNhapKho.Location = new System.Drawing.Point(248, 608);
            this.btn_Them_PhieuNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_PhieuNhapKho.Name = "btn_Them_PhieuNhapKho";
            this.btn_Them_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_PhieuNhapKho.OnHoverImage = null;
            this.btn_Them_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_PhieuNhapKho.Radius = 6;
            this.btn_Them_PhieuNhapKho.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_PhieuNhapKho.TabIndex = 6;
            this.btn_Them_PhieuNhapKho.Text = "Thêm";
            this.btn_Them_PhieuNhapKho.Click += new System.EventHandler(this.btn_Them_PhieuNhapKho_Click_1);
            // 
            // Form_ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1481, 893);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChiTietPhieuNhap";
            this.Text = "ChiTietHoaDon";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhapKho)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuNhapKho;
        private Guna.UI.WinForms.GunaButton btn_Show_ChiTietPhieuNhapKho;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1PNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_ThanhTienTungSP;
        private Guna.UI.WinForms.GunaLineTextBox txt_ThueVAT;
        private Guna.UI.WinForms.GunaLineTextBox txt_GiaNhapTungSP;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNK;
        private Guna.UI.WinForms.GunaLineTextBox txt_SoLuongSP;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaLT;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_PhuongThucThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_SoTienThanhToan_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNCC_PNK;
        private Guna.UI.WinForms.GunaLabel lbl_MaNK;
        private Guna.UI.WinForms.GunaButton btn_Xoa_PhieuNhapKho;
        private Guna.UI.WinForms.GunaButton btn_Sua_PhieuNhapKho;
        private Guna.UI.WinForms.GunaButton btn_Them_PhieuNhapKho;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsPNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhapTungSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienTungSP;
    }
}