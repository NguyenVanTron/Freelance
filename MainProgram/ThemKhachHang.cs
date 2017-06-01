using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Office.Interop.Excel;
namespace MainProgram
{
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
            nhomKH.Items.Add("Khách hàng mua lẻ");
            nhomKH.Items.Add("Khách hàng đại lý");
            nhomKH.Text = "Khách hàng đại lý";

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
            ExportExcel(saveFileDialog1, dataGVKhachHang);
        }

        private void tbNhapTenKH_Click(object sender, EventArgs e)
        {
            tbNhapTenKH.Text = "";
        }
        //load
        private void LoadgvKhachHang()
        {
            List<KhachHang_DTO> lskhachhang = KhachHang_BUS.LoadKhachHang();
            dataGVKhachHang.DataSource = lskhachhang;
            if (lskhachhang != null)
            {
                dataGVKhachHang.Columns["Id"].HeaderText = "STT";
                dataGVKhachHang.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVKhachHang.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dataGVKhachHang.Columns["NhomKhachHang"].HeaderText = "Nhóm khách hàng";
                dataGVKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
                dataGVKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dataGVKhachHang.Columns["Email"].HeaderText = "Email";
                dataGVKhachHang.Columns["GhiChu"].HeaderText = "Ghi Chú";
                dataGVKhachHang.Columns["DoanhSo"].HeaderText = "Doanh số";
                //
                dataGVKhachHang.Columns["MaKhachHang"].Width = 150;
                dataGVKhachHang.Columns["TenKhachHang"].Width = 150;
                dataGVKhachHang.Columns["NhomKhachHang"].Width = 150;
                dataGVKhachHang.Columns["SDT"].Width = 100;
                dataGVKhachHang.Columns["DiaChi"].Width = 200;
                dataGVKhachHang.Columns["Email"].Width = 200;
                dataGVKhachHang.Columns["DoanhSo"].Width = 100;
                dataGVKhachHang.Columns["GhiChu"].Width = 200;
            }
            //ẩn cột

        }
        //Load usercotrol
        public String strMaKH;
        private void UCS_KhachHang_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(themkh, "Thêm khách hàng");
            tooltip.SetToolTip(suaKhachHang, "Sửa khách hàng");
            tooltip.SetToolTip(xoaKhachHang, "Xóa khách hàng");
            tooltip.SetToolTip(xuatFileExcel, "Lưu dữ liệu vào excel");
            tooltip.SetToolTip(timKiemKH, "Tìm kiếm khách hàng");
            LoadgvKhachHang();
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
        private void themKhachHang_Click(object sender, EventArgs e)
        {
            //if (tb_makhachhang.Text == "" || tb_tenkhachhang.Text == "" || tb_SDT.Text == "" || tb_diachi.Text == "" || nhomKH.Text == "")
            //{
            //    MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
            //    return;
            //}
            if (ThongBao(tb_makhachhang.Text, "Mã khách hàng !"))
                return;
            if (ThongBao(tb_tenkhachhang.Text, "Tên khách hàng !"))
                return;
            if (ThongBao(tb_SDT.Text, "Số điện thoại !"))
                return;
            if (ThongBao(tb_diachi.Text, "Địa chỉ !"))
                return;
            if (ThongBao(nhomKH.Text, "Nhóm khách hàng !"))
                return;
            if (tb_email.Text == "")
            {
                tb_email.Text = "Không có";
            }
            if (tb_ghichu.Text == "")
            {
                tb_ghichu.Text = "Không có";
            }
            KhachHang_DTO khDTO = new KhachHang_DTO();
            khDTO.MaKhachHang = tb_makhachhang.Text;
            khDTO.TenKhachHang = tb_tenkhachhang.Text;
            khDTO.SDT = tb_SDT.Text;
            khDTO.NhomKhachHang = nhomKH.Text;
            khDTO.DiaChi = tb_diachi.Text;
            khDTO.Email = tb_email.Text;
            khDTO.GhiChu = tb_ghichu.Text;
            khDTO.DoanhSo = 0;
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (KhachHang_BUS.themkhachhang(khDTO) == true)
            {
                LoadgvKhachHang();
                return;
            }
            else
            {
                MessageBox.Show("Thêm không Thành Công", "Thông Báo");
                return;
            }
        }
        //Sửa khách hàng
        public int IDKH;
        private void suaKhachHang_Click(object sender, EventArgs e)
        {
            if (ThongBao(tb_makhachhang.Text, "Mã khách hàng !"))
                return;
            if (ThongBao(tb_tenkhachhang.Text, "Tên khách hàng !"))
                return;
            if (ThongBao(tb_SDT.Text, "Số điện thoại !"))
                return;
            if (ThongBao(tb_diachi.Text, "Địa chỉ !"))
                return;
            if (ThongBao(nhomKH.Text, "Nhóm khách hàng !"))
                return;
            if (tb_email.Text == "")
            {
                tb_email.Text = "Không có";
            }
            if (tb_ghichu.Text == "")
            {
                tb_ghichu.Text = "Không có";
            }
            KhachHang_DTO khDTO = new KhachHang_DTO();

            khDTO.Id = IDKH;
            khDTO.MaKhachHang = tb_makhachhang.Text;
            khDTO.MaKhachHang = strMaKH;
            khDTO.NhomKhachHang = nhomKH.Text;
            khDTO.TenKhachHang = tb_tenkhachhang.Text;
            khDTO.SDT = tb_SDT.Text;
            khDTO.DiaChi = tb_diachi.Text;
            khDTO.Email = tb_email.Text;
            khDTO.GhiChu = tb_ghichu.Text;
            khDTO.DoanhSo = 0;
            if (KhachHang_BUS.suakhachhang(khDTO) == true)
            {
                LoadgvKhachHang();
                return;
            }
            else
            {
                MessageBox.Show("Sửa không Thành Công", "Thông Báo");
                return;
            }
        }
        //Xóa khách hàng
        private void xoaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_DTO khDTO = new KhachHang_DTO();

            khDTO.Id = IDKH;
            khDTO.MaKhachHang = strMaKH;
            if (KhachHang_BUS.xoakhachhang(khDTO) == true)
            {
                LoadgvKhachHang();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }
        //tiem kiem
        private void tiemKiemKH_Click(object sender, EventArgs e)
        {
            string stukhoa = tbNhapTenKH.Text.ToString();
            List<KhachHang_DTO> lsst = KhachHang_BUS.TimkiemKhachHang(stukhoa);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVKhachHang.DataSource = lsst;
            }
        }

        private void dataGVKhachHang_Click(object sender, EventArgs e)
        {

            if (dataGVKhachHang.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_KhachHang = dataGVKhachHang.SelectedRows[0];
            IDKH = int.Parse(dr_KhachHang.Cells["Id"].Value.ToString());
            tb_makhachhang.Text = dr_KhachHang.Cells["MaKhachHang"].Value.ToString();
            strMaKH = tb_makhachhang.Text;
            nhomKH.Text = dr_KhachHang.Cells["NhomKhachHang"].Value.ToString();
            tb_tenkhachhang.Text = dr_KhachHang.Cells["TenKhachHang"].Value.ToString();
            tb_SDT.Text = dr_KhachHang.Cells["SDT"].Value.ToString();
            tb_diachi.Text = dr_KhachHang.Cells["DiaChi"].Value.ToString();
            tb_email.Text = dr_KhachHang.Cells["Email"].Value.ToString();
            tb_ghichu.Text = dr_KhachHang.Cells["GhiChu"].Value.ToString();
        }
    }
}
