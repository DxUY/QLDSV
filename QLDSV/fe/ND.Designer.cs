namespace QLDSV.fe
{
    partial class ND
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.khoaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.nhomComboBox = new System.Windows.Forms.ComboBox();
            this.mhComboBox = new System.Windows.Forms.ComboBox();
            this.hkComboBox = new System.Windows.Forms.ComboBox();
            this.nkComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sub = new System.Windows.Forms.DataGridView();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.DataGridView();
            this.dANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.dANGKYTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.lOPTINCHITableAdapter = new QLDSV.QLDSVDataSetTableAdapters.LOPTINCHITableAdapter();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM_GK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM_CK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.khoaComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 87);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(387, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "KHOA";
            // 
            // khoaComboBox
            // 
            this.khoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.khoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.khoaComboBox.FormattingEnabled = true;
            this.khoaComboBox.Location = new System.Drawing.Point(463, 41);
            this.khoaComboBox.Name = "khoaComboBox";
            this.khoaComboBox.Size = new System.Drawing.Size(380, 33);
            this.khoaComboBox.TabIndex = 6;
            this.khoaComboBox.SelectedIndexChanged += new System.EventHandler(this.khoaComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(220, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhập điểm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.start);
            this.panel2.Controls.Add(this.nhomComboBox);
            this.panel2.Controls.Add(this.mhComboBox);
            this.panel2.Controls.Add(this.hkComboBox);
            this.panel2.Controls.Add(this.nkComboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 401);
            this.panel2.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Indigo;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(541, 324);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(110, 59);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Indigo;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(286, 324);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 59);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Indigo;
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(38, 324);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(110, 59);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // nhomComboBox
            // 
            this.nhomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhomComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nhomComboBox.FormattingEnabled = true;
            this.nhomComboBox.Location = new System.Drawing.Point(479, 239);
            this.nhomComboBox.Name = "nhomComboBox";
            this.nhomComboBox.Size = new System.Drawing.Size(172, 33);
            this.nhomComboBox.TabIndex = 11;
            // 
            // mhComboBox
            // 
            this.mhComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mhComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mhComboBox.FormattingEnabled = true;
            this.mhComboBox.Location = new System.Drawing.Point(163, 239);
            this.mhComboBox.Name = "mhComboBox";
            this.mhComboBox.Size = new System.Drawing.Size(172, 33);
            this.mhComboBox.TabIndex = 10;
            this.mhComboBox.SelectedIndexChanged += new System.EventHandler(this.mhComboBox_SelectedIndexChanged);
            // 
            // hkComboBox
            // 
            this.hkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hkComboBox.FormattingEnabled = true;
            this.hkComboBox.Location = new System.Drawing.Point(479, 118);
            this.hkComboBox.Name = "hkComboBox";
            this.hkComboBox.Size = new System.Drawing.Size(172, 33);
            this.hkComboBox.TabIndex = 9;
            this.hkComboBox.SelectedIndexChanged += new System.EventHandler(this.hkComboBox_SelectedIndexChanged);
            // 
            // nkComboBox
            // 
            this.nkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nkComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nkComboBox.FormattingEnabled = true;
            this.nkComboBox.Location = new System.Drawing.Point(163, 118);
            this.nkComboBox.Name = "nkComboBox";
            this.nkComboBox.Size = new System.Drawing.Size(172, 33);
            this.nkComboBox.TabIndex = 8;
            this.nkComboBox.SelectedIndexChanged += new System.EventHandler(this.nkComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(401, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nhóm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(401, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Học kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(28, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(48, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Niên khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập thông tin";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.sub);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(717, 96);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(536, 401);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // sub
            // 
            this.sub.AllowUserToAddRows = false;
            this.sub.AllowUserToDeleteRows = false;
            this.sub.AllowUserToResizeColumns = false;
            this.sub.AllowUserToResizeRows = false;
            this.sub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sub.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC,
            this.TENMH,
            this.GV});
            this.sub.Location = new System.Drawing.Point(3, 3);
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            this.sub.RowHeadersWidth = 51;
            this.sub.RowTemplate.Height = 24;
            this.sub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sub.Size = new System.Drawing.Size(529, 391);
            this.sub.TabIndex = 0;
            // 
            // MALTC
            // 
            this.MALTC.DataPropertyName = "MALTC";
            this.MALTC.HeaderText = "Mã lớp tín chỉ";
            this.MALTC.MinimumWidth = 6;
            this.MALTC.Name = "MALTC";
            this.MALTC.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Tên môn học";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // GV
            // 
            this.GV.DataPropertyName = "HOTEN";
            this.GV.HeaderText = "Giảng Viên";
            this.GV.MinimumWidth = 6;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.main);
            this.panel3.Location = new System.Drawing.Point(3, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 378);
            this.panel3.TabIndex = 5;
            // 
            // main
            // 
            this.main.AllowUserToAddRows = false;
            this.main.AllowUserToDeleteRows = false;
            this.main.AllowUserToResizeColumns = false;
            this.main.AllowUserToResizeRows = false;
            this.main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.main.BackgroundColor = System.Drawing.SystemColors.Control;
            this.main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOTEN,
            this.DIEM_CC,
            this.DIEM_GK,
            this.DIEM_CK,
            this.DIEM_TK});
            this.main.Location = new System.Drawing.Point(3, 3);
            this.main.Name = "main";
            this.main.RowHeadersWidth = 51;
            this.main.RowTemplate.Height = 24;
            this.main.Size = new System.Drawing.Size(1243, 370);
            this.main.TabIndex = 0;
            this.main.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_CellEndEdit);
            this.main.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Main_EditingControlShowing);
            // 
            // dANGKYBindingSource
            // 
            this.dANGKYBindingSource.DataMember = "DANGKY";
            this.dANGKYBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.dANGKYTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã SV";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên SV";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // DIEM_CC
            // 
            this.DIEM_CC.DataPropertyName = "DIEM_CC";
            this.DIEM_CC.HeaderText = "Điểm Chuyên cần";
            this.DIEM_CC.MinimumWidth = 6;
            this.DIEM_CC.Name = "DIEM_CC";
            // 
            // DIEM_GK
            // 
            this.DIEM_GK.DataPropertyName = "DIEM_GK";
            this.DIEM_GK.HeaderText = "Điểm Giữa Kỳ";
            this.DIEM_GK.MinimumWidth = 6;
            this.DIEM_GK.Name = "DIEM_GK";
            // 
            // DIEM_CK
            // 
            this.DIEM_CK.DataPropertyName = "DIEM_CK";
            this.DIEM_CK.HeaderText = "Điểm Cuối Kì";
            this.DIEM_CK.MinimumWidth = 6;
            this.DIEM_CK.Name = "DIEM_CK";
            // 
            // DIEM_TK
            // 
            this.DIEM_TK.DataPropertyName = "DIEM_TK";
            this.DIEM_TK.HeaderText = "Điểm tổng kết";
            this.DIEM_TK.MinimumWidth = 6;
            this.DIEM_TK.Name = "DIEM_TK";
            this.DIEM_TK.ReadOnly = true;
            // 
            // ND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ND";
            this.Size = new System.Drawing.Size(1257, 884);
            this.Load += new System.EventHandler(this.ND_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sub)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox khoaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox nhomComboBox;
        private System.Windows.Forms.ComboBox mhComboBox;
        private System.Windows.Forms.ComboBox hkComboBox;
        private System.Windows.Forms.ComboBox nkComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource dANGKYBindingSource;
        private QLDSVDataSetTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sub;
        private QLDSVDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV;
        private System.Windows.Forms.DataGridView main;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_GK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_CK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM_TK;
    }
}
