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
    public partial class UC_CongNoTra : UserControl
    {
        public UC_CongNoTra()
        {
            InitializeComponent();
        }
        public string strNgayPhatSinh;
        private void LoadCongNoTra()
        {
            List<CongNoTra_DTO> lskhachhang = CongNoTra_BUS.LoadCongNoTra();
            dataGVCongNoTra.DataSource = lskhachhang;
            if (lskhachhang != null)
            {
                dataGVCongNoTra.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVCongNoTra.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                dataGVCongNoTra.Columns["SoDuDauKiNo"].HeaderText = "Nợ đầu kì";
                dataGVCongNoTra.Columns["NhomNCC"].HeaderText = "Nhóm nhà cung cấp";
                dataGVCongNoTra.Columns["PhatSinhTrongKiNo"].HeaderText = "Nợ phát sinh";
                dataGVCongNoTra.Columns["PhatSinhTrongKiCo"].HeaderText = "Có phát sinh";
                dataGVCongNoTra.Columns["SoDuCuoiKiNo"].HeaderText = "Nợ cuối kì";
                dataGVCongNoTra.Columns["ThoiGianPhatSinh"].HeaderText = "Thời gian phát sinh";
                dataGVCongNoTra.Columns["ThoiHanNo"].HeaderText = "Thời hạn nợ";
                dataGVCongNoTra.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVCongNoTra.Columns["PhatSinhTrongKiCo"].Width = 120;
                dataGVCongNoTra.Columns["PhatSinhTrongKiNo"].Width = 120;
                dataGVCongNoTra.Columns["GhiChu"].Width = 140;
                dataGVCongNoTra.Columns["TenNCC"].Width = 130;
                dataGVCongNoTra.Columns["MaNCC"].Width = 130;
                dataGVCongNoTra.Columns["SoDuDauKiNo"].Width = 120;
                dataGVCongNoTra.Columns["SoDuCuoiKiNo"].Width = 120;
                dataGVCongNoTra.Columns["NhomNCC"].Width = 130;
                dataGVCongNoTra.Columns["STT"].Width = 60;
                long ltongdauno = 0;
                long lphatsinhtongno = 0;
                long lphatsinhtongco = 0;
                long lcuoikitongno = 0;
                for(int i =0; i < lskhachhang.Count; i++)
                {
                    ltongdauno += lskhachhang[i].SoDuDauKiNo;
                    lphatsinhtongno += lskhachhang[i].PhatSinhTrongKiNo;
                    lphatsinhtongco += lskhachhang[i].PhatSinhTrongKiCo;
                    lcuoikitongno += lskhachhang[i].SoDuCuoiKiNo;
                }
                tongcuoinochung.Text = ltongdauno.ToString();
                phatsinhnochung.Text = lphatsinhtongno.ToString();
                phatsinhcochung.Text = lphatsinhtongco.ToString();
                tongcuoinochung.Text = lcuoikitongno.ToString();
            }
        }
        private void LoadNCCDV(bool flag, string strFrom, string strTo)
        {
            List<CongNoTra_DTO> lskhachhang = CongNoTra_BUS.LoadNCCDV(flag,strFrom,strTo);
            dataGVNCCDV.DataSource = lskhachhang;
            if (lskhachhang != null)
            {
                dataGVNCCDV.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVNCCDV.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                dataGVNCCDV.Columns["SoDuDauKiNo"].HeaderText = "Nợ đầu kì";
                dataGVNCCDV.Columns["NhomNCC"].Visible = false;
                dataGVNCCDV.Columns["PhatSinhTrongKiNo"].HeaderText = "Nợ phát sinh";
                dataGVNCCDV.Columns["PhatSinhTrongKiCo"].HeaderText = "Có phát sinh";
                dataGVNCCDV.Columns["SoDuCuoiKiNo"].HeaderText = "Nợ cuối kì";
                dataGVNCCDV.Columns["ThoiGianPhatSinh"].Visible = false;
                dataGVNCCDV.Columns["ThoiHanNo"].Visible = false;
                dataGVNCCDV.Columns["GhiChu"].Visible = false;
                dataGVNCCDV.Columns["STT"].Width = 60;
                dataGVNCCDV.Columns["TenNCC"].Width = 130;
                dataGVNCCDV.Columns["MaNCC"].Width = 130;
                dataGVNCCDV.Columns["PhatSinhTrongKiNo"].Width = 120;
                dataGVNCCDV.Columns["PhatSinhTrongKiCo"].Width = 120;
                dataGVNCCDV.Columns["SoDuCuoiKiNo"].Width = 120;
                dataGVNCCDV.Columns["SoDuDauKiNo"].Width = 120;
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
                tongdauno1.Text = ltongdauno.ToString();
                phatsinhtongno1.Text = lphatsinhtongno.ToString();
                phatsinhtongco1.Text = lphatsinhtongco.ToString();
                cuoikitongno1.Text = lcuoikitongno.ToString();
            }
        }
        private void LoadDTCC(bool flag, string strFrom, string strTo)
        {
            List<CongNoTra_DTO> lskhachhang = CongNoTra_BUS.LoadDTVV(flag, strFrom, strTo);
            dataGVDoiTCC.DataSource = lskhachhang;
            if (lskhachhang != null)
            {
                dataGVDoiTCC.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataGVDoiTCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                dataGVDoiTCC.Columns["SoDuDauKiNo"].HeaderText = "Nợ đầu kì";
                dataGVDoiTCC.Columns["NhomNCC"].Visible = false;
                dataGVDoiTCC.Columns["PhatSinhTrongKiNo"].HeaderText = "Nợ phát sinh";
                dataGVDoiTCC.Columns["PhatSinhTrongKiCo"].HeaderText = "Có phát sinh";
                dataGVDoiTCC.Columns["SoDuCuoiKiNo"].HeaderText = "Nợ cuối kì";
                dataGVDoiTCC.Columns["ThoiGianPhatSinh"].Visible = false;
                dataGVDoiTCC.Columns["ThoiHanNo"].Visible = false;
                dataGVDoiTCC.Columns["GhiChu"].Visible = false;
                dataGVDoiTCC.Columns["STT"].Width = 60;
                dataGVDoiTCC.Columns["TenNCC"].Width = 130;
                dataGVDoiTCC.Columns["MaNCC"].Width = 130;
                dataGVDoiTCC.Columns["PhatSinhTrongKiNo"].Width = 120;
                dataGVDoiTCC.Columns["PhatSinhTrongKiCo"].Width = 120;
                dataGVDoiTCC.Columns["SoDuCuoiKiNo"].Width = 120;
                dataGVDoiTCC.Columns["SoDuDauKiNo"].Width = 120;
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
                tongdauno2.Text = ltongdauno.ToString();
                psno2.Text = lphatsinhtongno.ToString();
                psco2.Text = lphatsinhtongco.ToString();
                tongcuoino2.Text = lcuoikitongno.ToString();
            }
        }
        private void UC_CongNoTra_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(capnhatlai, "Cập nhật lại từ đầu");
            tooltip.SetToolTip(suaCongNo, "Sửa thông tin phiếu");
            tooltip.SetToolTip(xoaNo, "Xóa một khách hàng");
            tooltip.SetToolTip(xuatExcel, "Lưu thành excel");
            tooltip.SetToolTip(tiemKiemHH, "Tìm kiếm tên khách hàng");
            tooltip.SetToolTip(timkiemtheongay, "Tìm kiếm theo ngày");
            LoadCongNoTra();
            LoadNCCDV(false, "", "");
            LoadDTCC(false, "", "");
        }

        private void dataGVCongNoTra_Click(object sender, EventArgs e)
        {
            if (dataGVCongNoTra.CurrentCellAddress.X < 0)
            {
                return;
            }
            DataGridViewRow dr_khachhang = dataGVCongNoTra.SelectedRows[0];
            maNCC.Text = dr_khachhang.Cells["MaNCC"].Value.ToString();
            tenNCC.Text = dr_khachhang.Cells["TenNCC"].Value.ToString();
            noDau.Text = dr_khachhang.Cells["SoDuDauKiNo"].Value.ToString();
            thoigianPS.Text = dr_khachhang.Cells["ThoiGianPhatSinh"].Value.ToString();
            strNgayPhatSinh = thoigianPS.Text;
            ngayHanNo.Text = dr_khachhang.Cells["ThoiHanNo"].Value.ToString();
            noTrong.Text = dr_khachhang.Cells["PhatSinhTrongKiNo"].Value.ToString();
            coTrong.Text = dr_khachhang.Cells["PhatSinhTrongKiCo"].Value.ToString();
            noCuoi.Text = dr_khachhang.Cells["SoDuCuoiKiNo"].Value.ToString();
            nhomNCC.Text = dr_khachhang.Cells["NhomNCC"].Value.ToString();
            rbGhiChu.Text = dr_khachhang.Cells["GhiChu"].Value.ToString();
        }
        private void tiemKiemHH_Click(object sender, EventArgs e)
        {
            string stukhoa = tbNhapTenHH.Text.ToString();
            List<CongNoTra_DTO> lsst = CongNoTra_BUS.TiemkiemCongNoTra(stukhoa);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVCongNoTra.DataSource = lsst;
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
            ExportExcel(saveFileDialog1, dataGVCongNoTra);
        }
        private void suaCongNo_Click(object sender, EventArgs e)
        {
            if (maNCC.Text == "" || maNCC.Text == "" || noCuoi.Text == "" || thoigianPS.Text == ""
                || nhomNCC.Text == "" || noDau.Text == "" || noTrong.Text == "" || coTrong.Text == "")
            {
                MessageBox.Show("Bạn cần điền thông tin đầy đủ", "Thông Báo");
                return;
            }
            if (rbGhiChu.Text == "")
            {
                rbGhiChu.Text = "Không có";
            }
            CongNoTra_DTO khDTO = new CongNoTra_DTO();
            khDTO.MaNCC = maNCC.Text;
            khDTO.TenNCC = maNCC.Text;
            khDTO.SoDuDauKiNo = long.Parse(noDau.Text.ToString());
            khDTO.NhomNCC = nhomNCC.Text.ToString();
            khDTO.PhatSinhTrongKiNo = long.Parse(noTrong.Text.ToString());
            khDTO.PhatSinhTrongKiCo = long.Parse(coTrong.Text.ToString());
            khDTO.SoDuCuoiKiNo = long.Parse(noCuoi.Text.ToString());
            khDTO.ThoiGianPhatSinh = DateTime.Parse(thoigianPS.Text.ToString());
            khDTO.ThoiGianPhatSinh = DateTime.Parse(strNgayPhatSinh);
            khDTO.ThoiHanNo = DateTime.Parse(ngayHanNo.Text.ToString());
            khDTO.GhiChu = rbGhiChu.Text;

            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (CongNoTra_BUS.themCongNoTra(khDTO) == true)
            {
                LoadCongNoTra();
                LoadDTCC(false,"","");
                LoadNCCDV(false, "", "");
                return;
            }
            else
            {
                MessageBox.Show("Thêm không Thành Công", "Thông Báo");
                return;
            }
        }

        private void xoaNo_Click(object sender, EventArgs e)
        {
            CongNoTra_DTO khDTO = new CongNoTra_DTO();

            khDTO.ThoiGianPhatSinh = DateTime.Parse(strNgayPhatSinh);


            //nếu là ngày hoặc int thì ép kiểu DateTime.Parse hay int
            if (CongNoTra_BUS.xoaCongNoTra(khDTO) == true)
            {
                LoadCongNoTra();
                LoadDTCC(false, "", "");
                LoadNCCDV(false, "", "");
                return;
            }
            else
            {
                MessageBox.Show("Xóa không Thành Công", "Thông Báo");
                return;
            }
        }

        private void capnhatlai_Click(object sender, EventArgs e)
        {
            if (CongNoTra_BUS.CapNhatLaiTuDau(DateTime.Now) == true)
            {
                LoadCongNoTra();
                LoadDTCC(false, "", "");
                LoadNCCDV(false, "", "");
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
            List<CongNoTra_DTO> lsst = CongNoTra_BUS.TiemkiemCongNoTra(strfrom, strto);
            List<CongNoTra_DTO> listDTCC = CongNoTra_BUS.LoadDTVV(true,strfrom, strto);
            List<CongNoTra_DTO> listNCCDV = CongNoTra_BUS.LoadNCCDV(true,strfrom, strto);
            if (lsst == null)
            {
                //donothing
                MessageBox.Show("Không tìm thấy!", "Thông báo!");
            }
            else
            {
                dataGVCongNoTra.DataSource = lsst;
                dataGVDoiTCC.DataSource = listDTCC;
                dataGVNCCDV.DataSource = listNCCDV;
            }
        }
    }
}
