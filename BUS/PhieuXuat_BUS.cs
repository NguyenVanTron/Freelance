using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class PhieuXuat_BUS
    {
        //load hàng hóa
        public static long DoanhSoBanHang()
        {
            return PhieuXuat_DAO.DoanhSoBanHang();
        }
        public static long LoadDoanhSo(string makh)
        {
            return PhieuXuat_DAO.LoadDoanhSo(makh);
        }
        public static List<PhieuXuat_DTO> LoadPhieuXuat()
        {
            //Load hàng hóa
            return PhieuXuat_DAO.LoadPhieuXuat();
        }
        //them hàng hóa
        public static bool ThemPhieuXuat(PhieuXuat_DTO hhdto)
        {
            return PhieuXuat_DAO.ThemPhieuXuat(hhdto);
        }
        //sửa hàng hóa
        public static bool SuaPhieuXuat(PhieuXuat_DTO hhdto)
        {
            return PhieuXuat_DAO.SuaPhieuXuat(hhdto);
        }
        //xóa hàng hóa
        public static bool XoaPhieuXuat(PhieuXuat_DTO hhdto)
        {
            return PhieuXuat_DAO.XoaPhieuXuat(hhdto);
        }
        //tiem kiem
        public static List<PhieuXuat_DTO> TimKiemPhieuXuat(string strfrom,string strto)
        {
            return PhieuXuat_DAO.TimKiemPhieuXuat(strfrom,strto);
        }
        //tiem kiem theo thời gian
        public static List<PhieuXuat_DTO> TimKiemPhieuXuatTG(string tiemkiem)
        {
            return PhieuXuat_DAO.TimKiemPhieuXuatTG(tiemkiem);
        }
        public static List<PhieuXuat_DTO> TimKiemInRP(string tiemkiem)
        {
            return PhieuXuat_DAO.TimKiemInReport(tiemkiem);
        }
        public static DataTable TimKiemInRP2(string tiemkiem)
        {
            return PhieuXuat_DAO.TimKiemInReport2(tiemkiem);
        }
    }
}
