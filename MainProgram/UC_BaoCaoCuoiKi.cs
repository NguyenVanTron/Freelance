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
namespace MainProgram
{
    
    public partial class UC_BaoCaoCuoiKi : UserControl
    {
        public class CChiPhiKhac
        {
            private int sTT;
            private String chiTieu;
            private long soTien;
            private String ghiChu;
            public CChiPhiKhac(int istt, String strchitieu, long lsotien, String strghichu)
            {
                this.STT = istt;
                this.ChiTieu = strchitieu;
                this.SoTien = lsotien;
                this.GhiChu = strghichu;

            }
            public int STT
            {
                get
                {
                    return sTT;
                }

                set
                {
                    sTT = value;
                }
            }

            public string ChiTieu
            {
                get
                {
                    return chiTieu;
                }

                set
                {
                    chiTieu = value;
                }
            }

            public long SoTien
            {
                get
                {
                    return soTien;
                }

                set
                {
                    soTien = value;
                }
            }

            public string GhiChu
            {
                get
                {
                    return ghiChu;
                }

                set
                {
                    ghiChu = value;
                }
            }
        }
        public class CChiPhiKinhDoanh
        {
            private int sTT;
            private String chiTieu;
            private long soTien;
            private String ghiChu;
            public CChiPhiKinhDoanh(int istt, String strchitieu, long lsotien, String strghichu)
            {
                this.STT = istt;
                this.ChiTieu = strchitieu;
                this.SoTien = lsotien;
                this.GhiChu = strghichu;
            }
            public int STT
            {
                get
                {
                    return sTT;
                }

                set
                {
                    sTT = value;
                }
            }

            public string ChiTieu
            {
                get
                {
                    return chiTieu;
                }

                set
                {
                    chiTieu = value;
                }
            }

            public long SoTien
            {
                get
                {
                    return soTien;
                }

                set
                {
                    soTien = value;
                }
            }

            public string GhiChu
            {
                get
                {
                    return ghiChu;
                }

                set
                {
                    ghiChu = value;
                }
            }
        }
        public UC_BaoCaoCuoiKi()
        {
            InitializeComponent();
        }
        public List<CChiPhiKinhDoanh> list = new List<CChiPhiKinhDoanh>();
        private void LoadBaoCaoCuoiKi()
        {
            list.Clear();
            long doanhthuthuan = 0;
            doanhthuthuan = PhieuXuat_BUS.DoanhSoBanHang() - PhieuTraHang_BUS.ThanhTien();
            doanhthubanhang.Text = doanhthuthuan.ToString();
            long notra = CongNoTra_BUS.NoTra();
            long nothu = CongNoThu_BUS.NoThu();
            long chiphinhap = PhieuNhap_BUS.ChiPhiNhap();
            notrancc.Text = notra.ToString();
            nothukh.Text = nothu.ToString();
            chiphimuahang.Text = chiphinhap.ToString();
            if (tongcong.Text == "")
            {
                tongcong.Text = "0";
            }
            if (thuthapkhac.Text == "")
            {
                thuthapkhac.Text = "0";
            }
            if (thue.Text == "")
            {
                thue.Text = "0";
            }
            chiphikhac.Text = tongcong.Text;
            long loinhuanrong1 = doanhthuthuan + long.Parse(thuthapkhac.Text.ToString()) - chiphinhap - long.Parse(thue.Text.ToString());
            loinhuanrong.Text = loinhuanrong1.ToString();
            list.Add(new CChiPhiKinhDoanh(1, "Doanh thu bán hàng", doanhthuthuan, ghichu1.Text));
            list.Add(new CChiPhiKinhDoanh(2, "Nợ trả cho người bán", notra, ghichu2.Text));
            list.Add(new CChiPhiKinhDoanh(3, "Nợ thu từ khách hàng", doanhthuthuan, ghichu3.Text));
            list.Add(new CChiPhiKinhDoanh(4, "Thu nhập khác", long.Parse(thuthapkhac.Text.ToString()), ghichu4.Text));
            list.Add(new CChiPhiKinhDoanh(5, "Chi phí mua hàng", chiphinhap, ghichu5.Text));
            list.Add(new CChiPhiKinhDoanh(6, "Thuế", long.Parse(thue.Text.ToString()), ghichu6.Text));
            list.Add(new CChiPhiKinhDoanh(7, "Chi phí khác", long.Parse(tongcong.Text.ToString()), ghichu7.Text));
            list.Add(new CChiPhiKinhDoanh(8, "Lợi nhuận ròng", loinhuanrong1, ghichu8.Text));
            dataGVCPKinhDoanh.DataSource = list;
            if (list.Count != 0)
            {
                dataGVCPKinhDoanh.Columns["ChiTieu"].HeaderText = "Chi tiêu";
                dataGVCPKinhDoanh.Columns["SoTien"].HeaderText = "Số tiền";
                dataGVCPKinhDoanh.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVCPKinhDoanh.Columns["ChiTieu"].Width = 190;
                dataGVCPKinhDoanh.Columns["SoTien"].Width = 200;
                dataGVCPKinhDoanh.Columns["GhiChu"].Width = 200;
            }

        }
        public List<CChiPhiKhac> listchiphikhac = new List<CChiPhiKhac>();
        private void tinhTongChiPhi_Click(object sender, EventArgs e)
        {
            listchiphikhac.Clear();
            long tongChiPhiKhac = 0;
            if (adsl.Text == "")
            {
                adsl.Text = "0";
            }
            if (tienvanchuyen.Text == "")
            {
                tienvanchuyen.Text = "0";
            }
            if (thuenha.Text == "")
            {
                thuenha.Text = "0";
            }
            if (tiendien.Text == "")
            {
                tiendien.Text = "0";
            }
            if (lainganhang.Text == "")
            {
                lainganhang.Text = "0";
            }
            if (congtacphi.Text == "")
            {
                congtacphi.Text = "0";
            }
            if (thuenhanvien.Text == "")
            {
                thuenhanvien.Text = "0";
            }
            tongChiPhiKhac = long.Parse(thuenhanvien.Text.ToString()) +
                             long.Parse(congtacphi.Text.ToString()) +
                             long.Parse(lainganhang.Text.ToString()) +
                             long.Parse(tiendien.Text.ToString()) +
                             long.Parse(adsl.Text.ToString()) +
                             long.Parse(tienvanchuyen.Text.ToString()) +
                             long.Parse(thuenha.Text.ToString());
            tongcong.Text = tongChiPhiKhac.ToString();
            listchiphikhac.Add(new CChiPhiKhac(1,"Tiền lương nhân viên", long.Parse(thuenhanvien.Text.ToString()), ghichu21.Text));
            listchiphikhac.Add(new CChiPhiKhac(2, "Công tác phí", long.Parse(congtacphi.Text.ToString()), ghichu21.Text));
            listchiphikhac.Add(new CChiPhiKhac(3, "Tiền điện", long.Parse(lainganhang.Text.ToString()), ghichu21.Text));
            listchiphikhac.Add(new CChiPhiKhac(4, "Tiền ADSL", long.Parse(tiendien.Text.ToString()), ghichu21.Text));
            listchiphikhac.Add(new CChiPhiKhac(5, "Tiền thuê nhà ",long.Parse(adsl.Text.ToString()), ghichu21.Text));
            listchiphikhac.Add(new CChiPhiKhac(6, "Tiền trả ngân hàng", long.Parse(tienvanchuyen.Text.ToString()), ghichu21.Text));
            listchiphikhac.Add(new CChiPhiKhac(7, "Tiền vận chuyển", long.Parse(thuenha.Text.ToString()), ghichu21.Text));
            
            dataGVChiPhiKhac.DataSource = listchiphikhac;
            if (listchiphikhac.Count != 0)
            {
                dataGVChiPhiKhac.Columns["ChiTieu"].HeaderText = "Chi tiêu";
                dataGVChiPhiKhac.Columns["SoTien"].HeaderText = "Số tiền";
                dataGVChiPhiKhac.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataGVChiPhiKhac.Columns["ChiTieu"].Width = 180;
                dataGVChiPhiKhac.Columns["SoTien"].Width = 180;
                dataGVChiPhiKhac.Columns["GhiChu"].Width = 180;
                dataGVChiPhiKhac.Columns["STT"].Width = 60;
            }
            LoadBaoCaoCuoiKi();
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
        private void xuatFileExcelCPK_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVChiPhiKhac);
        }
        private void xuatFileExcelCPKD_Click(object sender, EventArgs e)
        {
            ExportExcel(saveFileDialog1, dataGVCPKinhDoanh);
        }

        private void UC_BaoCaoCuoiKi_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(tinhTongChiPhi, "Tính tổng chi phí khác");
            tooltip.SetToolTip(xuatexcelchiphikhac, "Lưu thành danh sách chi phi khác excel");
            tooltip.SetToolTip(xuatExcelKD, "Xuất danh sách báo cáo cuối kì");
        }
    }
}
