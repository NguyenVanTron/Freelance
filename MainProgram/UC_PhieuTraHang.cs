using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
namespace MainProgram
{
    public partial class UC_PhieuTraHang : UserControl
    {
        public UC_PhieuTraHang()
        {
            InitializeComponent();
        }
        private string strCMaKH;
        public string strCTenKH;
        public string strDiaChi;
        public string strSoPT;
        private void LoadCmbMaKH()
        {
            List<KhachHang_DTO> list = KhachHang_BUS.LoadKhachHang();
            cbMaKH.DataSource = list;
            cbTenKH.DataSource = list;
            nhomKH.DataSource = list;
            nhomKH.DisplayMember = "NhomKhachHang";
            nhomKH.ValueMember = "NhomKhachHang";
            cbdiachi.DataSource = list;
            cbMaKH.DisplayMember = "MaKhachHang";
            cbMaKH.ValueMember = "MaKhachHang";
            strCMaKH = cbMaKH.Text;
            cbTenKH.DisplayMember = "TenKhachHang";
            cbTenKH.ValueMember = "TenKhachHang";
            strCTenKH = cbTenKH.Text;
            cbdiachi.DisplayMember = "DiaChi";
            cbdiachi.ValueMember = "DiaChi";
            strDiaChi = cbdiachi.Text;
        }
        private void LoadCmbMaHH()
        {
            List<HangHoa_DTO> list = HangHoa_BUS.LoadHangHoa();
            cbMaHangHoa.DataSource = list;
            cbtTenHH.DataSource = list;
            donVT.DataSource = list;
            giaBan.DataSource = list;

            giaBan.DisplayMember = "GiaBan";
            giaBan.ValueMember = "GiaBan";

            donVT.DisplayMember = "DonViTinh";
            donVT.ValueMember = "DonViTinh";

            cbMaHangHoa.DisplayMember = "MaHang";
            cbMaHangHoa.ValueMember = "MaHang";

            cbtTenHH.DisplayMember = "TenHang";
            cbtTenHH.ValueMember = "TenHang";
        }
        public List<PhieuTraHang_DTO> lsPhieuTra = new List<PhieuTraHang_DTO>();
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
            ExportExcel(saveFileDialog1, dataGVPhieuTra);
        }
        public long ltongTien = 0;
        private void LoadPhieuTra()
        {
            List<PhieuTraHang_DTO> listTemp = new List<PhieuTraHang_DTO>();

            for (int i = 0; i < lsPhieuTra.Count; i++)
            {
                PhieuTraHang_DTO hhDTO = new PhieuTraHang_DTO();
                hhDTO.SoPT = lsPhieuTra[i].SoPT;
                hhDTO.NgayTra = lsPhieuTra[i].NgayTra;
                hhDTO.MaKhachHang = lsPhieuTra[i].MaKhachHang;
                hhDTO.MaHangHoa = lsPhieuTra[i].MaHangHoa;
                hhDTO.TenHangHoa = lsPhieuTra[i].TenHangHoa;
                hhDTO.DonViTinh = lsPhieuTra[i].DonViTinh;
                hhDTO.SoLuong = lsPhieuTra[i].SoLuong;
                hhDTO.GiaBan = lsPhieuTra[i].GiaBan;
                hhDTO.ThanhTien = lsPhieuTra[i].ThanhTien;
                hhDTO.TongTien = lsPhieuTra[i].TongTien;
                hhDTO.GhiChu = lsPhieuTra[i].GhiChu;
                hhDTO.STT = i + 1;
                hhDTO.IDKey = i + 1;
                listTemp.Add(hhDTO);
                ltongTien += hhDTO.ThanhTien;

            }
          
            tongTien.Text = ltongTien.ToString();
            tongTienThanhToan.Text = ltongTien.ToString();
            thanhToanTruoc.Text = traTruoc.Text;
            if (traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            tienPhaiTra.Text = (ltongTien - long.Parse(traTruoc.Text.ToString())).ToString() ;
            ///


            dataGVPhieuTra.DataSource = listTemp;
            if (lsPhieuTra != null)
            {
                dataGVPhieuTra.Columns["SoPT"].HeaderText = "Số phiếu trả";
                dataGVPhieuTra.Columns["NgayTra"].HeaderText = "Ngày trả";
                dataGVPhieuTra.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVPhieuTra.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
                dataGVPhieuTra.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
                dataGVPhieuTra.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVPhieuTra.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGVPhieuTra.Columns["GiaBan"].HeaderText = "Giá bán";
                dataGVPhieuTra.Columns["ThanhTien"].HeaderText = "Thanh tiền";
                dataGVPhieuTra.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataGVPhieuTra.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVPhieuTra.Columns["IDKey"].Visible = false;
                dataGVPhieuTra.Columns["MaKhachHang"].Width = 120;

            }
        }

        private void UC_PhieuTraHang_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(themPhieuXuat, "Thêm phiếu trả hàng");
            tooltip.SetToolTip(suaPhieuXuat, "Sửa phiếu trả hàng");
            tooltip.SetToolTip(xoaPhieuXuat, "Xóa phiếu trả hàng");
            tooltip.SetToolTip(xuatExcel, "Lưu thành excel");
            tooltip.SetToolTip(lapPhieu, "Lập phiếu");
            LoadCmbMaHH();
            LoadCmbMaKH();
            LoadPhieuTra();
        }
        private bool ThongBao(string a, string c)
        {
            if (a == "")
            {
                MessageBox.Show("Bạn cần điền mục " + c, "Thông Báo");
                return true;
            }
            return false;
        }
        private void themPhieuXuat_Click(object sender, EventArgs e)
        {
            //if (soPhieuTra.Text == "" || dtNgayTra.Text == "" ||
            //    cbMaKH.Text == "" ||
            //   cbtTenHH.Text == "" ||
            //    cbMaHangHoa.Text == "" || donVT.Text == "" ||
            //    soLuong.Text == "" || giaBan.Text == "" ||
            //    rbGhiChu.Text == "")

            //{
            //    MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
            //    return;
            //}
            if (ThongBao(soPhieuTra.Text, "Số phiếu trả !"))
                return;
            if (ThongBao(dtNgayTra.Text, "Ngày trả !"))
                return;
            if (ThongBao(cbMaKH.Text, "Mã khách hàng !"))
                return;
            if (ThongBao(cbtTenHH.Text, "Tên hàng hóa !"))
                return;
            if (ThongBao(cbMaHangHoa.Text, "Mã hàng hóa !"))
                return;
            if (ThongBao(donVT.Text, "Đơn vị tính !"))
                return;
            if (ThongBao(giaBan.Text, "Giá bán !"))
                return;
            if (ThongBao(soLuong.Text, "Số lượng !"))
                return;
            if (rbGhiChu.Text == "")
            {
                rbGhiChu.Text = "Note";
            }
            if (traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            strCMaKH = cbMaKH.Text;
            strSoPT = soPhieuTra.Text;
            PhieuTraHang_DTO hhDTO = new PhieuTraHang_DTO();
            hhDTO.SoPT = soPhieuTra.Text;
            hhDTO.NgayTra = DateTime.Parse(dtNgayTra.Text.ToString());
            hhDTO.MaKhachHang = cbMaKH.Text;
            hhDTO.TenKhachHang = cbTenKH.Text;
            hhDTO.DiaChi = cbdiachi.Text;
            hhDTO.MaHangHoa = cbMaHangHoa.Text;
            hhDTO.TenHangHoa = cbtTenHH.Text;
            hhDTO.DonViTinh = donVT.Text;
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.GiaBan = long.Parse(giaBan.Text.ToString());
            hhDTO.ThanhTien = hhDTO.SoLuong * hhDTO.GiaBan;
            hhDTO.TongTien = hhDTO.ThanhTien;
            hhDTO.GhiChu = rbGhiChu.Text;

            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (PhieuTraHang_BUS.ThemPhieuTraHang(hhDTO) == true)
            {
                //Load dữ liệu vào bảng ảo
                hhDTO.STT = lsPhieuTra.Count + 1;
                //hhDTO.IDKey = lsPhieuXuat.Count + 1;
                lsPhieuTra.Add(hhDTO);
                //
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = hhDTO.MaHangHoa;
                hh.SoLuong = hhDTO.SoLuong;
                if (HangHoa_BUS.UpdateSoLuongNhap(hh))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Số lượng mặt hàng đã hết!", "Thông báo");
                }
                
                LoadPhieuTra();
                return;
            }
            else
            {
                MessageBox.Show("Thêm không Thành Công", "Thông Báo");
                return;
            }
        }
        public long IDHH = 0;
        private void suaPhieuXuat_Click(object sender, EventArgs e)
        {
            if (ThongBao(soPhieuTra.Text, "Số phiếu trả !"))
                return;
            if (ThongBao(dtNgayTra.Text, "Ngày trả !"))
                return;
            if (ThongBao(cbMaKH.Text, "Mã khách hàng !"))
                return;
            if (ThongBao(cbtTenHH.Text, "Tên hàng hóa !"))
                return;
            if (ThongBao(cbMaHangHoa.Text, "Mã hàng hóa !"))
                return;
            if (ThongBao(donVT.Text, "Đơn vị tính !"))
                return;
            if (ThongBao(giaBan.Text, "Giá bán !"))
                return;
            if (ThongBao(soLuong.Text, "Số lượng !"))
                return;
            if (rbGhiChu.Text == "")
            {
                rbGhiChu.Text = "Note";
            }
            if (traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            if (IDHH == 0)
            {
                IDHH = 1;
            }
            PhieuTraHang_DTO hhDTO = new PhieuTraHang_DTO();
            hhDTO.IDKey = IDHH;
            hhDTO.SoPT = soPhieuTra.Text;
            hhDTO.NgayTra = DateTime.Parse(dtNgayTra.Text.ToString());
            hhDTO.MaKhachHang = cbMaKH.Text;
            hhDTO.TenKhachHang = cbTenKH.Text;
            hhDTO.DiaChi = cbdiachi.Text;
            hhDTO.MaHangHoa = cbMaHangHoa.Text;
            hhDTO.TenHangHoa = cbtTenHH.Text;
            hhDTO.DonViTinh = donVT.Text;
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.GiaBan = long.Parse(giaBan.Text.ToString());
            hhDTO.ThanhTien = hhDTO.SoLuong * hhDTO.GiaBan;
            hhDTO.TongTien = hhDTO.ThanhTien + hhDTO.ThanhTien * (hhDTO.GTGT - hhDTO.ChiecKhau) / 100;
            hhDTO.GhiChu = rbGhiChu.Text;
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (PhieuTraHang_BUS.SuaPhieuTraHang(hhDTO) == true)
            {
                int id = int.Parse(hhDTO.IDKey.ToString()) - 1;
                lsPhieuTra[id].NgayTra = hhDTO.NgayTra;
                lsPhieuTra[id].MaKhachHang = hhDTO.MaKhachHang;
                lsPhieuTra[id].MaHangHoa = hhDTO.MaHangHoa;
                lsPhieuTra[id].TenHangHoa = hhDTO.TenHangHoa;
                lsPhieuTra[id].DonViTinh = hhDTO.DonViTinh;
                lsPhieuTra[id].ChiecKhau = hhDTO.ChiecKhau;
                lsPhieuTra[id].GTGT = hhDTO.GTGT;
                lsPhieuTra[id].SoLuong = hhDTO.SoLuong;
                lsPhieuTra[id].GiaBan = hhDTO.GiaBan;
                lsPhieuTra[id].ThanhTien = hhDTO.ThanhTien;
                lsPhieuTra[id].TongTien = hhDTO.TongTien;
                lsPhieuTra[id].GhiChu = hhDTO.GhiChu;
                //
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = hhDTO.MaHangHoa;
                hh.SoLuong = hhDTO.SoLuong;
                hh.ThanhTien = soluongtruockhisua;
                if (HangHoa_BUS.SuaSoLuongNhap(hh))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else {
                    MessageBox.Show("Số lượng mặt hàng đã hết!", "Thông báo");
                }
            }
        }
        public long soluongtruockhisua = 0;
        public string maHH;

        public string StrCMaKH
        {
            get
            {
                return strCMaKH;
            }

            set
            {
                strCMaKH = value;
            }
        }

        private void dataGVPhieuTra_Click(object sender, EventArgs e)
        {
            if (dataGVPhieuTra.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_PhieuTra = dataGVPhieuTra.SelectedRows[0];
            IDHH = long.Parse(dr_PhieuTra.Cells["IDKey"].Value.ToString());
            soPhieuTra.Text = dr_PhieuTra.Cells["SoPT"].Value.ToString();
            dtNgayTra.Text = dr_PhieuTra.Cells["NgayTra"].Value.ToString();
            cbMaKH.Text = dr_PhieuTra.Cells["MaKhachHang"].Value.ToString();
            cbMaHangHoa.Text = dr_PhieuTra.Cells["MaHangHoa"].Value.ToString();
            maHH = cbMaHangHoa.Text;
            cbtTenHH.Text = dr_PhieuTra.Cells["TenHangHoa"].Value.ToString();
            donVT.Text = dr_PhieuTra.Cells["DonViTinh"].Value.ToString();
            giaBan.Text = dr_PhieuTra.Cells["GiaBan"].Value.ToString();
            soLuong.Text = dr_PhieuTra.Cells["SoLuong"].Value.ToString();
            soluongtruockhisua = long.Parse(soLuong.Text.ToString());
            rbGhiChu.Text = dr_PhieuTra.Cells["GhiChu"].Value.ToString();
        }

        private void xoaPhieuXuat_Click(object sender, EventArgs e)
        {
            PhieuTraHang_DTO hhDTO = new PhieuTraHang_DTO();

            hhDTO.IDKey = IDHH;
            if (IDHH == 0)
            {
                IDHH = 1;
            }
            lsPhieuTra.RemoveAt(int.Parse((IDHH - 1).ToString()));
            if (PhieuTraHang_BUS.XoaPhieuTraHang(hhDTO) == true)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = maHH;
                hh.SoLuong = 0;
                hh.ThanhTien = soluongtruockhisua;
                if (HangHoa_BUS.SuaSoLuongNhap(hh))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else {
                    MessageBox.Show("Số lượng mặt hàng đã hết!", "Thông báo");
                }
                
                LoadPhieuTra();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }
        
        private void lapPhieu_Click(object sender, EventArgs e)
        {
            //Cong thu
            CongNoThu_DTO cNoThu = new CongNoThu_DTO();
            cNoThu.MaKhachHang = cbMaKH.Text;
            cNoThu.TenKhachHang = cbTenKH.Text;
            cNoThu.SoDuDauKiNo = 0;
            cNoThu.PhatSinhTrongKiNo = 0;
            cNoThu.PhatSinhTrongKiCo = ltongTien;
            cNoThu.SoDuCuoiKiNo = cNoThu.PhatSinhTrongKiNo - cNoThu.PhatSinhTrongKiCo;
            cNoThu.GhiChu = " ";
            cNoThu.NhomKhachHang = nhomKH.Text;
            cNoThu.ThoiGianPhatSinh = DateTime.Parse(dtNgayTra.Text.ToString());
            cNoThu.ThoiHanNo = DateTime.Parse(dtNgayTra.Text.ToString());
            if (cbMaKH.Text != "")
            {
                if (CongNoThu_BUS.themCongNoThu(cNoThu) == true)
                {
                    //Load dữ liệu vào bảng ảo
                    MessageBox.Show("Cập nhật công nợ Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật công nợ không Thành Công", "Thông Báo");
                }
            }
        }
    }
}
