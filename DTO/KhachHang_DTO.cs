using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private long id;
        private String maKhachHang;
        private String tenKhachHang;
        private String nhomKhachHang;
        private String sDT;
        private String diaChi;
        private String email;
        private String ghiChu;
        private long doanhSo;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public string NhomKhachHang
        {
            get
            {
                return nhomKhachHang;
            }

            set
            {
                nhomKhachHang = value;
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

        public long DoanhSo
        {
            get
            {
                return doanhSo;
            }

            set
            {
                doanhSo = value;
            }
        }
    }
}
