using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class GiangVien : Form
    {
        public GiangVien()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DML_Click(object sender, EventArgs e)
        {
            dml1.Visible = true;
            dsmh1.Visible = false;
            dsltc1.Visible = false;
            nd1.Visible = false;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void DSMH_Click(object sender, EventArgs e)
        {
            dml1.Visible = false;
            dsmh1.Visible = true;
            dsltc1.Visible = false;
            nd1.Visible = false;
        }

        private void DSLTC_Click(object sender, EventArgs e)
        {
            dml1.Visible = false;
            dsmh1.Visible = false;
            dsltc1.Visible = true;
            nd1.Visible = false;
        }

        private void ND_Click(object sender, EventArgs e)
        {
            dml1.Visible = false;
            dsmh1.Visible = false;
            dsltc1.Visible = false;
            nd1.Visible = true;
        }
    }
}
