namespace QLDSV.fe
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sv = new System.Windows.Forms.RadioButton();
            this.gv = new System.Windows.Forms.RadioButton();
            this.loginBtn = new System.Windows.Forms.Button();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 450);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 80);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quản lý điểm sinh viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(409, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(229, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(233, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // sv
            // 
            this.sv.AutoSize = true;
            this.sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sv.Location = new System.Drawing.Point(325, 77);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(114, 29);
            this.sv.TabIndex = 4;
            this.sv.TabStop = true;
            this.sv.Text = "Sinh viên";
            this.sv.UseVisualStyleBackColor = true;
            this.sv.CheckedChanged += new System.EventHandler(this.sv_CheckedChanged);
            // 
            // gv
            // 
            this.gv.AutoSize = true;
            this.gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gv.Location = new System.Drawing.Point(522, 77);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(126, 29);
            this.gv.TabIndex = 5;
            this.gv.TabStop = true;
            this.gv.Text = "Giảng viên";
            this.gv.UseVisualStyleBackColor = true;
            this.gv.CheckedChanged += new System.EventHandler(this.gv_CheckedChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Indigo;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(410, 349);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(145, 59);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // login_username
            // 
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_username.Location = new System.Drawing.Point(234, 149);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(468, 38);
            this.login_username.TabIndex = 8;
            // 
            // login_password
            // 
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_password.Location = new System.Drawing.Point(234, 245);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(468, 38);
            this.login_password.TabIndex = 9;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showPass.Location = new System.Drawing.Point(522, 301);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(159, 29);
            this.showPass.TabIndex = 10;
            this.showPass.Text = "Hiện mật khẩu";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(715, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 31);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.sv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sv;
        private System.Windows.Forms.RadioButton gv;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button exit;
    }
}