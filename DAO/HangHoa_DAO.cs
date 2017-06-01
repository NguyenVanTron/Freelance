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
    public class HangHoa_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        //Load hàng hóa
        public static List<HangHoa_DTO> LoadHangHoa()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from HangHoa";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<HangHoa_DTO> listHH = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hanghoa = new HangHoa_DTO();
                //int.Parse();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.MaHang = dt.Rows[i]["MaHang"].ToString();
                hanghoa.TenHang = dt.Rows[i]["TenHang"].ToString();
                hanghoa.DungTich = dt.Rows[i]["DungTich"].ToString();
                hanghoa.HoatChat = dt.Rows[i]["HoatChat"].ToString();
                hanghoa.DoiTuong = dt.Rows[i]["DoiTuong"].ToString();
                hanghoa.Loai = dt.Rows[i]["Loai"].ToString();
                hanghoa.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                hanghoa.QuiCach = long.Parse(dt.Rows[i]["QuiCach"].ToString());
                hanghoa.CachDung = dt.Rows[i]["CachDung"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.GiaNhap = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.GiaCu = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.ThanhTien = hanghoa.SoLuong * hanghoa.GiaNhap;
                hanghoa.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                listHH.Add(hanghoa);
            }
            DataProvider.dongketnoi(con);
            return listHH;

        }
        // Thêm hàng hóa

        public static bool ThemHangHoa(HangHoa_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into HangHoa(MaHang,TenHang,DungTich,HoatChat,DoiTuong,MaNCC,QuiCach,CachDung,DonViTinh,GiaNhap,GiaBan,SoLuong,NgayNhap,GiaCu,Loai) values ('{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',{6},N'{7}',N'{8}',{9},{10},{11},'{12}',{13},N'{14}')", hhdto.MaHang, hhdto.TenHang, hhdto.DungTich, hhdto.HoatChat, hhdto.DoiTuong, hhdto.MaNCC,hhdto.QuiCach,hhdto.CachDung,hhdto.DonViTinh,hhdto.GiaNhap,hhdto.GiaBan,hhdto.SoLuong ,hhdto.NgayNhap,hhdto.GiaCu,hhdto.Loai);
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
        public static bool UpdateSoLuongXuat(HangHoa_DTO hhdto)
        {
            string tim = string.Format("select SoLuong from HangHoa where MaHang = '{0}'", hhdto.MaHang);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(tim, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return false;
            }
            long soluong  = long.Parse(dt.Rows[0]["SoLuong"].ToString());
            if(soluong < hhdto.SoLuong)
            {
                return false;
            }
            long soluongcon = soluong - hhdto.SoLuong;
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update HangHoa SoLuong  = '{0}', where MaHang = '{1}'"
                , soluongcon, hhdto.MaHang);
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
        public static bool SuaSoLuongXuat(HangHoa_DTO hhdto)
        {
            string tim = string.Format("select SoLuong from HangHoa where MaHang = '{0}'", hhdto.MaHang);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(tim, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return false;
            }
            long soluong = long.Parse(dt.Rows[0]["SoLuong"].ToString());
            long soluongTruoc = soluong + hhdto.ThanhTien;
            if (soluongTruoc < hhdto.SoLuong)
            {
                return false;
            }
            long soluongcon = soluongTruoc - hhdto.SoLuong;
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update HangHoa set SoLuong  = '{0}', where MaHang = '{1}'"
                , soluongcon, hhdto.MaHang);
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
        public static bool SuaSoLuongNhap(HangHoa_DTO hhdto)
        {
            string tim = string.Format("select SoLuong from HangHoa where MaHang = '{0}'", hhdto.MaHang);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(tim, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return false;
            }
            long soluong = long.Parse(dt.Rows[0]["SoLuong"].ToString());
            long soluongTruoc = soluong - hhdto.ThanhTien;
            
            long soluongcon = soluongTruoc + hhdto.SoLuong;
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update HangHoa set SoLuong  = '{0}', where MaHang = '{1}'"
                , soluongcon, hhdto.MaHang);
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
        //
        public static bool UpdateSoLuongNhap(HangHoa_DTO hhdto)
        {
            string tim = string.Format("select SoLuong from HangHoa where MaHang = '{0}'",hhdto.MaHang);
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(tim, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return false;
            }
            long soluong = long.Parse(dt.Rows[0]["SoLuong"].ToString());
            if (soluong < hhdto.SoLuong)
            {
                return false;
            }
            long soluongsau = soluong + hhdto.SoLuong;
            // Khai báo truy vấn SQL
             string sTruyvan = string.Format("update HangHoa set GiaCu = (select GiaNhap from HangHoa where MaHang = '{0}')" + "update HangHoa set NgayNhap = '{1}', Soluong = {2}, GiaNhap = {3} where MaHang = '{0}'"
                , hhdto.MaHang, hhdto.NgayNhap, soluongsau, hhdto.GiaNhap);
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
        public static bool SuaHangHoa(HangHoa_DTO hhdto)
        {

            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update HangHoa set GiaCu = (select GiaNhap from HangHoa where MaHang = '{0}')" + "update HangHoa set TenHang = N'{1}',DungTich= '{2}',HoatChat  = N'{3}',DoiTuong = N'{4}',MaNCC  = N'{5}',QuiCach  = {6},CachDung  = N'{7}',DonViTinh = '{8}',GiaNhap  = {9},GiaBan  = {10},SoLuong  = {11},NgayNhap  = N'{12}', Loai = N'{13}' where MaHang = '{0}'"
                , hhdto.MaHang, hhdto.TenHang, hhdto.DungTich, hhdto.HoatChat, hhdto.DoiTuong, hhdto.MaNCC, hhdto.QuiCach, hhdto.CachDung, hhdto.DonViTinh, hhdto.GiaNhap, hhdto.GiaBan, hhdto.SoLuong, hhdto.NgayNhap,hhdto.Loai);
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
        public static bool XoaHangHoa(HangHoa_DTO hhdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From HangHoa where MaHang = '{0}'", hhdto.MaHang);
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
        public static List<HangHoa_DTO> TimKiemHangHoa(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from HangHoa where TenHang like N'%" + tiemkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<HangHoa_DTO> listHH = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hanghoa = new HangHoa_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.MaHang = dt.Rows[i]["MaHang"].ToString();
                hanghoa.TenHang = dt.Rows[i]["TenHang"].ToString();
                hanghoa.DungTich = dt.Rows[i]["DungTich"].ToString();
                hanghoa.HoatChat = dt.Rows[i]["HoatChat"].ToString();
                hanghoa.DoiTuong = dt.Rows[i]["DoiTuong"].ToString();
                hanghoa.Loai = dt.Rows[i]["Loai"].ToString();
                hanghoa.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                hanghoa.QuiCach = long.Parse(dt.Rows[i]["QuiCach"].ToString());
                hanghoa.CachDung = dt.Rows[i]["CachDung"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.GiaNhap = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.GiaCu = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaNhap * hanghoa.SoLuong;
                hanghoa.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                listHH.Add(hanghoa);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
        public static List<HangHoa_DTO> TimKiemHangTheoTG(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from HangHoa where NgayNhap like N'%" + tiemkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<HangHoa_DTO> listHH = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hanghoa = new HangHoa_DTO();
                hanghoa.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                hanghoa.MaHang = dt.Rows[i]["MaHang"].ToString();
                hanghoa.TenHang = dt.Rows[i]["TenHang"].ToString();
                hanghoa.DungTich = dt.Rows[i]["DungTich"].ToString();
                hanghoa.HoatChat = dt.Rows[i]["HoatChat"].ToString();
                hanghoa.DoiTuong = dt.Rows[i]["DoiTuong"].ToString();
                hanghoa.Loai = dt.Rows[i]["Loai"].ToString();
                hanghoa.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                hanghoa.QuiCach = long.Parse(dt.Rows[i]["QuiCach"].ToString());
                hanghoa.CachDung = dt.Rows[i]["CachDung"].ToString();
                hanghoa.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                hanghoa.GiaNhap = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.GiaCu = long.Parse(dt.Rows[i]["GiaNhap"].ToString());
                hanghoa.GiaBan = long.Parse(dt.Rows[i]["GiaBan"].ToString());
                hanghoa.SoLuong = long.Parse(dt.Rows[i]["SoLuong"].ToString());
                hanghoa.ThanhTien = hanghoa.GiaNhap * hanghoa.SoLuong;
                hanghoa.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                listHH.Add(hanghoa);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return listHH;
        }
    }
}
