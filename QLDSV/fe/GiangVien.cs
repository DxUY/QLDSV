using QLDSV.Be;
using QLDSV.Be.Interfaces;
using QLDSV.Be.Utils;
using QLDSV.Fe;
using QLDSV.Fe.Search;
using QLDSV.QLDSVDataSetTableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV.fe
{
    public partial class GiangVien : Form
    {
        private readonly string _username;
        private readonly string _name;
        private readonly string _role;
        private readonly string _khoa;
        
        private UserControl current;

        private bool manageCollapsed;
        private bool printCollapsed;
        private int step = 10;

        public GiangVien(string username, string name, string role, string khoa)
        {
            InitializeComponent();
            _username = username;
            _name = name;
            _role = role;
            _khoa = khoa;
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            name.Text = _name;
            role.Text = _role;
            ShowForm(typeof(DML));
            autoBackupTimer.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (!CheckUnsavedChanges()) return;
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (!CheckUnsavedChanges()) return;
            var result = MessageBox.Show("Are you sure you want to logout?",
                                         "Confirmation Message",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            var loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        #region Manage
        private void manageTimer_Tick(object sender, EventArgs e) => TogglePanelHeight(manageController, ref manageCollapsed, manageTimer);

        private void Manage_Click(object sender, EventArgs e) => manageTimer.Start();
        private void DML_Click(object sender, EventArgs e) => ShowForm(typeof(DML));
        private void DSMH_Click(object sender, EventArgs e) => ShowForm(typeof(DSMH));
        private void DSLTC_Click(object sender, EventArgs e) => ShowForm(typeof(DSLTC));
        private void ND_Click(object sender, EventArgs e) => ShowForm(typeof(ND), new object[] { _username, _role });
        private void TK_Click(object sender, EventArgs e) => ShowForm(typeof(TaoTK), new object[] { _role });

        #endregion

        #region Print
        private void Print_Click(object sender, EventArgs e) => printTimer.Start();

        private void printTimer_Tick(object sender, EventArgs e) => TogglePanelHeight(printController, ref printCollapsed, printTimer);

        private void pDSLTC_Click(object sender, EventArgs e) => ShowFloatingPopup(typeof(sDSLTC));

        private void pSVDK_Click(object sender, EventArgs e) => ShowFloatingPopup(typeof(sSVDK), new object[] { _khoa });

        private void pPD_Click(object sender, EventArgs e) => ShowFloatingPopup(typeof(sPD));

        private void pBDLTC_Click(object sender, EventArgs e) => ShowFloatingPopup(typeof(sBDLTC), new object[] { _khoa });

        private void pBDTK_Click(object sender, EventArgs e) => ShowFloatingPopup(typeof(sBDTK), new object[] { _khoa });

        #endregion

        #region Backup & Restore
        private void backup_Click(object sender, EventArgs e)
        {
            if (_role == "KHOA")
            {
                MessageBox.Show("Access denied!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowForm(typeof(Backup));
        }

        #endregion

        #region Helper function

        private void ShowForm(Type userControlType, object[] constructorArgs = null)
        {
            if (!CheckUnsavedChanges()) return;

            this.SuspendLayout();
            content.Controls.Clear();

            UserControl newPanel;

            newPanel = (UserControl)Activator.CreateInstance(userControlType, constructorArgs ?? Array.Empty<object>());

            newPanel.Location = content.Location;
            content.Controls.Add(newPanel);

            if (userControlType != typeof(TaoTK))
            {
                HandlePanels(newPanel);
            }

            current = newPanel;

            this.ResumeLayout();
        }

        private void HandlePanels(UserControl userControl)
        {
            var hasPanel = userControl as IHasPanel;
            if (hasPanel == null || hasPanel.Panels == null)
            {
                System.Diagnostics.Debug.WriteLine("UserControl does not implement IHasPanel or Panels is null.");
                return;
            }

            if (_role == "KHOA" && hasPanel.Panels.Count > 0)
            {
                Utils.SetPanelStatus(false, hasPanel.Panels.Values.ToArray());
            }
        }

        private void ShowFloatingPopup(Type formType, object[] constructorArgs = null)
        {
            if (_role == "KHOA")
            {
                MessageBox.Show("Access Denied", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form popupForm = (Form)Activator.CreateInstance(formType, constructorArgs ?? Array.Empty<object>());
            popupForm.Show();
        }

        private bool CheckUnsavedChanges()
        {
            if (current != null && current.GetType() == typeof(TaoTK))
            {
                return true;
            }

            if (current is IHasData hasData && hasData.DataSet != null)
            {
                foreach (var bindingSource in hasData.BindingSources.Values)
                {
                    if (bindingSource?.Current is DataRowView currentRow)
                    {
                        if (currentRow.IsNew)
                        {
                            DataColumn[] primaryKeyColumns = currentRow.Row.Table.PrimaryKey;
                            if (primaryKeyColumns.Length > 0)
                            {
                                bool isPrimaryKeyEmpty = true;
                                foreach (var pkColumn in primaryKeyColumns)
                                {
                                    var value = currentRow[pkColumn.ColumnName];
                                    if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                                    {
                                        isPrimaryKeyEmpty = false;
                                        break;
                                    }
                                }

                                if (isPrimaryKeyEmpty)
                                {
                                    bindingSource.CancelEdit();
                                    bindingSource.RemoveCurrent();
                                    continue;
                                }
                            }
                        }
                    }

                    bindingSource?.EndEdit();
                }

                if (hasData.DataSet.HasChanges())
                {
                    var result = MessageBox.Show(
                        "You have unsaved changes in the data. Do you want to save before proceeding?",
                        "Unsaved Changes",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var primaryBindingSource = hasData.BindingSources.Values.FirstOrDefault();
                            DataHandler.SaveChanges(current, primaryBindingSource, hasData.TableAdapterManager as TableAdapterManager, hasData.DataSet as QLDSVDataSet);
                            if (hasData.RowsBackups != null)
                            {
                                foreach (var backup in hasData.RowsBackups.Values)
                                {
                                    backup?.Clear();
                                }
                            }
                            return true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        hasData.DataSet.RejectChanges();
                        if (hasData.RowsBackups != null)
                        {
                            foreach (var backup in hasData.RowsBackups.Values)
                            {
                                backup?.Clear();
                            }
                        }
                        return true;
                    }
                }
            }
            return true;
        }

        private void TogglePanelHeight(Control panel, ref bool collapsed, Timer timer)
        {
            if (collapsed)
            {
                panel.Height += step;
                if (panel.Height >= panel.MaximumSize.Height)
                {
                    panel.Height = panel.MaximumSize.Height;
                    collapsed = false;
                    timer.Stop();
                }
            }
            else
            {
                panel.Height -= step;
                if (panel.Height <= panel.MinimumSize.Height)
                {
                    panel.Height = panel.MinimumSize.Height;
                    collapsed = true;
                    timer.Stop();
                }
            }
        }

        private void autoBackupTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                bool result = DbHandler.LogBackup();
                if (!result)
                {
                    System.Diagnostics.Debug.WriteLine("Auto log backup failed.");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Auto log backup completed successfully.");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error during auto log backup: {ex.Message}");
            }
        }

        #endregion
    }
}