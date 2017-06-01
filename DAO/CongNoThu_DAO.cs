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
    public class CongNoThu_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        public static long NoThu()
        {
            string sTruyvan = "select Sum(SoDuCuoiKiNo) AS NoThu from CongNoThu";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return 0;
            }
            List<CongNoThu_DTO> kh = new List<CongNoThu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long nothu = long.Parse(dt.Rows[i]["NoThu"].ToString());
                if (nothu != 0)
                {
                    return nothu;
                }
            }
            return 0;

        }
        public static List<CongNoThu_DTO> TiemkiemCongNoThu(string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from CongNoThu where ThoiGianPhatSinh Between '" + strFrom + "' And '" + strTo + "'";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoThu_DTO> kh = new List<CongNoThu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoThu_DTO khachhang = new CongNoThu_DTO();
                //int.Parse();
                khachhang.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["SoDuDauKiNo"].ToString());
                khachhang.PhatSinhTrongKiNo = long.Parse(dt.Rows[i]["PhatSinhTrongKiNo"].ToString());
                khachhang.PhatSinhTrongKiCo = long.Parse(dt.Rows[i]["PhatSinhTrongKiCo"].ToString());
                khachhang.SoDuCuoiKiNo = long.Parse(dt.Rows[i]["SoDuCuoiKiNo"].ToString());
                khachhang.ThoiGianPhatSinh = DateTime.Parse(dt.Rows[i]["ThoiGianPhatSinh"].ToString());
                khachhang.ThoiHanNo = DateTime.Parse(dt.Rows[i]["ThoiHanNo"].ToString());
                khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(khachhang);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }
        public static List<CongNoThu_DTO> TiemkiemCongNoThu(string timkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from CongNoThu where MaKhachHang like N'%" + timkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoThu_DTO> kh = new List<CongNoThu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoThu_DTO khachhang = new CongNoThu_DTO();
                //int.Parse();
                khachhang.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["SoDuDauKiNo"].ToString());
                khachhang.PhatSinhTrongKiNo = long.Parse(dt.Rows[i]["PhatSinhTrongKiNo"].ToString());
                khachhang.PhatSinhTrongKiCo = long.Parse(dt.Rows[i]["PhatSinhTrongKiCo"].ToString());
                khachhang.SoDuCuoiKiNo = long.Parse(dt.Rows[i]["SoDuCuoiKiNo"].ToString());
                khachhang.ThoiGianPhatSinh = DateTime.Parse(dt.Rows[i]["ThoiGianPhatSinh"].ToString());
                khachhang.ThoiHanNo = DateTime.Parse(dt.Rows[i]["ThoiHanNo"].ToString());
                khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(khachhang);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }

        //Load khach hàng
        public static List<CongNoThu_DTO> LoadCongNoThu()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from CongNoThu";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoThu_DTO> kh = new List<CongNoThu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoThu_DTO khachhang = new CongNoThu_DTO();
                //int.Parse();
                khachhang.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["SoDuDauKiNo"].ToString());
                khachhang.PhatSinhTrongKiNo = long.Parse(dt.Rows[i]["PhatSinhTrongKiNo"].ToString());
                khachhang.PhatSinhTrongKiCo = long.Parse(dt.Rows[i]["PhatSinhTrongKiCo"].ToString());
                khachhang.SoDuCuoiKiNo = long.Parse(dt.Rows[i]["SoDuCuoiKiNo"].ToString());
                khachhang.ThoiGianPhatSinh = DateTime.Parse(dt.Rows[i]["ThoiGianPhatSinh"].ToString());
                khachhang.ThoiHanNo = DateTime.Parse(dt.Rows[i]["ThoiHanNo"].ToString());
                khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(khachhang);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }
        public static List<CongNoThu_DTO> LoadKHMuaLe(bool flag, string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL

            string sTruyvan;
            if (flag)
            {
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaKhachHang,TenKhachHang,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoThu where (NhomKhachHang like N'%Khách hàng mua lẻ%') And (ThoiGianPhatSinh Between '" + strFrom + "' And '" + strTo + "') Group by MaKhachHang,TenKhachHang";
            }
            else
            {
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaKhachHang,TenKhachHang,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoThu where NhomKhachHang like N'%Khách hàng mua lẻ%' Group by MaKhachHang,TenKhachHang";
            }
                //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoThu_DTO> kh = new List<CongNoThu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoThu_DTO khachhang = new CongNoThu_DTO();
                //int.Parse();
                khachhang.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                //khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["DuDau"].ToString());
                khachhang.PhatSinhTrongKiNo = long.Parse(dt.Rows[i]["PSNo"].ToString());
                khachhang.PhatSinhTrongKiCo = long.Parse(dt.Rows[i]["PSCo"].ToString());
                khachhang.SoDuCuoiKiNo = long.Parse(dt.Rows[i]["DuCuoi"].ToString());
                //khachhang.ThoiGianPhatSinh = DateTime.Parse(dt.Rows[i]["ThoiGianPhatSinh"].ToString());
                //khachhang.ThoiHanNo = DateTime.Parse(dt.Rows[i]["ThoiHanNo"].ToString());
                //khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(khachhang);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }
        public static List<CongNoThu_DTO> LoadKHDaiLy(bool flag, string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan;
            if (flag)
            {
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaKhachHang,TenKhachHang,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoThu where (NhomKhachHang like N'%Khách hàng đại lý%') And (ThoiGianPhatSinh Between '" + strFrom + "' And '" + strTo + "') Group by MaKhachHang,TenKhachHang";
            }
            else
            {
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaKhachHang,TenKhachHang,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoThu where NhomKhachHang like N'%Khách hàng đại lý%' Group by MaKhachHang,TenKhachHang";
            }
                //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoThu_DTO> kh = new List<CongNoThu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoThu_DTO khachhang = new CongNoThu_DTO();
                //int.Parse();
                khachhang.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachhang.TenKhachHang = dt.Rows[i]["TenKhachHang"].ToString();
                //khachhang.NhomKhachHang = dt.Rows[i]["NhomKhachHang"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["DuDau"].ToString());
                khachhang.PhatSinhTrongKiNo = long.Parse(dt.Rows[i]["PSNo"].ToString());
                khachhang.PhatSinhTrongKiCo = long.Parse(dt.Rows[i]["PSCo"].ToString());
                khachhang.SoDuCuoiKiNo = long.Parse(dt.Rows[i]["DuCuoi"].ToString());
                //khachhang.ThoiGianPhatSinh = DateTime.Parse(dt.Rows[i]["ThoiGianPhatSinh"].ToString());
                //khachhang.ThoiHanNo = DateTime.Parse(dt.Rows[i]["ThoiHanNo"].ToString());
                //khachhang.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(khachhang);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;

        }
        // Thêm khách hàng

        public static bool ThemCongNoThu(CongNoThu_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into CongNoThu(MaKhachHang,TenKhachHang,SoDuDauKiNo,PhatSinhTrongKiNo,PhatSinhTrongKiCo,SoDuCuoiKiNo,ThoiGianPhatSinh,GhiChu,NhomKhachHang,ThoiHanNo) values (N'{0}',N'{1}',{2},{3},{4},{5},'{6}',N'{7}',N'{8}','{9}')", khdto.MaKhachHang, khdto.TenKhachHang, khdto.SoDuDauKiNo, khdto.PhatSinhTrongKiNo, khdto.PhatSinhTrongKiCo, khdto.SoDuCuoiKiNo, khdto.ThoiGianPhatSinh, khdto.GhiChu,khdto.NhomKhachHang,khdto.ThoiHanNo);
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
        public static bool CapNhatLaiTuDau(DateTime time)
        {
            string strTimKiem = string.Format("select MaKhachHang,TenKhachHang,NhomKhachHang,Sum(SoDuCuoiKiNo) As SoDuCuoiKi from CongNoThu Group by MaKhachHang,TenKhachHang,NhomKhachHang");
            con = DataProvider.ketnoi();
            long sodudaukino = 0;
            //truy vấn
            DataTable dt = DataProvider.laydatatable(strTimKiem, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
            }
            string strMaKH;
            string strTenKH;
            string strNhomKH;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strMaKH = dt.Rows[i]["MaKhachHang"].ToString();
                strTenKH = dt.Rows[i]["TenKhachHang"].ToString();
                strNhomKH = dt.Rows[i]["NhomKhachHang"].ToString();
                sodudaukino = long.Parse(dt.Rows[i]["SoDuCuoiKi"].ToString());
                string sTruyvan = string.Format("Delete From CongNoThu where MaKhachHang = N'{0}'" + "insert into CongNoThu(MaKhachHang,TenKhachHang,SoDuDauKiNo,PhatSinhTrongKiNo,PhatSinhTrongKiCo,SoDuCuoiKiNo,ThoiGianPhatSinh,NhomKhachHang,ThoiHanNo) values (N'{0}',N'{1}',{2},{3},{4},{5},'{6}',N'{7}','{8}')", strMaKH, strTenKH, sodudaukino, 0, 0, sodudaukino, time, strNhomKH,time);
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
        //sửa khách hàng
        public static bool SuaCongNoThu(CongNoThu_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update CongNoThu set MaKhachHang = N'{0}',TenKhachHang = N'{1}', SoDuDauKiNo= {2}, PhatSinhTrongKiNo = {3}, PhatSinhTrongKiCo = {4}, SoDuCuoiKiNo= {5}, ThoiGianPhatSinh= '{6}', GhiChu  = N'{7}', NhomKhachHang = N'{8}', ThoiHanNo = '{9}' where ThoiGianPhatSinh = '{6}'", khdto.MaKhachHang, khdto.TenKhachHang, khdto.SoDuDauKiNo, khdto.PhatSinhTrongKiNo, khdto.PhatSinhTrongKiCo, khdto.SoDuCuoiKiNo, khdto.ThoiGianPhatSinh, khdto.GhiChu,khdto.NhomKhachHang,khdto.ThoiHanNo);
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
        public static bool XoaCongNoThu(CongNoThu_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From CongNoThu where ThoiGianPhatSinh = N'{0}'", khdto.ThoiGianPhatSinh);
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
