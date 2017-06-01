using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTraHang_DTO
    {
        private long iDKey;
        private long sTT;
        private String soPT;
        private DateTime ngayTra;
        private String maKhachHang;
        private String tenKhachHang;
        private String diaChi;
        private String maHangHoa;
        private String tenHangHoa;
        private String donViTinh;
        private long soLuong;
        private long giaBan;
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

        public string SoPT
        {
            get
            {
                return soPT;
            }

            set
            {
                soPT = value;
            }
        }

        public DateTime NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
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

        public long GiaBan
        {
            get
            {
                return giaBan;
            }

            set
            {
                giaBan = value;
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
