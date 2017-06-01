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
    public class PhieuNhap_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        //Load hàng hóa
        public static long ChiPhiNhap()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select Sum(ThanhTien - ThanhTien*(ChiecKhau - GTGT)/100) As ChiPhiNhap from PhieuNhap";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return 0;
            }
            List<PhieuNhap_DTO> listHH = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long chiphinhap = long.Parse(dt.Rows[i]["ChiPhiNhap"].ToString());
                if (chiphinhap != 0)
                {
                    return chiphinhap;
                }
            }
            return 0;
        }
        public static List<PhieuNhap_DTO> LoadPhieuNhap()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuNhap";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuNhap_DTO> listHH = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhap_DTO hanghoa = new PhieuNhap_DTO();
                //int.Parse();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPN = dt.Rows[i]["SoPN"].ToString();
                hanghoa.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                hanghoa.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaNhap = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaNhap * hanghoa.SoLuong;
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau)/100;
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            DataProvider.dongketnoi(con);
            return listHH;

        }
        // Thêm hàng hóa

        public static bool ThemPhieuNhap(PhieuNhap_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into PhieuNhap(SoPN,NgayNhap,MaHangHoa,TenHangHoa,MaNCC,DonViTinh,GiaNhap,SoLuong,ThanhTien,GhiChu,ChiecKhau,GTGT,TongTien) values ('{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7},{8},N'{9}',{10},{11},{12})"
                  , hhdto.SoPN, hhdto.NgayNhap, hhdto.MaHangHoa, hhdto.TenHangHoa, hhdto.MaNCC, hhdto.DonViTinh, hhdto.GiaNhap, hhdto.SoLuong, hhdto.ThanhTien, hhdto.GhiChu,hhdto.ChiecKhau,hhdto.GTGT,hhdto.TongTien);
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
        public static bool SuaPhieuNhap(PhieuNhap_DTO hhdto)
        {

            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update PhieuNhap set SoPN = '{0}', NgayXuat = '{1}', MaHangHoa= '{2}', TenHangHoa= '{3}', MaNCC= '{4}', DonViTinh= '{5}', GiaNhap= {6}, SoLuong= {7}, ThanhTien= {8}, GhiChu= N'{9}', ChiecKhau= {10}, GTGT= {11} ,TongTien = {12} where STT = {13}"
                  , hhdto.SoPN, hhdto.NgayNhap, hhdto.MaHangHoa, hhdto.TenHangHoa, hhdto.MaNCC, hhdto.DonViTinh, hhdto.GiaNhap, hhdto.SoLuong, hhdto.ThanhTien, hhdto.GhiChu,hhdto.ChiecKhau,hhdto.GTGT, hhdto.TongTien,hhdto.IDKey);
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
        public static bool XoaPhieuNhap(PhieuNhap_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From PhieuNhap where SoPN = '{0}'", hhdto.SoPN);
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
        public static List<PhieuNhap_DTO> TimKiemPhieuNhap(string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            //string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuNhap where TenHangHoa like N'%" + tiemkiem + "%' ";
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD, SoPN,NgayNhap,Sum(ThanhTien) AS TienHang ,Sum(TongTien) AS TienTong from PhieuNhap where NgayNhap Between '" + strFrom + "' And '" + strTo +"' Group by SoPN,NgayNhap";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuNhap_DTO> listHH = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhap_DTO hanghoa = new PhieuNhap_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                //hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPN = dt.Rows[i]["SoPN"].ToString();
                hanghoa.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                //hanghoa.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                //hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                //hanghoa.TenHangHoa = dt.Rows[i]["DonViTinh"].ToString();
                //hanghoa.DonViTinh = dt.Rows[i]["TenHangHoa"].ToString();
                //hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                //hanghoa.GiaNhap = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.ThanhTien = long.Parse(dt.Rows[i]["TienHang"].ToString());// hanghoa.GiaNhap * hanghoa.SoLuong;
                hanghoa.TongTien = long.Parse(dt.Rows[i]["TienTong"].ToString());
                //hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
        public static List<PhieuNhap_DTO> TimKiemPhieuNhapTG(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("select ROW_NUMBER() over (order by (select 1)) as IDD,* from PhieuNhap where SoPN = '{0}'",tiemkiem);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<PhieuNhap_DTO> listHH = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhap_DTO hanghoa = new PhieuNhap_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.IDKey = long.Parse(dt.Rows[i]["STT"].ToString());
                hanghoa.SoPN = dt.Rows[i]["SoPN"].ToString();
                hanghoa.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                hanghoa.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                hanghoa.MaHangHoa = dt.Rows[i]["MaHangHoa"].ToString();
                hanghoa.TenHangHoa = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["TenHangHoa"].ToString();
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.GiaNhap = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.ChiecKhau = int.Parse(dt.Rows[i]["ChiecKhau"].ToString());
                hanghoa.GTGT = int.Parse(dt.Rows[i]["GTGT"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaNhap * hanghoa.SoLuong;
                hanghoa.TongTien = hanghoa.ThanhTien + hanghoa.ThanhTien * (hanghoa.GTGT - hanghoa.ChiecKhau)/100;
                hanghoa.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                listHH.Add(hanghoa);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
    }
}
