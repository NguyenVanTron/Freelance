using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class InPhieuBanHang : Form
    {
        public InPhieuBanHang()
        {
            InitializeComponent();
        }
        public void Inreport()
        {
            UC_ReportPXuat us = new UC_ReportPXuat();
            panelPhieuBanHang.Controls.Clear();
            panelPhieuBanHang.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
        private void InPhieuBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
