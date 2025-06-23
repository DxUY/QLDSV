using QLDSV.Be;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
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
            var loginData = new Dictionary<string, string>
            {
                { "USERNAME", login_username.Text },
                { "PASSWORD", login_password.Text }
            };

            if (!Validation.IsInputComplete(loginData)) return;

            string username = loginData["USERNAME"];
            string password = loginData["PASSWORD"];

            if (type == 0) // SinhVien login
            {
                try
                {
                    bool loginSuccess = DbHandler.LoginSV(username, password);

                    if (loginSuccess)
                    {
                        var info = DbHandler.GetColumnValues("SinhVien", new[] { "HO", "TEN" }, "MASV", username, true);
                        string fullName = $"{info["HO"]} {info["TEN"]}";

                        this.Hide();
                        SinhVien formSV = new SinhVien(username, fullName);
                        formSV.FormClosed += (s, args) => this.Close();
                        formSV.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai mã sinh viên hoặc mật khẩu.", "Đăng nhập thất bại",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đăng nhập sinh viên: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (DataHelper.Connect(username, password) == 1)
                {
                    try
                    {
                        var info = DbHandler.GetColumnValues("GIANGVIEN", new[] { "HO", "TEN", "MAKHOA" }, "MAGV", username, true);
                        string fullName = $"{info["HO"]} {info["TEN"]}";
                        string khoa = info["MAKHOA"].ToString();
                        string role = DbHandler.GetUserRole(username);

                        this.Hide();
                        GiangVien formGV = new GiangVien(username, fullName, role, khoa);
                        formGV.FormClosed += (s, args) => this.Close();
                        formGV.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy thông tin giảng viên: {ex.Message}", "Lỗi đăng nhập",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản SQL Server hoặc mật khẩu.", "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gv_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
            label2.Text = "Login";
        }

        private void sv_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
            label2.Text = "MaSV";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}