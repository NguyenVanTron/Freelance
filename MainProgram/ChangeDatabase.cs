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
namespace MainProgram
{
    public partial class ChangeDatabase : Form
    {
        public ChangeDatabase()
        {
            InitializeComponent();
        }

        private void ChangeDatabase_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(chonDuLieu, "Chọn dữ liệu");
            tooltip.SetToolTip(ketNoiDuLieu, "Kết nối dữ liệu");
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Thêm item combobox
                    chonDuLieu.Items.Add(line);
                    if (line != null)
                        chonDuLieu.Text = line;
                }

            }

        }

        private void ketNoiDuLieu_Click(object sender, EventArgs e)
        {
            String NameData = chonDuLieu.Text.ToString();
            if (chonDuLieu.Text == "")
            {
                MessageBox.Show("Bạn phải chọn cơ sỏ dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] AName = new string[] { NameData };
            String line;
            bool flagsCheckName = false;
            if (System.IO.File.Exists("DataBase.txt") == false)
            {
                MessageBox.Show("Cơ sở dữ liệu chưa có bạn cần phải chọn lại. !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    if (NameData == line)
                    {
                        flagsCheckName = true;
                    }
                }
            }
            if (flagsCheckName == false)
            {
                MessageBox.Show("Cơ sở dữ liệu chưa có bạn cần phải chọn lại. !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamWriter sw = new StreamWriter("ChoseName.txt"))
            {
                //sw.WriteLine(DateTime.Now.ToString() + Environment.NewLine);
                foreach (string s in AName)
                {
                    sw.WriteLine(s);
                }
            }
            this.Close();
        }
    }
}
