namespace QLDSV.fe
{
    partial class GiangVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiangVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DML = new System.Windows.Forms.Button();
            this.DSMH = new System.Windows.Forms.Button();
            this.ND = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DSLTC = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dml1 = new QLDSV.fe.DML();
            this.space = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.space.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 55);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1301, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 39);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý điểm sinh viên";
            // 
            // DML
            // 
            this.DML.FlatAppearance.BorderSize = 0;
            this.DML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DML.ForeColor = System.Drawing.Color.White;
            this.DML.Location = new System.Drawing.Point(-3, 187);
            this.DML.Name = "DML";
            this.DML.Size = new System.Drawing.Size(250, 52);
            this.DML.TabIndex = 0;
            this.DML.Text = "Danh mục lớp";
            this.DML.UseVisualStyleBackColor = true;
            this.DML.Click += new System.EventHandler(this.DML_Click);
            // 
            // DSMH
            // 
            this.DSMH.FlatAppearance.BorderSize = 0;
            this.DSMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DSMH.ForeColor = System.Drawing.Color.White;
            this.DSMH.Location = new System.Drawing.Point(-3, 245);
            this.DSMH.Name = "DSMH";
            this.DSMH.Size = new System.Drawing.Size(253, 52);
            this.DSMH.TabIndex = 2;
            this.DSMH.Text = "Danh sách môn học";
            this.DSMH.UseVisualStyleBackColor = true;
            // 
            // ND
            // 
            this.ND.FlatAppearance.BorderSize = 0;
            this.ND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ND.ForeColor = System.Drawing.Color.White;
            this.ND.Location = new System.Drawing.Point(0, 361);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(253, 52);
            this.ND.TabIndex = 3;
            this.ND.Text = "Nhập điểm";
            this.ND.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.DSLTC);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.ND);
            this.panel2.Controls.Add(this.DSMH);
            this.panel2.Controls.Add(this.DML);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 714);
            this.panel2.TabIndex = 2;
            // 
            // DSLTC
            // 
            this.DSLTC.FlatAppearance.BorderSize = 0;
            this.DSLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DSLTC.ForeColor = System.Drawing.Color.White;
            this.DSLTC.Location = new System.Drawing.Point(0, 303);
            this.DSLTC.Name = "DSLTC";
            this.DSLTC.Size = new System.Drawing.Size(253, 52);
            this.DSLTC.TabIndex = 6;
            this.DSLTC.Text = "Danh sách lớp tín chỉ";
            this.DSLTC.UseVisualStyleBackColor = true;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(53, 74);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(127, 26);
            this.role.TabIndex = 5;
            this.role.Text = "Placeholder";
            this.role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(22, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(192, 32);
            this.name.TabIndex = 4;
            this.name.Text = "Placeholder";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dml1
            // 
            this.dml1.Location = new System.Drawing.Point(0, 0);
            this.dml1.Name = "dml1";
            this.dml1.Size = new System.Drawing.Size(1085, 711);
            this.dml1.TabIndex = 0;
            // 
            // space
            // 
            this.space.Controls.Add(this.dml1);
            this.space.Location = new System.Drawing.Point(253, 55);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(1085, 714);
            this.space.TabIndex = 3;
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(50, 659);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(164, 52);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 769);
            this.Controls.Add(this.space);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.space.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button DML;
        private System.Windows.Forms.Button DSMH;
        private System.Windows.Forms.Button ND;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DSLTC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DML dml1;
        private System.Windows.Forms.Panel space;
        private System.Windows.Forms.Button Logout;
    }
}