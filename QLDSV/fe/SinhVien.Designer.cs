namespace QLDSV.fe
{
    partial class SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.side = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.XD = new System.Windows.Forms.Button();
            this.DKLTC = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.FlowLayoutPanel();
            this.side.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý điểm sinh viên";
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.Indigo;
            this.side.Controls.Add(this.Logout);
            this.side.Controls.Add(this.XD);
            this.side.Controls.Add(this.DKLTC);
            this.side.Controls.Add(this.role);
            this.side.Controls.Add(this.username);
            this.side.Dock = System.Windows.Forms.DockStyle.Left;
            this.side.Location = new System.Drawing.Point(0, 55);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(253, 884);
            this.side.TabIndex = 2;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(61, 829);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(122, 52);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // XD
            // 
            this.XD.FlatAppearance.BorderSize = 0;
            this.XD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.XD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.XD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.XD.ForeColor = System.Drawing.Color.White;
            this.XD.Location = new System.Drawing.Point(0, 441);
            this.XD.Name = "XD";
            this.XD.Size = new System.Drawing.Size(250, 52);
            this.XD.TabIndex = 8;
            this.XD.Text = "Xem điểm";
            this.XD.UseVisualStyleBackColor = true;
            this.XD.Click += new System.EventHandler(this.XD_Click);
            // 
            // DKLTC
            // 
            this.DKLTC.FlatAppearance.BorderSize = 0;
            this.DKLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DKLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DKLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DKLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DKLTC.ForeColor = System.Drawing.Color.White;
            this.DKLTC.Location = new System.Drawing.Point(3, 383);
            this.DKLTC.Name = "DKLTC";
            this.DKLTC.Size = new System.Drawing.Size(250, 52);
            this.DKLTC.TabIndex = 7;
            this.DKLTC.Text = "Đăng ký lớp tín chỉ";
            this.DKLTC.UseVisualStyleBackColor = true;
            this.DKLTC.Click += new System.EventHandler(this.DKLTC_Click);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(89, 115);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(57, 26);
            this.role.TabIndex = 6;
            this.role.Text = "Role";
            this.role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(17, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(219, 32);
            this.username.TabIndex = 5;
            this.username.Text = "Username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1464, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 35);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 55);
            this.panel1.TabIndex = 1;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(253, 55);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1257, 884);
            this.content.TabIndex = 4;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1510, 939);
            this.Controls.Add(this.content);
            this.Controls.Add(this.side);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            this.side.ResumeLayout(false);
            this.side.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel side;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button DKLTC;
        private System.Windows.Forms.Button XD;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel content;
    }
}