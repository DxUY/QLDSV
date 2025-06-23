using QLDSV.Be.Utils;
using QLDSV.Fe.Reports.DSLTC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLDSV.Fe.Search
{
    public partial class sDSLTC : Form
    {
        public sDSLTC()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var inputs = CollectInput();

            if (Validation.IsInputComplete(inputs))
            {

                if (!int.TryParse(inputs["hocKy"], out int hocKy) || hocKy <= 0)
                {
                    MessageBox.Show("Học kỳ phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var reportForm = new DSLTCReport(inputs["maKhoa"], inputs["tenKhoa"], inputs["nienKhoa"], hocKy);
                reportForm.ShowDialog();
            }
        }

        private void sDSLTC_Load(object sender, EventArgs e)
        {
            ComboBoxLoader.LoadKhoaComboBox(khoaComboBox);
        }

        private Dictionary<string, string> CollectInput()
        {
            return new Dictionary<string, string>
            {
                { "maKhoa", khoaComboBox.SelectedValue?.ToString() },
                { "tenKhoa", khoaComboBox.Text.Trim() },
                { "nienKhoa", nkInput.Text.Trim() },
                { "hocKy", hkInput.Text.Trim() }
            };
        }
    }
}