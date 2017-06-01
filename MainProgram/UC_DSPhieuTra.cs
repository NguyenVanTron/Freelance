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
using System.IO;
namespace MainProgram
{
    public partial class UC_DSPhieuTra : UserControl
    {
        public UC_DSPhieuTra()
        {
            InitializeComponent();
        }
        private void LoadDSPhieuTra()
        {
            long TongPhieuTra = 0;
            List<PhieuTraHang_DTO> list = PhieuTraHang_BUS.TimKiemPhieuTraHang(dateTimeFrom.Text.ToString(), dateTimeTO.Text.ToString());
            if (list != null)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    TongPhieuTra += list[i].TongTien;
                }
            }
            tongTien.Text = TongPhieuTra.ToString();
            dataGVPhieu.DataSource = list;
            if (list != null)
            {
                dataGVPhieu.Columns["SoPT"].HeaderText = "Số phiếu trả";
                dataGVPhieu.Columns["NgayTra"].HeaderText = "Ngày trả";

                dataGVPhieu.Columns["MaKhachHang"].Visible = false;
                dataGVPhieu.Columns["MaHangHoa"].Visible = false;
                dataGVPhieu.Columns["TenHangHoa"].Visible = false;
                dataGVPhieu.Columns["DonViTinh"].Visible = false;
                dataGVPhieu.Columns["SoLuong"].Visible = false;
                dataGVPhieu.Columns["GiaBan"].Visible = false;

                dataGVPhieu.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGVPhieu.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataGVPhieu.Columns["GhiChu"].HeaderText = "Ghi chú";

                dataGVPhieu.Columns["ChiecKhau"].Visible = false;
                dataGVPhieu.Columns["GTGT"].Visible = false;

                dataGVPhieu.Columns["NgayXuat"].Width = 300;
                dataGVPhieu.Columns["ThanhTien"].Width = 350;
                dataGVPhieu.Columns["TongTien"].Width = 350;
                dataGVPhieu.Columns["SoPT"].Width = 250;
                dataGVPhieu.Columns["GhiChu"].Visible = false;
                dataGVPhieu.Columns["IDKey"].Visible = false;
            }
        }
        public string strSoPT;
        private void dataGVPhieu_Click(object sender, EventArgs e)
        {
            if (dataGVPhieu.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_PhieuXuat = dataGVPhieu.SelectedRows[0];
            strSoPT = dr_PhieuXuat.Cells["SoPT"].Value.ToString();

            List<PhieuTraHang_DTO> list = PhieuTraHang_BUS.TimKiemPhieuTraHangTG(strSoPT);
            dataGVDSSanPham.DataSource = list;
            if (list != null)
            {
                dataGVDSSanPham.Columns["SoPT"].Visible = false;
                dataGVDSSanPham.Columns["NgayTra"].Visible = false;

                dataGVDSSanPham.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVDSSanPham.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
                dataGVDSSanPham.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
                dataGVDSSanPham.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVDSSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGVDSSanPham.Columns["GiaBan"].HeaderText = "Giá xuất";

                dataGVDSSanPham.Columns["ThanhTien"].HeaderText = "Thanh tiền";
                dataGVDSSanPham.Columns["GhiChu"].Visible = false;

                dataGVDSSanPham.Columns["ChiecKhau"].Visible = false;
                dataGVDSSanPham.Columns["GTGT"].Visible = false;

                dataGVDSSanPham.Columns["MaHangHoa"].Width = 110;
                dataGVDSSanPham.Columns["MaKhachHang"].Width = 110;
                dataGVDSSanPham.Columns["SoLuong"].Width = 120;
                dataGVDSSanPham.Columns["DonViTinh"].Width = 110;
                dataGVDSSanPham.Columns["GiaBan"].Width = 150;
                dataGVDSSanPham.Columns["TongTien"].Width = 150;
                dataGVDSSanPham.Columns["TenHangHoa"].Width = 130;
                dataGVDSSanPham.Columns["STT"].Width = 50;
                dataGVDSSanPham.Columns["ThanhTien"].Width = 140;
                dataGVDSSanPham.Columns["IDKey"].Visible = false;
            }
        }
        
        private void xoaPhieu_Click(object sender, EventArgs e)
        {
            PhieuTraHang_DTO hhDTO = new PhieuTraHang_DTO();

            hhDTO.SoPT = strSoPT;
            if (PhieuTraHang_BUS.XoaPhieuTraHang(hhDTO) == true)
            {
                LoadDSPhieuTra();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
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
        private void xuatExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVPhieu);
        }

        private void UC_DSPhieuTra_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(xoaPhieu, "Xóa phiếu nhập");
            tooltip.SetToolTip(xuatExcel, "Lưu dữ liệu thành excel");
            tooltip.SetToolTip(timKiem, "Tìm kiếm dữ liệu theo thời gian");
            LoadDSPhieuTra();
        }
    }
}
