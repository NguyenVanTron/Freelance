﻿namespace MainProgram
{
    partial class ChangeDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDatabase));
            this.ketNoiDuLieu = new System.Windows.Forms.Button();
            this.chonDuLieu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ketNoiDuLieu
            // 
            this.ketNoiDuLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketNoiDuLieu.Image = global::MainProgram.Properties.Resources.Accept_Database_48;
            this.ketNoiDuLieu.Location = new System.Drawing.Point(140, 59);
            this.ketNoiDuLieu.Name = "ketNoiDuLieu";
            this.ketNoiDuLieu.Size = new System.Drawing.Size(124, 57);
            this.ketNoiDuLieu.TabIndex = 10;
            this.ketNoiDuLieu.UseVisualStyleBackColor = true;
            this.ketNoiDuLieu.Click += new System.EventHandler(this.ketNoiDuLieu_Click);
            // 
            // chonDuLieu
            // 
            this.chonDuLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonDuLieu.FormattingEnabled = true;
            this.chonDuLieu.Location = new System.Drawing.Point(48, 24);
            this.chonDuLieu.Name = "chonDuLieu";
            this.chonDuLieu.Size = new System.Drawing.Size(329, 29);
            this.chonDuLieu.TabIndex = 8;
            // 
            // ChangeDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(416, 124);
            this.Controls.Add(this.ketNoiDuLieu);
            this.Controls.Add(this.chonDuLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeDatabase";
            this.Text = "Thay đổi dữ liệu";
            this.Load += new System.EventHandler(this.ChangeDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ketNoiDuLieu;
        private System.Windows.Forms.ComboBox chonDuLieu;
    }
}