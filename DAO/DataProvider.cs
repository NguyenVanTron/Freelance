using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
namespace DAO
{
    class DataProvider
    {
        public static SqlConnection ketnoi()
        {
            String NameData = "";
            using (StreamReader sr = new StreamReader("ChoseName.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Thêm item combobox
                    NameData = line.ToString();
                }
            }
            string path = Directory.GetCurrentDirectory();

            string s_connect = @"Server =.; AttachDbFilename = " + path + "\\" + NameData + ".mdf; Database = " + NameData + ";Trusted_Connection = Yes";
            // string chuoiketnoi = @"Data Source=(local);Initial Catalog=tttt5;Integrated Security=True";
            SqlConnection con = new SqlConnection(s_connect);
            con.Open();
            return con;
        }
        public static void dongketnoi(SqlConnection con)
        {
            con.Close();
        }

        //Lấy datatable
        public static DataTable laydatatable(string struyvan, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(struyvan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //
        public static void thucthitruyvannonquery(string struyvan, SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(struyvan, con);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
