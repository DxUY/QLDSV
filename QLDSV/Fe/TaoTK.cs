using QLDSV.Be;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.Fe
{
    public partial class TaoTK : UserControl
    {
        private string userRole;
        private bool isAddingTK;
        private bool isDeletingTK;
        private readonly Control[] inputs;

        public TaoTK(string role)
        {
            InitializeComponent();
            userRole = role;
            inputs = new Control[] { accName, accPassword, rolesComboBox };
        }

        #region Button Events

        private void createTK_Click(object sender, EventArgs e)
        {
            if (isDeletingTK)
            {
                MessageBox.Show("Bạn đang trong chế độ xóa tài khoản. Hãy hủy thao tác trước.");
                return;
            }

            if (!isAddingTK)
            {
                StartCreateMode();
                return;
            }

            try
            {
                var data = GetTKDataFromForm();
                if (Validation.IsInputComplete(data) && DbHandler.CreateLoginAndUser(data))
                {
                    MessageBox.Show("Tạo tài khoản thành công.");
                    ExitEditMode();
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo tài khoản: " + ex.Message);
                ExitEditMode();
            }
        }

        private void deleteTK_Click(object sender, EventArgs e)
        {
            if (userRole == "KHOA")
            {
                MessageBox.Show("Bạn không có quyền xóa.");
                return;
            }

            if (isAddingTK)
            {
                MessageBox.Show("Bạn đang trong chế độ tạo tài khoản. Hãy hủy thao tác trước.");
                return;
            }

            if (!isDeletingTK)
            {
                StartDeleteMode();
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản '" + accUsername.Text + "'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes &&
                DbHandler.DeleteLoginAndUser(accUsername.Text.Trim()))
            {
                MessageBox.Show("Tài khoản đã được xóa thành công.");
                ExitEditMode();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại.");
            }
        }

        private void cancelTK_Click(object sender, EventArgs e)
        {
            if (isAddingTK || isDeletingTK)
            {
                ExitEditMode();
                MessageBox.Show("Đã hủy thao tác.");
            }
        }

        #endregion

        #region Helper Methods

        private void StartCreateMode()
        {
            isAddingTK = true;
            LoadGVComboBox(false);
            LoadRolesComboBox(userRole);

            if (accName.Items.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để tạo tài khoản.");
                isAddingTK = false;
                return;
            }

            accName.SelectedIndex = accName.SelectedIndex == -1 ? 0 : accName.SelectedIndex;
            accUsername.Text = accName.SelectedValue?.ToString() ?? "";
            Utils.SetFieldEditability(true, inputs);
            accPassword.Enabled = true;
        }

        private void StartDeleteMode()
        {
            isDeletingTK = true;
            LoadGVComboBox(true);
            accName.Enabled = true;
            Utils.SetFieldEditability(false, inputs);

            if (accName.SelectedValue is string magv)
            {
                AddToForm(magv);
            }
        }

        private void ExitEditMode()
        {
            isAddingTK = false;
            isDeletingTK = false;
            ClearAndDisableForm();
            accName.Enabled = false;
        }

        private void LoadRolesComboBox(string role)
        {
            var dt = DbHandler.ExecuteStoredProcedure("sp_GetRolesByUser", "Lỗi khi lấy vai trò", false, new SqlParameter("@Role", role));

            rolesComboBox.DataSource = dt;
            rolesComboBox.DisplayMember = rolesComboBox.ValueMember = "RoleName";
            if (rolesComboBox.Items.Count > 0) rolesComboBox.SelectedIndex = 0;
        }

        private void LoadGVComboBox(bool exists)
        {
            var dt = DbHandler.GetExistenceList(exists);
            if (dt == null || dt.Rows.Count == 0)
            {
                accName.DataSource = null;
                return;
            }

            if (!dt.Columns.Contains("FULLNAME"))
                dt.Columns.Add("FULLNAME", typeof(string), "HO + ' ' + TEN");

            accName.DataSource = dt;
            accName.DisplayMember = "FULLNAME";
            accName.ValueMember = "MAGV";

            if (accName.Items.Count > 0) accName.SelectedIndex = 0;
        }

        private void accName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accName.SelectedValue is string magv)
            {
                accUsername.Text = magv;
                if (isDeletingTK) AddToForm(magv);
            }
        }

        private void AddToForm(string magv)
        {
            var dt = DbHandler.ExecuteStoredProcedure("sp_GetAccountInfoByMAGV", "Lỗi khi lấy thông tin tài khoản", false, new SqlParameter("@MAGV", magv));
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản cho giảng viên này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dt.Rows[0];
            accUsername.Text = row["USERNAME"].ToString();
            accName.Text = row["FullName"].ToString();
            rolesComboBox.DataSource = new List<string> { row["ROLE"].ToString() };
            rolesComboBox.SelectedIndex = 0;

            Utils.SetFieldEditability(false, inputs);
            accName.Enabled = true;
        }

        private void ClearTKFormFields()
        {
            accName.DataSource = null;
            accUsername.Clear();
            accPassword.Clear();
            rolesComboBox.DataSource = null;
        }

        private void ClearAndDisableForm()
        {
            ClearTKFormFields();
            Utils.SetFieldEditability(false, inputs);
        }

        private Dictionary<string, string> GetTKDataFromForm()
        {
            return new Dictionary<string, string>
            {
                { "TEN", accName.Text.Trim() },
                { "USERNAME", accUsername.Text.Trim() },
                { "PASSWORD", accPassword.Text.Trim() },
                { "ROLE", rolesComboBox.SelectedValue?.ToString() }
            };
        }

        #endregion
    }
}