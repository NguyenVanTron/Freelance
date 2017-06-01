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
using DTO;
namespace MainProgram
{
    public partial class UC_DSPhieuNhap : UserControl
    {
        public UC_DSPhieuNhap()
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
        private void LoadDSPhieuNhap()
        {
            long TongPhieuXuat = 0;
            List<PhieuNhap_DTO> list = PhieuNhap_BUS.TimKiemPhieuNhap(dateTimeFrom.Text.ToString(), dateTimeTO.Text.ToString());
            if (list != null)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    TongPhieuXuat += list[i].TongTien;
                }
            }
            else
                return;
            tongTien.Text = TongPhieuXuat.ToString();
            dataGVPhieu.DataSource = list;
            if (list != null)
            {
                dataGVPhieu.Columns["SoPN"].HeaderText = "Số phiếu nhập";
                dataGVPhieu.Columns["NgayNhap"].HeaderText = "Ngày nhập";

                dataGVPhieu.Columns["MaNCC"].Visible = false;
                dataGVPhieu.Columns["MaHangHoa"].Visible = false;
                dataGVPhieu.Columns["TenHangHoa"].Visible = false;
                dataGVPhieu.Columns["DonViTinh"].Visible = false;
                dataGVPhieu.Columns["SoLuong"].Visible = false;
                dataGVPhieu.Columns["GiaNhap"].Visible = false;

                dataGVPhieu.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGVPhieu.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataGVPhieu.Columns["GhiChu"].HeaderText = "Ghi chú";

                dataGVPhieu.Columns["ChiecKhau"].Visible = false;
                dataGVPhieu.Columns["GTGT"].Visible = false;

                dataGVPhieu.Columns["NgayNhap"].Width = 500;
                dataGVPhieu.Columns["ThanhTien"].Width = 550;
                dataGVPhieu.Columns["SoPN"].Width = 250;
                dataGVPhieu.Columns["GhiChu"].Visible = false;
                dataGVPhieu.Columns["IDKey"].Visible = false;
            }
        }
        private void UC_DSPhieuNhap_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(timKiem, "Tìm kiếm phiếu theo ngày");
            tooltip.SetToolTip(xoaPhieu, "Xóa phiếu xuất");
            tooltip.SetToolTip(xuatExcel, "Xuất dữ liệu thành excel");
            LoadDSPhieuNhap();
        }
        public string strSoPN;
        private void dataGVPhieu_Click(object sender, EventArgs e)
        {
            if (dataGVPhieu.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_PhieuNhap = dataGVPhieu.SelectedRows[0];
            strSoPN= dr_PhieuNhap.Cells["SoPN"].Value.ToString();
            List<PhieuNhap_DTO> list = PhieuNhap_BUS.TimKiemPhieuNhapTG(strSoPN);
            dataGVDSSanPham.DataSource = list;
            if (list != null)
            {
                dataGVDSSanPham.Columns["SoPN"].Visible = false;
                dataGVDSSanPham.Columns["NgayNhap"].Visible = false;

                dataGVDSSanPham.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVDSSanPham.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
                dataGVDSSanPham.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
                dataGVDSSanPham.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVDSSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGVDSSanPham.Columns["GiaNhap"].HeaderText = "Giá nhập";

                dataGVDSSanPham.Columns["ThanhTien"].HeaderText = "Thanh tiền";
                dataGVDSSanPham.Columns["GhiChu"].Visible = false;

                dataGVDSSanPham.Columns["ChiecKhau"].HeaderText = "Chiếc khấu";
                dataGVDSSanPham.Columns["GTGT"].HeaderText = "VAT(%)";
                
                dataGVDSSanPham.Columns["MaHangHoa"].Width = 150;
                dataGVDSSanPham.Columns["MaNCC"].Width = 150;
                dataGVDSSanPham.Columns["SoLuong"].Width = 120;
                dataGVDSSanPham.Columns["DonViTinh"].Width = 150;
                dataGVDSSanPham.Columns["GiaNhap"].Width = 150;
                dataGVDSSanPham.Columns["TenHangHoa"].Width = 150;
                dataGVDSSanPham.Columns["STT"].Width = 50;
                dataGVDSSanPham.Columns["ThanhTien"].Width = 150;
                dataGVDSSanPham.Columns["IDKey"].Visible = false;
            }
        }

        private void xoaPhieu_Click(object sender, EventArgs e)
        {
            PhieuNhap_DTO hhDTO = new PhieuNhap_DTO();

            hhDTO.SoPN = strSoPN;
            if (PhieuNhap_BUS.XoaPhieuNhap(hhDTO) == true)
            {
                LoadDSPhieuNhap();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }

        private void xuatExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVPhieu);
        }
    }
}
