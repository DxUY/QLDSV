using QLDSV.Be;
using QLDSV.fe;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV.Fe
{
    public partial class Backup : UserControl
    {
        private string selectedBackupPath;

        public Backup()
        {
            InitializeComponent();
        }

        #region Backup Event Button

        private void backupData_Click(object sender, EventArgs e)
        {
            try
            {
                bool clearOld = deleteOldChk.Checked;

                if (DbHandler.FullBackup(clearOld))
                {
                    MessageBox.Show(
                        "Sao lưu cơ sở dữ liệu thành công lên device DEVICE_QLDSV!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    main.DataSource = DbHandler.GetBackupHistory(); // refresh
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi sao lưu: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void restoreData_Click(object sender, EventArgs e)
        {
            if (restoreByTimeChk.Checked)
                RestoreToSpecificTime();
            else
                FullRestore();
        }

        #endregion

        #region Helper Function

        private void Backup_Load(object sender, EventArgs e)
        {
            main.DataSource = DbHandler.GetBackupHistory();
            selectedBackupPath = null;
        }

        private void main_SelectionChanged(object sender, EventArgs e)
        {
            if (main.SelectedRows.Count > 0)
            {
                try
                {
                    string fileName = main.SelectedRows[0].Cells["THIETBISAOLUU"].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        selectedBackupPath = Path.Combine(@"C:\Backup", fileName);
                    }
                    else
                    {
                        selectedBackupPath = null;
                    }
                }
                catch
                {
                    selectedBackupPath = null;
                }
            }
            else
            {
                selectedBackupPath = null;
            }
        }

        private void FullRestore()
        {
            if (string.IsNullOrWhiteSpace(selectedBackupPath) || !File.Exists(selectedBackupPath))
            {
                MessageBox.Show("Vui lòng chọn một bản sao lưu hợp lệ để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn khôi phục cơ sở dữ liệu từ:\n{selectedBackupPath}?",
                "Xác nhận khôi phục",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (DbHandler.FullRestore(selectedBackupPath))
                {
                    MessageBox.Show("Khôi phục cơ sở dữ liệu thành công!\nỨng dụng sẽ quay lại màn hình đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var loginForm = new Login();
                    loginForm.Show();
                    this.FindForm()?.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Khôi phục cơ sở dữ liệu thất bại.\n\nChi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreToSpecificTime()
        {
            if (string.IsNullOrWhiteSpace(selectedBackupPath) || !File.Exists(selectedBackupPath))
            {
                MessageBox.Show("Vui lòng chọn một bản sao lưu hợp lệ để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = datePicker.Value.Date;
            DateTime selectedTime = timePicker.Value;
            DateTime stopAt = new DateTime(
                selectedDate.Year, selectedDate.Month, selectedDate.Day,
                selectedTime.Hour, selectedTime.Minute, selectedTime.Second
            );

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn khôi phục đến thời điểm:\n{stopAt:G}?",
                "Xác nhận khôi phục theo thời gian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (DbHandler.FullRestore(selectedBackupPath))
                {
                    if (DbHandler.RestoreLogFromFolder(stopAt))
                    {
                        MessageBox.Show("Khôi phục đến thời điểm đã chọn thành công!\nỨng dụng sẽ quay lại màn hình đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var loginForm = new Login();
                        loginForm.Show();
                        this.FindForm()?.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục LOG thất bại. CSDL có thể ở trạng thái không nhất quán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khôi phục đến thời điểm cụ thể:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreByTimeChk_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = restoreByTimeChk.Checked;

            chooseTimeLabel.Visible = chk;
            datePicker.Visible = chk;
            timePicker.Visible = chk;
        }

        #endregion
    }
}
