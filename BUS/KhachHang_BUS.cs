using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class KhachHang_BUS
    {
        
        //load khách hàng
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            //Load khách hàng
            return KhachHang_DAO.LoadKhachHang();
        }
        //them khachhang
        public static bool themkhachhang(KhachHang_DTO khdto)
        {
            return KhachHang_DAO.ThemKhachHang(khdto);
        }
        //sửa khach hang
        public static bool suakhachhang(KhachHang_DTO khdto)
        {
            return KhachHang_DAO.suaKhachHang(khdto);
        }
        //xóa khach hang
        public static bool xoakhachhang(KhachHang_DTO khdto)
        {
            return KhachHang_DAO.xoaKhachHang(khdto);
        }
        //tiem kiem
        public static List<KhachHang_DTO> TimkiemKhachHang(string tiemkiem)
        {
            return KhachHang_DAO.Timkiemkhachhang(tiemkiem);
        }
    }
}
