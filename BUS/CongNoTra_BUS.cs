using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CongNoTra_BUS
    {
        public static long NoTra()
        {
            return CongNoTra_DAO.NoTra();
        }
        public static bool CapNhatLaiTuDau(DateTime time)
        {
            return CongNoTra_DAO.CapNhatLaiTuDau(time);
        }
        //load khách hàng
        
        public static List<CongNoTra_DTO> LoadCongNoTra()
        {
            //Load khách hàng
            return CongNoTra_DAO.LoadCongNoTra();
        }
        public static List<CongNoTra_DTO> LoadNCCDV(bool flag,string strfrom, string strto)
        {
            //Load khách hàng
            return CongNoTra_DAO.LoadCongNhaCCDV(flag,strfrom,strto);
        }
        public static List<CongNoTra_DTO> LoadDTVV(bool flag, string strfrom, string strto)
        {
            //Load khách hàng
            return CongNoTra_DAO.LoadCongDTCC(flag, strfrom, strto);
        }
        //them CongNoTra
        public static bool themCongNoTra(CongNoTra_DTO khdto)
        {
            return CongNoTra_DAO.ThemCongNoTra(khdto);
        }

        //them CongNoTra
        public static List<CongNoTra_DTO> TiemkiemCongNoTra(string tiemkiem)
        {
            return CongNoTra_DAO.TiemkiemCongNoTra(tiemkiem);
        }
        public static List<CongNoTra_DTO> TiemkiemCongNoTra(string strfrom, string strto)
        {
            return CongNoTra_DAO.TiemkiemCongNoTra(strfrom, strto);
        }
        //sửa khach hang
        public static bool suaCongNoTra(CongNoTra_DTO khdto)
        {
            return CongNoTra_DAO.SuaCongNoTra(khdto);
        }
        //xóa khach hang
        public static bool xoaCongNoTra(CongNoTra_DTO khdto)
        {
            return CongNoTra_DAO.XoaCongNoTra(khdto);
        }
    }
}
