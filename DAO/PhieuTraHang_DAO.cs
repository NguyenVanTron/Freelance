using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class PhieuTraHang_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        //Load hàng hóa
        public static long ThanhTienTra()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select Sum(ThanhTien)As ThanhTien2 from PhieuTraHang";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return 0;
            }
            List<PhieuTraHang_DTO> listHH = new List<PhieuTraHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long thanhtien = 0;
                if(dt.Rows[i]["ThanhTien2"].ToString() != "")
                    thanhtien = long.Parse(dt.Rows[i]["ThanhTien2"].ToString());
                if (thanhtien != 0)
                {
                    return thanhtien;
                }
            }
            return 0;
        }
        public static List<PhieuTraHang_DTO> LoadPhieuTraHang()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuTraHang";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuTraHang_DTO> listHH = new List<PhieuTraHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuTraHang_DTO hanghoa = new PhieuTraHang_DTO();
                //int.Parse();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPT = dt.Rows[i]["SoPT"].ToString();
                hanghoa.NgayTra = DateTime.Parse(dt.Rows[i]["NgayTra"].ToString());
                hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                hanghoa.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                hanghoa.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaBan * hanghoa.SoLuong;
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau) / 100;
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            DataProvider.dongketnoi(con);
            return listHH;

        }
        // Thêm hàng hóa

        public static bool ThemPhieuTraHang(PhieuTraHang_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into PhieuTraHang(SoPT,NgayTra,MaHangHoa,TenHangHoa,MaKhachHang,DonViTinh,GiaBan,SoLuong,ThanhTien,GhiChu,ChiecKhau,GTGT,TongTien,TenKhachHang,DiaChi) values ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},{8},N'{9}',{10},{11},{12},N'{13}',N'{14}')"
                  , hhdto.SoPT, hhdto.NgayTra, hhdto.MaHangHoa, hhdto.TenHangHoa, hhdto.MaKhachHang, hhdto.DonViTinh, hhdto.GiaBan, hhdto.SoLuong, hhdto.ThanhTien, hhdto.GhiChu, hhdto.ChiecKhau, hhdto.GTGT, hhdto.TongTien, hhdto.TenKhachHang, hhdto.DiaChi);
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
        //sửa hàng hóa
        public static bool SuaPhieuTraHang(PhieuTraHang_DTO hhdto)
        {

            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update PhieuTraHang set SoPT = '{0}', NgayTra = '{1}', MaHangHoa= '{2}', TenHangHoa= N'{3}', MaKhachHang= '{4}', DonViTinh= '{5}', GiaBan= {6}, SoLuong= {7}, ThanhTien= {8}, GhiChu= N'{9}',ChiecKhau = {10},GTGT = {11}, TongTien = {12} where STT = {13}"
                  , hhdto.SoPT, hhdto.NgayTra, hhdto.MaHangHoa, hhdto.TenHangHoa, hhdto.MaKhachHang, hhdto.DonViTinh, hhdto.GiaBan, hhdto.SoLuong, hhdto.ThanhTien, hhdto.GhiChu, hhdto.ChiecKhau, hhdto.GTGT, hhdto.TongTien, hhdto.IDKey);
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
        //xoa hàng hóa
        public static bool XoaPhieuTraHang(PhieuTraHang_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From PhieuTraHang where STT = '{0}'", hhdto.IDKey);
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
        //tiềm kiếm 
        public static List<PhieuTraHang_DTO> TimKiemPhieuTraHang(string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,SoPT,NgayTra,Sum(ThanhTien) As TienHang, Sum(TongTien) As TienTong from PhieuTraHang where NgayTra Between '" + strFrom + "' And'" + strTo + "' Group By SoPT,NgayTra";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuTraHang_DTO> listHH = new List<PhieuTraHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuTraHang_DTO hanghoa = new PhieuTraHang_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                //hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPT = dt.Rows[i]["SoPT"].ToString();
                hanghoa.NgayTra = DateTime.Parse(dt.Rows[i]["NgayTra"].ToString());
                //hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                //hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                //hanghoa.TenHangHoa = dt.Rows[i]["DonViTinh"].ToString();
                //hanghoa.DonViTinh = dt.Rows[i]["TenHangHoa"].ToString();
                //hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                //hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.ThanhTien = long.Parse(dt.Rows[i]["TienHang"].ToString());
                hanghoa.TongTien = long.Parse(dt.Rows[i]["TienTong"].ToString());
                //hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }

            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
        public static List<PhieuTraHang_DTO> TimKiemPhieuTraHangTG(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuTraHang where SoPT  = '{0}'", tiemkiem.ToString());
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }

            List<PhieuTraHang_DTO> listHH = new List<PhieuTraHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuTraHang_DTO hanghoa = new PhieuTraHang_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPT = dt.Rows[i]["SoPT"].ToString();
                hanghoa.NgayTra = DateTime.Parse(dt.Rows[i]["NgayTra"].ToString());
                hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                hanghoa.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                hanghoa.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaBan * hanghoa.SoLuong;
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau) / 100;
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
        public static List<PhieuTraHang_DTO> TimKiemInReport(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuTraHang where SoPT  = '{0}'", tiemkiem.ToString());
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }

            List<PhieuTraHang_DTO> listHH = new List<PhieuTraHang_DTO>();
            long tongthanhtien = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuTraHang_DTO hanghoa = new PhieuTraHang_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPT = dt.Rows[i]["SoPT"].ToString();
                hanghoa.NgayTra = DateTime.Parse(dt.Rows[i]["NgayTra"].ToString());
                hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                hanghoa.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                hanghoa.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaBan * hanghoa.SoLuong;
                tongthanhtien += hanghoa.ThanhTien;
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.ChiecKhau = int.Parse((hanghoa.ChiecKhau * hanghoa.ThanhTien).ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau) / 100;
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);

            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
    }
}
