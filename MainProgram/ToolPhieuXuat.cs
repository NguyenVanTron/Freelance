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
    public partial class ToolPhieuXuat : UserControl
    {
        public ToolPhieuXuat()
        {
            InitializeComponent();
            UC_PhieuXuat us = new UC_PhieuXuat();
            panelPhieuXuat.Controls.Clear();
            panelPhieuXuat.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void phiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_PhieuXuat us = new UC_PhieuXuat();
            panelPhieuXuat.Controls.Clear();
            panelPhieuXuat.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void danhSáchPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_DSPhieuXuat us = new UC_DSPhieuXuat();
            panelPhieuXuat.Controls.Clear();
            panelPhieuXuat.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
