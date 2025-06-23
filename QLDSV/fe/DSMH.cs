using QLDSV.Be.Interfaces;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class DSMH : UserControl, IHasPanel, IHasData
    {
        private bool isAddingMH;
        private bool isEditingMH;

        private Stack<DataTable> mhStateHistory = new Stack<DataTable>();

        private Control[] inputs;

        public Dictionary<string, Panel> Panels => new Dictionary<string, Panel>
        {
            { "buttons", buttons }
        };

        public DataSet DataSet => qLDSVDataSet;
        public Dictionary<string, BindingSource> BindingSources => new Dictionary<string, BindingSource>
        {
            { "MonHoc", monHocBindingSource }
        };
        public Dictionary<string, Stack<DataTable>> RowsBackups => new Dictionary<string, Stack<DataTable>>
        {
            { "MonHoc", mhStateHistory }
        };
        public object TableAdapterManager => tableAdapterManager;

        public DSMH()
        {
            InitializeComponent();
            inputs = new Control[] { idMHInput, nameMHInput, ltPeriodInput, thPeriodInput };
        }

        #region MH Event Button

        private void addMH_Click(object sender, EventArgs e)
        {
            if (!isAddingMH)
            {
                isAddingMH = true;
                dataMH.ClearSelection();
                ClearMHFormFields();
                Utils.SetFieldEditability(true, inputs);
                return;
            }

            try
            {
                var data = GetSubjectDataFromForm();

                if (!ValidateMHInput(data)) return;

                bool isDuplicateMa = Validation.IsDuplicateInBindingSource(monHocBindingSource, data["MAMH"], "MAMH");
                bool isDuplicateTen = Validation.IsDuplicateInBindingSource(monHocBindingSource, data["TENMH"], "TENMH");

                if (isDuplicateMa || isDuplicateTen)
                {
                    string message = "Giá trị sau đã tồn tại:\n";
                    if (isDuplicateMa) message += "- Mã môn học\n";
                    if (isDuplicateTen) message += "- Tên môn học\n";
                    message += "Vui lòng nhập giá trị khác.";

                    MessageBox.Show(message, "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable currentTable = ((DataRowView)monHocBindingSource.Current)?.Row?.Table.Copy();
                mhStateHistory.Push(currentTable);

                monHocBindingSource.AddNew();
                DataRowView newRow = (DataRowView)monHocBindingSource.Current;
                newRow["MAMH"] = data["MAMH"];
                newRow["TENMH"] = data["TENMH"];
                newRow["SOTIET_LT"] = data["SOTIET_LT"];
                newRow["SOTIET_TH"] = data["SOTIET_TH"];

                isAddingMH = false;
                ClearAndDisableForm();

                MessageBox.Show("Môn học đã được thêm. Nhấn Lưu để ghi vào CSDL.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isAddingMH = false;
                Utils.SetFieldEditability(false, inputs);
            }
        }

        private void editMH_Click(object sender, EventArgs e)
        {
            DataHandler.EditEntity(monHocBindingSource, () => Utils.IsInProgress(isAddingMH), () => isEditingMH,
                                value => isEditingMH = value, AddToForm, GetSubjectDataFromForm, ValidateMHInput, Validation.IsDuplicateInBindingSource,
                                editable => Utils.SetFieldEditability(editable, inputs), ClearAndDisableForm, mhStateHistory, new[] { "MAMH", "TENMH", "SOTIET_LT", "SOTIET_TH" }, "MAMH", "môn học", idMHInput);
        }

        private void deleteMH_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingMH, isEditingMH)) return;
            DataHandler.DeleteCurrentRow(monHocBindingSource, mhStateHistory, "MAMH", "môn học", mamh =>
            {
                return qLDSVDataSet.LOPTINCHI.Select($"MAMH = '{mamh}'").Length > 0;
            }, ClearAndDisableForm);
        }

        private void resMH_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingMH, isEditingMH)) return;
            DataHandler.RestorePreviousState(mhStateHistory, monHocBindingSource, () => {
                isAddingMH = false;
                ClearAndDisableForm();
            });
        }

        private void saveMH_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingMH, isEditingMH)) return;
            DataHandler.SaveChanges(this, this.monHocBindingSource, this.tableAdapterManager, this.qLDSVDataSet);
        }

        private void exitMH_Click(object sender, EventArgs e)
        {
            DataHandler.Cancel(monHocBindingSource, ref isAddingMH, ref isEditingMH, ClearAndDisableForm, dataMH, "môn học");
        }

        #endregion

        #region Helper functions

        private void DSMH_Load(object sender, EventArgs e)
        {
            Utils.SafeFill(monHocTableAdapter, () => monHocTableAdapter.Fill(qLDSVDataSet.MonHoc), "môn học");
        }

        private void searchMain_TextChanged(object sender, EventArgs e)
        {
            Utils.ApplySearchFilter(monHocBindingSource, search_main.Text, "MAMH", "TENMH", "SOTIET_LT", "SOTIET_TH");
        }

        private void dataMH_SelectionChanged(object sender, EventArgs e)
        {
            if (isAddingMH || isEditingMH) return;

            if (dataMH.CurrentRow != null && dataMH.CurrentRow.DataBoundItem is DataRowView row)
            {
                AddToForm(row);
            }
        }

        private void dataMH_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataMH.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader || hit.Type == DataGridViewHitTestType.RowHeader)
            {
                dataMH.ClearSelection();
                ClearAndDisableForm();
            }
        }

        private void ClearMHFormFields()
        {
            idMHInput.Clear();
            nameMHInput.Clear();
            ltPeriodInput.Value = ltPeriodInput.Minimum;
            thPeriodInput.Value = thPeriodInput.Minimum;
        }

        private Dictionary<string, string> GetSubjectDataFromForm()
        {
            return new Dictionary<string, string>
            {
                { "MAMH", idMHInput.Text.Trim() },
                { "TENMH", nameMHInput.Text.Trim() },
                { "SOTIET_LT", ltPeriodInput.Value.ToString() },
                { "SOTIET_TH", thPeriodInput.Value.ToString() }
            };
        }

        private bool ValidateMHInput(Dictionary<string, string> mhData)
        {
            if (!Validation.IsInputComplete(mhData)) return false;

            if (ltPeriodInput.Value + thPeriodInput.Value == 0) return false;

            return true;
        }

        private void AddToForm(DataRowView row)
        {
            idMHInput.Text = row["MAMH"].ToString().Trim();
            nameMHInput.Text = row["TENMH"].ToString().Trim();
            ltPeriodInput.Value = row["SOTIET_LT"] != DBNull.Value ? Convert.ToDecimal(row["SOTIET_LT"]) : 0;
            thPeriodInput.Value = row["SOTIET_TH"] != DBNull.Value ? Convert.ToDecimal(row["SOTIET_TH"]) : 0;
        }

        private void ClearAndDisableForm()
        {
            ClearMHFormFields();
            Utils.SetFieldEditability(false, inputs);
        }

        #endregion
    }
}