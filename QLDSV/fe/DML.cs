using QLDSV.Be.Interfaces;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class DML : UserControl, IHasPanel, IHasData
    {
        private bool isAddingDML;
        private bool isEditingDML;
        private bool isAddingSV;
        private bool isEditingSV;

        private Stack<DataTable> dmlStateHistory = new Stack<DataTable>();
        private Stack<DataTable> studentStateHistory = new Stack<DataTable>();

        private TextBox[] inputs;
        private Control[] inputSV;

        public Dictionary<string, Panel> Panels => new Dictionary<string, Panel>
        {
            { "mainButtons", mainButtons },
            { "subButtons", subButtons }
        };

        public DataSet DataSet => qLDSVDataSet;
        public Dictionary<string, BindingSource> BindingSources => new Dictionary<string, BindingSource>
        {
            { "Lop", lopBindingSource },
            { "SV", sinhVienBindingSource }
        };
        public Dictionary<string, Stack<DataTable>> RowsBackups => new Dictionary<string, Stack<DataTable>>
        {
            { "Lop", dmlStateHistory },
            { "SV", studentStateHistory }
        };
        public object TableAdapterManager => tableAdapterManager;

        public DML()
        {
            InitializeComponent();
            inputs = new TextBox[] { idDMLInput, nameDMLInput, courseDMLInput };
            inputSV = new Control[] { idSVInput, lNameInput, fNameInput, genderCheck, bdayInput, addressInput, isStudyCheck, passwordInput };
        }

        #region DML Button Events

        private void addDML_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingSV, isEditingDML, isEditingSV)) return;
            if (!isAddingDML)
            {
                isAddingDML = true;
                mainData.ClearSelection();
                ClearDMLFormFields();
                majorInput.Text = khoaComboBox.SelectedValue?.ToString();

                Utils.SetFieldEditability(true, inputs);
                return;
            }
            try
            {
                var data = GetClassDataFromForm();

                if (ValidateDMLInput(data) &&
                    !Validation.IsDuplicateInBindingSource(lopBindingSource, data["MALOP"], "MALOP"))
                {
                    DataTable currentTable = ((DataRowView)lopBindingSource.Current)?.Row?.Table.Copy();
                    dmlStateHistory.Push(currentTable);

                    lopBindingSource.AddNew();
                    DataRowView newRow = (DataRowView)lopBindingSource.Current;
                    newRow["MALOP"] = data["MALOP"];
                    newRow["TENLOP"] = data["TENLOP"];
                    newRow["KHOAHOC"] = data["KHOAHOC"];
                    newRow["MAKHOA"] = data["KHOA"];

                    isAddingDML = false;
                    ClearAndDisableForm();

                    MessageBox.Show("Lớp đã được thêm. Nhấn Lưu để ghi vào CSDL.");
                }
                else
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message);
                isAddingDML = false;
                Utils.SetFieldEditability(false, inputs);
            }
        }

        private void editDML_Click(object sender, EventArgs e)
        {
            DataHandler.EditEntity(
                lopBindingSource, () => Utils.IsInProgress(isAddingDML, isEditingSV, isAddingSV), () => isEditingDML,
                    value => isEditingDML = value, AddToForm, GetClassDataFromForm, ValidateDMLInput, Validation.IsDuplicateInBindingSource,
                    editable => Utils.SetFieldEditability(editable, inputs), ClearAndDisableForm, dmlStateHistory, new[] { "MALOP", "TENLOP", "KHOAHOC", "MAKHOA" }, "MALOP", "lớp", idDMLInput);
        }

        private void deleteDML_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV, isAddingSV)) return;
            DataHandler.DeleteCurrentRow(lopBindingSource, dmlStateHistory, "MALOP", "lớp", malop =>
            {
                return qLDSVDataSet.SinhVien.Select($"MALOP = '{malop}'").Length > 0;
            }, ClearAndDisableForm);
        }

        private void saveDML_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV, isAddingSV)) return;
            DataHandler.SaveChanges(this, this.lopBindingSource, this.tableAdapterManager, this.qLDSVDataSet);
        }

        private void resDML_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV, isAddingSV)) return;
            DataHandler.RestorePreviousState(dmlStateHistory, lopBindingSource, () => {
                isAddingDML = false;
                ClearAndDisableForm();
            });
        }

        private void exitDML_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingSV, isEditingSV)) return;
            DataHandler.Cancel(lopBindingSource, ref isAddingDML, ref isEditingDML, ClearAndDisableForm, mainData, "lớp");
        }

        #endregion

        #region DML Helper Functions 

        private void DML_Load(object sender, EventArgs e)
        {
            Utils.SafeFill(lopTableAdapter, () => lopTableAdapter.Fill(qLDSVDataSet.Lop), "lớp");
            ComboBoxLoader.LoadKhoaComboBox(khoaComboBox);

            KhoaFilter();
        }

        private void searchMain_TextChanged(object sender, EventArgs e)
        {
            Utils.ApplySearchFilter(lopBindingSource, search_main.Text, "MALOP", "TENLOP", "KHOAHOC", "MAKHOA");
        }

        private void khoaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhoaFilter();
        }

        private void KhoaFilter()
        {
            string selectedKhoa = khoaComboBox.SelectedValue.ToString();
            lopBindingSource.Filter = $"MAKHOA = '{selectedKhoa}'";
        }

        private void ClearDMLFormFields()
        {
            idDMLInput.Clear();
            nameDMLInput.Clear();
            courseDMLInput.Clear();
            majorInput.Clear();
        }

        private void AddToForm(DataRowView row)
        {
            idDMLInput.Text = row["MALOP"].ToString().Trim();
            nameDMLInput.Text = row["TENLOP"].ToString().Trim();
            courseDMLInput.Text = row["KHOAHOC"].ToString().Trim();
            majorInput.Text = row["MAKHOA"].ToString().Trim();
        }

        private void ClearAndDisableForm()
        {
            ClearDMLFormFields();
            Utils.SetFieldEditability(false, inputs);
        }

        private Dictionary<string, string> GetClassDataFromForm()
        {
            return new Dictionary<string, string>
            {
                { "MALOP", idDMLInput.Text.Trim() },
                { "TENLOP", nameDMLInput.Text.Trim() },
                { "KHOAHOC", courseDMLInput.Text.Trim() },
                { "KHOA", khoaComboBox.SelectedValue?.ToString()}
            };
        }

        private bool ValidateDMLInput(Dictionary<string, string> dmlData)
        {
            if (!Validation.IsInputComplete(dmlData)) return false;

            if (!Validation.IsValidYearRange(dmlData["KHOAHOC"]))
            {
                MessageBox.Show("Niên khóa không hợp lệ. Định dạng phải là YYYY-YYYY và năm kết thúc > năm bắt đầu, khóa học tối đa là 5 năm.");
                return false;
            }

            return true;
        }

        private void mainData_SelectionChanged(object sender, EventArgs e)
        {
            if (isAddingDML || isEditingDML) return;

            if (mainData.CurrentRow != null && mainData.CurrentRow.DataBoundItem is DataRowView row)
            {
                AddToForm(row);

                Utils.SafeFill(sinhVienTableAdapter, () =>
                    sinhVienTableAdapter.Fill(qLDSVDataSet.SinhVien), "sinh viên");
            }
        }

        private void mainData_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = mainData.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader || hit.Type == DataGridViewHitTestType.RowHeader)
            {
                mainData.ClearSelection();
            }
        }

        #endregion

        #region SV Button Events

        private void addSV_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV)) return;
            if (!isAddingSV)
            {
                isAddingSV = true;
                subData.ClearSelection();
                ClearSVFormFields();

                classIdInput.Text = ((DataRowView)lopBindingSource.Current)["MALOP"].ToString();
                passwordInput.Text = "123456";

                Utils.SetFieldEditability(true, inputSV);
                return;
            }
            try
            {
                var data = GetSVDataFromForm();

                if (ValidateSVInput(data) &&
                    !Validation.IsDuplicateInBindingSource(sinhVienBindingSource, data["MASV"], "MASV"))
                {
                    DataTable currentTable = ((DataRowView)sinhVienBindingSource.Current)?.Row?.Table.Copy();
                    studentStateHistory.Push(currentTable);

                    sinhVienBindingSource.AddNew();

                    DataRowView newRow = (DataRowView)sinhVienBindingSource.Current;

                    newRow["MASV"] = data["MASV"];
                    newRow["HO"] = data["HO"];
                    newRow["TEN"] = data["TEN"];
                    newRow["MALOP"] = data["MALOP"];
                    newRow["PHAI"] = bool.Parse(data["PHAI"]);
                    newRow["NGAYSINH"] = data["NGAYSINH"];
                    newRow["DIACHI"] = data["DIACHI"];
                    newRow["DANGHIHOC"] = bool.Parse(data["DANGHIHOC"]);
                    newRow["PASSWORD"] = data["PASSWORD"];


                    isAddingSV = false;
                    ClearAndDisableFormSV();

                    MessageBox.Show("Sinh viên đã được thêm. Nhấn Lưu để ghi vào CSDL.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
                isAddingSV = false;
                Utils.SetFieldEditability(false, inputSV);
            }
        }

        private void editSV_Click(object sender, EventArgs e)
        {
            DataHandler.EditEntity(
                sinhVienBindingSource, () => Utils.IsInProgress(isAddingDML, isEditingDML, isAddingSV), () => isEditingSV, value => isEditingSV = value,
                AddToFormSV, GetSVDataFromForm, ValidateSVInput, Validation.IsDuplicateInBindingSource, editable => Utils.SetFieldEditability(editable, inputSV),
                ClearAndDisableFormSV, studentStateHistory, new[] { "MASV", "HO", "TEN", "MALOP", "PHAI", "NGAYSINH", "DIACHI", "DANGHIHOC", "PASSWORD" }, "sinh viên", "MASV", idSVInput);
        }

        private void deleteSV_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV, isAddingSV)) return;
            DataHandler.DeleteCurrentRow(sinhVienBindingSource, studentStateHistory, "MASV", "sinh viên", masv =>
            {
                return qLDSVDataSet.DANGKY.Select($"MASV = '{masv}'").Length > 0;
            }, ClearAndDisableFormSV);
        }

        private void resSV_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV, isAddingSV)) return;
            DataHandler.RestorePreviousState(studentStateHistory, sinhVienBindingSource, () => {
                isAddingSV = false;
                ClearAndDisableFormSV();
            });
        }

        private void saveSV_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML, isEditingSV, isAddingSV)) return;
            DataHandler.SaveChanges(this, this.sinhVienBindingSource, this.tableAdapterManager, this.qLDSVDataSet);
        }

        private void exitSV_Click(object sender, EventArgs e)
        {
            if (Utils.IsInProgress(isAddingDML, isEditingDML)) return;
            DataHandler.Cancel(sinhVienBindingSource, ref isAddingSV, ref isEditingSV, ClearAndDisableFormSV, subData, "sinh viên");
        }

        #endregion

        #region SV Helper Functions

        private void subData_SelectionChanged(object sender, EventArgs e)
        {
            if (isAddingSV || isEditingSV) return;

            if (subData.CurrentRow != null && subData.CurrentRow.DataBoundItem is DataRowView row)
            {
                AddToFormSV(row);
            }
        }

        private void searchSub_TextChanged(object sender, EventArgs e)
        {
            Utils.ApplySearchFilter(sinhVienBindingSource, search_sub.Text, "MASV", "HO", "TEN", "NGAYSINH", "DIACHI");
        }

        private void ClearSVFormFields()
        {
            idSVInput.Clear();
            lNameInput.Clear();
            fNameInput.Clear();
            classIdInput.Clear();
            genderCheck.Checked = false;
            bdayInput.Clear();
            addressInput.Clear();
            isStudyCheck.Checked = false;
            passwordInput.Clear();
        }

        private void AddToFormSV(DataRowView row)
        {
            idSVInput.Text = row["MASV"].ToString().Trim();
            lNameInput.Text = row["HO"].ToString().Trim();
            fNameInput.Text = row["TEN"].ToString().Trim();
            classIdInput.Text = row["MALOP"].ToString().Trim();
            genderCheck.Checked = bool.Parse(row["PHAI"].ToString());
            bdayInput.Text = row["NGAYSINH"].ToString().Trim();
            addressInput.Text = row["DIACHI"].ToString().Trim();
            isStudyCheck.Checked = bool.Parse(row["DANGHIHOC"].ToString());
            passwordInput.Text = row["PASSWORD"].ToString().Trim();
        }

        private void ClearAndDisableFormSV()
        {
            ClearSVFormFields();
            Utils.SetFieldEditability(false, inputSV);
        }

        private Dictionary<string, string> GetSVDataFromForm()
        {
            return new Dictionary<string, string>
            {
                { "MASV", idSVInput.Text.Trim() },
                { "HO", lNameInput.Text.Trim() },
                { "TEN", fNameInput.Text.Trim() },
                { "MALOP", classIdInput.Text.Trim() },
                { "PHAI", genderCheck.Checked.ToString() },
                { "NGAYSINH", bdayInput.Text.Trim() },
                { "DIACHI", addressInput.Text.Trim() },
                { "DANGHIHOC", isStudyCheck.Checked.ToString() },
                { "PASSWORD", passwordInput.Text.Trim() }
            };
        }

        private bool ValidateSVInput(Dictionary<string, string> svData)
        {
            if (!Validation.IsInputComplete(svData)) return false;

            if (!Validation.IsValidDate(svData["NGAYSINH"]))
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return false;
            }

            return true;
        }

        private void subData_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = subData.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader || hit.Type == DataGridViewHitTestType.RowHeader)
            {
                subData.ClearSelection();
            }
        }

        #endregion
    }
}