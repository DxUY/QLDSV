using Microsoft.Reporting.WinForms;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QLDSV.Be.Utils
{
    internal class Utils
    {
        public static void SetFieldEditability(bool editable, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.ReadOnly = !editable;
                        break;
                    case NumericUpDown numericUpDown:
                        numericUpDown.ReadOnly = !editable;
                        break;
                    case CheckBox checkBox:
                        checkBox.Enabled = editable;
                        break;
                    case ComboBox comboBox:
                        comboBox.Enabled = editable;
                        break;
                }
            }
        }

        public static void SetPanelStatus(bool editable, params Panel[] panels)
        {
            foreach (Panel panel in panels)
            {
                panel.Enabled = editable;
            }
        }

        public static bool IsInProgress(params bool[] editingStates)
        {
            if (editingStates.Any(state => state))
            {
                MessageBox.Show(
                    "Bạn đang làm dang dở . Vui lòng hoàn tất hoặc hủy trước khi làm chức năng khác.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            return false;
        }

        public static void SafeFill<T>(T tableAdapter, Action fillAction, string entityName = "dữ liệu")
        {
            try
            {
                fillAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải {entityName}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ApplySearchFilter(BindingSource source, string searchText, params string[] columns)
        {
            if (source == null || columns == null || columns.Length == 0)
                return;

            string value = searchText?.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(value))
            {
                source.RemoveFilter();
                return;
            }

            string filter = string.Join(" OR ",
                Array.ConvertAll(columns, column =>
                    $"{column} LIKE '%{value}%'"));

            source.Filter = filter;
        }

        public static void HideExportFormats(LocalReport report, params string[] formats)
        {
            var extensions = report.ListRenderingExtensions();
            foreach (var ext in extensions)
            {
                if (formats.Contains(ext.Name, StringComparer.OrdinalIgnoreCase))
                {
                    var fieldInfo = ext.GetType().GetField("m_isVisible", BindingFlags.Instance | BindingFlags.NonPublic);
                    if (fieldInfo != null)
                    {
                        fieldInfo.SetValue(ext, false);
                    }
                }
            }
        }

    }
}
