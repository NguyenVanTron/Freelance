using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap_DTO
    {
        private long sTT;
        private String maNCC;
        private String tenNCC;
        private String nhomNCC;
        private String nguoiGiaoDich;
        private String sDT;
        private String email;
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

        public string NguoiGiaoDich
        {
            get
            {
                return nguoiGiaoDich;
            }

            set
            {
                nguoiGiaoDich = value;
            }
        }

        public string SDT
        {
            get
            {
                return sDT;
            }

            set
            {
                sDT = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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
