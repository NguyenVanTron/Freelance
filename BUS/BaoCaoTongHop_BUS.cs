using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BaoCaoTongHop_BUS
    {
        public static bool PhatSinhBaoCao(string tenhanghoa,BaoCaoTongHop_DTO bc)
        {
            return BaoCaoTongHop_DAO.PhatSinhBaoCao(tenhanghoa, bc);
        }
        public static bool CapNhatLaiTuDau()
        {
            return BaoCaoTongHop_DAO.CapNhatLaiTuDau();
        }
        //load khách hàng
        public static List<BaoCaoTongHop_DTO> LoadBaoCao()
        {
            //Load khách hàng
            return BaoCaoTongHop_DAO.LoadBaoCaoTongHop();
        }

        //them CongNoThu
        public static bool ThemBaoCao(BaoCaoTongHop_DTO bc)
        {
            return BaoCaoTongHop_DAO.ThemCongBaoCao(bc);
        }

        //them CongNoThu
        public static List<BaoCaoTongHop_DTO> TiemkiemBaoCao(string tiemkiem)
        {
            return BaoCaoTongHop_DAO.TiemkiemHangHoa(tiemkiem);
        }
        //xóa khach hang
        public static bool XoaBaoCao(string bc)
        {
            return BaoCaoTongHop_DAO.XoaBaoCao(bc);
        }
        public static BaoCaoTongHop_DTO TongKetBaoCao()
        {
            return BaoCaoTongHop_DAO.TongKetBaoCao();
        }
        public static bool SuaSoLuongNhap(BaoCaoTongHop_DTO bc)
        {
            return BaoCaoTongHop_DAO.SuaSoLuongNhap(bc);
        }
        public static bool SuaSoLuongXuat(BaoCaoTongHop_DTO bc)
        {
            return BaoCaoTongHop_DAO.SuaSoLuongXuat(bc);
        }
    }
}
