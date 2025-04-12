using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class Login : Form
    {
        private int type; // 0 = SV, 1 = GV

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            if (DataHelper.Connect(username, password) == 1)
            {
                string table = (type == 0) ? "SinhVien" : "GIANGVIEN";
                string idField = (type == 0) ? "MASV" : "MAGV";
                string query = $"SELECT * FROM {table} WHERE {idField} = @username";

                using (SqlCommand cmd = new SqlCommand(query, DataHelper.conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            reader.Read();
                            reader.Close();
                            this.Hide();

                            SqlCommand roleCmd = new SqlCommand("SELECT IS_MEMBER('PGV') AS IS_PGV, IS_MEMBER('KHOA') AS IS_KHOA, IS_MEMBER('SV') AS IS_SV", DataHelper.conn);
                            SqlDataReader roleReader = roleCmd.ExecuteReader();

                            if (roleReader.Read())
                            {
                                bool isPGV = (int)roleReader["IS_PGV"] == 1;
                                bool isKhoa = (int)roleReader["IS_KHOA"] == 1;
                                bool isSV = (int)roleReader["IS_SV"] == 1;
                                roleReader.Close();

                                if (isPGV) new FormMainPGV().Show();
                                else if (isKhoa) new FormMainKhoa().Show();
                                else if (isSV) new FormMainSV(username).Show();
                                else MessageBox.Show("Tài khoản không thuộc nhóm nào.");
                            }
                        }
                        else MessageBox.Show("Sai thông tin đăng nhập.");
                    }
                }
            }
        }
    }
}
