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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MH = new System.Windows.Forms.Button();
            this.DSSV = new System.Windows.Forms.Button();
            this.DML = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý điểm sinh viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.MH);
            this.panel2.Controls.Add(this.DSSV);
            this.panel2.Controls.Add(this.DML);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 599);
            this.panel2.TabIndex = 2;
            // 
            // MH
            // 
            this.MH.BackColor = System.Drawing.Color.Indigo;
            this.MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MH.ForeColor = System.Drawing.Color.White;
            this.MH.Location = new System.Drawing.Point(0, 265);
            this.MH.Name = "MH";
            this.MH.Size = new System.Drawing.Size(273, 47);
            this.MH.TabIndex = 2;
            this.MH.Text = "Môn học";
            this.MH.UseVisualStyleBackColor = false;
            // 
            // DSSV
            // 
            this.DSSV.BackColor = System.Drawing.Color.Indigo;
            this.DSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DSSV.ForeColor = System.Drawing.Color.White;
            this.DSSV.Location = new System.Drawing.Point(0, 212);
            this.DSSV.Name = "DSSV";
            this.DSSV.Size = new System.Drawing.Size(273, 47);
            this.DSSV.TabIndex = 1;
            this.DSSV.Text = "Danh sách sinh viên";
            this.DSSV.UseVisualStyleBackColor = false;
            // 
            // DML
            // 
            this.DML.BackColor = System.Drawing.Color.Indigo;
            this.DML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DML.ForeColor = System.Drawing.Color.White;
            this.DML.Location = new System.Drawing.Point(0, 159);
            this.DML.Name = "DML";
            this.DML.Size = new System.Drawing.Size(273, 47);
            this.DML.TabIndex = 0;
            this.DML.Text = "Danh mục lớp";
            this.DML.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1142, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 39);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MH;
        private System.Windows.Forms.Button DSSV;
        private System.Windows.Forms.Button DML;
        private System.Windows.Forms.Button exit;
    }
}