using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CongNoThu_BUS
    {
        public static long NoThu()
        {
            return CongNoThu_DAO.NoThu();
        }
        public static bool CapNhatLaiTuDau(DateTime time)
        {
            return CongNoThu_DAO.CapNhatLaiTuDau(time);
        }
        //load khách hàng
        public static List<CongNoThu_DTO> LoadCongNoThu()
        {
            //Load khách hàng
            return CongNoThu_DAO.LoadCongNoThu();
        }
        public static List<CongNoThu_DTO> LoadKHMuaLe(bool flag, string strfrom, string strto)
        {
            //Load khách hàng
            return CongNoThu_DAO.LoadKHMuaLe(flag, strfrom, strto);
        }
        public static List<CongNoThu_DTO> LoadKHDaiLy(bool flag, string strfrom, string strto)
        {
            //Load khách hàng
            return CongNoThu_DAO.LoadKHDaiLy(flag, strfrom, strto);
        }
        //them CongNoThu
        public static bool themCongNoThu(CongNoThu_DTO khdto)
        {
            return CongNoThu_DAO.ThemCongNoThu(khdto);
        }

        //them CongNoThu
        public static List<CongNoThu_DTO> TiemkiemCongNoThu(string tiemkiem)
        {
            return CongNoThu_DAO.TiemkiemCongNoThu(tiemkiem);
        }
        public static List<CongNoThu_DTO> TiemkiemCongNoThu(string strfrom,string strto)
        {
            return CongNoThu_DAO.TiemkiemCongNoThu(strfrom,strto);
        }
        //sửa khach hang
        public static bool suaCongNoThu(CongNoThu_DTO khdto)
        {
            return CongNoThu_DAO.SuaCongNoThu(khdto);
        }
        //xóa khach hang
        public static bool xoaCongNoThu(CongNoThu_DTO khdto)
        {
            return CongNoThu_DAO.XoaCongNoThu(khdto);
        }
    }
}
