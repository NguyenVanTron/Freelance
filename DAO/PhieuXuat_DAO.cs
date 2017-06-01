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
    public class PhieuXuat_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        public static long DoanhSoBanHang()
        {
            string sTruyvan = "select Sum(ThanhTien - ThanhTien*(ChiecKhau - GTGT)/100) As DoanhSo from PhieuXuat";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return 0;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                PhieuXuat_DTO hanghoa = new PhieuXuat_DTO();
                hanghoa.ThanhTien = long.Parse(dt.Rows[i]["DoanhSo"].ToString());
                if (hanghoa.ThanhTien !=0)
                {
                    return hanghoa.ThanhTien;
                }
            }
            DataProvider.dongketnoi(con);
            return 0;
        }
        public static long LoadDoanhSo(string makh)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select MaKhachHang,Sum(ThanhTien) As DoanhSo from PhieuXuat Group by MaKhachHang";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return 0;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                PhieuXuat_DTO hanghoa = new PhieuXuat_DTO();
                hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                hanghoa.ThanhTien = long.Parse(dt.Rows[i]["DoanhSo"].ToString());
                if (makh == hanghoa.MaKhachHang)
                {
                    return hanghoa.ThanhTien;
                }
            }
            DataProvider.dongketnoi(con);
            return 0;

        }
        //Load hàng hóa
        public static List<PhieuXuat_DTO> LoadPhieuXuat()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuXuat";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuXuat_DTO> listHH = new List<PhieuXuat_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuXuat_DTO hanghoa = new PhieuXuat_DTO();
                //int.Parse();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPX = dt.Rows[i]["SoPX"].ToString();
                hanghoa.NgayXuat = DateTime.Parse(dt.Rows[i]["NgayXuat"].ToString());
                hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                hanghoa.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                hanghoa.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaBan * hanghoa.SoLuong;
                hanghoa.ConNo = long.Parse(dt.Rows[i]["ConNo"].ToString());
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau)/100 + hanghoa.ConNo;
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            DataProvider.dongketnoi(con);
            return listHH;

        }
        // Thêm hàng hóa

        public static bool ThemPhieuXuat(PhieuXuat_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into PhieuXuat(SoPX,NgayXuat,MaHangHoa,TenHangHoa,MaKhachHang,DonViTinh,GiaBan,SoLuong,ThanhTien,GhiChu,ChiecKhau,GTGT,TongTien,TenKhachHang,DiaChi,ConNo) values ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},{8},N'{9}',{10},{11},{12},N'{13}',N'{14}',{15})"
                  , hhdto.SoPX, hhdto.NgayXuat, hhdto.MaHangHoa, hhdto.TenHangHoa, hhdto.MaKhachHang, hhdto.DonViTinh, hhdto.GiaBan, hhdto.SoLuong, hhdto.ThanhTien, hhdto.GhiChu,hhdto.ChiecKhau,hhdto.GTGT,hhdto.TongTien,hhdto.TenKhachHang,hhdto.DiaChi,hhdto.ConNo);
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
        public static bool SuaPhieuXuat(PhieuXuat_DTO hhdto)
        {

            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update PhieuXuat set SoPX = '{0}', NgayXuat = '{1}', MaHangHoa= '{2}', TenHangHoa= N'{3}', MaKhachHang= '{4}', DonViTinh= '{5}', GiaBan= {6}, SoLuong= {7}, ThanhTien= {8}, GhiChu= N'{9}',ChiecKhau = {10},GTGT = {11}, TongTien = {12} where STT = {13}"
                  , hhdto.SoPX, hhdto.NgayXuat, hhdto.MaHangHoa, hhdto.TenHangHoa, hhdto.MaKhachHang, hhdto.DonViTinh, hhdto.GiaBan, hhdto.SoLuong, hhdto.ThanhTien, hhdto.GhiChu,hhdto.ChiecKhau,hhdto.GTGT,hhdto.TongTien,hhdto.IDKey);
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
        public static bool XoaPhieuXuat(PhieuXuat_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From PhieuXuat where STT = {0}", hhdto.IDKey);
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
        public static List<PhieuXuat_DTO> TimKiemPhieuXuat(string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,SoPX,NgayXuat,Sum(ThanhTien) As TienHang, Sum(TongTien) As TienTong from PhieuXuat where NgayXuat Between '" + strFrom +"' And'" + strTo +"' Group By SoPX,NgayXuat";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuXuat_DTO> listHH = new List<PhieuXuat_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuXuat_DTO hanghoa = new PhieuXuat_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                //hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPX = dt.Rows[i]["SoPX"].ToString();
                hanghoa.NgayXuat = DateTime.Parse(dt.Rows[i]["NgayXuat"].ToString());
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
        public static List<PhieuXuat_DTO> TimKiemPhieuXuatTG(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuXuat where SoPX  = '{0}'",tiemkiem.ToString());
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            
            List<PhieuXuat_DTO> listHH = new List<PhieuXuat_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuXuat_DTO hanghoa = new PhieuXuat_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPX = dt.Rows[i]["SoPX"].ToString();
                hanghoa.NgayXuat = DateTime.Parse(dt.Rows[i]["NgayXuat"].ToString());
                hanghoa.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                hanghoa.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                hanghoa.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaBan * hanghoa.SoLuong;
                hanghoa.ConNo = long.Parse(dt.Rows[i]["ConNo"].ToString());
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau)/100;
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
        public static List<PhieuXuat_DTO> TimKiemInReport(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuXuat where SoPX  = '{0}'", tiemkiem.ToString());
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }

            List<PhieuXuat_DTO> listHH = new List<PhieuXuat_DTO>();
            long tongthanhtien = 0;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuXuat_DTO hanghoa = new PhieuXuat_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPX = dt.Rows[i]["SoPX"].ToString();
                hanghoa.NgayXuat = DateTime.Parse(dt.Rows[i]["NgayXuat"].ToString());
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
                hanghoa.ConNo = long.Parse(dt.Rows[i]["ConNo"].ToString());
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.ChiecKhau = int.Parse((hanghoa.ChiecKhau * hanghoa.ThanhTien).ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau) / 100;
                if(i == (dt.Rows.Count - 1))
                {
                    hanghoa.TongTien += hanghoa.ConNo;
                }
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);

            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
        public static DataTable TimKiemInReport2(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuXuat where SoPX  = '{0}'", tiemkiem.ToString());
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            return dt;
        }

        }
}
