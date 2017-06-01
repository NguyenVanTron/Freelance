namespace MainProgram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chonDuLieu = new System.Windows.Forms.ComboBox();
            this.taoDuLieu = new System.Windows.Forms.Button();
            this.ketNoiDuLieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chonDuLieu
            // 
            this.chonDuLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonDuLieu.FormattingEnabled = true;
            this.chonDuLieu.Location = new System.Drawing.Point(71, 27);
            this.chonDuLieu.Name = "chonDuLieu";
            this.chonDuLieu.Size = new System.Drawing.Size(329, 29);
            this.chonDuLieu.TabIndex = 5;
            // 
            // taoDuLieu
            // 
            this.taoDuLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taoDuLieu.Image = global::MainProgram.Properties.Resources.Add_Database_48;
            this.taoDuLieu.Location = new System.Drawing.Point(251, 83);
            this.taoDuLieu.Name = "taoDuLieu";
            this.taoDuLieu.Size = new System.Drawing.Size(124, 57);
            this.taoDuLieu.TabIndex = 6;
            this.taoDuLieu.UseVisualStyleBackColor = true;
            this.taoDuLieu.Click += new System.EventHandler(this.taoDuLieu_Click);
            // 
            // ketNoiDuLieu
            // 
            this.ketNoiDuLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketNoiDuLieu.Image = global::MainProgram.Properties.Resources.Accept_Database_48;
            this.ketNoiDuLieu.Location = new System.Drawing.Point(94, 83);
            this.ketNoiDuLieu.Name = "ketNoiDuLieu";
            this.ketNoiDuLieu.Size = new System.Drawing.Size(124, 57);
            this.ketNoiDuLieu.TabIndex = 7;
            this.ketNoiDuLieu.UseVisualStyleBackColor = true;
            this.ketNoiDuLieu.Click += new System.EventHandler(this.ketNoiDuLieu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(480, 191);
            this.Controls.Add(this.taoDuLieu);
            this.Controls.Add(this.ketNoiDuLieu);
            this.Controls.Add(this.chonDuLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kết Nối Dữ Liệu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button taoDuLieu;
        private System.Windows.Forms.Button ketNoiDuLieu;
        private System.Windows.Forms.ComboBox chonDuLieu;
    }
}

