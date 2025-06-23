using QLDSV.Be;
using QLDSV.Be.Interfaces;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class ND : UserControl
    {
        private int nkRequestId = 0;
        private int hkRequestId = 0;
        private int mhRequestId = 0;
        private int nhomRequestId = 0;

        private bool isEditing;

        private readonly string _magv;
        private readonly string _role;

        public ND(string masv, string role)
        {
            InitializeComponent();
            _magv = masv;
            _role = role;
        }

        #region ND Event Button

        private void start_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isEditing)) return;

            if (!ValidateComboBoxes())
            {
                MessageBox.Show("Hiện không có thông tin, vui lòng tạo các lớp tín chỉ trước.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditing = true;
            var selection = GetLTCSelection();

            var parametersForSub = CreateLTCParameters(selection);
            sub.DataSource = DbHandler.RunJoinedQuery(
                "LOPTINCHI LTC",
                @"JOIN MONHOC MH ON MH.MAMH = LTC.MAMH JOIN GIANGVIEN GV ON GV.MAGV = LTC.MAGV",
                @"LTC.MALTC, MH.TENMH, GV.HO + ' ' + GV.TEN AS HOTEN",
                @"LTC.NIENKHOA = @nienKhoa AND LTC.HOCKY = @hocky AND LTC.MAMH = @mamh AND LTC.NHOM = @nhom",
                "", false, parametersForSub);

            var parametersForMain = CreateLTCParameters(selection);
            main.DataSource = DbHandler.RunJoinedQuery(
                "DANGKY DK",
                @"JOIN SINHVIEN SV ON DK.MASV = SV.MASV JOIN LOPTINCHI LTC ON DK.MALTC = LTC.MALTC JOIN LOP L ON SV.MALOP = L.MALOP",
                @"SV.MASV, SV.HO + ' ' + SV.TEN AS HOTEN, DK.MALTC, DK.DIEM_CC, DK.DIEM_GK, DK.DIEM_CK",
                @"LTC.NIENKHOA = @nienKhoa AND LTC.HOCKY = @hocky AND LTC.MAMH = @mamh AND LTC.NHOM = @nhom AND DK.HUYDANGKY = 0",
                "", false, parametersForMain);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                List<string> failedUpdates = new List<string>();

                foreach (DataGridViewRow row in main.Rows)
                {
                    if (row.IsNewRow) continue;

                    var data = ExtractSVData(row);

                    bool success = DbHandler.UpdateStudentScore(data);
                    if (!success)
                    {
                        failedUpdates.Add(data["MASV"].ToString());
                    }
                }

                if (failedUpdates.Count == 0)
                {
                    isEditing = false;
                    ClearForm();
                    MessageBox.Show("Cập nhật điểm thành công cho tất cả sinh viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"Cập nhật điểm thất bại cho {failedUpdates.Count} sinh viên:\n{string.Join(", ", failedUpdates)}",
                        "Lỗi cập nhật",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                var selection = GetLTCSelection();
                if (selection == null) return;

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn hủy nhập điểm?",
                    "Xác nhận hủy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        isEditing = false;
                        ClearForm();
                        MessageBox.Show("Đã thoát tiến trình!", "Đã hủy thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thoát:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #region Helper Function

        private async void ND_Load(object sender, EventArgs e)
        {
            ComboBoxLoader.LoadKhoaComboBox(khoaComboBox);

            if (_role == "KHOA") 
            {
                string makhoa = DbHandler.GetColumnValues("GIANGVIEN", new[] { "MAKHOA" }, "MAGV", _magv , false)?["MAKHOA"]?.ToString(); 
                
                khoaComboBox.SelectedValue = makhoa;
                khoaComboBox.Enabled = false; 
                await LoadNienKhoaAsync(makhoa);
            }
            else
            {
                ComboBoxLoader.LoadKhoaComboBox(khoaComboBox);
                if (khoaComboBox.SelectedValue != null)
                    await LoadNienKhoaAsync(khoaComboBox.SelectedValue.ToString());
            }
        }

        private async void khoaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = khoaComboBox.SelectedValue?.ToString();
            if (!string.IsNullOrWhiteSpace(maKhoa))
                await LoadNienKhoaAsync(maKhoa);
        }

        private async void nkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nk = nkComboBox.SelectedValue?.ToString();
            if (!string.IsNullOrWhiteSpace(nk))
                await LoadHocKyAsync(nk);
        }

        private async void hkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(hkComboBox.SelectedValue?.ToString(), out int hk))
                await LoadMonHocAsync(hk);
        }

        private async void mhComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mamh = mhComboBox.SelectedValue?.ToString();
            if (!string.IsNullOrWhiteSpace(mamh))
                await LoadNhomAsync(mamh);
        }

        private void main_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = main.Rows[e.RowIndex];

            bool ccValid = Validation.ValidateScore(row.Cells["DIEM_CC"]?.Value, out float cc);
            bool gkValid = Validation.ValidateScore(row.Cells["DIEM_GK"]?.Value, out float gk);
            bool ckValid = Validation.ValidateScore(row.Cells["DIEM_CK"]?.Value, out float ck);

            if (ccValid && gkValid && ckValid)
            {
                float tk = (cc * 0.1f) + (gk * 0.3f) + (ck * 0.6f);
                row.Cells["DIEM_TK"].Value = Math.Round(tk, 2);
            }
            else
            {
                row.Cells["DIEM_TK"].Value = null;

                if (!ccValid) row.Cells["DIEM_CC"].Value = DBNull.Value;
                if (!gkValid) row.Cells["DIEM_GK"].Value = DBNull.Value;
                if (!ckValid) row.Cells["DIEM_CK"].Value = DBNull.Value;
            }
        }

        private void Main_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                tb.TextChanged -= TextBox_TextChanged;
                tb.TextChanged += TextBox_TextChanged;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            main.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private Dictionary<string, object> GetLTCSelection()
        {
            return new Dictionary<string, object>
            {
                { "NIENKHOA", nkComboBox.SelectedValue?.ToString() },
                { "HOCKY", int.Parse(hkComboBox.SelectedValue?.ToString()) },
                { "MAMH", mhComboBox.SelectedValue?.ToString() },
                { "NHOM", int.Parse(nhomComboBox.SelectedValue?.ToString()) }
            };
        }

        private Dictionary<string, object> ExtractSVData(DataGridViewRow row)
        {
            return new Dictionary<string, object>
            {
                { "MASV", row.Cells["MASV"].Value?.ToString() },
                { "MALTC", Convert.ToInt32(row.Cells["MALTC"].Value) },
                { "DIEM_CC", row.Cells["DIEM_CC"].Value == DBNull.Value ? (object)DBNull.Value : Convert.ToSingle(row.Cells["DIEM_CC"].Value) },
                { "DIEM_GK", row.Cells["DIEM_GK"].Value == DBNull.Value ? (object)DBNull.Value : Convert.ToSingle(row.Cells["DIEM_GK"].Value) },
                { "DIEM_CK", row.Cells["DIEM_CK"].Value == DBNull.Value ? (object)DBNull.Value : Convert.ToSingle(row.Cells["DIEM_CK"].Value) }
            };
        }

        private SqlParameter[] CreateLTCParameters(Dictionary<string, object> selection)
        {
            return new[]
            {
                new SqlParameter("@nienKhoa", selection["NIENKHOA"]),
                new SqlParameter("@hocky", selection["HOCKY"]),
                new SqlParameter("@mamh", selection["MAMH"]),
                new SqlParameter("@nhom", selection["NHOM"])
            };
        }


        private void ClearForm()
        {
            main.DataSource = ((DataTable)main.DataSource)?.Clone();
            sub.DataSource = ((DataTable)sub.DataSource)?.Clone();
        }

        private bool ValidateComboBoxes()
        {
            return nkComboBox.SelectedValue != null && hkComboBox.SelectedValue != null &&
                   mhComboBox.SelectedValue != null && nhomComboBox.SelectedValue != null;
        }

        #endregion

        #region Async Load Chain Methods

        private async Task LoadNienKhoaAsync(string maKhoa)
        {
            int requestId = ++nkRequestId;
            var data = await ComboBoxAsyncLoader.GetNienKhoaTheoKhoaAsync(maKhoa);
            if (requestId != nkRequestId) return;

            if (data == null || data.Rows.Count == 0)
            {
                ComboBoxLoader.ClearComboBox(nkComboBox, "Không có dữ liệu");
                ComboBoxLoader.ClearComboBox(hkComboBox);
                ComboBoxLoader.ClearComboBox(mhComboBox);
                ComboBoxLoader.ClearComboBox(nhomComboBox);
                return;
            }

            ComboBoxLoader.LoadNienKhoaTheoKhoa(nkComboBox, data);

            if (nkComboBox.SelectedValue != null)
                await LoadHocKyAsync(nkComboBox.SelectedValue.ToString());
        }

        private async Task LoadHocKyAsync(string nk)
        {
            int requestId = ++hkRequestId;
            var data = await ComboBoxAsyncLoader.GetHockyTheoNienKhoaAsync(nk);
            if (requestId != hkRequestId) return;

            ComboBoxLoader.LoadHockyTheoNienkhoa(hkComboBox, data);

            if (hkComboBox.SelectedValue != null &&
                int.TryParse(hkComboBox.SelectedValue.ToString(), out int hk))
                await LoadMonHocAsync(hk);
        }

        private async Task LoadMonHocAsync(int hk)
        {
            int requestId = ++mhRequestId;

            string nienKhoa = nkComboBox.SelectedValue?.ToString();
            if (string.IsNullOrWhiteSpace(nienKhoa)) return;

            var data = await ComboBoxAsyncLoader.GetMonTheoHocKyAsync(nienKhoa, hk);
            if (requestId != mhRequestId) return;

            ComboBoxLoader.LoadMonTheoHocky(mhComboBox, data);

            if (mhComboBox.SelectedValue != null)
                await LoadNhomAsync(mhComboBox.SelectedValue.ToString());
        }

        private async Task LoadNhomAsync(string mamh)
        {
            int requestId = ++nhomRequestId;

            string nienKhoa = nkComboBox.SelectedValue?.ToString();
            if (string.IsNullOrWhiteSpace(nienKhoa)) return;

            if (!int.TryParse(hkComboBox.SelectedValue?.ToString(), out int hk)) return;

            var data = await ComboBoxAsyncLoader.GetNhomTheoMonAsync(nienKhoa, hk, mamh);
            if (requestId != nhomRequestId) return;

            ComboBoxLoader.LoadNhomTheoMon(nhomComboBox, data);
        }

        #endregion
    }
}
