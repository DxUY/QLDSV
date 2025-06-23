using QLDSV.Be;
using QLDSV.Be.Utils;
using QLDSV.Fe.Reports.BDTK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace QLDSV.Fe.Search
{
    public partial class sBDTK : Form
    {
        private readonly string _khoa;

        public sBDTK(string khoa)
        {
            InitializeComponent();
            _khoa = khoa;
        }

        private void search_Click(object sender, EventArgs e)
        {
            var inputs = CollectInput();

            if (!Validation.IsInputComplete(inputs)) return;

            string maLop = inputs["maLop"];

            DataTable dt = DataHelper.ExecSqlDataTable("SELECT TENLOP, KHOAHOC FROM LOP WHERE MALOP = @maLop", false, new[] { new SqlParameter("@maLop", maLop) });

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenLop = dt.Rows[0]["TENLOP"].ToString();
            string khoaHoc = dt.Rows[0]["KHOAHOC"].ToString();

            var reportForm = new BDTKReport(maLop, tenLop, _khoa, khoaHoc);
            reportForm.ShowDialog();
        }

        private Dictionary<string, string> CollectInput()
        {
            return new Dictionary<string, string>
            {
                { "maLop", lopInput.Text.Trim() },
            };
        }
    }
}
