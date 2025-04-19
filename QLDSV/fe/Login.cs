using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (login_username.Text == "" || (type == 0 && login_password.Text == ""))
            {
                MessageBox.Show("Please fill all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            if (DataHelper.Connect(login_username.Text.Trim(), login_password.Text.Trim()) == 1)
            {
                string table = (type == 0) ? "SinhVien" : "GIANGVIEN";
                string idField = (type == 0) ? "MASV" : "MAGV";

                string query = $"SELECT * FROM {table} WHERE {idField} = @username";

                using (SqlCommand cmd = new SqlCommand(query, DataHelper.conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                reader.Close();
                                this.Hide();

                                if (type == 0)
                                {
                                    SinhVien formSV = new SinhVien();
                                    formSV.FormClosed += (s, args) => this.Close();
                                    formSV.Show();
                                }
                                else
                                {
                                    GiangVien formGV = new GiangVien();
                                    formGV.FormClosed += (s, args) => this.Close();
                                    formGV.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or role.", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to DB. Check server or credentials.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
            label3.Visible = true;
            login_password.Visible = true;
            showPass.Visible = true;
        }

        private void sv_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
            label3.Visible = true;
            login_password.Visible = true;
            showPass.Visible = true;
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = showPass.Checked ? '\0' : '*';
        }

    }
}
