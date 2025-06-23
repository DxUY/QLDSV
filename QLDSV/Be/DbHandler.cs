using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV.Be
{
    public static class DbHandler
    {
        #region Generic Query Helpers

        public static DataTable ExecuteQuery(string query, string errorMessage, bool useDefault, params SqlParameter[] parameters)
        {
            try
            {
                return DataHelper.ExecSqlDataTable(query, useDefault, parameters) ?? new DataTable();
            }
            catch (Exception ex)
            {
                ShowError(errorMessage, ex);
                return new DataTable();
            }
        }

        public static void ExecuteNonQuery(string query, bool useDefault = false, params SqlParameter[] parameters)
        {
            try
            {
                DataHelper.ExecSqlNonQuery(query, useDefault, parameters);
            }
            catch (Exception ex)
            {
                ShowError("Lỗi thực thi câu lệnh SQL", ex);
            }
        }

        public static DataTable ExecuteStoredProcedure(string spName, string errorMessage, bool useDefault, params SqlParameter[] parameters)
        {
            try
            {
                return DataHelper.ExecSqlDataTableSP(spName, useDefault, parameters) ?? new DataTable();
            }
            catch (Exception ex)
            {
                ShowError(errorMessage, ex);
                return new DataTable();
            }
        }

        public static object ExecuteScalar(string query, bool useDefault, params SqlParameter[] parameters) =>
            DataHelper.ExecSqlScalar(query, useDefault, parameters);

        public static object ExecuteScalarSP(string sp, bool useDefault, params SqlParameter[] parameters) =>
            DataHelper.ExecSqlScalarSP(sp, useDefault, parameters);

        public static void ExecuteNonQuerySP(string sp, bool useDefault, params SqlParameter[] parameters) =>
            DataHelper.ExecSqlNonQuerySP(sp, useDefault, parameters);

        #endregion

        #region Generic Data Methods

        public static DataTable GetColumnsByKey(string table, string[] columns, string keyColumn, string keyValue, bool useDefault)
        {
            string columnList = string.Join(", ", columns);
            string query = $"SELECT {columnList} FROM {table} WHERE {keyColumn} = @id";
            return ExecuteQuery(query, $"Lỗi khi lấy dữ liệu từ {table}", useDefault, new SqlParameter("@id", keyValue));
        }

        public static Dictionary<string, object> GetColumnValues(string table, string[] columns, string keyColumn, string keyValue, bool useDefault)
        {
            var dt = GetColumnsByKey(table, columns, keyColumn, keyValue, useDefault);
            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return columns.ToDictionary(col => col, col => row[col]);
        }

        public static DataTable GetDistinctValues(string column, string table, string whereClause, bool useDefault, params SqlParameter[] parameters)
        {
            string query = $"SELECT DISTINCT {column} FROM {table}";
            if (!string.IsNullOrWhiteSpace(whereClause)) query += $" WHERE {whereClause}";
            return ExecuteQuery(query, $"Lỗi khi lấy DISTINCT {column} từ {table}", useDefault, parameters);
        }

        public static DataTable RunJoinedQuery(string baseTable, string joins, string columns, string whereClause, string groupBy, bool useDefault, SqlParameter[] parameters)
        {
            var query = $"SELECT {columns} FROM {baseTable} {joins}";

            if (!string.IsNullOrWhiteSpace(whereClause))
                query += $" WHERE {whereClause}";

            if (!string.IsNullOrWhiteSpace(groupBy))
                query += $" GROUP BY {groupBy}";

            return ExecuteQuery(query, "Lỗi khi thực hiện truy vấn", useDefault, parameters ?? new SqlParameter[0]);
        }

        #endregion

        #region Account & Role

        public static bool LoginSV(string masv, string password)
        {
            const string query = @"SELECT COUNT(*) FROM SinhVien WHERE MASV = @masv AND PASSWORD = @pass AND DANGHIHOC = 0";
            return Convert.ToInt32(ExecuteScalar(query, true, new SqlParameter("@masv", masv), new SqlParameter("@pass", password))) == 1;
        }

        public static bool CheckAccountExist(string login) =>
            Convert.ToInt32(ExecuteScalarSP("sp_CheckAccountExist", false, new SqlParameter("@LoginName", login))) == 1;

        public static bool CreateLoginAndUser(Dictionary<string, string> loginData)
        {
            ExecuteNonQuerySP("sp_CreateLoginAndUser", false, new SqlParameter("@LoginName", loginData["USERNAME"]), new SqlParameter("@Password", loginData["PASSWORD"]), new SqlParameter("@RoleName", loginData["ROLE"]));

            return true;
        }

        public static DataTable GetExistenceList(bool accountsExist)
        {
            DataTable allGV = ExecuteQuery("SELECT MAGV, HO, TEN FROM GIANGVIEN", "Lỗi khi lấy danh sách giảng viên", false);
            DataTable result = allGV.Clone();

            foreach (DataRow row in allGV.Rows)
            {
                string magv = row["MAGV"].ToString().Trim();
                if (CheckAccountExist(magv) == accountsExist)
                {
                    if (!accountsExist || magv != DataHelper.currentLogin)
                    {
                        result.ImportRow(row);
                    }
                }
            }

            return result;
        }

        public static bool DeleteLoginAndUser(string login) =>
            TryExecute(() => ExecuteNonQuerySP("sp_DeleteLoginAndUser", false, new SqlParameter("@LoginName", login)));

        public static string GetUserRole(string login) =>
            SafeScalarSP("sp_GetUserRole", "Lỗi lấy vai trò", false, new SqlParameter("@Login", login));

        #endregion

        #region Student/Class/Score Operations

        public static bool UpdateStudentScore(Dictionary<string, object> scoreData)
        {
            try
            {
                const string query = @"
                                UPDATE DANGKY
                                SET 
                                    DIEM_CC = @DIEM_CC,
                                    DIEM_GK = @DIEM_GK,
                                    DIEM_CK = @DIEM_CK
                                WHERE MASV = @MASV AND MALTC = @MALTC AND HUYDANGKY = 0;";

                var parameters = scoreData.Select(kv =>
                    new SqlParameter("@" + kv.Key, kv.Value ?? DBNull.Value)
                ).ToArray();

                ExecuteNonQuery(query, false, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật điểm:\n" + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Backup/Restore

        public static bool FullBackup(bool clearOld = false)
        {
            try
            {
                const string backupDir = @"C:\Backup";

                if (!Directory.Exists(backupDir))
                    Directory.CreateDirectory(backupDir);

                if (clearOld)
                {
                    foreach (var file in Directory.GetFiles(backupDir, "*.bak"))
                        File.Delete(file);
                }

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"QLDSV_{timestamp}.bak";
                string fullPath = Path.Combine(backupDir, fileName);

                const string sql = "BACKUP DATABASE QLDSV TO DISK = @path WITH INIT";
                var param = new SqlParameter("@path", fullPath);

                DataHelper.ExecSqlNonQuery(sql, false, param);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu cơ sở dữ liệu:\n{ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable GetBackupHistory()
        {
            try
            {
                string backupDir = @"C:\Backup";
                var table = new DataTable();

                table.Columns.Add("NGAYSAOLUU", typeof(DateTime));
                table.Columns.Add("KICHTHUOC", typeof(long));
                table.Columns.Add("THIETBISAOLUU", typeof(string));
                table.Columns.Add("NGUOISAOLUU", typeof(string));

                if (Directory.Exists(backupDir))
                {
                    var files = Directory.GetFiles(backupDir, "*.bak")
                        .Select(f => new FileInfo(f))
                        .OrderByDescending(f => f.CreationTime);

                    foreach (var file in files)
                    {
                        table.Rows.Add(
                            file.CreationTime,
                            file.Length,
                            file.Name,
                            DataHelper.currentLogin
                        );
                    }
                }

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc lịch sử sao lưu: {ex.Message}", "Backup History Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public static bool LogBackup()
        {
            try
            {
                const string backupDir = @"C:\Backup\Logs";

                if (!Directory.Exists(backupDir))
                    Directory.CreateDirectory(backupDir);

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"QLDSV_LOG_{timestamp}.trn";
                string fullPath = Path.Combine(backupDir, fileName);

                const string sql = "BACKUP LOG QLDSV TO DISK = @path WITH INIT";
                var param = new SqlParameter("@path", fullPath);

                DataHelper.ExecSqlNonQuery(sql, false, param);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu LOG:\n{ex.Message}", "Log Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool FullRestore(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Tệp sao lưu không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string restoreSql = @"
                                USE master;
                                ALTER DATABASE QLDSV SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                                RESTORE DATABASE QLDSV
                                FROM DISK = @path
                                WITH 
                                    FILE = 1,
                                    REPLACE,
                                    RECOVERY;

                                ALTER DATABASE QLDSV SET MULTI_USER;";

                var param = new SqlParameter("@path", filePath);

                int result = DataHelper.ExecSqlNonQuery(restoreSql, false, param);
                return result >= 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khôi phục cơ sở dữ liệu:\n{ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool RestoreLogFromFolder(DateTime stopAt)
        {
            try
            {
                const string logDir = @"C:\Backup\Logs";

                if (!Directory.Exists(logDir))
                {
                    MessageBox.Show("Thư mục LOG không tồn tại.", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var logPaths = Directory.GetFiles(logDir, "*.trn")
                    .Select(p => new FileInfo(p))
                    .OrderBy(f => f.CreationTime)
                    .Select(f => f.FullName)
                    .ToList();

                if (logPaths.Count == 0)
                {
                    MessageBox.Show("Không có tệp LOG nào để khôi phục.", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return RestoreLog(logPaths, stopAt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chuẩn bị khôi phục LOG:\n{ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool RestoreLog(List<string> logPaths, DateTime stopAt)
        {
            try
            {
                if (logPaths == null || logPaths.Count == 0)
                {
                    MessageBox.Show("Không có tệp LOG để khôi phục.", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string initSql = @"
                            USE master;
                            ALTER DATABASE QLDSV SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";

                ExecuteNonQuery(initSql);

                for (int i = 0; i < logPaths.Count; i++)
                {
                    string logPath = logPaths[i];

                    if (!File.Exists(logPath))
                    {
                        MessageBox.Show($"Tệp LOG không tồn tại: {logPath}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    var param = new SqlParameter("@path", logPath);

                    if (i < logPaths.Count - 1)
                    {
                        string sql = "RESTORE LOG QLDSV FROM DISK = @path WITH NORECOVERY;";
                        DataHelper.ExecSqlNonQuery(sql, false, param);
                    }
                    else
                    {
                        string sql = @"
                                RESTORE LOG QLDSV 
                                FROM DISK = @path 
                                WITH STOPAT = @stopAt, RECOVERY;";

                        var stopAtParam = new SqlParameter("@stopAt", stopAt);
                        DataHelper.ExecSqlNonQuery(sql, false, param, stopAtParam);
                        break;
                    }
                }

                string finalSql = "ALTER DATABASE QLDSV SET MULTI_USER;";
                ExecuteNonQuery(finalSql, true);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khôi phục LOG:\n{ex.Message}", "Restore Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Utility Wrappers

        private static void ShowError(string msg, Exception ex)
        {
            MessageBox.Show($"{msg}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static bool TryExecute(Action action)
        {
            try { action(); return true; }
            catch (Exception ex) { ShowError("Lỗi thực thi hành động", ex); return false; }
        }

        private static string SafeScalarSP(string sp, string errorMessage, bool useDefault, params SqlParameter[] parameters)
        {
            try
            {
                return ExecuteScalarSP(sp, useDefault, parameters)?.ToString();
            }
            catch (Exception ex)
            {
                ShowError(errorMessage, ex);
                return null;
            }
        }

        #endregion
    }
}