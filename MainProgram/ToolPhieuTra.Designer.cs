namespace MainProgram
{
    partial class ToolPhieuTra
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
            this.panelPhieuXuat = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phiếuXuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPhieuXuat
            // 
            this.panelPhieuXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhieuXuat.Location = new System.Drawing.Point(0, 24);
            this.panelPhieuXuat.Name = "panelPhieuXuat";
            this.panelPhieuXuat.Size = new System.Drawing.Size(1364, 640);
            this.panelPhieuXuat.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuXuấtHàngToolStripMenuItem,
            this.danhSáchPhiếuXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phiếuXuấtHàngToolStripMenuItem
            // 
            this.phiếuXuấtHàngToolStripMenuItem.Image = global::MainProgram.Properties.Resources.school_material__1_;
            this.phiếuXuấtHàngToolStripMenuItem.Name = "phiếuXuấtHàngToolStripMenuItem";
            this.phiếuXuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.phiếuXuấtHàngToolStripMenuItem.Text = "Phiếu trả hàng";
            this.phiếuXuấtHàngToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtHàngToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuXuấtToolStripMenuItem
            // 
            this.danhSáchPhiếuXuấtToolStripMenuItem.Image = global::MainProgram.Properties.Resources.office_material;
            this.danhSáchPhiếuXuấtToolStripMenuItem.Name = "danhSáchPhiếuXuấtToolStripMenuItem";
            this.danhSáchPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.danhSáchPhiếuXuấtToolStripMenuItem.Text = "Danh Sách phiếu trả";
            this.danhSáchPhiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuXuấtToolStripMenuItem_Click);
            // 
            // ToolPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.panelPhieuXuat);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ToolPhieuTra";
            this.Size = new System.Drawing.Size(1364, 664);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPhieuXuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuXuấtToolStripMenuItem;
    }
}
