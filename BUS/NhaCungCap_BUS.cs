using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhaCungCap_BUS
    {
        //load NhaCungCap
        public static List<NhaCungCap_DTO> LoadNhaCungCap()
        {
            //Load NhaCungCap
            return NhaCungCap_DAO.LoadNhaCungCap();
        }
        //them NhaCungCap
        public static bool themNhaCungCap(NhaCungCap_DTO khdto)
        {
            return NhaCungCap_DAO.ThemNhaCungCap(khdto);
        }
        //sửa NhaCungCap
        public static bool suaNhaCungCap(NhaCungCap_DTO khdto)
        {
            return NhaCungCap_DAO.suaNhaCungCap(khdto);
        }
        //xóa NhaCungCap
        public static bool xoaNhaCungCap(NhaCungCap_DTO khdto)
        {
            return NhaCungCap_DAO.xoaNhaCungCap(khdto);
        }
        //tiem kiem
        public static List<NhaCungCap_DTO> TimkiemNhaCungCap(string tiemkiem)
        {
            return NhaCungCap_DAO.TimkiemNhaCungCap(tiemkiem);
        }
    }
}
