using QLDSV.QLDSVDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QLDSV.Be.Utils
{
    internal class DataHandler
    {
        public static void SaveChanges(ContainerControl container, BindingSource bindingSource, TableAdapterManager tableAdapterManager, QLDSVDataSet dataSet)
        {
            try
            {
                string backupFolder = @"C:\Backup";
                if (!Directory.Exists(backupFolder)) Directory.CreateDirectory(backupFolder);

                container.Validate();
                bindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dataSet);
                MessageBox.Show("Đã lưu các thay đổi vào cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        public static void RestorePreviousState(Stack<DataTable> stateHistory, BindingSource bindingSource, Action resetFormAction)
        {
            if (stateHistory == null || stateHistory.Count == 0)
            {
                MessageBox.Show("Không có thao tác nào để hoàn tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataTable previousState = stateHistory.Pop();
                bindingSource.DataSource = previousState;
                resetFormAction?.Invoke();

                MessageBox.Show("Đã hoàn tác thao tác trước đó.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hoàn tác: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EditEntity(BindingSource bindingSource, Func<bool> isInProgressCheck, Func<bool> isEditingFlagGetter,
                                        Action<bool> isEditingFlagSetter, Action<DataRowView> populateForm, Func<Dictionary<string, string>> getDataFromForm,
                                        Func<Dictionary<string, string>, bool> validateInput, Func<BindingSource, string, string, DataRowView, bool> checkDuplicate,
                                        Action<bool> setFieldEditability, Action clearAndDisableForm, Stack<DataTable> stateHistory, string[] fields, string keyField, string entityName, TextBox excludedInput = null)
        {
            if (isInProgressCheck()) return;

            if (bindingSource.Current == null)
            {
                MessageBox.Show($"Vui lòng chọn một {entityName} để chỉnh sửa.");
                return;
            }

            if (!isEditingFlagGetter())
            {
                var selectedRow = (DataRowView)bindingSource.Current;
                populateForm(selectedRow);
                isEditingFlagSetter(true);
                setFieldEditability(true);
                excludedInput.ReadOnly = true;
            }
            else
            {
                var updatedData = getDataFromForm();
                if (!validateInput(updatedData)) return;

                var selectedRow = (DataRowView)bindingSource.Current;

                stateHistory.Push(selectedRow.Row?.Table.Copy());

                if (checkDuplicate(bindingSource, updatedData[keyField], keyField, selectedRow))
                {
                    MessageBox.Show($"{keyField} đã tồn tại. Vui lòng nhập {keyField} khác.");
                    return;
                }

                foreach (var field in fields)
                {
                    if (updatedData.ContainsKey(field))
                        selectedRow[field] = updatedData[field];
                }

                bindingSource.EndEdit();
                isEditingFlagSetter(false);
                clearAndDisableForm();
                MessageBox.Show($"{entityName} đã được cập nhật.");
            }
        }

        public static void DeleteCurrentRow(BindingSource bindingSource, Stack<DataTable> stateHistory, string idField, string entityName, Func<string, bool> hasForeignKeyReference = null, Action postDeleteAction = null)
        {
            if (bindingSource?.Current == null)
            {
                MessageBox.Show($"Vui lòng chọn một {entityName} để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView selectedRow = (DataRowView)bindingSource.Current;
            string idValue = selectedRow[idField]?.ToString()?.Trim() ?? "";

            if (hasForeignKeyReference != null && hasForeignKeyReference.Invoke(idValue))
            {
                MessageBox.Show($"{entityName} {idValue} không thể xóa vì đang được tham chiếu ở bảng khác.", "Lỗi ràng buộc khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa {entityName} {idValue}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataTable table = selectedRow.Row.Table;

                    stateHistory?.Push(table.Copy());

                    bindingSource.RemoveCurrent();
                    postDeleteAction?.Invoke();

                    MessageBox.Show($"{entityName} đã được xóa khỏi danh sách.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa {entityName}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Cancel(BindingSource bindingSource, ref bool isAddingFlag, ref bool isEditingFlag, Action clearAndDisableForm, DataGridView dataGridView, string entityName)
        {
            try
            {
                if (isAddingFlag || isEditingFlag)
                {
                    if (isAddingFlag && bindingSource.Current is DataRowView currentRowView)
                    {
                        if (currentRowView.IsNew || currentRowView.Row.RowState == DataRowState.Added)
                        {
                            bindingSource.RemoveCurrent();
                        }
                        else
                        {
                            bindingSource.CancelEdit();
                        }

                        MessageBox.Show($"Đã hủy thêm {entityName}.");
                    }
                    else if (isEditingFlag)
                    {
                        bindingSource.CancelEdit();
                        MessageBox.Show($"Đã hủy chỉnh sửa {entityName}.");
                    }

                    isAddingFlag = false;
                    isEditingFlag = false;
                }

                clearAndDisableForm?.Invoke();
                dataGridView?.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi huỷ thao tác với {entityName}: {ex.Message}");
            }
        }
    }
}