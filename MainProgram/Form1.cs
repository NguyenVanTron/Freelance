using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace MainProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ketNoiDuLieu_Click(object sender, EventArgs e)
        {
            String NameData = chonDuLieu.Text.ToString();
            if (chonDuLieu.Text == "")
            {
                MessageBox.Show("Bạn phải chọn cơ sỏ dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] AName = new string[] { NameData };
            String line;
            bool flagsCheckName = false;
            if (System.IO.File.Exists("DataBase.txt") == false)
            {
                MessageBox.Show("Cơ sở dữ liệu chưa có bạn cần phải chọn lại hoặc tạo mới. !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    if (NameData == line)
                    {
                        flagsCheckName = true;
                    }
                }
            }
            if (flagsCheckName == false)
            {
                MessageBox.Show("Cơ sở dữ liệu chưa có bạn cần phải chọn lại hoặc tạo mới. !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (StreamWriter sw = new StreamWriter("ChoseName.txt"))
            {
                //sw.WriteLine(DateTime.Now.ToString() + Environment.NewLine);
                foreach (string s in AName)
                {
                    sw.WriteLine(s);
                }
            }

           this.Close();
           Program.th.Start();
        }

        private void taoDuLieu_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            String NameData = chonDuLieu.Text.ToString();

            //Tạo cơ sở dữ liệu
            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE " + NameData + " ON PRIMARY " +
                "(NAME = " + NameData + "_Data, " +
                "FILENAME = '" + path + "\\" + NameData + ".mdf', " +
                "SIZE = 4MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = " + NameData + "_Log, " +
                "FILENAME = '" + path + "\\" + NameData + ".ldf', " +
                "SIZE = 1MB, " +
                "MAXSIZE = 5MB, " +
                "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Cơ sở dữ liệu được tạo thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Cơ sở dữ liệu đã có hoặc lỗi quyền admin nhấn ok để tiếp tục", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            // Tạp bảng dữ liệu sản phẩm
            SqlConnection myConn1 = new SqlConnection("Server =.; AttachDbFilename = " + path + "\\" + NameData + ".mdf; Database = " + NameData + ";Trusted_Connection = Yes");
            string s_creattb = @"CREATE TABLE HangHoa(	STT bigint IDENTITY(1,1),
                                                        MaHang nvarchar(50) ,	
                                                        TenHang nvarchar(50), 
                                                        DungTich nvarchar(20),
                                                        HoatChat nvarchar(50),
                                                        Loai     nvarchar(50),
                                                        DoiTuong nvarchar(50) ,	
                                                        MaNCC nvarchar(50)  NULL, 
                                                        DonViTinh nvarchar(30),	
                                                        QuiCach bigint,	
                                                        CachDung nvarchar(100) NULL, 
                                                        SoLuong bigint,
                                                        GiaNhap bigint ,
                                                        GiaBan bigint,
                                                        GiaCu bigint,
                                                        NgayNhap datetime,
                                                        Primary key(STT))"
                                                        + @"CREATE TABLE KhachHang(	STT bigint IDENTITY(1,1),
                                                        MaKhachHang nvarchar(50) ,	
                                                        TenKhachHang nvarchar(50), NhomKhachHang nvarchar(50),
                                                        SDT char(12),
                                                        DiaChi nvarchar(50),
                                                        Email char(20),
                                                        GhiChu nvarchar(200),
                                                        DoanhSo bigint ,Primary key(STT))"
                                                        + @"CREATE TABLE NhaCungCap(	STT bigint IDENTITY(1,1),
                                                        MaNCC nvarchar(50) ,	
                                                        TenNCC nvarchar(50), NhomNCC nvarchar(50),
                                                        SDT char(12),
                                                        NguoiGiaoDich nvarchar(50),
                                                        Email char(20),
                                                        GhiChu nvarchar(200),Primary key(STT))"
                                                        + @"CREATE TABLE PhieuXuat(STT bigint IDENTITY(1,1),
                                                         SoPX nvarchar(50),
                                                         NgayXuat datetime,
                                                         MaHangHoa nvarchar(50),
                                                         TenHangHoa nvarchar(50),
                                                         MaKhachHang nvarchar(50), TenKhachHang nvarchar(50),
                                                         DiaChi nvarchar(50),
                                                         DonViTinh nvarchar(30),
                                                         GiaBan bigint,
                                                         SoLuong bigint , ConNo bigint,
                                                         ThanhTien bigint, ChiecKhau int, GTGT int,TongTien bigint,
                                                         GhiChu nvarchar(200), 
                                                         Primary key(STT))"
                                                        + @"CREATE TABLE PhieuNhap(STT bigint IDENTITY(1,1),
                                                         SoPN nvarchar(50),
                                                         NgayNhap datetime,
                                                         MaNCC nvarchar(50),
                                                         MaHangHoa nvarchar(50),
                                                         TenHangHoa nvarchar(50),
                                                         DonViTinh nvarchar(30),
                                                         SoLuong bigint ,
                                                         GiaNhap bigint, ChiecKhau int, GTGT int,
                                                         ThanhTien bigint, TongTien bigint,
                                                         GhiChu nvarchar(200),Primary key(STT))"
                                                         + @"CREATE TABLE CongNoThu(STT bigint IDENTITY(1, 1),
                                                        MaKhachHang nvarchar(50),
                                                        TenKhachHang nvarchar(50), NhomKhachHang nvarchar(50),
                                                        SoDuDauKiNo bigint,
                                                        PhatSinhTrongKiNo bigint,
                                                        PhatSinhTrongKiCo bigint,
                                                        SoDuCuoiKiNo bigint,
                                                        ThoiGianPhatSinh Datetime,
                                                        ThoiHanNo Datetime,
                                                        GhiChu nvarchar(200), Primary key(STT))"
                                                         + @"CREATE TABLE CongNoTra(	STT bigint IDENTITY(1,1),
                                                        MaNCC nvarchar(50) ,	
                                                        TenNCC nvarchar(50), NhomNCC nvarchar(50),
                                                        SoDuDauKiNo bigint ,
                                                        PhatSinhTrongKiNo bigint ,
                                                        PhatSinhTrongKiCo bigint ,
                                                        SoDuCuoiKiNo bigint ,
                                                        ThoiGianPhatSinh Datetime,
                                                        ThoiHanNo Datetime ,
                                                        GhiChu nvarchar(200), Primary key(STT))"
                                                        + @"CREATE TABLE BaoCaoTongHop(	STT bigint IDENTITY(1,1),
                                                        TenHangHoa nvarchar(50) ,	
                                                        SLTonDK bigint, 
                                                        DGTonDK bigint,
                                                        TTTonDK bigint,
                                                        SLNhapTK bigint,
                                                        DGNhapTK bigint,
                                                        TTNhapTK bigint,
                                                        SLXuatTK bigint,
                                                        DGXuatTK bigint,
                                                        TTXuatTK bigint,
                                                        SLTonCK bigint, 
                                                        DGTonCK bigint,
                                                        TTTonCK bigint, Primary key(STT))"
                                                        + @"CREATE TABLE PhieuTraHang(STT bigint IDENTITY(1,1),
                                                         SoPT nvarchar(50),
                                                         NgayTra datetime,
                                                         MaHangHoa nvarchar(50),
                                                         TenHangHoa nvarchar(50),
                                                         MaKhachHang nvarchar(50), TenKhachHang nvarchar(50),
                                                         DiaChi nvarchar(50),
                                                         DonViTinh nvarchar(30),
                                                         GiaBan bigint,
                                                         SoLuong bigint , ConNo bigint,
                                                         ThanhTien bigint, ChiecKhau int, GTGT int,TongTien bigint,
                                                         GhiChu nvarchar(200), 
                                                         Primary key(STT))";
            SqlCommand sc_commancreate = new SqlCommand(s_creattb, myConn1);
            try
            {
                myConn1.Open();
                sc_commancreate.ExecuteNonQuery();
                MessageBox.Show("Bảng được tạo thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string[] AName = new string[] { NameData };
                using (StreamWriter sw = new StreamWriter("DataBase.txt",true))
                {
                    foreach (string s in AName)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Bảng đã có nhấn ok để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn1.State == ConnectionState.Open)
                {
                    myConn1.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(ketNoiDuLieu, "Kết nối dữ liệu");
            tooltip.SetToolTip(taoDuLieu, "Tạo mới dữ liệu");
            tooltip.SetToolTip(chonDuLieu, "Chọn dữ liệu hoặc nhập tên tạo mới");
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Thêm item combobox
                    chonDuLieu.Items.Add(line);
                    if (line != null)
                        chonDuLieu.Text = line;
                }
                
            }
        }
        
    }
}
