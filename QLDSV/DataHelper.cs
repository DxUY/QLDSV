using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV
{
    internal class DataHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static String servername = "localhost";
        public static String database = "QLDSV_HTC";
        public static String mlogin;
        public static String password;

        public static int Connect(string user, string pass)
        {
            mlogin = user;
            password = pass;

            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            try
            {
                string connstr = $"Data Source={servername};Initial Catalog={database};User ID={mlogin};Password={password}";
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối: " + e.Message);
                return 0;
            }
        }
    }
}
