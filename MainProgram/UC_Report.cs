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
    public partial class UC_Report : UserControl
    {
        public UC_Report()
        {
            InitializeComponent();
            báoCáoTổngHợpHàngHóaToolStripMenuItem.ForeColor = Color.Red;
            UC_BaoCaoTongHop us = new UC_BaoCaoTongHop();
            panelReport.Controls.Clear();
            panelReport.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void báoCáoTổngHợpHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            báoCáoTổngHợpCuốiKìToolStripMenuItem.ForeColor = Color.Black;
            báoCáoTổngHợpHàngHóaToolStripMenuItem.ForeColor = Color.Red;
            UC_BaoCaoTongHop us = new UC_BaoCaoTongHop();
            panelReport.Controls.Clear();
            panelReport.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void báoCáoTổngHợpCuốiKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            báoCáoTổngHợpCuốiKìToolStripMenuItem.ForeColor = Color.Red;
            báoCáoTổngHợpHàngHóaToolStripMenuItem.ForeColor = Color.Black;
            UC_BaoCaoCuoiKi us = new UC_BaoCaoCuoiKi();
            panelReport.Controls.Clear();
            panelReport.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
