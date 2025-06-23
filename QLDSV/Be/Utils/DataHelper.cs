using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.Be.Utils
{
    internal class DataHelper
    {
        private static string _connectionString;
        public static string servername = "LAPTOP-5Q9C6NPT";
        public static string database = "QLDSV";
        public static string currentLogin = "";

        public static int Connect(string login, string password)
        {
            try
            {
                string connectionString = $"Data Source={servername};Initial Catalog={database};User ID={login};Password={password}";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                }

                _connectionString = connectionString;
                currentLogin = login;
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static SqlConnection CreateConnection(bool useDefault = false)
        {
            if (useDefault)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                return new SqlConnection(connectionString);
            }

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string not initialized. Call Connect() first.");

            return new SqlConnection(_connectionString);
        }

        #region Stored Procedure Functions

        public static int ExecSqlNonQuerySP(string spName, bool useDefault = false, params SqlParameter[] parameters)
        {
            using (var conn = CreateConnection(useDefault))
            using (var cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
        }

        public static DataTable ExecSqlDataTableSP(string spName, bool useDefault = false, params SqlParameter[] parameters)
        {
            using (var conn = CreateConnection(useDefault))
            using (var cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing stored procedure: {ex.Message}", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }
            }
        }

        public static object ExecSqlScalarSP(string spName, bool useDefault = false, params SqlParameter[] parameters)
        {
            using (var conn = CreateConnection(useDefault))
            using (var cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        #endregion

        #region Query Functions

        public static int ExecSqlNonQuery(string query, bool useDefault = false, params SqlParameter[] parameters)
        {
            using (var conn = CreateConnection(useDefault))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 600;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error executing SQL: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        public static DataTable ExecSqlDataTable(string query, bool useDefault = false, params SqlParameter[] parameters)
        {
            using (var conn = CreateConnection(useDefault))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.Text;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static object ExecSqlScalar(string query, bool useDefault = false, params SqlParameter[] parameters)
        {
            using (var conn = CreateConnection(useDefault))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.Text;

                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        #endregion
    }
}
