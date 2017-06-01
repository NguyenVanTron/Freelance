namespace MainProgram
{
    partial class UC_Report
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
            this.panelReport = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 24);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1364, 664);
            this.panelReport.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem,
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // báoCáoTổngHợpHàngHóaToolStripMenuItem
            // 
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem.Image = global::MainProgram.Properties.Resources.bars_chart;
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem.Name = "báoCáoTổngHợpHàngHóaToolStripMenuItem";
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(182, 20);
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem.Text = "Báo cáo tổng hợp hàng hóa";
            this.báoCáoTổngHợpHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTổngHợpHàngHóaToolStripMenuItem_Click);
            // 
            // báoCáoTổngHợpCuốiKìToolStripMenuItem
            // 
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem.Image = global::MainProgram.Properties.Resources.cash;
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem.Name = "báoCáoTổngHợpCuốiKìToolStripMenuItem";
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem.Text = "Báo cáo tổng hợp cuối kì";
            this.báoCáoTổngHợpCuốiKìToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTổngHợpCuốiKìToolStripMenuItem_Click);
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(1364, 688);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTổngHợpHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTổngHợpCuốiKìToolStripMenuItem;
    }
}
