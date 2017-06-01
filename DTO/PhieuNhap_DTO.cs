using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap_DTO
    {
        private long iDKey;
        private long sTT;
        private String soPN;
        private DateTime ngayNhap;
        private String maNCC;
        private String maHangHoa;
        private String tenHangHoa;
        private String donViTinh;
        private long soLuong;
        private long giaNhap;
        private long thanhTien;
        private int gTGT;
        private int chiecKhau;
        private long tongTien;
        private String ghiChu;

        public long IDKey
        {
            get
            {
                return iDKey;
            }

            set
            {
                iDKey = value;
            }
        }

        public long STT
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

        public string SoPN
        {
            get
            {
                return soPN;
            }

            set
            {
                soPN = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public string MaNCC
        {
            get
            {
                return maNCC;
            }

            set
            {
                maNCC = value;
            }
        }

        public string MaHangHoa
        {
            get
            {
                return maHangHoa;
            }

            set
            {
                maHangHoa = value;
            }
        }

        public string TenHangHoa
        {
            get
            {
                return tenHangHoa;
            }

            set
            {
                tenHangHoa = value;
            }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }

        public long SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public long GiaNhap
        {
            get
            {
                return giaNhap;
            }

            set
            {
                giaNhap = value;
            }
        }

        public long ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        public int GTGT
        {
            get
            {
                return gTGT;
            }

            set
            {
                gTGT = value;
            }
        }

        public int ChiecKhau
        {
            get
            {
                return chiecKhau;
            }

            set
            {
                chiecKhau = value;
            }
        }

        public long TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
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
}
