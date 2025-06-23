using QLDSV.Be.Interfaces;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class DSLTC : UserControl, IHasPanel, IHasData
    {
        private bool isAddingLTC;
        private bool isEditingLTC;

        private Control[] inputs;

        private Stack<DataTable> ltcStateHistory = new Stack<DataTable>();

        public Dictionary<string, Panel> Panels => new Dictionary<string, Panel>
        {
            { "buttons", buttons }
        };

        public DataSet DataSet => qLDSVDataSet;
        public Dictionary<string, BindingSource> BindingSources => new Dictionary<string, BindingSource>
        {
            { "LTC", lOPTINCHIBindingSource }
        };
        public Dictionary<string, Stack<DataTable>> RowsBackups => new Dictionary<string, Stack<DataTable>>
        {
            { "LTC", ltcStateHistory }
        };
        public object TableAdapterManager => tableAdapterManager;

        public DSLTC()
        {
            InitializeComponent();
            inputs = new Control[] { semesterInput, mhComboBox, gvComboBox, minSVInput, yearInput, groupInput, cancelClassCheck };
        }

        #region LTC Event Button

        private void addLTC_Click(object sender, EventArgs e)
        {
            if (!isAddingLTC)
            {
                isAddingLTC = true;
                dataLTC.ClearSelection();
                ClearLTCFormFields();
                khoaInput.Text = khoaComboBox.SelectedValue.ToString();

                ComboBoxLoader.LoadGVTheoKhoaComboBox(gvComboBox, khoaComboBox.SelectedValue.ToString());
                ComboBoxLoader.LoadMonComboBox(mhComboBox);

                mhIdInput.Text = mhComboBox.SelectedValue.ToString();
                gvIdInput.Text = gvComboBox.SelectedValue.ToString();

                Utils.SetFieldEditability(true, inputs);

                return;
            }
            try
            {
                var data = getLTCDataFromForm();

                if (ValidateLTCInput(data) && !IsDuplicateLTCEntry(data))
                {
                    DataTable currentTable = ((DataRowView)lOPTINCHIBindingSource.Current)?.Row?.Table.Copy();
                    ltcStateHistory.Push(currentTable);

                    lOPTINCHIBindingSource.AddNew();
                    var currentRow = (lOPTINCHIBindingSource.Current as DataRowView)?.Row;

                    if (currentRow != null)
                    {
                        currentRow["NIENKHOA"] = data["NIENKHOA"];
                        currentRow["HOCKY"] = data["HOCKY"];
                        currentRow["MAMH"] = data["MAMH"];
                        currentRow["MAGV"] = data["MAGV"];
                        currentRow["MAKHOA"] = data["MAKHOA"];
                        currentRow["SOSVTOITHIEU"] = int.Parse(data["SOSVTOITHIEU"]);
                        currentRow["NHOM"] = int.Parse(data["NHOM"]);
                        currentRow["HUYLOP"] = bool.Parse(data["HUYLOP"]);

                        isAddingLTC = false;
                        ClearAndDisableForm();

                        MessageBox.Show("lớp tín chỉ đã được thêm. Nhấn Lưu để ghi vào CSDL.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp tín chỉ: " + ex.Message);
                isAddingLTC = false;
                Utils.SetFieldEditability(false, inputs);
            }
        }

        private void editLTC_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingLTC)) return;
            DataHandler.EditEntity(lOPTINCHIBindingSource, () => Utils.IsInProgress(isAddingLTC), () => isEditingLTC,
                                value => isEditingLTC = value, AddToForm, getLTCDataFromForm, ValidateLTCInput, Validation.IsDuplicateInBindingSource,
                                editable => Utils.SetFieldEditability(editable, inputs), ClearAndDisableForm, ltcStateHistory,
                                new[] { "MALTC", "NIENKHOA", "HOCKY", "MAMH", "NHOM", "MAGV", "MAKHOA", "SOSVTOITHIEU", "HUYLOP" }, "MALTC", "lớp tín chỉ");
        }

        private void deleteLTC_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingLTC, isEditingLTC)) return;
            DataHandler.DeleteCurrentRow(lOPTINCHIBindingSource, ltcStateHistory, "MALTC", "lớp tín chỉ", maltc =>
            {
                return qLDSVDataSet.DANGKY.Select($"MALTC = '{maltc}'").Length > 0;
            }, ClearAndDisableForm);
        }

        private void resLTC_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingLTC, isEditingLTC)) return;
            DataHandler.RestorePreviousState(ltcStateHistory, lOPTINCHIBindingSource, () => {
                isAddingLTC = false;
                ClearAndDisableForm();
            });
        }

        private void saveLTC_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingLTC, isEditingLTC)) return;
            DataHandler.SaveChanges(this, this.lOPTINCHIBindingSource, this.tableAdapterManager, this.qLDSVDataSet);
        }

        private void exitLTC_Click(object sender, EventArgs e)
        {
            DataHandler.Cancel(lOPTINCHIBindingSource, ref isAddingLTC, ref isEditingLTC, ClearAndDisableForm, dataLTC, "Lớp tín chỉ");
        }
        private void dataLTC_SelectionChanged(object sender, EventArgs e)
        {
            if (isAddingLTC || isEditingLTC) return;

            if (dataLTC.CurrentRow != null && dataLTC.CurrentRow.DataBoundItem is DataRowView row)
            {
                AddToForm(row);
            }
        }

        private void gvComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvComboBox.SelectedValue != null && gvComboBox.SelectedValue is string magv)
            {
                gvIdInput.Text = magv;
            }
        }

        private void mhComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mhComboBox.SelectedValue != null && mhComboBox.SelectedValue is string mamh)
            {
                mhIdInput.Text = mamh;
            }
        }

        private void dataLTC_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataLTC.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader || hit.Type == DataGridViewHitTestType.RowHeader)
            {
                dataLTC.ClearSelection();
                ClearAndDisableForm();
            }
        }

        #endregion

        #region Helper functions

        private void DSLTC_Load(object sender, EventArgs e)
        {
            ComboBoxLoader.LoadKhoaComboBox(khoaComboBox);
            Utils.SafeFill(lOPTINCHITableAdapter, () => lOPTINCHITableAdapter.Fill(qLDSVDataSet.LOPTINCHI), "lớp tín chỉ");

            KhoaFilter();
        }

        private void searchMain_TextChanged(object sender, EventArgs e)
        {
            Utils.ApplySearchFilter(lOPTINCHIBindingSource, search_main.Text,
                "MALTC", "NIENKHOA", "HOCKY", "MAMH", "MAGV", "MAKHOA", "NHOM", "SOSVTOITHIEU", "HUYLOP");
        }

        private void khoaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhoaFilter();
        }

        private void KhoaFilter()
        {
            string selectedKhoa = khoaComboBox.SelectedValue.ToString();
            lOPTINCHIBindingSource.Filter = $"MAKHOA = '{selectedKhoa}'";
        }

        private void ClearLTCFormFields()
        {
            khoaInput.Clear();
            semesterInput.Value = semesterInput.Minimum;
            mhComboBox.DataSource = null;
            gvComboBox.DataSource = null;
            minSVInput.Value = minSVInput.Minimum;
            yearInput.Clear();
            groupInput.Value = groupInput.Minimum;
            mhIdInput.Clear();
            gvIdInput.Clear();
            cancelClassCheck.Checked = false;
        }

        private Dictionary<string, string> getLTCDataFromForm()
        {
            return new Dictionary<string, string>
            {
                { "MAKHOA", khoaInput.Text.Trim() },
                { "HOCKY", semesterInput.Value.ToString() },
                { "MONHOC", mhComboBox.SelectedValue?.ToString() },
                { "GIANGVIEN", gvComboBox.SelectedValue?.ToString() },
                { "SOSVTOITHIEU", minSVInput.Value.ToString() },
                { "NIENKHOA", yearInput.Text.ToString() },
                { "NHOM", groupInput.Value.ToString() },
                { "MAMH", mhIdInput.Text.ToString() },
                { "MAGV", gvIdInput.Text.ToString() },
                { "HUYLOP", cancelClassCheck.Checked.ToString() },
            };
        }

        private bool ValidateLTCInput(Dictionary<string, string> ltcData)
        {
            if (!Validation.IsInputComplete(ltcData)) return false;

            if (!Validation.IsValidYearRange(ltcData["NIENKHOA"], maxSpan: 1))
            {
                MessageBox.Show("Niên khóa không hợp lệ. Định dạng phải là YYYY-YYYY và năm kết thúc > năm bắt đầu.");
                return false;
            }

            return true;
        }

        private bool IsDuplicateLTCEntry(Dictionary<string, string> data)
        {
            foreach (DataRowView r in lOPTINCHIBindingSource.List)
            {
                if (r.IsNew || r.Row.RowState == DataRowState.Deleted) continue;
                if (r["NIENKHOA"].ToString() == data["NIENKHOA"] && r["HOCKY"].ToString() == data["HOCKY"] &&
                    r["MAMH"].ToString() == data["MAMH"] && r["NHOM"].ToString() == data["NHOM"])
                    return true;
            }
            return false;
        }

        private void AddToForm(DataRowView row)
        {
            khoaInput.Text = row["MAKHOA"]?.ToString().Trim() ?? "";
            semesterInput.Value = row["HOCKY"] != DBNull.Value ? Convert.ToDecimal(row["HOCKY"]) : semesterInput.Minimum;
            minSVInput.Value = row["SOSVTOITHIEU"] != DBNull.Value ? Convert.ToDecimal(row["SOSVTOITHIEU"]) : minSVInput.Minimum;
            yearInput.Text = row["NIENKHOA"]?.ToString().Trim() ?? "";
            groupInput.Value = row["NHOM"] != DBNull.Value ? Convert.ToDecimal(row["NHOM"]) : groupInput.Minimum;
            cancelClassCheck.Checked = row["HUYLOP"] != DBNull.Value && Convert.ToBoolean(row["HUYLOP"]);

            mhIdInput.Text = row["MAMH"]?.ToString().Trim() ?? "";
            gvIdInput.Text = row["MAGV"]?.ToString().Trim() ?? "";

            if (mhComboBox.DataSource != null)
                mhComboBox.SelectedValue = row["MAMH"]?.ToString().Trim();

            if (gvComboBox.DataSource != null)
                gvComboBox.SelectedValue = row["MAGV"]?.ToString().Trim();
        }

        private void ClearAndDisableForm()
        {
            ClearLTCFormFields();
            Utils.SetFieldEditability(false, inputs);
        }

        #endregion
    }
}
