using QLDSV.Be;
using QLDSV.Fe;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class SinhVien : Form
    {
        private readonly string _masv;
        private readonly string _name;
        private string _tenLop;
        private string _tenKhoa;

        public SinhVien(string masv, string name) 
        {
            InitializeComponent();
            _masv = masv;
            _name = name;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
            ShowForm(typeof(DKLTC), new object[] { _masv, _name, _tenLop, _tenKhoa });
            username.Text = _name;
            role.Text = "SV";
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?",
                                         "Confirmation Message",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            var loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void ShowForm(Type userControlType, object[] constructorArgs = null)
        {
            this.SuspendLayout();
            content.Controls.Clear();

            UserControl newPanel;

            newPanel = (UserControl)Activator.CreateInstance(userControlType, constructorArgs ?? Array.Empty<object>());

            newPanel.Location = content.Location;
            content.Controls.Add(newPanel);

            this.ResumeLayout();
        }

        private void DKLTC_Click(object sender, EventArgs e)
            => ShowForm(typeof(DKLTC), new object[] { _masv, _name, _tenLop, _tenKhoa });

        private void XD_Click(object sender, EventArgs e)
            => ShowForm(typeof(XD), new object[] { _masv, _name, _tenLop, _tenKhoa });


        private void LoadStudentInfo()
        {
            var studentInfo = DbHandler.RunJoinedQuery("SinhVien SV", @"JOIN Lop L ON SV.MALOP = L.MALOP JOIN Khoa K ON L.MAKHOA = K.MAKHOA",
                                                    @"L.TENLOP, K.TENKHOA", @"SV.MASV = @MASV", "", true, new[] { new SqlParameter("@MASV", _masv) }
            );

            if (studentInfo.Rows.Count > 0)
            {
                _tenLop = studentInfo.Rows[0]["TENLOP"].ToString();
                _tenKhoa = studentInfo.Rows[0]["TENKHOA"].ToString();
            }
        }
    }
}
