namespace QLDSV.Fe
{
    partial class TaoTK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accUsername = new System.Windows.Forms.TextBox();
            this.accPassword = new System.Windows.Forms.TextBox();
            this.createTK = new System.Windows.Forms.Button();
            this.deleteTK = new System.Windows.Forms.Button();
            this.accName = new System.Windows.Forms.ComboBox();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.cancelTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản đăng nhập ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(164, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên chủ tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(164, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(164, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(164, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhóm quyền";
            // 
            // accUsername
            // 
            this.accUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accUsername.Location = new System.Drawing.Point(418, 303);
            this.accUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accUsername.Name = "accUsername";
            this.accUsername.ReadOnly = true;
            this.accUsername.Size = new System.Drawing.Size(384, 30);
            this.accUsername.TabIndex = 9;
            // 
            // accPassword
            // 
            this.accPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accPassword.Location = new System.Drawing.Point(418, 426);
            this.accPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accPassword.Name = "accPassword";
            this.accPassword.ReadOnly = true;
            this.accPassword.Size = new System.Drawing.Size(384, 30);
            this.accPassword.TabIndex = 10;
            // 
            // createTK
            // 
            this.createTK.BackColor = System.Drawing.Color.Indigo;
            this.createTK.FlatAppearance.BorderSize = 0;
            this.createTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.createTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.createTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createTK.ForeColor = System.Drawing.Color.White;
            this.createTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createTK.Location = new System.Drawing.Point(131, 727);
            this.createTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTK.Name = "createTK";
            this.createTK.Size = new System.Drawing.Size(156, 79);
            this.createTK.TabIndex = 14;
            this.createTK.Text = "Tạo tài khoản";
            this.createTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createTK.UseVisualStyleBackColor = false;
            this.createTK.Click += new System.EventHandler(this.createTK_Click);
            // 
            // deleteTK
            // 
            this.deleteTK.BackColor = System.Drawing.Color.Indigo;
            this.deleteTK.FlatAppearance.BorderSize = 0;
            this.deleteTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.deleteTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.deleteTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteTK.ForeColor = System.Drawing.Color.White;
            this.deleteTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTK.Location = new System.Drawing.Point(538, 727);
            this.deleteTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteTK.Name = "deleteTK";
            this.deleteTK.Size = new System.Drawing.Size(156, 79);
            this.deleteTK.TabIndex = 15;
            this.deleteTK.Text = "Xóa tài khoản";
            this.deleteTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteTK.UseVisualStyleBackColor = false;
            this.deleteTK.Click += new System.EventHandler(this.deleteTK_Click);
            // 
            // accName
            // 
            this.accName.Enabled = false;
            this.accName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accName.FormattingEnabled = true;
            this.accName.Location = new System.Drawing.Point(418, 196);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(384, 33);
            this.accName.TabIndex = 18;
            this.accName.SelectedIndexChanged += new System.EventHandler(this.accName_SelectedIndexChanged);
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Enabled = false;
            this.rolesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(418, 558);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(384, 33);
            this.rolesComboBox.TabIndex = 19;
            // 
            // cancelTK
            // 
            this.cancelTK.BackColor = System.Drawing.Color.Indigo;
            this.cancelTK.FlatAppearance.BorderSize = 0;
            this.cancelTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.cancelTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.cancelTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelTK.ForeColor = System.Drawing.Color.White;
            this.cancelTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelTK.Location = new System.Drawing.Point(966, 727);
            this.cancelTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelTK.Name = "cancelTK";
            this.cancelTK.Size = new System.Drawing.Size(156, 79);
            this.cancelTK.TabIndex = 20;
            this.cancelTK.Text = "Hủy";
            this.cancelTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelTK.UseVisualStyleBackColor = false;
            this.cancelTK.Click += new System.EventHandler(this.cancelTK_Click);
            // 
            // TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelTK);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.deleteTK);
            this.Controls.Add(this.createTK);
            this.Controls.Add(this.accPassword);
            this.Controls.Add(this.accUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaoTK";
            this.Size = new System.Drawing.Size(1257, 884);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accUsername;
        private System.Windows.Forms.TextBox accPassword;
        private System.Windows.Forms.Button createTK;
        private System.Windows.Forms.Button deleteTK;
        private System.Windows.Forms.ComboBox accName;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Button cancelTK;
    }
}
