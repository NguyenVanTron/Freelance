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
    public partial class UC_BaoCaoTongHop : UserControl
    {
        public UC_BaoCaoTongHop()
        {
            InitializeComponent();
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
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
                //donothing
            }
            else
            {
                dataGVHangHoa.DataSource = lsst;
            }
        }
        private void LoadBaoCao()
        {
            List<BaoCaoTongHop_DTO> list = BaoCaoTongHop_BUS.LoadBaoCao();
            dataGVHangHoa.DataSource = list;
            if(list != null)
            {
                dataGVHangHoa.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
                dataGVHangHoa.Columns["SLTonDK"].HeaderText = "Số lượng";
                dataGVHangHoa.Columns["DGTonDK"].HeaderText = "Đơn giá";
                dataGVHangHoa.Columns["TTTonDK"].HeaderText = "Thanh tiền";
                dataGVHangHoa.Columns["SLNhapTK"].HeaderText = "Số lượng";
                dataGVHangHoa.Columns["DGNhapTK"].HeaderText = "Đơn giá";
                dataGVHangHoa.Columns["TTNhapTK"].HeaderText = "Thành tiền";
                dataGVHangHoa.Columns["SLXuatTK"].HeaderText = "Số lượng";
                dataGVHangHoa.Columns["DGXuatTK"].HeaderText = "Đơn giá vốn";
                dataGVHangHoa.Columns["TTXuatTK"].HeaderText = "Thành tiền";
                dataGVHangHoa.Columns["SLTonCK"].HeaderText = "Số lượng";
                dataGVHangHoa.Columns["DGTonCK"].HeaderText = "Đơn giá";
                dataGVHangHoa.Columns["TTTonCK"].HeaderText = "Thành tiền";
                //
                dataGVHangHoa.Columns["TenHangHoa"].Width = 160;
                dataGVHangHoa.Columns["STT"].Width = 60;
                dataGVHangHoa.Columns["SLTonDK"].Width = 88;
                dataGVHangHoa.Columns["DGTonDK"].Width = 89;
                dataGVHangHoa.Columns["TTTonDK"].Width = 88;
                dataGVHangHoa.Columns["SLNhapTK"].Width = 89;
                dataGVHangHoa.Columns["DGNhapTK"].Width = 88;
                dataGVHangHoa.Columns["TTNhapTK"].Width = 89;
                dataGVHangHoa.Columns["SLXuatTK"].Width = 88;
                dataGVHangHoa.Columns["DGXuatTK"].Width = 89;
                dataGVHangHoa.Columns["TTXuatTK"].Width = 88;
                dataGVHangHoa.Columns["SLTonCK"].Width = 89;
                dataGVHangHoa.Columns["DGTonCK"].Width = 88;
                dataGVHangHoa.Columns["TTTonCK"].Width = 89;
                BaoCaoTongHop_DTO baocao = BaoCaoTongHop_BUS.TongKetBaoCao();
                soluongdk.Text = baocao.SLTonDK.ToString();
                thanhtiendk.Text = baocao.TTTonDK.ToString();
                soluongn.Text = baocao.SLNhapTK.ToString();
                thanhtienn.Text = baocao.TTNhapTK.ToString();
                soluongx.Text = baocao.SLXuatTK.ToString();
                thanhtienx.Text = baocao.TTXuatTK.ToString();
                soluongck.Text = baocao.SLTonCK.ToString();
                thanhtienck.Text = baocao.TTTonCK.ToString();
            }
        }
        private void UC_BaoCaoTongHop_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(timKiem,"Tìm kiếm khách hàng");
            toolTip.SetToolTip(xuatFileExcel, "Xuất dữ liệu ra excel");
            toolTip.SetToolTip(xoaHH, "Xóa một hàng hóa");
            toolTip.SetToolTip(capNhatLai, "Cập nhật lại từ đầu");
        }

        private void xoaHH_Click(object sender, EventArgs e)
        {
            if (BaoCaoTongHop_BUS.XoaBaoCao(strTenHangHoa) == true)
            {
                
                LoadBaoCao();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }
        public string strTenHangHoa;
        private void dataGVHangHoa_Click(object sender, EventArgs e)
        {
            if (dataGVHangHoa.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_BaoCao = dataGVHangHoa.SelectedRows[0];
            strTenHangHoa = dr_BaoCao.Cells["TenHangHoa"].Value.ToString();
        }

        private void capNhatLai_Click(object sender, EventArgs e)
        {
            if (BaoCaoTongHop_BUS.CapNhatLaiTuDau())
            {
                LoadBaoCao();
                MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông báo");
            }
            
        }
    }
}
