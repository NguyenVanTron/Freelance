namespace MainProgram
{
    partial class ThemNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNCC));
            this.nhomNCC = new System.Windows.Forms.ComboBox();
            this.xuatFileExcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNhapTenKH = new System.Windows.Forms.TextBox();
            this.timKiemNCC = new System.Windows.Forms.Button();
            this.xoaNCC = new System.Windows.Forms.Button();
            this.suaNCC = new System.Windows.Forms.Button();
            this.themnhacc = new System.Windows.Forms.Button();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nguoiGiaoDich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_maNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVNCC = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // nhomNCC
            // 
            this.nhomNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomNCC.FormattingEnabled = true;
            this.nhomNCC.Location = new System.Drawing.Point(191, 185);
            this.nhomNCC.Name = "nhomNCC";
            this.nhomNCC.Size = new System.Drawing.Size(219, 29);
            this.nhomNCC.TabIndex = 20;
            // 
            // xuatFileExcel
            // 
            this.xuatFileExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatFileExcel.Image = global::MainProgram.Properties.Resources.Microsoft_Excel_64;
            this.xuatFileExcel.Location = new System.Drawing.Point(59, 532);
            this.xuatFileExcel.Name = "xuatFileExcel";
            this.xuatFileExcel.Size = new System.Drawing.Size(322, 60);
            this.xuatFileExcel.TabIndex = 19;
            this.xuatFileExcel.UseVisualStyleBackColor = true;
            this.xuatFileExcel.Click += new System.EventHandler(this.xuatFileExcel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tìm kiếm nhà cung cấp";
            // 
            // tbNhapTenKH
            // 
            this.tbNhapTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapTenKH.Location = new System.Drawing.Point(82, 79);
            this.tbNhapTenKH.Name = "tbNhapTenKH";
            this.tbNhapTenKH.Size = new System.Drawing.Size(246, 29);
            this.tbNhapTenKH.TabIndex = 17;
            this.tbNhapTenKH.Text = "Nhập tên nhà cung cấp cần tìm ....";
            this.tbNhapTenKH.Click += new System.EventHandler(this.tbNhapTenNCC_Click);
            // 
            // timKiemNCC
            // 
            this.timKiemNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemNCC.Image = global::MainProgram.Properties.Resources.research__1_;
            this.timKiemNCC.Location = new System.Drawing.Point(150, 114);
            this.timKiemNCC.Name = "timKiemNCC";
            this.timKiemNCC.Size = new System.Drawing.Size(106, 51);
            this.timKiemNCC.TabIndex = 16;
            this.timKiemNCC.UseVisualStyleBackColor = true;
            this.timKiemNCC.Click += new System.EventHandler(this.tiemKiemNCC_Click);
            // 
            // xoaNCC
            // 
            this.xoaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaNCC.Image = global::MainProgram.Properties.Resources.file;
            this.xoaNCC.Location = new System.Drawing.Point(296, 445);
            this.xoaNCC.Name = "xoaNCC";
            this.xoaNCC.Size = new System.Drawing.Size(114, 60);
            this.xoaNCC.TabIndex = 15;
            this.xoaNCC.UseVisualStyleBackColor = true;
            this.xoaNCC.Click += new System.EventHandler(this.xoaNhaCungCap_Click);
            // 
            // suaNCC
            // 
            this.suaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaNCC.Image = global::MainProgram.Properties.Resources.Available_Updates_48;
            this.suaNCC.Location = new System.Drawing.Point(175, 445);
            this.suaNCC.Name = "suaNCC";
            this.suaNCC.Size = new System.Drawing.Size(115, 60);
            this.suaNCC.TabIndex = 15;
            this.suaNCC.UseVisualStyleBackColor = true;
            this.suaNCC.Click += new System.EventHandler(this.suaNhaCungCap_Click);
            // 
            // themnhacc
            // 
            this.themnhacc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themnhacc.Image = global::MainProgram.Properties.Resources.Add_List_48;
            this.themnhacc.Location = new System.Drawing.Point(44, 445);
            this.themnhacc.Name = "themnhacc";
            this.themnhacc.Size = new System.Drawing.Size(125, 60);
            this.themnhacc.TabIndex = 14;
            this.themnhacc.UseVisualStyleBackColor = true;
            this.themnhacc.Click += new System.EventHandler(this.themNhaCungCap_Click);
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ghichu.Location = new System.Drawing.Point(190, 399);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(220, 29);
            this.tb_ghichu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ghi chú";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(190, 359);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(220, 29);
            this.tb_email.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nhomNCC);
            this.splitContainer1.Panel1.Controls.Add(this.xuatFileExcel);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbNhapTenKH);
            this.splitContainer1.Panel1.Controls.Add(this.timKiemNCC);
            this.splitContainer1.Panel1.Controls.Add(this.xoaNCC);
            this.splitContainer1.Panel1.Controls.Add(this.suaNCC);
            this.splitContainer1.Panel1.Controls.Add(this.themnhacc);
            this.splitContainer1.Panel1.Controls.Add(this.tb_ghichu);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tb_email);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tb_nguoiGiaoDich);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tb_SDT);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tb_tenNCC);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tb_maNCC);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGVNCC);
            this.splitContainer1.Size = new System.Drawing.Size(1333, 635);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // tb_nguoiGiaoDich
            // 
            this.tb_nguoiGiaoDich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nguoiGiaoDich.Location = new System.Drawing.Point(190, 322);
            this.tb_nguoiGiaoDich.Name = "tb_nguoiGiaoDich";
            this.tb_nguoiGiaoDich.Size = new System.Drawing.Size(220, 29);
            this.tb_nguoiGiaoDich.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Người giao dịch";
            // 
            // tb_SDT
            // 
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.Location = new System.Drawing.Point(191, 289);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(219, 29);
            this.tb_SDT.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // tb_tenNCC
            // 
            this.tb_tenNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenNCC.Location = new System.Drawing.Point(191, 254);
            this.tb_tenNCC.Name = "tb_tenNCC";
            this.tb_tenNCC.Size = new System.Drawing.Size(219, 29);
            this.tb_tenNCC.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nhóm nhà cung cấp";
            // 
            // tb_maNCC
            // 
            this.tb_maNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maNCC.Location = new System.Drawing.Point(191, 218);
            this.tb_maNCC.Name = "tb_maNCC";
            this.tb_maNCC.Size = new System.Drawing.Size(219, 29);
            this.tb_maNCC.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // dataGVNCC
            // 
            this.dataGVNCC.AllowUserToAddRows = false;
            this.dataGVNCC.AllowUserToDeleteRows = false;
            this.dataGVNCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGVNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVNCC.Location = new System.Drawing.Point(0, 0);
            this.dataGVNCC.Name = "dataGVNCC";
            this.dataGVNCC.ReadOnly = true;
            this.dataGVNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVNCC.Size = new System.Drawing.Size(885, 635);
            this.dataGVNCC.TabIndex = 0;
            this.dataGVNCC.Click += new System.EventHandler(this.dataGVNCC_Click);
            // 
            // ThemNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1348, 649);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemNCC";
            this.Text = "Thêm nhà cung cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_NhaCungCap_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox nhomNCC;
        private System.Windows.Forms.Button xuatFileExcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNhapTenKH;
        private System.Windows.Forms.Button timKiemNCC;
        private System.Windows.Forms.Button xoaNCC;
        private System.Windows.Forms.Button suaNCC;
        private System.Windows.Forms.Button themnhacc;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nguoiGiaoDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_maNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVNCC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}