namespace MainProgram
{
    partial class UCS_KhachHang
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nhomKH = new System.Windows.Forms.ComboBox();
            this.xuatFileExcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNhapTenKH = new System.Windows.Forms.TextBox();
            this.timKiemKH = new System.Windows.Forms.Button();
            this.xoaKhachHang = new System.Windows.Forms.Button();
            this.suaKhachHang = new System.Windows.Forms.Button();
            this.themKhachHang = new System.Windows.Forms.Button();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_makhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVKhachHang = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 14);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nhomKH);
            this.splitContainer1.Panel1.Controls.Add(this.xuatFileExcel);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbNhapTenKH);
            this.splitContainer1.Panel1.Controls.Add(this.timKiemKH);
            this.splitContainer1.Panel1.Controls.Add(this.xoaKhachHang);
            this.splitContainer1.Panel1.Controls.Add(this.suaKhachHang);
            this.splitContainer1.Panel1.Controls.Add(this.themKhachHang);
            this.splitContainer1.Panel1.Controls.Add(this.tb_ghichu);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tb_email);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tb_diachi);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tb_SDT);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tb_tenkhachhang);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tb_makhachhang);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGVKhachHang);
            this.splitContainer1.Size = new System.Drawing.Size(1333, 635);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 1;
            // 
            // nhomKH
            // 
            this.nhomKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomKH.FormattingEnabled = true;
            this.nhomKH.Location = new System.Drawing.Point(167, 161);
            this.nhomKH.Name = "nhomKH";
            this.nhomKH.Size = new System.Drawing.Size(241, 29);
            this.nhomKH.TabIndex = 20;
            // 
            // xuatFileExcel
            // 
            this.xuatFileExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatFileExcel.Image = global::MainProgram.Properties.Resources.Microsoft_Excel_64;
            this.xuatFileExcel.Location = new System.Drawing.Point(67, 514);
            this.xuatFileExcel.Name = "xuatFileExcel";
            this.xuatFileExcel.Size = new System.Drawing.Size(326, 60);
            this.xuatFileExcel.TabIndex = 19;
            this.xuatFileExcel.UseVisualStyleBackColor = true;
            this.xuatFileExcel.Click += new System.EventHandler(this.xuatFileExcel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tìm kiếm khách hàng";
            // 
            // tbNhapTenKH
            // 
            this.tbNhapTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapTenKH.Location = new System.Drawing.Point(83, 60);
            this.tbNhapTenKH.Name = "tbNhapTenKH";
            this.tbNhapTenKH.Size = new System.Drawing.Size(246, 29);
            this.tbNhapTenKH.TabIndex = 17;
            this.tbNhapTenKH.Text = "Nhập tên khách hàng cần tìm ....";
            this.tbNhapTenKH.Click += new System.EventHandler(this.tbNhapTenKH_Click);
            // 
            // timKiemKH
            // 
            this.timKiemKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemKH.Image = global::MainProgram.Properties.Resources.research__1_;
            this.timKiemKH.Location = new System.Drawing.Point(142, 95);
            this.timKiemKH.Name = "timKiemKH";
            this.timKiemKH.Size = new System.Drawing.Size(130, 51);
            this.timKiemKH.TabIndex = 16;
            this.timKiemKH.UseVisualStyleBackColor = true;
            this.timKiemKH.Click += new System.EventHandler(this.tiemKiemKH_Click);
            // 
            // xoaKhachHang
            // 
            this.xoaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaKhachHang.Image = global::MainProgram.Properties.Resources.file;
            this.xoaKhachHang.Location = new System.Drawing.Point(300, 426);
            this.xoaKhachHang.Name = "xoaKhachHang";
            this.xoaKhachHang.Size = new System.Drawing.Size(108, 60);
            this.xoaKhachHang.TabIndex = 15;
            this.xoaKhachHang.UseVisualStyleBackColor = true;
            this.xoaKhachHang.Click += new System.EventHandler(this.xoaKhachHang_Click);
            // 
            // suaKhachHang
            // 
            this.suaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaKhachHang.Image = global::MainProgram.Properties.Resources.Available_Updates_48;
            this.suaKhachHang.Location = new System.Drawing.Point(168, 426);
            this.suaKhachHang.Name = "suaKhachHang";
            this.suaKhachHang.Size = new System.Drawing.Size(115, 60);
            this.suaKhachHang.TabIndex = 15;
            this.suaKhachHang.UseVisualStyleBackColor = true;
            this.suaKhachHang.Click += new System.EventHandler(this.suaKhachHang_Click);
            // 
            // themKhachHang
            // 
            this.themKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themKhachHang.Image = global::MainProgram.Properties.Resources.Add_List_48;
            this.themKhachHang.Location = new System.Drawing.Point(29, 426);
            this.themKhachHang.Name = "themKhachHang";
            this.themKhachHang.Size = new System.Drawing.Size(117, 60);
            this.themKhachHang.TabIndex = 14;
            this.themKhachHang.UseVisualStyleBackColor = true;
            this.themKhachHang.Click += new System.EventHandler(this.themKhachHang_Click);
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ghichu.Location = new System.Drawing.Point(167, 380);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(241, 29);
            this.tb_ghichu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ghi chú";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(167, 343);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(241, 29);
            this.tb_email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.Location = new System.Drawing.Point(167, 306);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(241, 29);
            this.tb_diachi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // tb_SDT
            // 
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.Location = new System.Drawing.Point(168, 270);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(240, 29);
            this.tb_SDT.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nhóm khách hàng";
            // 
            // tb_tenkhachhang
            // 
            this.tb_tenkhachhang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenkhachhang.Location = new System.Drawing.Point(167, 235);
            this.tb_tenkhachhang.Name = "tb_tenkhachhang";
            this.tb_tenkhachhang.Size = new System.Drawing.Size(241, 29);
            this.tb_tenkhachhang.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // tb_makhachhang
            // 
            this.tb_makhachhang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makhachhang.Location = new System.Drawing.Point(167, 196);
            this.tb_makhachhang.Name = "tb_makhachhang";
            this.tb_makhachhang.Size = new System.Drawing.Size(241, 29);
            this.tb_makhachhang.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã khách hàng";
            // 
            // dataGVKhachHang
            // 
            this.dataGVKhachHang.AllowUserToAddRows = false;
            this.dataGVKhachHang.AllowUserToDeleteRows = false;
            this.dataGVKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGVKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataGVKhachHang.Name = "dataGVKhachHang";
            this.dataGVKhachHang.ReadOnly = true;
            this.dataGVKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVKhachHang.Size = new System.Drawing.Size(885, 635);
            this.dataGVKhachHang.TabIndex = 0;
            this.dataGVKhachHang.Click += new System.EventHandler(this.dataGVKhachHang_Click);
            // 
            // UCS_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCS_KhachHang";
            this.Size = new System.Drawing.Size(1364, 688);
            this.Load += new System.EventHandler(this.UCS_KhachHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button xuatFileExcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNhapTenKH;
        private System.Windows.Forms.Button timKiemKH;
        private System.Windows.Forms.Button xoaKhachHang;
        private System.Windows.Forms.Button suaKhachHang;
        private System.Windows.Forms.Button themKhachHang;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_makhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVKhachHang;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox nhomKH;
    }
}
