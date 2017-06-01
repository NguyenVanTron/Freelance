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
    public partial class UC_PhieuNhap : UserControl
    {
        List<PhieuNhap_DTO> lsphieunhap = new List<PhieuNhap_DTO>();
        public string strCMaNCC;
        public string strCTenNCC;
        public UC_PhieuNhap()
        {
            InitializeComponent();
        }

        private void UC_PhieuNhap_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(themPhieuXuat, "Thêm phiếu nhập");
            tooltip.SetToolTip(suaPhieuXuat, "Sửa phiếu nhập");
            tooltip.SetToolTip(xoaPhieuXuat, "Xóa phiếu nhập");
            tooltip.SetToolTip(xuatExcel, "Lưu thành excel");
            tooltip.SetToolTip(lapPhieu, "Lập phiếu");
            tooltip.SetToolTip(themnhacc, "Thêm mới nhà cung cấp");
            tooltip.SetToolTip(themhanghoa, "Thêm mới hàng hóa");
            LoadPhieuNhap();
            LoadCmbMaCC();
            LoadCmbMaHH();
        }
        private void LoadCmbMaCC()
        {
            List<NhaCungCap_DTO> list = NhaCungCap_BUS.LoadNhaCungCap();
            cbMaNCC.DataSource = list;
            nhomNCC.DataSource = list;
            nhomNCC.DisplayMember = "NhomNCC";
            nhomNCC.ValueMember = "NhomNCC";
            cbMaNCC.DisplayMember = "MaNCC";
            cbMaNCC.ValueMember = "MaNCC";
            strCMaNCC = cbMaNCC.Text;
            cbMaNCC.DisplayMember = "TenNCC";
            cbMaNCC.ValueMember = "TenNCC";
            strCTenNCC = cbMaNCC.Text;
            cbMaNCC.DisplayMember = "MaNCC";
            cbMaNCC.ValueMember = "MaNCC";
        }
        private void LoadCmbMaHH()
        {
            List<HangHoa_DTO> list = HangHoa_BUS.LoadHangHoa();
            cbMaHangHoa.DataSource = list;
            cbtTenHH.DataSource = list;
            donVT.DataSource = list;
            giaNhap.DataSource = list;
            cbMaNCC.DataSource = list;
            //soLuong.DataSource = list;

            //soLuong.DisplayMember = "SoLuong";
            //soLuong.ValueMember = "SoLuong";

            giaNhap.DisplayMember = "GiaNhap";
            giaNhap.ValueMember = "GiaNhap";

            donVT.DisplayMember = "DonViTinh";
            donVT.ValueMember = "DonViTinh";

            cbMaHangHoa.DisplayMember = "MaHang";
            cbMaHangHoa.ValueMember = "MaHang";

            cbtTenHH.DisplayMember = "TenHang";
            cbtTenHH.ValueMember = "TenHang";

            cbMaNCC.DisplayMember = "MaNCC";
            cbMaNCC.ValueMember = "MaNCC";
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
        public long ltongTien = 0;
        public long ltienChiecKhau = 0;
        public long ltienGTGT = 0;
        private void LoadPhieuNhap()
        {

            List<PhieuNhap_DTO> listTemp = new List<PhieuNhap_DTO>();
            for (int i = 0; i < lsphieunhap.Count; i++)
            {
                PhieuNhap_DTO hhDTO = new PhieuNhap_DTO();
                hhDTO.SoPN = lsphieunhap[i].SoPN;
                hhDTO.NgayNhap = lsphieunhap[i].NgayNhap;
                hhDTO.MaNCC = lsphieunhap[i].MaNCC;
                hhDTO.MaHangHoa = lsphieunhap[i].MaHangHoa;
                hhDTO.TenHangHoa = lsphieunhap[i].TenHangHoa;
                hhDTO.DonViTinh = lsphieunhap[i].DonViTinh;
                hhDTO.SoLuong = lsphieunhap[i].SoLuong;
                hhDTO.GiaNhap = lsphieunhap[i].GiaNhap;
                hhDTO.ChiecKhau = lsphieunhap[i].ChiecKhau;
                hhDTO.GTGT = lsphieunhap[i].GTGT;
                hhDTO.ThanhTien = lsphieunhap[i].ThanhTien;
                hhDTO.TongTien = lsphieunhap[i].TongTien;
                hhDTO.GhiChu = lsphieunhap[i].GhiChu;
                hhDTO.STT = i + 1;
                hhDTO.IDKey = i + 1;
                listTemp.Add(hhDTO);
                ltienChiecKhau += hhDTO.ThanhTien * hhDTO.ChiecKhau / 100;
                ltienGTGT += hhDTO.ThanhTien * hhDTO.GTGT / 100;
                ltongTien += hhDTO.ThanhTien;
            }
            tienChiecKhau.Text = ltienChiecKhau.ToString();
            tbVAT.Text = ltienGTGT.ToString();
            tongTien.Text = ltongTien.ToString();
            tongTienThanhToan.Text = (ltongTien + ltienGTGT - ltienChiecKhau).ToString();
            thanhToanTruoc.Text = traTruoc.Text;
            if (traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            tienPhaiTra.Text = (ltongTien + ltienGTGT - ltienChiecKhau - long.Parse(traTruoc.Text.ToString())).ToString();
            dataGVPhieuNhap.DataSource = listTemp;
            if (lsphieunhap != null)
            {
                dataGVPhieuNhap.Columns["SoPN"].HeaderText = "Số phiếu nhập";
                dataGVPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dataGVPhieuNhap.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVPhieuNhap.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
                dataGVPhieuNhap.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
                dataGVPhieuNhap.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVPhieuNhap.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGVPhieuNhap.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dataGVPhieuNhap.Columns["ThanhTien"].HeaderText = "Thanh tiền";
                dataGVPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataGVPhieuNhap.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVPhieuNhap.Columns["ChiecKhau"].HeaderText = "Chiếc khấu";
                dataGVPhieuNhap.Columns["GTGT"].HeaderText = "VAT(%)";
                dataGVPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataGVPhieuNhap.Columns["NgayNhap"].Width = 100;
                dataGVPhieuNhap.Columns["MaHangHoa"].Width = 100;
                dataGVPhieuNhap.Columns["MaNCC"].Width = 120;
                dataGVPhieuNhap.Columns["TenHangHoa"].Width = 100;
                dataGVPhieuNhap.Columns["STT"].Width = 50;
                dataGVPhieuNhap.Columns["ThanhTien"].Width = 100;
                dataGVPhieuNhap.Columns["GhiChu"].Width = 200;
                dataGVPhieuNhap.Columns["IDKey"].Visible = false;
            }
        }
        

        private void xuatFileExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVPhieuNhap);
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
        private void themPhieuNhap_Click(object sender, EventArgs e)
        {
            //if (soPhieuNhap.Text == "" || dtNgayNhap.Text == "" ||
            //    cbMaNCC.Text == "" ||
            //   cbtTenHH.Text == "" ||
            //    cbMaHangHoa.Text == "" || donVT.Text == "" ||
            //    soLuong.Text == "" || giaNhap.Text == "" ||
            //    rbGhiChu.Text == "")

            //{
            //    MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
            //    return;
            //}
            if (ThongBao(soPhieuNhap.Text, "Số phiếu nhập !"))
                return;
            if (ThongBao(dtNgayNhap.Text, "Ngày nhập !"))
                return;
            if (ThongBao(cbMaNCC.Text, "Mã nhà cung cấp!"))
                return;
            if (ThongBao(cbtTenHH.Text, "Tên hàng hóa !"))
                return;
            if (ThongBao(cbMaHangHoa.Text, "Mã hàng hóa !"))
                return;
            if (ThongBao(donVT.Text, "Đơn vị tính !"))
                return;
            if (ThongBao(giaNhap.Text, "Giá nhập !"))
                return;
            if (ThongBao(soLuong.Text, "Số lượng !"))
                return;
            if (rbGhiChu.Text == "")
            {
                rbGhiChu.Text = "Note";
            }
            
             if (gTGT.Text == "")
            {
                gTGT.Text = "0";
            }
            if (chiecKhau.Text == "")
            {
                chiecKhau.Text = "0";
            }
            if (traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            PhieuNhap_DTO hhDTO = new PhieuNhap_DTO();
            hhDTO.SoPN = soPhieuNhap.Text;
            hhDTO.NgayNhap = DateTime.Parse(dtNgayNhap.Text.ToString());
            hhDTO.MaNCC = cbMaNCC.Text;
            hhDTO.MaHangHoa = cbMaHangHoa.Text;
            hhDTO.TenHangHoa = cbtTenHH.Text;
            hhDTO.DonViTinh = donVT.Text;
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.GiaNhap = long.Parse(giaNhap.Text.ToString());
            hhDTO.ChiecKhau = int.Parse(chiecKhau.Text.ToString());
            hhDTO.GTGT = int.Parse(gTGT.Text.ToString());
            hhDTO.ThanhTien = hhDTO.SoLuong * hhDTO.GiaNhap;
            hhDTO.TongTien = hhDTO.ThanhTien +hhDTO.ThanhTien * (hhDTO.GTGT - hhDTO.ChiecKhau)/100;
            hhDTO.GhiChu = rbGhiChu.Text;
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (PhieuNhap_BUS.ThemPhieuNhap(hhDTO) == true)
            {

                lsphieunhap.Add(hhDTO);

                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = hhDTO.MaHangHoa;
                hh.SoLuong = hhDTO.SoLuong;
                hh.GiaNhap = hhDTO.GiaNhap;
                hh.NgayNhap = hhDTO.NgayNhap;
                if (HangHoa_BUS.UpdateSoLuongNhap(hh))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Số lượng mặt hàng đã hết!", "Thông báo");
                }
                //Thêm vào báo cáo
                BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
                List<HangHoa_DTO> hhmoi = HangHoa_BUS.TimKiemHangHoa(cbtTenHH.Text.ToString());
                baocao.TenHangHoa = hhDTO.TenHangHoa;
                baocao.SLNhapTK= hh.SoLuong;

                baocao.DGNhapTK= hhmoi[0].GiaBan;
                baocao.SLXuatTK= 0;
                baocao.DGXuatTK= 0;
                baocao.TTXuatTK= 0;
                if (BaoCaoTongHop_BUS.PhatSinhBaoCao(hhDTO.TenHangHoa, baocao))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }


                //
                LoadPhieuNhap();
                return;
            }
            else
            {
                MessageBox.Show("Thêm không Thành Công", "Thông Báo");
                return;
            }
        }
        //Sửa khách hàng
        public long IDHH = 0;
        private void suaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (ThongBao(soPhieuNhap.Text, "Số phiếu nhập !"))
                return;
            if (ThongBao(dtNgayNhap.Text, "Ngày nhập !"))
                return;
            if (ThongBao(cbMaNCC.Text, "Mã nhà cung cấp!"))
                return;
            if (ThongBao(cbtTenHH.Text, "Tên hàng hóa !"))
                return;
            if (ThongBao(cbMaHangHoa.Text, "Mã hàng hóa !"))
                return;
            if (ThongBao(donVT.Text, "Đơn vị tính !"))
                return;
            if (ThongBao(giaNhap.Text, "Giá nhập !"))
                return;
            if (ThongBao(soLuong.Text, "Số lượng !"))
                return;
            if (rbGhiChu.Text == "")
            {
                rbGhiChu.Text = "Note";
            }
            if (gTGT.Text == "")
            {
                gTGT.Text = "0";
            }
            if (chiecKhau.Text == "")
            {
                chiecKhau.Text = "0";
            }
            if (traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            if (IDHH == 0)
            {
                IDHH = 1;
            }
            PhieuNhap_DTO hhDTO = new PhieuNhap_DTO();
            hhDTO.IDKey = IDHH;
            hhDTO.SoPN = soPhieuNhap.Text;
            hhDTO.NgayNhap = DateTime.Parse(dtNgayNhap.Text.ToString());
            hhDTO.MaNCC = cbMaNCC.Text;
            hhDTO.MaHangHoa = cbMaHangHoa.Text;
            hhDTO.TenHangHoa = cbtTenHH.Text;
            hhDTO.DonViTinh = donVT.Text;
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.GiaNhap = long.Parse(giaNhap.Text.ToString());
            hhDTO.ThanhTien = hhDTO.SoLuong * hhDTO.GiaNhap;
            hhDTO.ChiecKhau = int.Parse(chiecKhau.Text.ToString());
            hhDTO.GTGT = int.Parse(gTGT.Text.ToString());
            hhDTO.TongTien = hhDTO.ThanhTien + hhDTO.ThanhTien * (hhDTO.GTGT - hhDTO.ChiecKhau)/100;
            hhDTO.GhiChu = rbGhiChu.Text;
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (PhieuNhap_BUS.SuaPhieuNhap(hhDTO) == true)
            {
                int id = int.Parse(hhDTO.IDKey.ToString()) - 1;
                lsphieunhap[id].NgayNhap = hhDTO.NgayNhap;
                lsphieunhap[id].MaNCC = hhDTO.MaNCC;
                lsphieunhap[id].MaHangHoa = hhDTO.MaHangHoa;
                lsphieunhap[id].TenHangHoa = hhDTO.TenHangHoa;
                lsphieunhap[id].DonViTinh = hhDTO.DonViTinh;
                lsphieunhap[id].ChiecKhau = hhDTO.ChiecKhau;
                lsphieunhap[id].GTGT = hhDTO.GTGT;
                lsphieunhap[id].SoLuong = hhDTO.SoLuong;
                lsphieunhap[id].GiaNhap = hhDTO.GiaNhap;
                lsphieunhap[id].ThanhTien = hhDTO.ThanhTien;
                lsphieunhap[id].TongTien = hhDTO.ThanhTien + hhDTO.ThanhTien * (hhDTO.GTGT - hhDTO.ChiecKhau)/100;
                lsphieunhap[id].GhiChu = hhDTO.GhiChu;
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
                //Thêm vào báo cáo
                BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
                List<HangHoa_DTO> hhmoi = HangHoa_BUS.TimKiemHangHoa(cbtTenHH.Text.ToString());
                baocao.TenHangHoa = hhDTO.TenHangHoa;
                baocao.SLNhapTK = hh.SoLuong;
                baocao.DGNhapTK = hhmoi[0].GiaBan;
                baocao.SLTonDK = soluongtruockhisua;
                baocao.SLXuatTK = 0;
                baocao.DGXuatTK = 0;
                baocao.TTXuatTK = 0;
                if (BaoCaoTongHop_BUS.SuaSoLuongNhap(baocao))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
                LoadPhieuNhap();
                return;
            }
            else
            {
                MessageBox.Show("Sửa không Thành Công", "Thông Báo");
                return;
            }
        }
        public long soluongtruockhisua;
        public string MaHH;
        private void dataGVPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dataGVPhieuNhap.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_PhieuNhap = dataGVPhieuNhap.SelectedRows[0];
            IDHH = long.Parse(dr_PhieuNhap.Cells["IDKey"].Value.ToString());
            soPhieuNhap.Text = dr_PhieuNhap.Cells["SoPN"].Value.ToString();
            dtNgayNhap.Text = dr_PhieuNhap.Cells["NgayNhap"].Value.ToString();
            cbMaNCC.Text = dr_PhieuNhap.Cells["MaNCC"].Value.ToString();
            cbMaHangHoa.Text = dr_PhieuNhap.Cells["MaHangHoa"].Value.ToString();
            MaHH = cbMaHangHoa.Text;
            cbtTenHH.Text = dr_PhieuNhap.Cells["TenHangHoa"].Value.ToString();
            donVT.Text = dr_PhieuNhap.Cells["DonViTinh"].Value.ToString();
            giaNhap.Text = dr_PhieuNhap.Cells["GiaNhap"].Value.ToString();
            soLuong.Text = dr_PhieuNhap.Cells["SoLuong"].Value.ToString();
            soluongtruockhisua = long.Parse(soLuong.Text.ToString());
            rbGhiChu.Text = dr_PhieuNhap.Cells["GhiChu"].Value.ToString();
            gTGT.Text = dr_PhieuNhap.Cells["GTGT"].Value.ToString();
            chiecKhau.Text = dr_PhieuNhap.Cells["ChiecKhau"].Value.ToString();

        }

        private void xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            PhieuNhap_DTO hhDTO = new PhieuNhap_DTO();

            hhDTO.IDKey = IDHH;
            if (IDHH == 0)
            {
                IDHH = 1;
            }
            lsphieunhap.RemoveAt(int.Parse((IDHH - 1).ToString()));
            if (PhieuNhap_BUS.XoaPhieuNhap(hhDTO) == true)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = MaHH;
                hh.SoLuong = 0;
                hh.ThanhTien = soluongtruockhisua;
                if (HangHoa_BUS.SuaSoLuongNhap(hh))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else {
                    MessageBox.Show("Số lượng mặt hàng đã hết!", "Thông báo");
                }
                //Thêm vào báo cáo
                BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
                List<HangHoa_DTO> hhmoi = HangHoa_BUS.TimKiemHangHoa(cbtTenHH.Text.ToString());
                baocao.TenHangHoa = hhDTO.TenHangHoa;
                baocao.SLNhapTK = 0;
                baocao.DGNhapTK = hhmoi[0].GiaBan;
                baocao.SLTonDK = soluongtruockhisua;
                baocao.SLXuatTK = 0;
                baocao.DGXuatTK = 0;
                baocao.TTXuatTK = 0;
                if (BaoCaoTongHop_BUS.SuaSoLuongNhap(baocao))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
                LoadPhieuNhap();
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
            CongNoTra_DTO cNoTra = new CongNoTra_DTO();
            cNoTra.MaNCC = strCMaNCC;
            cNoTra.TenNCC = strCTenNCC;
            cNoTra.NhomNCC = nhomNCC.Text;
            cNoTra.SoDuDauKiNo = 0;
            cNoTra.PhatSinhTrongKiNo = ltongTien + ltienGTGT;
            cNoTra.PhatSinhTrongKiCo = ltienChiecKhau + long.Parse(traTruoc.Text.ToString());
            cNoTra.SoDuCuoiKiNo = cNoTra.PhatSinhTrongKiCo - cNoTra.PhatSinhTrongKiNo;
            cNoTra.ThoiGianPhatSinh = DateTime.Parse(dtNgayNhap.Text.ToString());
            cNoTra.ThoiHanNo = DateTime.Parse(ngayHanNo.Text.ToString());
            cNoTra.GhiChu = " ";
            if (strCMaNCC != null)
            {
                if (CongNoTra_BUS.themCongNoTra(cNoTra) == true)
                {
                    //Load dữ liệu vào bảng ảo
                    MessageBox.Show("Lập phiếu Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Lập phiếu không Thành Công", "Thông Báo");
                }
            }
        }

        private void themncc_Click(object sender, EventArgs e)
        {
            ThemNCC us = new ThemNCC();
            us.ShowDialog();
            LoadCmbMaCC();
        }

        private void themhanghoa_Click(object sender, EventArgs e)
        {
            ThemHang us = new ThemHang();
            us.ShowDialog();
            LoadCmbMaHH();
        }
    }
}
