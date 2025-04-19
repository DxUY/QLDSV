using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace QLDSV
{
    internal class DataHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static SqlDataReader myReader;

        public static string servername = "DESKTOP-BTD7L2A"; // sửa nếu dùng server khác
        public static string database = "QLDSV";

        public static string currentLogin = ""; // Lưu login hiện tại nếu cần dùng sau

        public static int Connect(string login, string password)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();

            try
            {
                connstr = "Data Source=" + servername + ";Initial Catalog=" +
                          database + ";User ID=" + login + ";Password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                currentLogin = login; // lưu lại login hiện tại nếu cần
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(string query)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            try
            {
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int ExecSqlNonQuery(string query)
        {
            SqlCommand Sqlcmd = new SqlCommand(query, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; // 10 phút 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }
    }
}