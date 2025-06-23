using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.Be.Utils
{
    internal static class ComboBoxLoader
    {
        private static void LoadComboBox(ComboBox comboBox, DataTable data, string displayMember, string valueMember)
        {
            if (data == null || data.Rows.Count == 0)
            {
                ClearComboBox(comboBox, "Không có dữ liệu");
                return;
            }

            comboBox.DataSource = null; 
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DataSource = data;
            comboBox.SelectedIndex = 0;
        }

        public static void ClearComboBox(ComboBox comboBox, string message = "Không có dữ liệu")
        {
            comboBox.DataSource = null;      
            comboBox.Items.Clear();          
            comboBox.Text = message;         
        }

        public static void LoadKhoaComboBox(ComboBox cbo) =>
            LoadComboBox(cbo, DbHandler.ExecuteQuery("SELECT * FROM KHOA", "Lỗi khi lấy danh sách khoa", false), "TENKHOA", "MAKHOA");

        public static void LoadMonComboBox(ComboBox cbo) =>
            LoadComboBox(cbo, DbHandler.ExecuteQuery("SELECT * FROM MONHOC", "Lỗi khi lấy danh sách khoa", false), "TENMH", "MAMH");

        public static void LoadGVTheoKhoaComboBox(ComboBox cbo, string maKhoa)
        {
            string query = @"SELECT MAGV, HO + ' ' + TEN AS HOTEN FROM GIANGVIEN WHERE MAKHOA = @MaKhoa";
            var data = DbHandler.ExecuteQuery(query, "Lỗi khi lấy danh sách giảng viên theo khoa", false,
                new SqlParameter("@MaKhoa", maKhoa));
            LoadComboBox(cbo, data, "HOTEN", "MAGV");
        }

        public static void LoadNienKhoa(ComboBox cbo) =>
            LoadComboBox(cbo, DbHandler.GetDistinctValues("NIENKHOA", "LOPTINCHI", "", true), "NIENKHOA", "NIENKHOA");

        public static void LoadHocKi(ComboBox cbo) =>
            LoadComboBox(cbo, DbHandler.GetDistinctValues("HOCKY", "LOPTINCHI", "", true), "HOCKY", "HOCKY");

        public static void LoadNienKhoaTheoKhoa(ComboBox cbo, DataTable data) =>
            LoadComboBox(cbo, data, "NIENKHOA", "NIENKHOA");

        public static void LoadHockyTheoNienkhoa(ComboBox cbo, DataTable data) =>
            LoadComboBox(cbo, data, "HOCKY", "HOCKY");

        public static void LoadMonTheoHocky(ComboBox cbo, DataTable data) =>
            LoadComboBox(cbo, data, "MAMH", "MAMH");

        public static void LoadNhomTheoMon(ComboBox cbo, DataTable data) =>
            LoadComboBox(cbo, data, "NHOM", "NHOM");
    }
}
