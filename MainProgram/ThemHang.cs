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
namespace MainProgram
{
    public partial class ThemHang : Form
    {
        public ThemHang()
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
        private void LoadHang()
        {
            List<HangHoa_DTO> lsthanghoa = HangHoa_BUS.LoadHangHoa();
            dataGVNhapHang.DataSource = lsthanghoa;
            if (lsthanghoa != null)
            {

                dataGVNhapHang.Columns["MaHang"].HeaderText = "Mã hàng";
                dataGVNhapHang.Columns["TenHang"].HeaderText = "Tên hàng";
                dataGVNhapHang.Columns["DungTich"].HeaderText = "Dung tích";
                dataGVNhapHang.Columns["HoatChat"].HeaderText = "Hoạt chất";
                dataGVNhapHang.Columns["DoiTuong"].HeaderText = "Đối tượng";
                dataGVNhapHang.Columns["Loai"].HeaderText = "Loại";
                dataGVNhapHang.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVNhapHang.Columns["QuiCach"].HeaderText = "Qui cách";
                dataGVNhapHang.Columns["CachDung"].HeaderText = "Cách dùng";
                dataGVNhapHang.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVNhapHang.Columns["GiaCu"].HeaderText = "Giá nhập cũ";
                dataGVNhapHang.Columns["GiaNhap"].HeaderText = "Giá mới";
                dataGVNhapHang.Columns["GiaBan"].HeaderText = "Giá xuất";
                dataGVNhapHang.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGVNhapHang.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dataGVNhapHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGVNhapHang.Columns["MaNCC"].Width = 150;

            }
        }
        private void LoadCmbMaCC()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(themhanghoa, "Thêm mới hàng hóa");
            tooltip.SetToolTip(suaHang, "Sửa thông tin hàng hóa");
            tooltip.SetToolTip(xoaHang, "Xóa một hàng hóa");
            tooltip.SetToolTip(xuatFileExcel, "Lưu dữ liệu thành file excel");
            tooltip.SetToolTip(timKiemHH, "Tìm kiếm hàng hóa");
            List<NhaCungCap_DTO> list = NhaCungCap_BUS.LoadNhaCungCap();
            MaNCC.DataSource = list;
            MaNCC.DisplayMember = "MaNCC";
            MaNCC.ValueMember = "MaNCC";
        }
        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            LoadHang();
            LoadCmbMaCC();
        }

        private void tbNhapTenHH_Click(object sender, EventArgs e)
        {
            tbNhapTenHH.Text = "";
        }

        private void xuatFileExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVNhapHang);
        }
        private bool ThongBao(string a,string c)
        {
            if (a == "")
            {
                MessageBox.Show("Bạn cần điền mục " +c, "Thông Báo");
                return true;
            }
            return false;
        }
        private void themHang_Click(object sender, EventArgs e)
        {
            //if (maHang.Text == "" ||  datetimeNgayNhap.Text == "" ||
            //   tenHang.Text == "" || giaBan.Text == "" ||
            //   hoatChat.Text == "" || giaNhap.Text == "" ||
            //   dungTich.Text == "" || donViTinh.Text == "" ||
            //   doiTuong.Text == "" || cachDung.Text == "" ||
            //   soLuong.Text == "" || quiCach.Text == "" ||
            //   MaNCC.Text == "" || loai.Text == "")

            //{
            //    MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
            //    return;
            //}
            if (ThongBao(maHang.Text, "Mã hàng !"))
                return;
            if (ThongBao(soLuong.Text, "Số lượng !"))
                return;
            if (ThongBao(datetimeNgayNhap.Text, "Ngày nhập !"))
                return;
            if (ThongBao(tenHang.Text, "Tên hàng !"))
                return;
            if (ThongBao(giaBan.Text, "Giá bán !"))
                return;
            if (ThongBao(giaNhap.Text, "Giá nhập !"))
                return;
            if (ThongBao(hoatChat.Text, "Hoạt chất !"))
                return;
            if (ThongBao(doiTuong.Text, "Đối tượng !"))
                return;
            if (ThongBao(dungTich.Text, "Dung tích !"))
                return;
            if (ThongBao(cachDung.Text, "Cách dùng !"))
                return;
            if (ThongBao(quiCach.Text, "Qui cách !"))
                return;
            if (ThongBao(loai.Text, "Loại !"))
                return;
            if (ThongBao(MaNCC.Text, "Mã nhà cung cấp !"))
                return;
            if (ThongBao(donViTinh.Text, "Đơn vị tính !"))
                return;
            HangHoa_DTO hhDTO = new HangHoa_DTO();
            hhDTO.MaHang = maHang.Text;
            hhDTO.TenHang = tenHang.Text;
            hhDTO.HoatChat = hoatChat.Text;
            hhDTO.DungTich = dungTich.Text;
            hhDTO.DoiTuong = doiTuong.Text;
            hhDTO.MaNCC = MaNCC.Text;
            hhDTO.Loai = loai.Text;
            hhDTO.QuiCach = long.Parse(quiCach.Text.ToString());
            hhDTO.CachDung = cachDung.Text;
            hhDTO.DonViTinh = donViTinh.Text;
            hhDTO.GiaNhap = long.Parse(giaNhap.Text.ToString());
            hhDTO.GiaBan = long.Parse(giaBan.Text.ToString());
            hhDTO.GiaCu = long.Parse(giaNhap.Text.ToString());
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.NgayNhap = DateTime.Parse(datetimeNgayNhap.Text.ToString());

            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (HangHoa_BUS.ThemHangHoa(hhDTO) == true)
            {
                LoadHang();
                return;
            }
            else
            {
                MessageBox.Show("Thêm không Thành Công", "Thông Báo");
                return;
            }
        }
        //Sửa khách hàng
        public long IDHH;
        public String strmaHang;
        private void suaHang_Click(object sender, EventArgs e)
        {
            if (ThongBao(maHang.Text, "Mã hàng !"))
                return;
            if (ThongBao(soLuong.Text, "Số lượng !"))
                return;
            if (ThongBao(datetimeNgayNhap.Text, "Ngày nhập !"))
                return;
            if (ThongBao(tenHang.Text, "Tên hàng !"))
                return;
            if (ThongBao(giaBan.Text, "Giá bán !"))
                return;
            if (ThongBao(giaNhap.Text, "Giá nhập !"))
                return;
            if (ThongBao(hoatChat.Text, "Hoạt chất !"))
                return;
            if (ThongBao(doiTuong.Text, "Đối tượng !"))
                return;
            if (ThongBao(dungTich.Text, "Dung tích !"))
                return;
            if (ThongBao(cachDung.Text, "Cách dùng !"))
                return;
            if (ThongBao(quiCach.Text, "Qui cách !"))
                return;
            if (ThongBao(loai.Text, "Loại !"))
                return;
            if (ThongBao(MaNCC.Text, "Mã nhà cung cấp !"))
                return;
            if (ThongBao(donViTinh.Text, "Đơn vị tính !"))
                return;
            HangHoa_DTO hhDTO = new HangHoa_DTO();
            hhDTO.STT = IDHH;
            hhDTO.MaHang = maHang.Text;
            strmaHang = hhDTO.MaHang;
            hhDTO.TenHang = tenHang.Text;
            hhDTO.HoatChat = hoatChat.Text;
            hhDTO.DungTich = dungTich.Text;
            hhDTO.DoiTuong = doiTuong.Text;
            hhDTO.MaNCC = MaNCC.Text;
            hhDTO.Loai = loai.Text;
            hhDTO.QuiCach = long.Parse(quiCach.Text.ToString());
            hhDTO.CachDung = cachDung.Text;
            hhDTO.DonViTinh = donViTinh.Text;
            hhDTO.GiaNhap = long.Parse(giaNhap.Text.ToString());
            hhDTO.GiaBan = long.Parse(giaBan.Text.ToString());

            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.NgayNhap = DateTime.Parse(datetimeNgayNhap.Text.ToString());

            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (HangHoa_BUS.SuaHangHoa(hhDTO) == true)
            {
                LoadHang();
                return;
            }
            else
            {
                MessageBox.Show("Sửa không Thành Công", "Thông Báo");
                return;
            }
        }

        private void dataGVNhapHang_Click(object sender, EventArgs e)
        {
            if (dataGVNhapHang.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_HangHoa = dataGVNhapHang.SelectedRows[0];
            IDHH = long.Parse(dr_HangHoa.Cells["STT"].Value.ToString());
            maHang.Text = dr_HangHoa.Cells["MaHang"].Value.ToString();
            strmaHang = maHang.Text;
            tenHang.Text = dr_HangHoa.Cells["TenHang"].Value.ToString();
            hoatChat.Text = dr_HangHoa.Cells["HoatChat"].Value.ToString();
            dungTich.Text = dr_HangHoa.Cells["DungTich"].Value.ToString();
            doiTuong.Text = dr_HangHoa.Cells["DoiTuong"].Value.ToString();
            loai.Text = dr_HangHoa.Cells["Loai"].Value.ToString();
            MaNCC.Text = dr_HangHoa.Cells["MaNCC"].Value.ToString();
            quiCach.Text = dr_HangHoa.Cells["QuiCach"].Value.ToString();
            cachDung.Text = dr_HangHoa.Cells["CachDung"].Value.ToString();
            donViTinh.Text = dr_HangHoa.Cells["DonViTinh"].Value.ToString();
            giaNhap.Text = dr_HangHoa.Cells["GiaNhap"].Value.ToString();
            giaBan.Text = dr_HangHoa.Cells["GiaBan"].Value.ToString();
            soLuong.Text = dr_HangHoa.Cells["SoLuong"].Value.ToString();
            datetimeNgayNhap.Text = dr_HangHoa.Cells["NgayNhap"].Value.ToString();

        }

        private void xoaHang_Click(object sender, EventArgs e)
        {
            HangHoa_DTO hhDTO = new HangHoa_DTO();

            hhDTO.STT = IDHH;
            hhDTO.MaHang = strmaHang;
            if (HangHoa_BUS.XoaHangHoa(hhDTO) == true)
            {
                LoadHang();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }

        private void tiemKiemHH_Click(object sender, EventArgs e)
        {
            string stukhoa = tbNhapTenHH.Text.ToString();
            List<HangHoa_DTO> lsst = HangHoa_BUS.TimKiemHangHoa(stukhoa);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVNhapHang.DataSource = lsst;
            }
        }
    }
}
