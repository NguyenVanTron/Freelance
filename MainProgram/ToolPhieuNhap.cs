using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class ToolPhieuNhap : UserControl
    {
        public ToolPhieuNhap()
        {
            InitializeComponent();
            phiếuNhậpHàngToolStripMenuItem.ForeColor = Color.Red;
            UC_PhieuNhap us = new UC_PhieuNhap();
            panelPhieuNhap.Controls.Clear();
            panelPhieuNhap.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phiếuNhậpHàngToolStripMenuItem.ForeColor = Color.Red;
            danhSáchPhiếuNhậpToolStripMenuItem.ForeColor = Color.Black;
            UC_PhieuNhap us = new UC_PhieuNhap();
            panelPhieuNhap.Controls.Clear();
            panelPhieuNhap.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void danhSáchPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phiếuNhậpHàngToolStripMenuItem.ForeColor = Color.Black;
            danhSáchPhiếuNhậpToolStripMenuItem.ForeColor = Color.Red;
            UC_DSPhieuNhap us = new UC_DSPhieuNhap();
            panelPhieuNhap.Controls.Clear();
            panelPhieuNhap.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
