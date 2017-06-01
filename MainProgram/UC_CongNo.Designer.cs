namespace MainProgram
{
    partial class UC_CongNo
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
            this.panelCongNo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CongNoThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CongNoTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCongNo
            // 
            this.panelCongNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCongNo.Location = new System.Drawing.Point(0, 24);
            this.panelCongNo.Name = "panelCongNo";
            this.panelCongNo.Size = new System.Drawing.Size(1364, 664);
            this.panelCongNo.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CongNoThuToolStripMenuItem,
            this.CongNoTraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CongNoThuToolStripMenuItem
            // 
            this.CongNoThuToolStripMenuItem.Image = global::MainProgram.Properties.Resources.money2;
            this.CongNoThuToolStripMenuItem.Name = "CongNoThuToolStripMenuItem";
            this.CongNoThuToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.CongNoThuToolStripMenuItem.Text = "Công nợ thu";
            this.CongNoThuToolStripMenuItem.Click += new System.EventHandler(this.CongNoThuToolStripMenuItem_Click);
            // 
            // CongNoTraToolStripMenuItem
            // 
            this.CongNoTraToolStripMenuItem.Image = global::MainProgram.Properties.Resources.wallet;
            this.CongNoTraToolStripMenuItem.Name = "CongNoTraToolStripMenuItem";
            this.CongNoTraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.CongNoTraToolStripMenuItem.Text = "Công nợ trả";
            this.CongNoTraToolStripMenuItem.Click += new System.EventHandler(this.CongNoTraToolStripMenuItem_Click);
            // 
            // UC_CongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCongNo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_CongNo";
            this.Size = new System.Drawing.Size(1364, 688);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCongNo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CongNoThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CongNoTraToolStripMenuItem;
    }
}
