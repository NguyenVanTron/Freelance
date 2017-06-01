using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongNoTra_DTO
    {
        private long sTT;
        private String maNCC;
        private String tenNCC;
        private String nhomNCC;
        private long soDuDauKiNo;
        private long phatSinhTrongKiNo;
        private long phatSinhTrongKiCo;
        private long soDuCuoiKiNo;
        private DateTime thoiGianPhatSinh;
        private DateTime thoiHanNo;
        private String ghiChu;

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

        public string TenNCC
        {
            get
            {
                return tenNCC;
            }

            set
            {
                tenNCC = value;
            }
        }

        public string NhomNCC
        {
            get
            {
                return nhomNCC;
            }

            set
            {
                nhomNCC = value;
            }
        }

        public long SoDuDauKiNo
        {
            get
            {
                return soDuDauKiNo;
            }

            set
            {
                soDuDauKiNo = value;
            }
        }

        public long PhatSinhTrongKiNo
        {
            get
            {
                return phatSinhTrongKiNo;
            }

            set
            {
                phatSinhTrongKiNo = value;
            }
        }

        public long PhatSinhTrongKiCo
        {
            get
            {
                return phatSinhTrongKiCo;
            }

            set
            {
                phatSinhTrongKiCo = value;
            }
        }

        public long SoDuCuoiKiNo
        {
            get
            {
                return soDuCuoiKiNo;
            }

            set
            {
                soDuCuoiKiNo = value;
            }
        }

        public DateTime ThoiGianPhatSinh
        {
            get
            {
                return thoiGianPhatSinh;
            }

            set
            {
                thoiGianPhatSinh = value;
            }
        }

        public DateTime ThoiHanNo
        {
            get
            {
                return thoiHanNo;
            }

            set
            {
                thoiHanNo = value;
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
