using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace MainProgram
{
    public partial class US_HangHoa : UserControl
    {
        public US_HangHoa()
        {
            InitializeComponent();
        }

        private void timkiemTenHang_Click(object sender, EventArgs e)
        {
            timkiemTenHang.Text = "";
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            string stukhoa = timkiemTenHang.Text.ToString();
            List<HangHoa_DTO> lsst = HangHoa_BUS.TimKiemHangHoa(stukhoa);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVHangHoa.DataSource = lsst;
            }
        }
        public void LoadDataGVHangHoa()
        {
            List<HangHoa_DTO> lsHH = HangHoa_BUS.LoadHangHoa();

            dataGVHangHoa.DataSource = lsHH;
            if (lsHH != null)
            {
                dataGVHangHoa.Columns["MaHang"].HeaderText = "Mã hàng";
                dataGVHangHoa.Columns["TenHang"].HeaderText = "Tên hàng";
                dataGVHangHoa.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVHangHoa.Columns["DungTich"].HeaderText = "Dung tích";
                dataGVHangHoa.Columns["Loai"].HeaderText = "Loại";
                dataGVHangHoa.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dataGVHangHoa.Columns["GiaBan"].HeaderText = "Giá xuất";
                //

                dataGVHangHoa.Columns["MaHang"].Width = 200;
                dataGVHangHoa.Columns["TenHang"].Width = 200;
                dataGVHangHoa.Columns["DonViTinh"].Width = 200;
                dataGVHangHoa.Columns["DungTich"].Width = 200;
                dataGVHangHoa.Columns["Loai"].Width = 200;
                dataGVHangHoa.Columns["GiaNhap"].Width = 200;
                dataGVHangHoa.Columns["GiaBan"].Width = 200;
                //
                dataGVHangHoa.Columns["NgayNhap"].Visible = false;
                dataGVHangHoa.Columns["DungTich"].Visible = false;
                dataGVHangHoa.Columns["HoatChat"].Visible = false;
                dataGVHangHoa.Columns["MaNCC"].Visible = false;
                dataGVHangHoa.Columns["CachDung"].Visible = false;
                dataGVHangHoa.Columns["ThanhTien"].Visible = false;
                dataGVHangHoa.Columns["SoLuong"].Visible = false;
                dataGVHangHoa.Columns["DoiTuong"].Visible = false;
                dataGVHangHoa.Columns["QuiCach"].Visible = false;
                dataGVHangHoa.Columns["GiaCu"].Visible = false;


            }
        }
        private void US_HangHoa_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(timKiem, "Tìm kiếm hàng hóa");
            tooltip.SetToolTip(xuatFileExcel, "Lưu dữ liệu xuống excel");
            LoadDataGVHangHoa();
        }
        public void ExportExcel(SaveFileDialog Name, DataGridView DataName)
        {
            Name.InitialDirectory = "C:";
            Name.Title = "Save as to excel file";
            Name.FileName = "";
            Name.Filter = "Excel File(2003)|*.xls|Excel File(2007) | *.xlsx";
            if (Name.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add();
                ExcelApp.Columns.ColumnWidth = 20;
                //storing header part in excel
                for (int i = 1; i < DataName.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = DataName.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < DataName.Rows.Count; i++)
                {
                    for (int j = 0; j < DataName.Columns.Count; j++)
                    {
                        if (DataName.Rows[i].Cells[j].Value != null)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = DataName.Rows[i].Cells[j].Value.ToString();
                        }
                        else {

                        }
                    }

                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(Name.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();

            }
        }
        private void xuatFileExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVHangHoa);
        }
    }
}
