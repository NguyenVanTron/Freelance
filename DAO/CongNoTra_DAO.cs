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
    public class CongNoTra_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        public static long NoTra()
        {
            string sTruyvan = "select Sum(SoDuCuoiKiNo) AS NoTra from CongNoTra";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return 0;
            }
            List<CongNoTra_DTO> kh = new List<CongNoTra_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                long notra = long.Parse(dt.Rows[i]["NoTra"].ToString());
                if (notra != 0)
                {
                    return notra;
                }
            }
            return 0;

        }
        public static List<CongNoTra_DTO> TiemkiemCongNoTra(string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from CongNoTra where ThoiGianPhatSinh Between '" + strFrom + "' And '" + strTo + "'";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoTra_DTO> kh = new List<CongNoTra_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoTra_DTO khachhang = new CongNoTra_DTO();
                //int.Parse();
                khachhang.STT = int.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                khachhang.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                khachhang.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
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
        public static List<CongNoTra_DTO> TiemkiemCongNoTra(string timkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from CongNoTra where TenNCC like N'%" + timkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoTra_DTO> kh = new List<CongNoTra_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoTra_DTO khachhang = new CongNoTra_DTO();
                //int.Parse();
                khachhang.STT = int.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                khachhang.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                khachhang.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
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
        public static List<CongNoTra_DTO> LoadCongNhaCCDV(bool flag,string strFrom,string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan;
            if (flag)
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaNCC,TenNCC,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoTra where (NhomNCC like N'%Nhà cung cấp dịch vụ%') And (ThoiGianPhatSinh Between '" + strFrom + "' And '" + strTo + "') Group by MaNCC,TenNCC";
            else
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaNCC,TenNCC,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoTra where NhomNCC like N'%Nhà cung cấp dịch vụ%' Group by MaNCC,TenNCC";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoTra_DTO> kh = new List<CongNoTra_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoTra_DTO khachhang = new CongNoTra_DTO();
                //int.Parse();
                khachhang.STT = int.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                khachhang.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["DuDau"].ToString());
                //khachhang.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
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
        public static List<CongNoTra_DTO> LoadCongDTCC(bool flag, string strFrom, string strTo)
        {
            // Khai báo truy vấn SQL
            string sTruyvan;
            if (flag)
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaNCC,TenNCC,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoTra where (NhomNCC like N'%Đối tác cung cấp%') And (ThoiGianPhatSinh Between '" + strFrom + "' And '" + strTo + "') Group by MaNCC,TenNCC";
            else
                sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,MaNCC,TenNCC,Sum(SoDuDauKiNo)As DuDau,Sum(PhatSinhTrongKiNo) As PSNo,Sum(PhatSinhTrongKiCo) As PSCo,Sum(SoDuCuoiKiNo) As DuCuoi from CongNoTra where NhomNCC like N'%Đối tác cung cấp%' Group by MaNCC,TenNCC";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoTra_DTO> kh = new List<CongNoTra_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoTra_DTO khachhang = new CongNoTra_DTO();
                khachhang.STT = int.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                khachhang.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["DuDau"].ToString());
                //khachhang.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
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
        public static List<CongNoTra_DTO> LoadCongNoTra()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from CongNoTra";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<CongNoTra_DTO> kh = new List<CongNoTra_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongNoTra_DTO khachhang = new CongNoTra_DTO();
                //int.Parse();
                khachhang.STT = int.Parse(dt.Rows[i]["IDD"].ToString());
                khachhang.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                khachhang.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                khachhang.SoDuDauKiNo = long.Parse(dt.Rows[i]["SoDuDauKiNo"].ToString());
                khachhang.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
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
        // Thêm khách hàng

        public static bool ThemCongNoTra(CongNoTra_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into CongNoTra(MaNCC,TenNCC,SoDuDauKiNo,PhatSinhTrongKiNo,PhatSinhTrongKiCo,SoDuCuoiKiNo,ThoiGianPhatSinh,GhiChu,NhomNCC,ThoiHanNo) values (N'{0}',N'{1}',{2},{3},{4},{5},'{6}',N'{7}',N'{8}','{9}')", khdto.MaNCC, khdto.TenNCC, khdto.SoDuDauKiNo, khdto.PhatSinhTrongKiNo, khdto.PhatSinhTrongKiCo, khdto.SoDuCuoiKiNo, khdto.ThoiGianPhatSinh, khdto.GhiChu,khdto.NhomNCC,khdto.ThoiHanNo);
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
            string strTimKiem = string.Format("select MaNCC,TenNCC,NhomNCC,Sum(SoDuCuoiKiNo) As SoDuCuoiKi from CongNoTra Group by MaNCC,TenNCC,NhomNCC");
            con = DataProvider.ketnoi();
            long sodudaukino = 0;
            //truy vấn
            DataTable dt = DataProvider.laydatatable(strTimKiem, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
            }
            string strMaNCC;
            string strTenNCC;
            string strNhomNCC;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strMaNCC = dt.Rows[i]["MaNCC"].ToString();
                strTenNCC = dt.Rows[i]["TenNCC"].ToString();
                strNhomNCC = dt.Rows[i]["NhomNCC"].ToString();
                sodudaukino = long.Parse(dt.Rows[i]["SoDuCuoiKi"].ToString());
                string sTruyvan = string.Format("Delete From CongNoTra where MaNCC = N'{0}'" + "insert into CongNoTra(ManCC,TenNCC,SoDuDauKiNo,PhatSinhTrongKiNo,PhatSinhTrongKiCo,SoDuCuoiKiNo,ThoiGianPhatSinh,NhomNCC,ThoiHanNo) values (N'{0}',N'{1}',{2},{3},{4},{5},'{6}',N'{7}','{8}')", strMaNCC, strTenNCC, sodudaukino, 0, 0, sodudaukino, time, strNhomNCC,time);
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
        public static bool SuaCongNoTra(CongNoTra_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update CongNoTra set MaNCC = N'{0}',TenNCC = N'{1}', SoDuDauKiNo= {2}, PhatSinhTrongKiNo = {3}, PhatSinhCuoiKi = {4}, SoDuCuoiKiNo= {5}, ThoiGianPhatSinh= '{6}', GhiChu  = N'{7}',NhomNCC = N'{8}, ThoiHanNo = '{9}' where ThoiGianPhatSinh = '{6}'", khdto.MaNCC, khdto.TenNCC, khdto.SoDuDauKiNo, khdto.PhatSinhTrongKiNo, khdto.PhatSinhTrongKiCo, khdto.SoDuCuoiKiNo, khdto.ThoiGianPhatSinh, khdto.GhiChu,khdto.NhomNCC,khdto.ThoiHanNo);
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
        public static bool XoaCongNoTra(CongNoTra_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From CongNoTra where ThoiGianPhatSinh = '{0}'", khdto.ThoiGianPhatSinh);
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
