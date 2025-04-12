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
        private int type;

        public Login()
        {
            InitializeComponent();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();
            
            if (DataHelper.Connect() == 1)
            {
                string table = (type == 0) ? "SinhVien" : "GIANGVIEN";
                string idField = (type == 0) ? "MASV" : "MAGV";
                string passField = "PASSWORD"; // ⚠️ Adjust if needed
                string nameField = "TEN"; // common field name for both tables assumed

                string query = $"SELECT * FROM {table} WHERE {idField} = @username AND {passField} = @password";

                using (SqlCommand cmd = new SqlCommand(query, DataHelper.conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null && reader.HasRows)
                            {
                                reader.Read();
                                string name = reader[nameField].ToString();

                                MessageBox.Show($"Welcome, {name}!", "Login Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                reader.Close();
                                this.Hide();

                                if (type == 0)
                                    new SinhVien().Show();
                                else
                                    new GiangVien().Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.",
                                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during login:\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;
        }

        private void sv_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
        }
    }
}
