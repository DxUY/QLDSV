using QLDSV.Be;
using QLDSV.Be.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.Fe
{
    public partial class DKLTC : UserControl
    {
        private readonly string _name;
        private readonly string _masv;
        private readonly string _tenLop;
        private readonly string _tenKhoa;

        public DKLTC(string masv, string name, string tenLop, string tenKhoa)
        {
            InitializeComponent();
            _name = name;
            _masv = masv;
            _tenLop = tenLop;
            _tenKhoa = tenKhoa;
        }

        #region DKLTC Event Button

        private void searchLTC_Click(object sender, EventArgs e)
        {
            int hocKy = Convert.ToInt32(hkComboBox.SelectedValue);
            string nienKhoa = nkComboBox.SelectedValue.ToString();

            main.DataSource = DbHandler.RunJoinedQuery("LOPTINCHI LTC", @"JOIN MONHOC MH ON LTC.MAMH = MH.MAMH JOIN GIANGVIEN GV ON LTC.MAGV = GV.MAGV LEFT JOIN DANGKY DK ON LTC.MALTC = DK.MALTC",
                                                    @" LTC.MALTC, LTC.MAMH, MH.TENMH, LTC.NHOM, GV.HO + ' ' + GV.TEN AS GIANGVIEN, COUNT(DK.MASV) AS DADANGKY", @"LTC.HUYLOP = 0 AND LTC.HOCKY = @hk AND LTC.NIENKHOA = @nienkhoa", 
                                                    @"LTC.MALTC, LTC.MAMH, MH.TENMH, LTC.NHOM, GV.HO, GV.TEN", true, new[] {new SqlParameter("@hk", hocKy), new SqlParameter("@nienkhoa", nienKhoa)});
        }

        private void registerLTC_Click(object sender, EventArgs e)
        {
            if (main.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp để đăng ký.");
                return;
            }

            string maltc = ltcIdInput.Text.Trim();

            DataTable result = DbHandler.ExecuteStoredProcedure("sp_RegisterClass", "Lỗi khi đăng ký lớp tín chỉ", true, new SqlParameter("@MALTC", maltc), new SqlParameter("@MASV", _masv));

            if (result.Rows.Count > 0 && result.Columns.Contains("Message"))
            {
                string message = result.Rows[0]["Message"].ToString();
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelLTC_Click(object sender, EventArgs e)
        {
            if (main.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp để hủy đăng ký.");
                return;
            }

            string maltc = ltcIdInput.Text.Trim();

            DataTable result = DbHandler.ExecuteStoredProcedure("sp_CancelClass", "Lỗi khi hủy đăng ký lớp tín chỉ", true, new SqlParameter("@MALTC", maltc), new SqlParameter("@MASV", _masv));

            if (result.Rows.Count > 0 && result.Columns.Contains("Message"))
            {
                string message = result.Rows[0]["Message"].ToString();
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Helper Functions

        private void DKLTC_Load(object sender, EventArgs e)
        {
            masv.Text = _masv;
            ten.Text = _name;

            lop.Text = _tenLop;
            khoa.Text = _tenKhoa;

            ComboBoxLoader.LoadNienKhoa(nkComboBox);
            ComboBoxLoader.LoadHocKi(hkComboBox);

            sub.DataSource = DbHandler.RunJoinedQuery("DANGKY DK", @"JOIN LOPTINCHI LTC ON DK.MALTC = LTC.MALTC JOIN MONHOC MH ON LTC.MAMH = MH.MAMH JOIN GIANGVIEN GV ON LTC.MAGV = GV.MAGV",
                                                    @"DK.MALTC, LTC.MAMH, MH.TENMH, LTC.NHOM, GV.HO + ' ' + GV.TEN AS GIANGVIEN, (SELECT COUNT(*) FROM DANGKY DK2 WHERE DK2.MALTC = DK.MALTC AND DK2.HUYDANGKY = 0) AS DADANGKY",
                                                    "DK.MASV = @masv AND DK.HUYDANGKY = 0", "", true, new[] { new SqlParameter("@masv", _masv) }
            );
        }

        private void main_SelectionChanged(object sender, EventArgs e)
        {
            if (main.CurrentRow != null && main.CurrentRow.DataBoundItem is DataRowView row)
            {
                AddToForm(row);
            }
        }

        private void AddToForm(DataRowView row)
        {
            ltcIdInput.Text = row["MALTC"].ToString();
            mhInput.Text = row["TENMH"].ToString();
            gvInput.Text = row["GIANGVIEN"].ToString();
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = main.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader || hit.Type == DataGridViewHitTestType.RowHeader)
            {
                main.ClearSelection();
                ClearMainFormFields();
            }
        }

        private void ClearMainFormFields()
        {
            ltcIdInput.Clear();
            mhInput.Clear();
            gvInput.Clear();
        }

        #endregion
    }
}