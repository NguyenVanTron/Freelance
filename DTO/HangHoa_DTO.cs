using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_DTO
    {
        private long sTT;
        private String maHang;
        private String tenHang;
        private String dungTich;
        private String hoatChat;
        private String doiTuong;
        private String loai;
        private String maNCC;
        private long quiCach;
        private String cachDung;
        private String donViTinh;
        private long giaNhap;
        private long giaCu;
        private long giaBan;
        private long soLuong;
        private long thanhTien;
        private DateTime ngayNhap;

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

        public string MaHang
        {
            get
            {
                return maHang;
            }

            set
            {
                maHang = value;
            }
        }

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public string DungTich
        {
            get
            {
                return dungTich;
            }

            set
            {
                dungTich = value;
            }
        }

        public string HoatChat
        {
            get
            {
                return hoatChat;
            }

            set
            {
                hoatChat = value;
            }
        }

        public string DoiTuong
        {
            get
            {
                return doiTuong;
            }

            set
            {
                doiTuong = value;
            }
        }

        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
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

        public long QuiCach
        {
            get
            {
                return quiCach;
            }

            set
            {
                quiCach = value;
            }
        }

        public string CachDung
        {
            get
            {
                return cachDung;
            }

            set
            {
                cachDung = value;
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

        public long GiaCu
        {
            get
            {
                return giaCu;
            }

            set
            {
                giaCu = value;
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
    }
}
