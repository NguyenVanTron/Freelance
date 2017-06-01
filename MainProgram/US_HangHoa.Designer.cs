namespace MainProgram
{
    partial class US_HangHoa
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
            this.dataGVHangHoa = new System.Windows.Forms.DataGridView();
            this.timkiemTenHang = new System.Windows.Forms.TextBox();
            this.timKiem = new System.Windows.Forms.Button();
            this.xuatFileExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVHangHoa
            // 
            this.dataGVHangHoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGVHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVHangHoa.Location = new System.Drawing.Point(21, 67);
            this.dataGVHangHoa.Name = "dataGVHangHoa";
            this.dataGVHangHoa.Size = new System.Drawing.Size(1325, 585);
            this.dataGVHangHoa.TabIndex = 1;
            // 
            // timkiemTenHang
            // 
            this.timkiemTenHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemTenHang.Location = new System.Drawing.Point(21, 21);
            this.timkiemTenHang.Name = "timkiemTenHang";
            this.timkiemTenHang.Size = new System.Drawing.Size(278, 29);
            this.timkiemTenHang.TabIndex = 2;
            this.timkiemTenHang.Text = "Nhập tên hàng...";
            this.timkiemTenHang.Click += new System.EventHandler(this.timkiemTenHang_Click);
            // 
            // timKiem
            // 
            this.timKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiem.Image = global::MainProgram.Properties.Resources.research__1_;
            this.timKiem.Location = new System.Drawing.Point(317, 6);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(64, 57);
            this.timKiem.TabIndex = 3;
            this.timKiem.UseVisualStyleBackColor = true;
            this.timKiem.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // xuatFileExcel
            // 
            this.xuatFileExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatFileExcel.Image = global::MainProgram.Properties.Resources.Microsoft_Excel_64;
            this.xuatFileExcel.Location = new System.Drawing.Point(408, 6);
            this.xuatFileExcel.Name = "xuatFileExcel";
            this.xuatFileExcel.Size = new System.Drawing.Size(91, 57);
            this.xuatFileExcel.TabIndex = 3;
            this.xuatFileExcel.UseVisualStyleBackColor = true;
            this.xuatFileExcel.Click += new System.EventHandler(this.xuatFileExcel_Click);
            // 
            // US_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.xuatFileExcel);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.timkiemTenHang);
            this.Controls.Add(this.dataGVHangHoa);
            this.Name = "US_HangHoa";
            this.Size = new System.Drawing.Size(1364, 688);
            this.Load += new System.EventHandler(this.US_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVHangHoa;
        private System.Windows.Forms.TextBox timkiemTenHang;
        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.Button xuatFileExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
