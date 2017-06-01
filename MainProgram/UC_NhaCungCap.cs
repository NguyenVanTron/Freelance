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
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
            nhomNCC.Items.Add("Đối tác cung cấp");
            nhomNCC.Items.Add("Nhà cung cấp dịch vụ");
            nhomNCC.Text = "Đối tác cung cấp";
        }

        private void UC_NhaCungCap_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(themNCC, "Thêm mới nhà cung cấp");
            tooltip.SetToolTip(suaNCC, "Sửa thông tin nhà cung cấp");
            tooltip.SetToolTip(xoaNCC, "Xóa nhà cung cấp");
            tooltip.SetToolTip(xuatFileExcel, "Lưu dữ liệu thành excel");
            tooltip.SetToolTip(timKiemNCC, "Tìm kiếm nhà cung cấp");
            LoadgvNhaCungCap();
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
            ExportExcel(saveFileDialog1, dataGVNCC);
        }

        private void tbNhapTenNCC_Click(object sender, EventArgs e)
        {
            tbNhapTenKH.Text = "";
        }
        //load
        private void LoadgvNhaCungCap()
        {
            List<NhaCungCap_DTO> lsNhaCungCap = NhaCungCap_BUS.LoadNhaCungCap();
            dataGVNCC.DataSource = lsNhaCungCap;
            if (lsNhaCungCap != null)
            {
                //dataGVNCC.Columns["STT"].Visible = false;
                dataGVNCC.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                dataGVNCC.Columns["SDT"].HeaderText = "Số điện thoại";
                dataGVNCC.Columns["NhomNCC"].HeaderText = "Nhóm nhà cung cấp";
                dataGVNCC.Columns["NguoiGiaoDich"].HeaderText = "Người giao dịch";
                dataGVNCC.Columns["Email"].HeaderText = "Email";
                dataGVNCC.Columns["GhiChu"].HeaderText = "Ghi Chú";
                //
                dataGVNCC.Columns["MaNCC"].Width = 150;
                dataGVNCC.Columns["TenNCC"].Width = 150;
                dataGVNCC.Columns["SDT"].Width = 100;
                dataGVNCC.Columns["NguoiGiaoDich"].Width = 200;
                dataGVNCC.Columns["Email"].Width = 200;
                dataGVNCC.Columns["GhiChu"].Width = 200;
            }
            //ẩn cột

        }
        //Thêm mới
        private bool ThongBao(string a, string c)
        {
            if (a == "")
            {
                MessageBox.Show("Bạn cần điền mục " + c, "Thông Báo");
                return true;
            }
            return false;
        }
        private void themNhaCungCap_Click(object sender, EventArgs e)
        {
            //if (tb_maNCC.Text == "" || tb_tenNCC.Text == "" || tb_SDT.Text == "" || tb_nguoiGiaoDich.Text == "" || nhomNCC.Text == "")
            //{
            //    MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
            //    return;
            //}
            if (ThongBao(tb_maNCC.Text, "Mã nhà cung cấp !"))
                return;
            if (ThongBao(tb_tenNCC.Text, "Tên nhà cung cấp !"))
                return;
            if (ThongBao(tb_SDT.Text, "Số điện thoại !"))
                return;
            if (ThongBao(tb_nguoiGiaoDich.Text, "Người giao dịch !"))
                return;
            if (ThongBao(nhomNCC.Text, "Nhóm nhà cung cấp !"))
                return;
            if (tb_email.Text == "")
            {
                tb_email.Text = "Không có";
            }
            if (tb_ghichu.Text == "")
            {
                tb_ghichu.Text = "Không có";
            }
            NhaCungCap_DTO khDTO = new NhaCungCap_DTO();
            khDTO.MaNCC = tb_maNCC.Text;
            khDTO.TenNCC = tb_tenNCC.Text;
            khDTO.NhomNCC = nhomNCC.Text;
            khDTO.SDT = tb_SDT.Text;
            khDTO.NguoiGiaoDich = tb_nguoiGiaoDich.Text;
            khDTO.Email = tb_email.Text;
            khDTO.GhiChu = tb_ghichu.Text;
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (NhaCungCap_BUS.themNhaCungCap(khDTO) == true)
            {
                LoadgvNhaCungCap();
                return;
            }
            else
            {
                MessageBox.Show("Thêm không Thành Công", "Thông Báo");
                return;
            }
        }
        //Sửa khách hàng
        public long IDKH;
        public String strMaNCC;
        private void suaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (ThongBao(tb_maNCC.Text, "Mã nhà cung cấp !"))
                return;
            if (ThongBao(tb_tenNCC.Text, "Tên nhà cung cấp !"))
                return;
            if (ThongBao(tb_SDT.Text, "Số điện thoại !"))
                return;
            if (ThongBao(tb_nguoiGiaoDich.Text, "Người giao dịch !"))
                return;
            if (ThongBao(nhomNCC.Text, "Nhóm nhà cung cấp !"))
                return;
            if (tb_email.Text == "")
            {
                tb_email.Text = "Không có";
            }
            if (tb_ghichu.Text == "")
            {
                tb_ghichu.Text = "Không có";
            }
            NhaCungCap_DTO khDTO = new NhaCungCap_DTO();

            khDTO.STT = IDKH;
            khDTO.MaNCC = tb_maNCC.Text;
            khDTO.MaNCC = strMaNCC;
            khDTO.TenNCC = tb_tenNCC.Text;
            khDTO.NhomNCC = nhomNCC.Text;
            khDTO.SDT = tb_SDT.Text;
            khDTO.NguoiGiaoDich = tb_nguoiGiaoDich.Text;
            khDTO.Email = tb_email.Text;
            khDTO.GhiChu = tb_ghichu.Text;
            if (NhaCungCap_BUS.suaNhaCungCap(khDTO) == true)
            {
                LoadgvNhaCungCap();
                return;
            }
            else
            {
                MessageBox.Show("Sửa không Thành Công", "Thông Báo");
                return;
            }
        }
        //Xóa khách hàng
        private void xoaNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap_DTO khDTO = new NhaCungCap_DTO();

            khDTO.STT = IDKH;
            khDTO.MaNCC = strMaNCC;
            if (NhaCungCap_BUS.xoaNhaCungCap(khDTO) == true)
            {
                LoadgvNhaCungCap();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }
        //tiem kiem
        private void tiemKiemNCC_Click(object sender, EventArgs e)
        {
            string stukhoa = tbNhapTenKH.Text.ToString();
            List<NhaCungCap_DTO> lsst = NhaCungCap_BUS.TimkiemNhaCungCap(stukhoa);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVNCC.DataSource = lsst;
            }
        }

        private void dataGVNCC_Click(object sender, EventArgs e)
        {

            if (dataGVNCC.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_NhaCungCap = dataGVNCC.SelectedRows[0];
            IDKH = int.Parse(dr_NhaCungCap.Cells["STT"].Value.ToString());
            tb_maNCC.Text = dr_NhaCungCap.Cells["MaNCC"].Value.ToString();
            strMaNCC = tb_maNCC.Text;
            nhomNCC.Text = dr_NhaCungCap.Cells["NhomNCC"].Value.ToString();
            tb_tenNCC.Text = dr_NhaCungCap.Cells["TenNCC"].Value.ToString();
            tb_SDT.Text = dr_NhaCungCap.Cells["SDT"].Value.ToString();
            tb_nguoiGiaoDich.Text = dr_NhaCungCap.Cells["NguoiGiaoDich"].Value.ToString();
            tb_email.Text = dr_NhaCungCap.Cells["Email"].Value.ToString();
            tb_ghichu.Text = dr_NhaCungCap.Cells["GhiChu"].Value.ToString();
        }
    }
}
