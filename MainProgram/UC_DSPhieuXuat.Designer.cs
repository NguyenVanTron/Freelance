namespace MainProgram
{
    partial class UC_DSPhieuXuat
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
            this.label3 = new System.Windows.Forms.Label();
            this.printPhieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGVDSSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGVPhieu = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tongTien = new System.Windows.Forms.TextBox();
            this.timKiem = new System.Windows.Forms.Button();
            this.xuatExcel = new System.Windows.Forms.Button();
            this.xoaPhieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTO = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1099, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng tiền";
            // 
            // printPhieu
            // 
            this.printPhieu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPhieu.Image = global::MainProgram.Properties.Resources.printer;
            this.printPhieu.Location = new System.Drawing.Point(211, 20);
            this.printPhieu.Name = "printPhieu";
            this.printPhieu.Size = new System.Drawing.Size(83, 66);
            this.printPhieu.TabIndex = 20;
            this.printPhieu.UseVisualStyleBackColor = true;
            this.printPhieu.Click += new System.EventHandler(this.printPhieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGVDSSanPham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1306, 275);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dataGVDSSanPham
            // 
            this.dataGVDSSanPham.AllowUserToAddRows = false;
            this.dataGVDSSanPham.AllowUserToDeleteRows = false;
            this.dataGVDSSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGVDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDSSanPham.Location = new System.Drawing.Point(3, 16);
            this.dataGVDSSanPham.Name = "dataGVDSSanPham";
            this.dataGVDSSanPham.ReadOnly = true;
            this.dataGVDSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDSSanPham.Size = new System.Drawing.Size(1300, 256);
            this.dataGVDSSanPham.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGVPhieu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1306, 259);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu xuất";
            // 
            // dataGVPhieu
            // 
            this.dataGVPhieu.AllowUserToAddRows = false;
            this.dataGVPhieu.AllowUserToDeleteRows = false;
            this.dataGVPhieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGVPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVPhieu.Location = new System.Drawing.Point(3, 16);
            this.dataGVPhieu.Name = "dataGVPhieu";
            this.dataGVPhieu.ReadOnly = true;
            this.dataGVPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVPhieu.Size = new System.Drawing.Size(1300, 240);
            this.dataGVPhieu.TabIndex = 6;
            this.dataGVPhieu.Click += new System.EventHandler(this.dataGVPhieu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(30, 99);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1306, 538);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 25;
            // 
            // tongTien
            // 
            this.tongTien.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongTien.Location = new System.Drawing.Point(1168, 68);
            this.tongTien.Name = "tongTien";
            this.tongTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tongTien.Size = new System.Drawing.Size(165, 22);
            this.tongTien.TabIndex = 13;
            // 
            // timKiem
            // 
            this.timKiem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiem.Image = global::MainProgram.Properties.Resources.research;
            this.timKiem.Location = new System.Drawing.Point(762, 63);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(32, 21);
            this.timKiem.TabIndex = 21;
            this.timKiem.UseVisualStyleBackColor = true;
            // 
            // xuatExcel
            // 
            this.xuatExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatExcel.Image = global::MainProgram.Properties.Resources.Microsoft_Excel_64;
            this.xuatExcel.Location = new System.Drawing.Point(122, 20);
            this.xuatExcel.Name = "xuatExcel";
            this.xuatExcel.Size = new System.Drawing.Size(83, 66);
            this.xuatExcel.TabIndex = 22;
            this.xuatExcel.UseVisualStyleBackColor = true;
            this.xuatExcel.Click += new System.EventHandler(this.xuatExcel_Click);
            // 
            // xoaPhieu
            // 
            this.xoaPhieu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaPhieu.Image = global::MainProgram.Properties.Resources.file;
            this.xoaPhieu.Location = new System.Drawing.Point(33, 20);
            this.xoaPhieu.Name = "xoaPhieu";
            this.xoaPhieu.Size = new System.Drawing.Size(83, 66);
            this.xoaPhieu.TabIndex = 23;
            this.xoaPhieu.UseVisualStyleBackColor = true;
            this.xoaPhieu.Click += new System.EventHandler(this.xoaPhieu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ ngày";
            // 
            // dateTimeTO
            // 
            this.dateTimeTO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTO.Location = new System.Drawing.Point(654, 64);
            this.dateTimeTO.Name = "dateTimeTO";
            this.dateTimeTO.Size = new System.Drawing.Size(93, 22);
            this.dateTimeTO.TabIndex = 16;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(489, 64);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(89, 22);
            this.dateTimeFrom.TabIndex = 17;
            // 
            // UC_DSPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printPhieu);
            this.Controls.Add(this.tongTien);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.xuatExcel);
            this.Controls.Add(this.xoaPhieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeTO);
            this.Controls.Add(this.dateTimeFrom);
            this.Name = "UC_DSPhieuXuat";
            this.Size = new System.Drawing.Size(1364, 688);
            this.Load += new System.EventHandler(this.UC_DSPhieuXuat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPhieu)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printPhieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGVDSSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGVPhieu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tongTien;
        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.Button xuatExcel;
        private System.Windows.Forms.Button xoaPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeTO;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
