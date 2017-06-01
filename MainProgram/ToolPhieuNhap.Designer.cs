namespace MainProgram
{
    partial class ToolPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelPhieuNhap = new System.Windows.Forms.Panel();
            this.phiếuNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuNhậpHàngToolStripMenuItem,
            this.danhSáchPhiếuNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelPhieuNhap
            // 
            this.panelPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhieuNhap.Location = new System.Drawing.Point(0, 24);
            this.panelPhieuNhap.Name = "panelPhieuNhap";
            this.panelPhieuNhap.Size = new System.Drawing.Size(1364, 664);
            this.panelPhieuNhap.TabIndex = 6;
            // 
            // phiếuNhậpHàngToolStripMenuItem
            // 
            this.phiếuNhậpHàngToolStripMenuItem.Image = global::MainProgram.Properties.Resources.school_material__1_;
            this.phiếuNhậpHàngToolStripMenuItem.Name = "phiếuNhậpHàngToolStripMenuItem";
            this.phiếuNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.phiếuNhậpHàngToolStripMenuItem.Text = "Phiếu nhập hàng";
            this.phiếuNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpHàngToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuNhậpToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpToolStripMenuItem.Image = global::MainProgram.Properties.Resources.office_material;
            this.danhSáchPhiếuNhậpToolStripMenuItem.Name = "danhSáchPhiếuNhậpToolStripMenuItem";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.danhSáchPhiếuNhậpToolStripMenuItem.Text = "Danh Sách phiếu nhập";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuNhậpToolStripMenuItem_Click);
            // 
            // ToolPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPhieuNhap);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ToolPhieuNhap";
            this.Size = new System.Drawing.Size(1364, 688);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpToolStripMenuItem;
    }
}
