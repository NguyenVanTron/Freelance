namespace MainProgram
{
    partial class InPhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InPhieuBanHang));
            this.panelPhieuBanHang = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPhieuBanHang
            // 
            this.panelPhieuBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhieuBanHang.Location = new System.Drawing.Point(0, 0);
            this.panelPhieuBanHang.Name = "panelPhieuBanHang";
            this.panelPhieuBanHang.Size = new System.Drawing.Size(284, 261);
            this.panelPhieuBanHang.TabIndex = 0;
            // 
            // InPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panelPhieuBanHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InPhieuBanHang";
            this.Text = "In Phiếu Bán Hàng";
            this.Load += new System.EventHandler(this.InPhieuBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhieuBanHang;
    }
}