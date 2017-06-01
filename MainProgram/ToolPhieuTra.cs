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
    public partial class ToolPhieuTra : UserControl
    {
        public ToolPhieuTra()
        {
            InitializeComponent();
            UC_PhieuTraHang us = new UC_PhieuTraHang();
            panelPhieuXuat.Controls.Clear();
            panelPhieuXuat.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void danhSáchPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DSPhieuTra us= new UC_DSPhieuTra();
            panelPhieuXuat.Controls.Clear();
            panelPhieuXuat.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void phiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_PhieuTraHang us = new UC_PhieuTraHang();
            panelPhieuXuat.Controls.Clear();
            panelPhieuXuat.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
