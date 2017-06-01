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
    public partial class UC_CongNo : UserControl
    {
        public UC_CongNo()
        {
            InitializeComponent();
            CongNoThuToolStripMenuItem.ForeColor = Color.Red;
            UC_CongNoThu us = new UC_CongNoThu();
            panelCongNo.Controls.Clear();
            panelCongNo.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void CongNoThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CongNoThuToolStripMenuItem.ForeColor = Color.Red;
            CongNoTraToolStripMenuItem.ForeColor = Color.Black;
            UC_CongNoThu us = new UC_CongNoThu();
            panelCongNo.Controls.Clear();
            panelCongNo.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void CongNoTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CongNoTraToolStripMenuItem.ForeColor = Color.Red;
            CongNoThuToolStripMenuItem.ForeColor = Color.Black;
            UC_CongNoTra us = new UC_CongNoTra();
            panelCongNo.Controls.Clear();
            panelCongNo.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
