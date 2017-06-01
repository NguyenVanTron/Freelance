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
using System.IO;
namespace MainProgram
{
    public partial class UC_PhieuXuat : UserControl
    {
        public List<PhieuXuat_DTO> lsPhieuXuat = new List<PhieuXuat_DTO>();
        public UC_PhieuXuat()
        {
            InitializeComponent();
            //cbTenKH.Hide();
            //cbnocon.Hide();
            //cbdiachi.Hide();
        }
        private string strCMaKH;
        public string strCTenKH;
        public string strDiaChi;
        public long lconNo;
        private void LoadNo()
        {
            List<CongNoThu_DTO> list = CongNoThu_BUS.TiemkiemCongNoThu(cbMaKH.Text);
            if (list != null)
            {
                cbnocon.DataSource = list;
                cbnocon.DisplayMember = "SoDuCuoiKiNo";
                cbnocon.ValueMember = "SoDuCuoiKiNo";
            }
            else
            {
                cbnocon.DisplayMember = "SoDuCuoiKiNo";
                cbnocon.ValueMember = "SoDuCuoiKiNo";
            }
        }
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
            StrCMaKH = cbMaKH.Text;
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
        private void UC_PhieuXuat_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(themPhieuXuat, "Thêm phiếu xuất");
            tooltip.SetToolTip(xoaPhieuXuat, "Xóa phiếu xuất");
            tooltip.SetToolTip(suaPhieuXuat, "Sửa phiếu xuất");
            tooltip.SetToolTip(xuatExcel, "Lưu dữ liệu thành excel");
            tooltip.SetToolTip(inPhieuXuat, "In phiếu xuất");
            tooltip.SetToolTip(lapPhieu, "Lập phiếu xuất");
            tooltip.SetToolTip(themkh, "Thêm mới khách hàng");
            LoadPhieuXuat();
            LoadCmbMaKH();
            LoadNo();
            LoadCmbMaHH();

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
        private void LoadPhieuXuat()
        {
            List<PhieuXuat_DTO> listTemp = new List<PhieuXuat_DTO>();
            
            for(int i = 0; i < lsPhieuXuat.Count; i++)
            {
                PhieuXuat_DTO hhDTO = new PhieuXuat_DTO();
                hhDTO.SoPX = lsPhieuXuat[i].SoPX;
                hhDTO.NgayXuat = lsPhieuXuat[i].NgayXuat;
                hhDTO.MaKhachHang = lsPhieuXuat[i].MaKhachHang;
                hhDTO.MaHangHoa = lsPhieuXuat[i].MaHangHoa;
                hhDTO.TenHangHoa = lsPhieuXuat[i].TenHangHoa;
                hhDTO.DonViTinh = lsPhieuXuat[i].DonViTinh;
                hhDTO.SoLuong = lsPhieuXuat[i].SoLuong;
                hhDTO.GiaBan = lsPhieuXuat[i].GiaBan;
                hhDTO.ChiecKhau = lsPhieuXuat[i].ChiecKhau;
                hhDTO.GTGT = lsPhieuXuat[i].GTGT;
                hhDTO.ThanhTien = lsPhieuXuat[i].ThanhTien;
                hhDTO.TongTien = lsPhieuXuat[i].TongTien;
                hhDTO.GhiChu = lsPhieuXuat[i].GhiChu;
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
            if(traTruoc.Text == "")
            {
                traTruoc.Text = "0";
            }
            if(cbnocon.Text == "")
            {
                cbnocon.Text = "0";
            }
            tienPhaiTra.Text = (ltongTien + ltienGTGT - ltienChiecKhau - long.Parse(traTruoc.Text.ToString()) + long.Parse(cbnocon.Text.ToString())).ToString();
            ///


            dataGVPhieuNhap.DataSource = listTemp;
            if (lsPhieuXuat != null)
            {
                dataGVPhieuNhap.Columns["SoPX"].HeaderText = "Số phiếu xuất";
                dataGVPhieuNhap.Columns["NgayXuat"].HeaderText = "Ngày xuất";
                dataGVPhieuNhap.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVPhieuNhap.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
                dataGVPhieuNhap.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
                dataGVPhieuNhap.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dataGVPhieuNhap.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGVPhieuNhap.Columns["GiaBan"].HeaderText = "Giá bán";
                dataGVPhieuNhap.Columns["ChiecKhau"].HeaderText = "Chiếc khấu";
                dataGVPhieuNhap.Columns["GTGT"].HeaderText = "VAT(%)";
                dataGVPhieuNhap.Columns["ThanhTien"].HeaderText = "Thanh tiền";
                dataGVPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataGVPhieuNhap.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVPhieuNhap.Columns["IDKey"].Visible = false;
                dataGVPhieuNhap.Columns["MaKhachHang"].Width = 120;

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
        private void themPhieuXuat_Click(object sender, EventArgs e)
        {
            LoadNo();
            //if (soPhieuXuat.Text == "" || dtNgayXuat.Text == "" ||
            //    cbMaKH.Text == "" ||
            //   cbtTenHH.Text == "" ||
            //    cbMaHangHoa.Text == "" || donVT.Text == "" ||
            //    soLuong.Text == "" || giaBan.Text == "" ||
            //    rbGhiChu.Text == "")

            //{
            //    MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
            //    return;
            //}
            if (ThongBao(soPhieuXuat.Text, "Số phiếu xuất !"))
                return;
            if (ThongBao(dtNgayXuat.Text, "Ngày xuất !"))
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
            if (cbnocon.Text == "")
            {
                cbnocon.Text = "0";
            }
            StrCMaKH = cbMaKH.Text;
            strSoPX = soPhieuXuat.Text;
            PhieuXuat_DTO hhDTO = new PhieuXuat_DTO();
            hhDTO.SoPX = soPhieuXuat.Text;
            hhDTO.NgayXuat = DateTime.Parse(dtNgayXuat.Text.ToString());
            hhDTO.MaKhachHang = cbMaKH.Text;
            hhDTO.TenKhachHang = cbTenKH.Text;
            hhDTO.DiaChi = cbdiachi.Text;
            hhDTO.MaHangHoa = cbMaHangHoa.Text;
            hhDTO.TenHangHoa = cbtTenHH.Text;
            hhDTO.DonViTinh = donVT.Text;
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.GiaBan = long.Parse(giaBan.Text.ToString());
            hhDTO.ConNo = long.Parse(cbnocon.Text.ToString());
            hhDTO.ChiecKhau = int.Parse(chiecKhau.Text.ToString());
            hhDTO.GTGT = int.Parse(gTGT.Text.ToString());
            hhDTO.ThanhTien = hhDTO.SoLuong * hhDTO.GiaBan;
            hhDTO.TongTien = hhDTO.ThanhTien + hhDTO.ThanhTien * (hhDTO.GTGT - hhDTO.ChiecKhau)/100 + hhDTO.ConNo;
            hhDTO.GhiChu = rbGhiChu.Text;
            
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (PhieuXuat_BUS.ThemPhieuXuat(hhDTO) == true)
            {
                //Load dữ liệu vào bảng ảo
                hhDTO.STT = lsPhieuXuat.Count + 1;
                //hhDTO.IDKey = lsPhieuXuat.Count + 1;
                lsPhieuXuat.Add(hhDTO);
                //
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = hhDTO.MaHangHoa;
                hh.SoLuong = hhDTO.SoLuong;
                if (HangHoa_BUS.UpdateSoLuongXuat(hh)) {
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
                baocao.SLNhapTK = 0;
                baocao.DGNhapTK = 0;
                baocao.TTNhapTK = 0;
                baocao.SLXuatTK = hh.SoLuong;
                baocao.DGXuatTK = hhmoi[0].GiaNhap;
                if (BaoCaoTongHop_BUS.PhatSinhBaoCao(hhDTO.TenHangHoa, baocao))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
                LoadPhieuXuat();
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
        private void suaPhieuXuat_Click(object sender, EventArgs e)
        {
            if (ThongBao(soPhieuXuat.Text, "Số phiếu xuất !"))
                return;
            if (ThongBao(dtNgayXuat.Text, "Ngày xuất !"))
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
            if (cbnocon.Text == "")
            {
                cbnocon.Text = "0";
            }
            PhieuXuat_DTO hhDTO = new PhieuXuat_DTO();
            hhDTO.IDKey = IDHH;
            hhDTO.SoPX = soPhieuXuat.Text;
            hhDTO.NgayXuat = DateTime.Parse(dtNgayXuat.Text.ToString());
            hhDTO.MaKhachHang = cbMaKH.Text;
            hhDTO.TenKhachHang = cbTenKH.Text;
            hhDTO.DiaChi = cbdiachi.Text;
            hhDTO.MaHangHoa = cbMaHangHoa.Text;
            hhDTO.TenHangHoa = cbtTenHH.Text;
            hhDTO.DonViTinh = donVT.Text;
            hhDTO.ChiecKhau = int.Parse(chiecKhau.Text.ToString());
            hhDTO.GTGT = int.Parse(gTGT.Text.ToString());
            hhDTO.SoLuong = long.Parse(soLuong.Text.ToString());
            hhDTO.GiaBan = long.Parse(giaBan.Text.ToString());
            hhDTO.ConNo = long.Parse(cbnocon.Text.ToString());
            hhDTO.ThanhTien = hhDTO.SoLuong * hhDTO.GiaBan;
            hhDTO.TongTien = hhDTO.ThanhTien + hhDTO.ThanhTien * (hhDTO.GTGT - hhDTO.ChiecKhau)/100 + hhDTO.ConNo;
            hhDTO.GhiChu = rbGhiChu.Text;
            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (PhieuXuat_BUS.SuaPhieuXuat(hhDTO) == true)
            {
                int id = int.Parse(hhDTO.IDKey.ToString()) - 1;
                lsPhieuXuat[id].NgayXuat = hhDTO.NgayXuat;
                lsPhieuXuat[id].MaKhachHang = hhDTO.MaKhachHang;
                lsPhieuXuat[id].MaHangHoa = hhDTO.MaHangHoa;
                lsPhieuXuat[id].TenHangHoa = hhDTO.TenHangHoa;
                lsPhieuXuat[id].DonViTinh = hhDTO.DonViTinh;
                lsPhieuXuat[id].ChiecKhau = hhDTO.ChiecKhau;
                lsPhieuXuat[id].GTGT = hhDTO.GTGT;
                lsPhieuXuat[id].SoLuong = hhDTO.SoLuong;
                lsPhieuXuat[id].GiaBan = hhDTO.GiaBan;
                lsPhieuXuat[id].ThanhTien = hhDTO.ThanhTien;
                lsPhieuXuat[id].TongTien = hhDTO.TongTien;
                lsPhieuXuat[id].GhiChu = hhDTO.GhiChu;
                //
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = hhDTO.MaHangHoa;
                hh.SoLuong = hhDTO.SoLuong;
                hh.ThanhTien = soluongtruockhisua;
                if (HangHoa_BUS.SuaSoLuongXuat(hh))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else{
                    MessageBox.Show("Số lượng mặt hàng đã hết!", "Thông báo");
                }
                //Thêm vào báo cáo
                BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
                List<HangHoa_DTO> hhmoi = HangHoa_BUS.TimKiemHangHoa(cbtTenHH.Text.ToString());
                baocao.TenHangHoa = hhDTO.TenHangHoa;
                baocao.SLNhapTK = hh.SoLuong;
                baocao.DGNhapTK = hhmoi[0].GiaNhap;
                baocao.SLTonDK = soluongtruockhisua;
                baocao.SLXuatTK = 0;
                baocao.DGXuatTK = 0;
                baocao.TTXuatTK = 0;
                if (BaoCaoTongHop_BUS.SuaSoLuongXuat(baocao))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
                LoadPhieuXuat();
                return;
            }
            else
            {
                MessageBox.Show("Sửa không Thành Công", "Thông Báo");
                return;
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

        private void dataGVPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dataGVPhieuNhap.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_PhieuNhap = dataGVPhieuNhap.SelectedRows[0];
            IDHH = long.Parse(dr_PhieuNhap.Cells["IDKey"].Value.ToString());
            soPhieuXuat.Text = dr_PhieuNhap.Cells["SoPX"].Value.ToString();
            dtNgayXuat.Text = dr_PhieuNhap.Cells["NgayXuat"].Value.ToString();
            cbMaKH.Text = dr_PhieuNhap.Cells["MaKhachHang"].Value.ToString();
            cbMaHangHoa.Text = dr_PhieuNhap.Cells["MaHangHoa"].Value.ToString();
            maHH = cbMaHangHoa.Text;
            cbtTenHH.Text = dr_PhieuNhap.Cells["TenHangHoa"].Value.ToString();
            donVT.Text = dr_PhieuNhap.Cells["DonViTinh"].Value.ToString();
            giaBan.Text = dr_PhieuNhap.Cells["GiaBan"].Value.ToString();
            soLuong.Text = dr_PhieuNhap.Cells["SoLuong"].Value.ToString();
            soluongtruockhisua = long.Parse(soLuong.Text.ToString());
            rbGhiChu.Text = dr_PhieuNhap.Cells["GhiChu"].Value.ToString();
            chiecKhau.Text = dr_PhieuNhap.Cells["ChiecKhau"].Value.ToString();
            gTGT.Text = dr_PhieuNhap.Cells["GTGT"].Value.ToString();

        }

        private void xoaPhieuXuat_Click(object sender, EventArgs e)
        {
            PhieuXuat_DTO hhDTO = new PhieuXuat_DTO();

            hhDTO.IDKey = IDHH;
            if (IDHH == 0)
            {
                IDHH = 1;
            }
            lsPhieuXuat.RemoveAt(int.Parse((IDHH - 1).ToString()));
            if (PhieuXuat_BUS.XoaPhieuXuat(hhDTO) == true)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.MaHang = maHH;
                hh.SoLuong = 0;
                hh.ThanhTien = soluongtruockhisua;
                if (HangHoa_BUS.SuaSoLuongXuat(hh))
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
                baocao.DGNhapTK = hhmoi[0].GiaNhap;
                baocao.SLTonDK = soluongtruockhisua;
                baocao.SLXuatTK = 0;
                baocao.DGXuatTK = 0;
                baocao.TTXuatTK = 0;
                if (BaoCaoTongHop_BUS.SuaSoLuongXuat(baocao))
                {
                    MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
                LoadPhieuXuat();
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }
        public String strSoPX;
       

        private void inPhieuXuat_Click(object sender, EventArgs e)
        {
            if (flaglapphieu)
            {
                using (StreamWriter sw = new StreamWriter("SoPX.txt"))
                {
                    sw.WriteLine(strSoPX);
                }
                InPhieuBanHang us = new InPhieuBanHang();
                us.Inreport();
                us.ShowDialog();
            }
            else {
                MessageBox.Show("Bạn cần phải lập phiếu trước khi in", "Thông báo");
            }
            return;
        }
        public bool flaglapphieu = false;
        private void lapPhieu_Click(object sender, EventArgs e)
        {
            flaglapphieu = true;
            //Cong thu
            CongNoThu_DTO cNoThu = new CongNoThu_DTO();
            cNoThu.MaKhachHang = cbMaKH.Text;
            cNoThu.TenKhachHang = cbTenKH.Text;
            cNoThu.SoDuDauKiNo = 0;
            cNoThu.PhatSinhTrongKiNo = ltongTien + ltienGTGT;
            cNoThu.PhatSinhTrongKiCo = ltienChiecKhau + long.Parse(traTruoc.Text.ToString());
            cNoThu.SoDuCuoiKiNo = cNoThu.PhatSinhTrongKiNo - cNoThu.PhatSinhTrongKiCo;
            cNoThu.GhiChu = " ";
            cNoThu.NhomKhachHang = nhomKH.Text;
            cNoThu.ThoiGianPhatSinh = DateTime.Parse(dtNgayXuat.Text.ToString());
            cNoThu.ThoiHanNo = DateTime.Parse(ngayHanNo.Text.ToString());
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

        private void themkh_Click(object sender, EventArgs e)
        {
            ThemKhachHang us = new ThemKhachHang();
            us.ShowDialog();
            LoadCmbMaKH();
        }
    }
}
