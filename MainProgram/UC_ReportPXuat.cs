using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.IO;
using CrystalDecisions.Shared;

namespace MainProgram
{
    public partial class UC_ReportPXuat : UserControl
    {
        public UC_ReportPXuat()
        {
            InitializeComponent();
        }
        private void UC_ReportPXuat_Load(object sender, EventArgs e)
        {
            string line;
            using (StreamReader sr = new StreamReader("SoPX.txt"))
            {

                line = sr.ReadLine();
            }
            PhieuXuat_DTOBindingSource.DataSource = PhieuXuat_BUS.TimKiemInRP(line);
            this.reportViewer1.RefreshReport();
            //DataTable dt = new DataTable();
            //dt = PhieuXuat_BUS.TimKiemInRP2(line);
            //CrystalReportPhieuXuat rp = new CrystalReportPhieuXuat();
            //rp.SetDataSource(dt);
            //crystalReportViewer1.ReportSource = rp;
            //crystalReportViewer1.Refresh();
        }
    }
}
