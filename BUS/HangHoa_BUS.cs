using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HangHoa_BUS
    {
        //load hàng hóa
        public static List<HangHoa_DTO> LoadHangHoa()
        {
            //Load hàng hóa
            return HangHoa_DAO.LoadHangHoa();
        }
        //them hàng hóa
        public static bool ThemHangHoa(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.ThemHangHoa(hhdto);
        }
        //sửa hàng hóa
        public static bool SuaHangHoa(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.SuaHangHoa(hhdto);
        }
        public static bool UpdateSoLuongNhap(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.UpdateSoLuongNhap(hhdto);
        }
        public static bool UpdateSoLuongXuat(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.UpdateSoLuongXuat(hhdto);
        }
        public static bool SuaSoLuongXuat(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.SuaSoLuongXuat(hhdto);
        }
        public static bool SuaSoLuongNhap(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.SuaSoLuongNhap(hhdto);
        }
        //xóa hàng hóa
        public static bool XoaHangHoa(HangHoa_DTO hhdto)
        {
            return HangHoa_DAO.XoaHangHoa(hhdto);
        }
        //tiem kiem
        public static List<HangHoa_DTO> TimKiemHangHoa(string tiemkiem)
        {
            return HangHoa_DAO.TimKiemHangHoa(tiemkiem);
        }
        //tiem kiem theo thời gian
        public static List<HangHoa_DTO> TimKiemHangTheoTG(string tiemkiem)
        {
            return HangHoa_DAO.TimKiemHangTheoTG(tiemkiem);
        }
    }
}
