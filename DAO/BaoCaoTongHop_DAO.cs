using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class BaoCaoTongHop_DAO
    {
        static SqlConnection con;

        public static List<BaoCaoTongHop_DTO> TiemkiemHangHoa(string timkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from BaoCaoTongHop where TenHangHoa like N'%" + timkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<BaoCaoTongHop_DTO> kh = new List<BaoCaoTongHop_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
                //int.Parse();
                baocao.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                baocao.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                baocao.SLTonDK = long.Parse(dt.Rows[i]["SLTonDK"].ToString());
                baocao.DGTonDK = long.Parse(dt.Rows[i]["DGTonDK"].ToString());
                baocao.TTTonDK = long.Parse(dt.Rows[i]["TTTonDK"].ToString());
                baocao.SLNhapTK = long.Parse(dt.Rows[i]["SLNhapTK"].ToString());
                baocao.DGNhapTK = long.Parse(dt.Rows[i]["DGNhapTK"].ToString());
                baocao.TTNhapTK = long.Parse(dt.Rows[i]["TTNhapTK"].ToString());
                baocao.SLXuatTK = long.Parse(dt.Rows[i]["SLXuatTK"].ToString());
                baocao.DGXuatTK = long.Parse(dt.Rows[i]["DGXuatTK"].ToString());
                baocao.TTXuatTK = long.Parse(dt.Rows[i]["TTXuatTK"].ToString());
                baocao.SLTonCK = long.Parse(dt.Rows[i]["SLTonCK"].ToString());
                baocao.DGTonCK = long.Parse(dt.Rows[i]["DGTonCK"].ToString());
                baocao.TTTonCK = long.Parse(dt.Rows[i]["TTTonCK"].ToString());
                kh.Add(baocao);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }

        //Load khach hàng
        public static List<BaoCaoTongHop_DTO> LoadBaoCaoTongHop()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from BaoCaoTongHop";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<BaoCaoTongHop_DTO> kh = new List<BaoCaoTongHop_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
                //int.Parse();
                baocao.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                baocao.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                baocao.SLTonDK = long.Parse(dt.Rows[i]["SLTonDK"].ToString());
                baocao.DGTonDK = long.Parse(dt.Rows[i]["DGTonDK"].ToString());
                baocao.TTTonDK = long.Parse(dt.Rows[i]["TTTonDK"].ToString());
                baocao.SLNhapTK = long.Parse(dt.Rows[i]["SLNhapTK"].ToString());
                baocao.DGNhapTK = long.Parse(dt.Rows[i]["DGNhapTK"].ToString());
                baocao.TTNhapTK = long.Parse(dt.Rows[i]["TTNhapTK"].ToString());
                baocao.SLXuatTK = long.Parse(dt.Rows[i]["SLXuatTK"].ToString());
                baocao.DGXuatTK = long.Parse(dt.Rows[i]["DGXuatTK"].ToString());
                baocao.TTXuatTK = long.Parse(dt.Rows[i]["TTXuatTK"].ToString());
                baocao.SLTonCK = long.Parse(dt.Rows[i]["SLTonCK"].ToString());
                baocao.DGTonCK = long.Parse(dt.Rows[i]["DGTonCK"].ToString());
                baocao.TTTonCK = long.Parse(dt.Rows[i]["TTTonCK"].ToString());
                kh.Add(baocao);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }
        // Thêm khách hàng

        public static bool ThemCongBaoCao(BaoCaoTongHop_DTO bcDTO)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into BaoCaoTongHop(TenHangHoa,SLTonDK,DGTonDK,TTTonDK,SLNhapTK,DGNhapTK,TTNhapTK,SLXuatTK,DGXuatTK,TTXuatTK,SLTonCK,TTTonCK) values (N'{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})"
                                                                        ,bcDTO.TenHangHoa,bcDTO.SLTonDK,bcDTO.DGTonDK,bcDTO.TTTonDK,bcDTO.SLNhapTK,bcDTO.DGNhapTK,bcDTO.TTNhapTK,bcDTO.SLXuatTK,bcDTO.DGXuatTK,bcDTO.TTXuatTK,bcDTO.SLTonCK,bcDTO.DGTonCK,bcDTO.TTTonCK);
            //values(@MaKhachHang,@TenKhachHang,@SDT,@DiaChi,@Email,@GhiChu)";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            try
            {
                DataProvider.thucthitruyvannonquery(sTruyvan, con);
                DataProvider.dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.dongketnoi(con);
                return false;
            }

        }
        public static bool CapNhatLaiTuDau()
        {
            string strTimKiem = string.Format("select TenHangHoa,SLTonCK,DGTonCK,TTTonCK from BaoCaoTongHop");
            con = DataProvider.ketnoi();
            long lSLTonCK = 0;
            long lDGTonCK = 0;
            long lTTTonCK = 0;
            //truy vấn
            DataTable dt = DataProvider.laydatatable(strTimKiem, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
            }
            string strTenHH;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strTenHH = dt.Rows[i]["TenHangHoa"].ToString();
                lSLTonCK = long.Parse(dt.Rows[i]["SLTonCK"].ToString());
                lDGTonCK = long.Parse(dt.Rows[i]["DGTonCK"].ToString());
                lTTTonCK = long.Parse(dt.Rows[i]["TTTonCK"].ToString());
                string sTruyvan = string.Format("update BaoCaoTongHop set SLTonDK = {0},DGTonDK = {1}, TTTonDK = {2}, SLNhapTK = {3}, DGNhapTK= {4}, TTNhapTK= {5}, SLXuatTK= {6},DGXuatTK= {7},TTXuatTK= {8} where TenHangHoa = N'{9}'", lSLTonCK, lDGTonCK,lTTTonCK, 0, 0, 0, 0, 0, 0, strTenHH);
                con = DataProvider.ketnoi();
                //truy vấn
                try
                {
                    DataProvider.thucthitruyvannonquery(sTruyvan, con);
                    DataProvider.dongketnoi(con);
                    return true;
                }
                catch (Exception ex)
                {
                    DataProvider.dongketnoi(con);
                    return false;
                }

            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return true;
        }
        //
        public static bool SuaSoLuongXuat(BaoCaoTongHop_DTO bcDTO)
        {
            string tim = string.Format("select SLXuatTK from BaoCaoTongHop where TenHangHoa = N'{0}'", bcDTO.TenHangHoa);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(tim, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return false;
            }
            long soluong = long.Parse(dt.Rows[0]["SLXuatTK"].ToString());
            long soluongTruoc = soluong - bcDTO.SLTonDK;

            long soluongNhap = soluongTruoc + bcDTO.SLNhapTK;
            //Thêm vào báo cáo
            BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
            baocao.TenHangHoa = bcDTO.TenHangHoa;
            baocao.SLNhapTK = 0;
            baocao.DGNhapTK = 0;
            baocao.TTNhapTK = 0;
            baocao.SLXuatTK = soluongNhap;
            baocao.DGXuatTK = bcDTO.DGNhapTK;
            baocao.TTXuatTK =  soluongNhap* bcDTO.DGNhapTK;
            return PhatSinhBaoCao(bcDTO.TenHangHoa, baocao);

        }
        public static bool SuaSoLuongNhap(BaoCaoTongHop_DTO bcDTO)
        {
            string tim = string.Format("select SLNhapTK from BaoCaoTongHop where TenHangHoa = N'{0}'", bcDTO.TenHangHoa);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(tim, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return false;
            }
            long soluong = long.Parse(dt.Rows[0]["SLNhapTK"].ToString());
            long soluongTruoc = soluong - bcDTO.SLTonDK;
            
            long soluongNhap = soluongTruoc + bcDTO.SLNhapTK;
            //Thêm vào báo cáo
            BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
            baocao.TenHangHoa = bcDTO.TenHangHoa;
            baocao.SLNhapTK = soluongNhap;
            baocao.DGNhapTK = bcDTO.DGNhapTK;
            baocao.TTNhapTK = soluongNhap * bcDTO.DGNhapTK;
            baocao.SLXuatTK = 0;
            baocao.DGXuatTK = 0;
            baocao.TTXuatTK = 0;
            return PhatSinhBaoCao(bcDTO.TenHangHoa, baocao);

        }
        public static bool PhatSinhBaoCao(string tenhang, BaoCaoTongHop_DTO bcDTO)
        {
            string strTimKiem = string.Format("select * from BaoCaoTongHop");
            con = DataProvider.ketnoi();
            long lSLTonCK = 0;
            long lDGTonCK = 0;
            long lTTTonCK = 0;
            long lSLNhapTK = 0;
            long lDGNhapTK = 0;
            long lSLXuatTK = 0;
            long lDGXuatTK = 0;
            bool flag = false;
            //truy vấn
            DataTable dt = DataProvider.laydatatable(strTimKiem, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string strTenHH = dt.Rows[i]["TenHangHoa"].ToString();
                if(strTenHH == tenhang)
                {
                    flag = true;
                    lSLTonCK = long.Parse(dt.Rows[i]["SLTonCK"].ToString());
                    lDGTonCK = long.Parse(dt.Rows[i]["DGTonCK"].ToString());
                    lSLXuatTK = long.Parse(dt.Rows[i]["SLXuatTK"].ToString());
                    lDGXuatTK = long.Parse(dt.Rows[i]["DGXuatTK"].ToString());
                    lDGNhapTK = long.Parse(dt.Rows[i]["DGNhapTK"].ToString());
                    lSLNhapTK = long.Parse(dt.Rows[i]["SLNhapTK"].ToString());

                    break;
                }
                
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);

            if (flag)
            {
                string sTruyvan = string.Format("update BaoCaoTongHop set SLTonCK = {0},DGTonCK = {1}, TTTonCK = {2}, SLNhapTK = {3}, DGNhapTK= {4}, TTNhapTK= {5}, SLXuatTK= {6},DGXuatTK= {7},TTXuatTK= {8} where TenHangHang = N'{9}'", lSLTonCK + bcDTO.SLNhapTK - bcDTO.SLXuatTK, bcDTO.DGNhapTK, bcDTO.DGNhapTK * (lSLTonCK + bcDTO.SLNhapTK - bcDTO.SLXuatTK), bcDTO.SLNhapTK + lSLNhapTK, bcDTO.DGNhapTK, bcDTO.DGNhapTK*(bcDTO.SLNhapTK + lSLNhapTK), bcDTO.SLXuatTK + lSLXuatTK, bcDTO.DGXuatTK, bcDTO.DGXuatTK *(bcDTO.SLXuatTK + lSLXuatTK), tenhang);
                con = DataProvider.ketnoi();
                //truy vấn
                try
                {
                    DataProvider.thucthitruyvannonquery(sTruyvan, con);
                    DataProvider.dongketnoi(con);
                    return true;
                }
                catch (Exception ex)
                {
                    DataProvider.dongketnoi(con);
                    return false;
                }
            }
            else
            {
                string strTimKiem1 = string.Format("select SoLuong,GiaBan,GiaNhap from HangHoa where TenHang = N'{0}'",tenhang);
                con = DataProvider.ketnoi();
                long lsoluong = 0;
                long lgiaban = 0;
                long lgianhap = 0;
                //truy vấn
                DataTable dt1 = DataProvider.laydatatable(strTimKiem1, con);
                if (dt1.Rows.Count == 0)
                {
                    DataProvider.dongketnoi(con);
                }
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    lsoluong = long.Parse(dt1.Rows[i]["SoLuong"].ToString());
                    lgiaban = long.Parse(dt1.Rows[i]["GiaBan"].ToString());
                    lgianhap = long.Parse(dt1.Rows[i]["GiaNhap"].ToString());
                }
                //đóng kết nối
                DataProvider.dongketnoi(con);
                // Khai báo truy vấn SQL
                string sTruyvan = string.Format("insert into BaoCaoTongHop(TenHangHoa,SLTonDK,DGTonDK,TTTonDK,SLNhapTK,DGNhapTK,TTNhapTK,SLXuatTK,DGXuatTK,TTXuatTK,SLTonCK, DGTonCK,TTTonCK) values (N'{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})"
                                                                        , bcDTO.TenHangHoa, lsoluong, lgiaban, lgiaban* lsoluong, bcDTO.SLNhapTK, bcDTO.DGNhapTK, bcDTO.SLNhapTK * bcDTO.DGNhapTK, bcDTO.SLXuatTK, bcDTO.DGXuatTK, bcDTO.SLXuatTK* bcDTO.DGXuatTK, lsoluong + bcDTO.SLNhapTK - bcDTO.SLXuatTK, lgiaban, (lsoluong + bcDTO.SLNhapTK - bcDTO.SLXuatTK) *lgiaban);
                //values(@MaKhachHang,@TenKhachHang,@SDT,@DiaChi,@Email,@GhiChu)";
                //mở kết nối
                con = DataProvider.ketnoi();
                //truy vấn
                try
                {
                    DataProvider.thucthitruyvannonquery(sTruyvan, con);
                    DataProvider.dongketnoi(con);
                    return true;
                }
                catch (Exception ex)
                {
                    DataProvider.dongketnoi(con);
                    return false;
                }
            }

        }
        //sửa khách hàng
        public static BaoCaoTongHop_DTO TongKetBaoCao()
        {
            string sTruyvan = "select * from BaoCaoTongHop";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            BaoCaoTongHop_DTO baocao = new BaoCaoTongHop_DTO();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                baocao.SLTonDK += long.Parse(dt.Rows[i]["SLTonDK"].ToString());
                baocao.DGTonDK += long.Parse(dt.Rows[i]["DGTonDK"].ToString());
                baocao.TTTonDK += long.Parse(dt.Rows[i]["TTTonDK"].ToString());
                baocao.SLNhapTK += long.Parse(dt.Rows[i]["SLNhapTK"].ToString());
                baocao.DGNhapTK += long.Parse(dt.Rows[i]["DGNhapTK"].ToString());
                baocao.TTNhapTK += long.Parse(dt.Rows[i]["TTNhapTK"].ToString());
                baocao.SLXuatTK += long.Parse(dt.Rows[i]["SLXuatTK"].ToString());
                baocao.DGXuatTK += long.Parse(dt.Rows[i]["DGXuatTK"].ToString());
                baocao.TTXuatTK += long.Parse(dt.Rows[i]["TTXuatTK"].ToString());
                baocao.SLTonCK += long.Parse(dt.Rows[i]["SLTonCK"].ToString());
                baocao.DGTonCK += long.Parse(dt.Rows[i]["DGTonCK"].ToString());
                baocao.TTTonCK += long.Parse(dt.Rows[i]["TTTonCK"].ToString());
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return baocao;
        }
        //xoa khách hàng
        public static bool XoaBaoCao(string tenhanghoa)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From BaoCaoTongHop where TenHangHoa = N'{0}'", tenhanghoa);
            //values(@MaKhachHang,@TenKhachHang,@SDT,@DiaChi,@Email,@GhiChu)";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            try
            {
                DataProvider.thucthitruyvannonquery(sTruyvan, con);
                DataProvider.dongketnoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.dongketnoi(con);
                return false;
            }

        }
    }
}
