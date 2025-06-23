using QLDSV.Be.Utils;
using QLDSV.Fe.Reports.SVDK;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.Fe.Search
{
    public partial class sSVDK : Form
    {
        private readonly string _khoa;
        public sSVDK(string khoa)
        {
            InitializeComponent();
            _khoa = khoa;
        }

        private void search_Click(object sender, EventArgs e)
        {
            var inputs = CollectInput();

            if (Validation.IsInputComplete(inputs))
            {
                if (!Validation.TryValidatePositiveInt(inputs["hocKy"], "Học kỳ", out int hocKy)) return;

                string maMH = DataHelper.ExecSqlScalar("SELECT MAMH FROM MONHOC WHERE TENMH = @tenMH", true, new SqlParameter("@tenMH", inputs["monHoc"])).ToString();

                var reportForm = new SVDKReport(_khoa, inputs["nienKhoa"], inputs["hocKy"], maMH, inputs["monHoc"], inputs["nhom"]);
                reportForm.ShowDialog();
            }
        }

        private Dictionary<string, string> CollectInput()
        {
            return new Dictionary<string, string>
            {
                { "nienKhoa", nkInput.Text.Trim() },
                { "hocKy", hkInput.Text.Trim() },
                { "monHoc", mhInput.Text.Trim() },
                { "nhom", nhomInput.Text.Trim() },
            };
        }
    }
}
