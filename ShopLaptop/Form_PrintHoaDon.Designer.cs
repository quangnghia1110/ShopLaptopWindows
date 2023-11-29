namespace ShopLaptop
{
    partial class Form_PrintHoaDon
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
            this.crv_HoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_HoaDon
            // 
            this.crv_HoaDon.ActiveViewIndex = -1;
            this.crv_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_HoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.crv_HoaDon.Name = "crv_HoaDon";
            this.crv_HoaDon.Size = new System.Drawing.Size(1725, 666);
            this.crv_HoaDon.TabIndex = 0;
            // 
            // Form_PrintHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 666);
            this.Controls.Add(this.crv_HoaDon);
            this.Name = "Form_PrintHoaDon";
            this.Text = "Form_PrintHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_HoaDon;
    }
}