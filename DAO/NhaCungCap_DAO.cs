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
    public class NhaCungCap_DAO
    {
        //Khởi tạo biến kết nối
        static SqlConnection con;
        //Load NhaCungCap
        public static List<NhaCungCap_DTO> LoadNhaCungCap()
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from NhaCungCap";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<NhaCungCap_DTO> kh = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO NhaCungCap = new NhaCungCap_DTO();
                NhaCungCap.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                NhaCungCap.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                NhaCungCap.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                NhaCungCap.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
                NhaCungCap.SDT = dt.Rows[i]["SDT"].ToString();
                NhaCungCap.NguoiGiaoDich = dt.Rows[i]["NguoiGiaoDich"].ToString();
                NhaCungCap.Email = dt.Rows[i]["Email"].ToString();
                NhaCungCap.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(NhaCungCap);
            }
            DataProvider.dongketnoi(con);
            return kh;

        }
        // Thêm NhaCungCap

        public static bool ThemNhaCungCap(NhaCungCap_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("insert into NhaCungCap(MaNCC,TenNCC,SDT,NguoiGiaoDich,Email,GhiChu,NhomNCC) values (N'{0}',N'{1}','{2}',N'{3}','{4}',N'{5}', N'{6}')", khdto.MaNCC, khdto.TenNCC, khdto.SDT, khdto.NguoiGiaoDich, khdto.Email, khdto.GhiChu,khdto.NhomNCC);
            //values(@MaNhaCungCap,@TenNhaCungCap,@SDT,@DiaChi,@Email,@GhiChu)";
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
        //sửa NhaCungCap
        public static bool suaNhaCungCap(NhaCungCap_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("update NhaCungCap set MaNCC = N'{0}',TenNCC = N'{1}',SDT= '{2}',NguoiGiaoDich  = N'{3}',Email = N'{4}',GhiChu  = N'{5}', NhomNCC = N'{6}' where MaNCC = '{0}'", khdto.MaNCC, khdto.TenNCC, khdto.SDT, khdto.NguoiGiaoDich, khdto.Email, khdto.GhiChu,khdto.NhomNCC);
            //values(@MaNhaCungCap,@TenNhaCungCap,@SDT,@DiaChi,@Email,@GhiChu)";
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
        //xoa NhaCungCap
        public static bool xoaNhaCungCap(NhaCungCap_DTO khdto)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = string.Format("Delete From NhaCungCap where MaNCC = '{0}'", khdto.MaNCC);
            //values(@MaNhaCungCap,@TenNhaCungCap,@SDT,@DiaChi,@Email,@GhiChu)";
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
        public static List<NhaCungCap_DTO> TimkiemNhaCungCap(string tiemkiem)
        {
            // Khai báo truy vấn SQL
            string sTruyvan = "select ROW_NUMBER() over (order by (select 1)) as IDD,* from NhaCungCap where TenNCC like N'%" + tiemkiem + "%' ";
            //mở kết nối
            con = DataProvider.ketnoi();
            //truy vấn
            DataTable dt = DataProvider.laydatatable(sTruyvan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.dongketnoi(con);
                return null;
            }
            List<NhaCungCap_DTO> kh = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO NhaCungCap = new NhaCungCap_DTO();
                NhaCungCap.STT = long.Parse(dt.Rows[i]["IDD"].ToString());
                NhaCungCap.MaNCC = dt.Rows[i]["MaNCC"].ToString();
                NhaCungCap.TenNCC = dt.Rows[i]["TenNCC"].ToString();
                NhaCungCap.NhomNCC = dt.Rows[i]["NhomNCC"].ToString();
                NhaCungCap.SDT = dt.Rows[i]["SDT"].ToString();
                NhaCungCap.NguoiGiaoDich = dt.Rows[i]["NguoiGiaoDich"].ToString();
                NhaCungCap.Email = dt.Rows[i]["Email"].ToString();
                NhaCungCap.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                kh.Add(NhaCungCap);
            }
            //đóng kết nối
            DataProvider.dongketnoi(con);
            return kh;
        }
    }
}
