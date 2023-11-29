namespace ShopLaptop
{
    partial class Form_PrintPhieuNhap
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
            this.crv_PhieuNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            //this.rpr_PhieuNhap1 = new ShopLaptop.rpr_PhieuNhap();
            this.SuspendLayout();
            // 
            // crv_PhieuNhap
            // 
            this.crv_PhieuNhap.ActiveViewIndex = 0;
            this.crv_PhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_PhieuNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_PhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_PhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.crv_PhieuNhap.Name = "crv_PhieuNhap";
            //this.crv_PhieuNhap.ReportSource = this.rpr_PhieuNhap1;
            this.crv_PhieuNhap.Size = new System.Drawing.Size(1599, 1050);
            this.crv_PhieuNhap.TabIndex = 0;
            // 
            // Form_PrintPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 1050);
            this.Controls.Add(this.crv_PhieuNhap);
            this.Name = "Form_PrintPhieuNhap";
            this.Text = "Form_PrintPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_PhieuNhap;
        //private ShopLaptop.rpt_PhieuNhap rpt_PhieuNhap1;
    }
}