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
    public partial class UC_CongNoThu : UserControl
    {
        public UC_CongNoThu()
        {
            InitializeComponent();
        }
        private void LoadCongNoThu()
        {
            List<CongNoThu_DTO> lskhachhang = CongNoThu_BUS.LoadCongNoThu();
            dataGVCongNoThu.DataSource = lskhachhang;
            if(lskhachhang != null)
            {
                dataGVCongNoThu.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVCongNoThu.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dataGVCongNoThu.Columns["SoDuDauKiNo"].HeaderText = "Nợ đầu kì";
                dataGVCongNoThu.Columns["PhatSinhTrongKiNo"].HeaderText = "Nợ phát sinh";
                dataGVCongNoThu.Columns["PhatSinhTrongKiCo"].HeaderText = "Có phát sinh";
                dataGVCongNoThu.Columns["SoDuCuoiKiNo"].HeaderText = "Nợ cuối kì";
                dataGVCongNoThu.Columns["ThoiGianPhatSinh"].HeaderText = "Thời gian";
                dataGVCongNoThu.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVCongNoThu.Columns["NhomKhachHang"].HeaderText = "Nhóm khách hàng";
                dataGVCongNoThu.Columns["PhatSinhTrongKiCo"].Width = 120;
                dataGVCongNoThu.Columns["PhatSinhTrongKiNo"].Width = 120;
                dataGVCongNoThu.Columns["TenKhachHang"].Width = 150;
                dataGVCongNoThu.Columns["MaKhachHang"].Width = 100;
                dataGVCongNoThu.Columns["SoDuCuoiKiNo"].Width = 120;
                dataGVCongNoThu.Columns["SoDuDauKiNo"].Width = 120;
                dataGVCongNoThu.Columns["ThoiGianPhatSinh"].Width = 120;
                dataGVCongNoThu.Columns["NhomKhachHang"].Width = 120;
                dataGVCongNoThu.Columns["GhiChu"].Width = 140;
                dataGVCongNoThu.Columns["STT"].Width = 60;
                long ltongdauno = 0;
                long lphatsinhtongno = 0;
                long lphatsinhtongco = 0;
                long lcuoikitongno = 0;
                for (int i = 0; i < lskhachhang.Count; i++)
                {
                    ltongdauno += lskhachhang[i].SoDuDauKiNo;
                    lphatsinhtongno += lskhachhang[i].PhatSinhTrongKiNo;
                    lphatsinhtongco += lskhachhang[i].PhatSinhTrongKiCo;
                    lcuoikitongno += lskhachhang[i].SoDuCuoiKiNo;
                }
                tongdauno.Text = ltongdauno.ToString();
                phatsinhnotong.Text = lphatsinhtongno.ToString();
                phatsinhcotong.Text = lphatsinhtongco.ToString();
                cuoikitongno.Text = lcuoikitongno.ToString();
            }
        }
        private void LoadKHDaiLy(bool flag, string strFrom, string strTo)
        {
            List<CongNoThu_DTO> lskhachhang = CongNoThu_BUS.LoadKHDaiLy(flag, strFrom, strTo);
            dataGVKHDaiLy.DataSource = lskhachhang;
            if (lskhachhang != null)
            {
                dataGVKHDaiLy.Columns["STT"].Width = 60;
                dataGVKHDaiLy.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVKHDaiLy.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dataGVKHDaiLy.Columns["SoDuDauKiNo"].HeaderText = "Nợ đầu kì";
                dataGVKHDaiLy.Columns["NhomKhachHang"].Visible = false;
                dataGVKHDaiLy.Columns["PhatSinhTrongKiNo"].HeaderText = "Nợ phát sinh";
                dataGVKHDaiLy.Columns["PhatSinhTrongKiCo"].HeaderText = "Có phát sinh";
                dataGVKHDaiLy.Columns["SoDuCuoiKiNo"].HeaderText = "Nợ cuối kì";
                dataGVKHDaiLy.Columns["ThoiGianPhatSinh"].Visible = false;
                dataGVKHDaiLy.Columns["ThoiHanNo"].Visible = false;
                dataGVKHDaiLy.Columns["GhiChu"].Visible = false;
                dataGVKHDaiLy.Columns["MaKhachHang"].Width = 120;
                dataGVKHDaiLy.Columns["TenKhachHang"].Width = 140;
                dataGVKHDaiLy.Columns["SoDuDauKiNo"].Width = 120;
                dataGVKHDaiLy.Columns["PhatSinhTrongKiNo"].Width = 120;
                dataGVKHDaiLy.Columns["PhatSinhTrongKiCo"].Width = 120;
                dataGVKHDaiLy.Columns["SoDuCuoiKiNo"].Width = 120;
                long ltongdauno = 0;
                long lphatsinhtongno = 0;
                long lphatsinhtongco = 0;
                long lcuoikitongno = 0;
                for (int i = 0; i < lskhachhang.Count; i++)
                {
                    ltongdauno += lskhachhang[i].SoDuDauKiNo;
                    lphatsinhtongno += lskhachhang[i].PhatSinhTrongKiNo;
                    lphatsinhtongco += lskhachhang[i].PhatSinhTrongKiCo;
                    lcuoikitongno += lskhachhang[i].SoDuCuoiKiNo;
                }
                dauno1.Text = ltongdauno.ToString();
                phatsinhno1.Text = lphatsinhtongno.ToString();
                phatsinhco1.Text = lphatsinhtongco.ToString();
                cuoino1.Text = lcuoikitongno.ToString();
            }
        }
        private void LoadKHMuaLe(bool flag, string strFrom, string strTo)
        {
            List<CongNoThu_DTO> lskhachhang = CongNoThu_BUS.LoadKHMuaLe(flag, strFrom, strTo);
            dataGVKHMuaLe.DataSource = lskhachhang;
            if (lskhachhang != null)
            {
                dataGVKHMuaLe.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dataGVKHMuaLe.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dataGVKHMuaLe.Columns["SoDuDauKiNo"].HeaderText = "Nợ đầu kì";
                dataGVKHMuaLe.Columns["NhomNCC"].Visible = false;
                dataGVKHMuaLe.Columns["PhatSinhTrongKiNo"].HeaderText = "Nợ phát sinh";
                dataGVKHMuaLe.Columns["PhatSinhTrongKiCo"].HeaderText = "Có phát sinh";
                dataGVKHMuaLe.Columns["SoDuCuoiKiNo"].HeaderText = "Nợ cuối kì";
                dataGVKHMuaLe.Columns["ThoiGianPhatSinh"].Visible = false;
                dataGVKHMuaLe.Columns["ThoiHanNo"].Visible = false;
                dataGVKHMuaLe.Columns["GhiChu"].Visible = false;
                dataGVKHMuaLe.Columns["MaKhachHang"].Width = 120;
                dataGVKHMuaLe.Columns["MaKhachHang"].Width = 150;
                dataGVKHMuaLe.Columns["SoDuDauKiNo"].Width = 120;
                dataGVKHMuaLe.Columns["PhatSinhTrongKiNo"].Width = 120;
                dataGVKHMuaLe.Columns["PhatSinhTrongKiCo"].Width = 120;
                dataGVKHMuaLe.Columns["SoDuCuoiKiNo"].Width = 120;
                long ltongdauno = 0;
                long lphatsinhtongno = 0;
                long lphatsinhtongco = 0;
                long lcuoikitongno = 0;
                for (int i = 0; i < lskhachhang.Count; i++)
                {
                    ltongdauno += lskhachhang[i].SoDuDauKiNo;
                    lphatsinhtongno += lskhachhang[i].PhatSinhTrongKiNo;
                    lphatsinhtongco += lskhachhang[i].PhatSinhTrongKiCo;
                    lcuoikitongno += lskhachhang[i].SoDuCuoiKiNo;
                }
                dauno2.Text = ltongdauno.ToString();
                phatsinhno2.Text = lphatsinhtongno.ToString();
                phatsinhco2.Text = lphatsinhtongco.ToString();
                cuoino2.Text = lcuoikitongno.ToString();
            }
        }
        public string strNgayPS;
        private void dataGVCongNoThu_Click(object sender, EventArgs e)
        {
            if (dataGVCongNoThu.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_khachhang = dataGVCongNoThu.SelectedRows[0];
            maKH.Text = dr_khachhang.Cells["MaKhachHang"].Value.ToString();
            tenKH.Text = dr_khachhang.Cells["TenKhachHang"].Value.ToString();
            nhomKH.Text = dr_khachhang.Cells["NhomKhachHang"].Value.ToString();
            noDau.Text = dr_khachhang.Cells["SoDuDauKiNo"].Value.ToString();
            noTrong.Text = dr_khachhang.Cells["PhatSinhTrongKiNo"].Value.ToString();
            coTrong.Text = dr_khachhang.Cells["PhatSinhTrongKiCo"].Value.ToString();
            noCuoi.Text = dr_khachhang.Cells["SoDuCuoiKiNo"].Value.ToString();
            thoigianPS.Text = dr_khachhang.Cells["ThoiGianPhatSinh"].Value.ToString();
            strNgayPS = thoigianPS.Text;
            rbGhiChu.Text = dr_khachhang.Cells["GhiChu"].Value.ToString();
        }

        private void UC_CongNoThu_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(capnhatlai, "Cập nhật lại từ đầu");
            tooltip.SetToolTip(suaPhieuXuat, "Sửa thông tin phiếu");
            tooltip.SetToolTip(xoaNo, "Xóa một khách hàng");
            tooltip.SetToolTip(xuatExcel, "Lưu thành excel");
            tooltip.SetToolTip(tiemKiemHH, "Tìm kiếm tên khách hàng");
            tooltip.SetToolTip(timkiemtheongay, "Tìm kiếm theo ngày");
            LoadCongNoThu();
            LoadKHDaiLy(false, "", "");
            LoadKHMuaLe(false, "", "");
        }
        private void suaPhieuXuat_Click(object sender, EventArgs e)
        {
            if (maKH.Text == "" || tenKH.Text == "" || noCuoi.Text == "" || thoigianPS.Text == ""
                || nhomKH.Text == "" || noDau.Text == "" || noTrong.Text == "" || coTrong.Text == "")
            {
                MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
                return;
            }
            if (rbGhiChu.Text == "")
            {
                rbGhiChu.Text = "Không có";
            }
            CongNoThu_DTO khDTO = new CongNoThu_DTO();
            khDTO.MaKhachHang = maKH.Text;
            khDTO.TenKhachHang = tenKH.Text;
            khDTO.NhomKhachHang = nhomKH.Text;
            khDTO.SoDuDauKiNo = long.Parse(noDau.Text.ToString());
            khDTO.PhatSinhTrongKiNo = long.Parse(noTrong.Text.ToString());
            khDTO.PhatSinhTrongKiCo = long.Parse(coTrong.Text.ToString());
            khDTO.SoDuCuoiKiNo = long.Parse(noCuoi.Text.ToString());
            khDTO.ThoiGianPhatSinh = DateTime.Parse(thoigianPS.Text.ToString());
            khDTO.ThoiGianPhatSinh = DateTime.Parse(strNgayPS.ToString());
            khDTO.GhiChu = rbGhiChu.Text;

            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (CongNoThu_BUS.suaCongNoThu(khDTO) == true)
            {
                LoadCongNoThu();
                LoadKHDaiLy(false, "", "");
                LoadKHMuaLe(false, "", "");
                return;
            }
            else
            {
                MessageBox.Show("Sửa không Thành Công", "Thông Báo");
                return;
            }
        }

        private void xoaNo_Click(object sender, EventArgs e)
        {
            CongNoThu_DTO khDTO = new CongNoThu_DTO();

            khDTO.ThoiGianPhatSinh = DateTime.Parse(strNgayPS.ToString());


            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (CongNoThu_BUS.xoaCongNoThu(khDTO) == true)
            {
                LoadCongNoThu();
                LoadKHDaiLy(false, "", "");
                LoadKHMuaLe(false, "", "");
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
            List<CongNoThu_DTO> lsst = CongNoThu_BUS.TiemkiemCongNoThu(stukhoa);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVCongNoThu.DataSource = lsst;
            }
        }

        private void tbNhapTenHH_Click(object sender, EventArgs e)
        {
            tbNhapTenHH.Text = "";
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
            ExportExcel(saveFileDialog1, dataGVCongNoThu);
        }

        private void capnhatlai_Click(object sender, EventArgs e)
        {
            DateTime today = new DateTime();
            today = DateTime.Now;
            if (CongNoThu_BUS.CapNhatLaiTuDau(today) == true)
            {
                LoadCongNoThu();
                LoadKHDaiLy(false, "", "");
                LoadKHMuaLe(false, "", "");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật không Thành Công", "Thông Báo");
                return;
            }
        }

        private void timkiemtheongay_Click(object sender, EventArgs e)
        {
            string strfrom = dateTimeFrom.Text.ToString();
            string strto = dateTimeTO.Text.ToString();
            List<CongNoThu_DTO> lsst = CongNoThu_BUS.TiemkiemCongNoThu(strfrom,strto);
            List<CongNoThu_DTO> list1 = CongNoThu_BUS.LoadKHDaiLy(true,strfrom, strto);
            List<CongNoThu_DTO> list2 = CongNoThu_BUS.LoadKHMuaLe(true,strfrom, strto);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVCongNoThu.DataSource = lsst;
                dataGVKHDaiLy.DataSource = list1;
                dataGVKHMuaLe.DataSource = list2;
            }
        }
    }
}
