using QLDSV.Be;
using QLDSV.Be.Utils;
using QLDSV.Fe.Reports.PD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace QLDSV.Fe.Search
{
    public partial class sPD : Form
    {
        private readonly string _khoa;

        public sPD(string khoa)
        {
            InitializeComponent();
            _khoa = khoa;
        }

        private void search_Click(object sender, EventArgs e)
        {
            var inputs = CollectInput();

            if (!Validation.IsInputComplete(inputs)) return;

            string masv = inputs["masv"];

            DataTable dt = DbHandler.RunJoinedQuery("SINHVIEN sv", "JOIN LOP l ON sv.MALOP = l.MALOP", "sv.HO + ' ' + sv.TEN AS HOTEN, l.TENLOP",
                                                    "sv.MASV = @masv", "", false, new[] { new SqlParameter("@masv", masv) });

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoten = dt.Rows[0]["HOTEN"].ToString();
            string tenlop = dt.Rows[0]["TENLOP"].ToString();

            var reportForm = new PDReport(masv, hoten, tenlop, _khoa);
            reportForm.ShowDialog();
        }

        private Dictionary<string, string> CollectInput()
        {
            return new Dictionary<string, string>
            {
                { "masv", svInput.Text.Trim() },
            };
        }
    }
}
