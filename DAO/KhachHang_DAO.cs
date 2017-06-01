using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class KhachHang_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        //Load khach hàng
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from KhachHang";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<KhachHang_DTO> kh = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO khachhang = new KhachHang_DTO();
                //int.Parse();
                khachhang.Id = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SDT = dt.Rows[i]["SDT"].ToString();
                khachhang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khachhang.Email = dt.Rows[i]["Email"].ToString();
                khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                khachhang.DoanhSo = PhieuXuat_DAO.LoadDoanhSo(khachhang.MaKhachHang);
                kh.Add(khachhang);
            }
            DataProvider.dongketnoi(con);
            return kh;

        }
        // Thêm khách hàng

        public static bool ThemKhachHang(KhachHang_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into KhachHang(MaKhachHang,TenKhachHang,SDT,DiaChi,Email,GhiChu,DoanhSo,NhomKhachHang) values (N'{0}',N'{1}','{2}',N'{3}','{4}',N'{5}',{6},N'{7}')", khdto.MaKhachHang, khdto.TenKhachHang, khdto.SDT, khdto.DiaChi, khdto.Email, khdto.GhiChu,khdto.DoanhSo,khdto.NhomKhachHang);
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
        //sửa khách hàng
        public static bool suaKhachHang(KhachHang_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update KhachHang set MaKhachHang = N'{0}',TenKhachHang = N'{1}',SDT= '{2}',DiaChi  = N'{3}',Email = N'{4}',GhiChu  = N'{5}',DoanhSo = {6}, NhomKhachHang = N'{7}' where MaKhachHang = '{0}'", khdto.MaKhachHang, khdto.TenKhachHang, khdto.SDT, khdto.DiaChi, khdto.Email, khdto.GhiChu, khdto.DoanhSo,khdto.NhomKhachHang);
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
        //xoa khách hàng
        public static bool xoaKhachHang(KhachHang_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From KhachHang where MaKhachHang = '{0}'", khdto.MaKhachHang);
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
        public static List<KhachHang_DTO> Timkiemkhachhang(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from KhachHang where TenKhachHang like N'%" + tiemkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<KhachHang_DTO> kh = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO khachhang = new KhachHang_DTO();
                //int.Parse();
                khachhang.Id = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SDT = dt.Rows[i]["SDT"].ToString();
                khachhang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khachhang.Email = dt.Rows[i]["Email"].ToString();
                khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(khachhang);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;
        }
    }
}
