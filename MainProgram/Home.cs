using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace MainProgram
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            String NameData = "";
            using (StreamReader sr = new StreamReader("ChoseName.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Thêm item combobox
                    NameData = line.ToString();
                }
            }
            NamedatabaseToolStripMenuItem.Text = NameData;
            homeToolStripMenuItem.ForeColor = Color.Red;
        }

        private void menuItemKhachHang_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Red;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            menuItemKhachHang.ForeColor = Color.Green;
            nhàCungCấpToolStripMenuItem.ForeColor = Color.Black;
            hàngHóaToolStripMenuItem.ForeColor = Color.Black;
            UCS_KhachHang us = new UCS_KhachHang();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Red;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            menuItemKhachHang.ForeColor = Color.Black;
            nhàCungCấpToolStripMenuItem.ForeColor = Color.Black;
            hàngHóaToolStripMenuItem.ForeColor = Color.Green;
            US_HangHoa us = new US_HangHoa();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Red;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            cậpNhậtPhiếuNhậpToolStripMenuItem.ForeColor = Color.Black;
            danhSáchNhậpHàngToolStripMenuItem.ForeColor = Color.Black;
            nhậpHàngToolStripMenuItem.ForeColor = Color.Green;
            UC_NhapHang us = new UC_NhapHang();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void danhSáchNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Red;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            cậpNhậtPhiếuNhậpToolStripMenuItem.ForeColor = Color.Black;
            danhSáchNhậpHàngToolStripMenuItem.ForeColor = Color.Black;
            nhậpHàngToolStripMenuItem.ForeColor = Color.Green;
            UC_DSNhapHang us = new UC_DSNhapHang();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void cậpNhậtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Red;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            cậpNhậtPhiếuXuấtToolStripMenuItem.ForeColor = Color.Green;
            ToolPhieuXuat us = new ToolPhieuXuat();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Red;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            menuItemKhachHang.ForeColor = Color.Black;
            nhàCungCấpToolStripMenuItem.ForeColor = Color.Green;
            hàngHóaToolStripMenuItem.ForeColor = Color.Black;
            UC_NhaCungCap us = new UC_NhaCungCap();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void cậpNhậtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Red;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            cậpNhậtPhiếuNhậpToolStripMenuItem.ForeColor = Color.Green;
            danhSáchNhậpHàngToolStripMenuItem.ForeColor = Color.Black;
            nhậpHàngToolStripMenuItem.ForeColor = Color.Black;
            ToolPhieuNhap us = new ToolPhieuNhap();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void côngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Red;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            côngNợToolStripMenuItem.ForeColor = Color.Green;
            baoCaoToolStripMenuItem.ForeColor = Color.Black;
            UC_CongNo us = new UC_CongNo();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
        
        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Black;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Red;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            côngNợToolStripMenuItem.ForeColor = Color.Black;
            baoCaoToolStripMenuItem.ForeColor = Color.Green;
            UC_Report us = new UC_Report();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
        public void Inreport()
        {
            UC_ReportPXuat us = new UC_ReportPXuat();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }

        private void chinhsuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDatabase us = new ChangeDatabase();
            us.ShowDialog();
            String NameData = "";
            using (StreamReader sr = new StreamReader("ChoseName.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Thêm item combobox
                    NameData = line.ToString();
                }
            }
            NamedatabaseToolStripMenuItem.Text = NameData;
        }

        private void giúpĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string path1 = "\\help.docx";
            Process.Start(path + path1);
        }

        private void hàngTrảLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhMụcToolStripMenuItem.ForeColor = Color.Black;
            xuấtKhoToolStripMenuItem.ForeColor = Color.Red;
            nhậpKhoToolStripMenuItem.ForeColor = Color.Black;
            thốngKêBáoCáoToolStripMenuItem.ForeColor = Color.Black;
            giúpĐỡToolStripMenuItem.ForeColor = Color.Black;
            homeToolStripMenuItem.ForeColor = Color.Black;

            cậpNhậtPhiếuXuấtToolStripMenuItem.ForeColor = Color.Black;
            hàngTrảLạiToolStripMenuItem.ForeColor = Color.Green;
            ToolPhieuTra us = new ToolPhieuTra();
            panelHome.Controls.Clear();
            panelHome.Controls.Add(us);
            us.Dock = DockStyle.Fill;
        }
    }
}
