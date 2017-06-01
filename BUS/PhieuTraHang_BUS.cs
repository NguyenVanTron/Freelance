using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PhieuTraHang_BUS
    {
        public static long ThanhTien()
        {
            return PhieuTraHang_DAO.ThanhTienTra();
        }
        public static List<PhieuTraHang_DTO> LoadPhieuTraHang()
        {
            //Load hàng hóa
            return PhieuTraHang_DAO.LoadPhieuTraHang();
        }
        //them hàng hóa
        public static bool ThemPhieuTraHang(PhieuTraHang_DTO hhdto)
        {
            return PhieuTraHang_DAO.ThemPhieuTraHang(hhdto);
        }
        //sửa hàng hóa
        public static bool SuaPhieuTraHang(PhieuTraHang_DTO hhdto)
        {
            return PhieuTraHang_DAO.SuaPhieuTraHang(hhdto);
        }
        //xóa hàng hóa
        public static bool XoaPhieuTraHang(PhieuTraHang_DTO hhdto)
        {
            return PhieuTraHang_DAO.XoaPhieuTraHang(hhdto);
        }
        //tiem kiem
        public static List<PhieuTraHang_DTO> TimKiemPhieuTraHang(string strfrom, string strto)
        {
            return PhieuTraHang_DAO.TimKiemPhieuTraHang(strfrom, strto);
        }
        //tiem kiem theo thời gian
        public static List<PhieuTraHang_DTO> TimKiemPhieuTraHangTG(string tiemkiem)
        {
            return PhieuTraHang_DAO.TimKiemPhieuTraHangTG(tiemkiem);
        }
        public static List<PhieuTraHang_DTO> TimKiemInRP(string tiemkiem)
        {
            return PhieuTraHang_DAO.TimKiemInReport(tiemkiem);
        }
    }
}
