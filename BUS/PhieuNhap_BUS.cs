using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuNhap_BUS
    {
        //load hàng hóa
        public static long ChiPhiNhap()
        {
            //Load hàng hóa
            return PhieuNhap_DAO.ChiPhiNhap();
        }
        public static List<PhieuNhap_DTO> LoadPhieuNhap()
        {
            //Load hàng hóa
            return PhieuNhap_DAO.LoadPhieuNhap();
        }
        //them hàng hóa
        public static bool ThemPhieuNhap(PhieuNhap_DTO hhdto)
        {
            return PhieuNhap_DAO.ThemPhieuNhap(hhdto);
        }
        //sửa hàng hóa
        public static bool SuaPhieuNhap(PhieuNhap_DTO hhdto)
        {
            return PhieuNhap_DAO.SuaPhieuNhap(hhdto);
        }
        //xóa hàng hóa
        public static bool XoaPhieuNhap(PhieuNhap_DTO hhdto)
        {
            return PhieuNhap_DAO.XoaPhieuNhap(hhdto);
        }
        //tiem kiem
        public static List<PhieuNhap_DTO> TimKiemPhieuNhap(string strFrom, string strTo)
        {
            return PhieuNhap_DAO.TimKiemPhieuNhap(strFrom, strTo);
        }
        //tiem kiem theo thời gian
        public static List<PhieuNhap_DTO> TimKiemPhieuNhapTG(string tiemkiem)
        {
            return PhieuNhap_DAO.TimKiemPhieuNhapTG(tiemkiem);
        }
    }
}
