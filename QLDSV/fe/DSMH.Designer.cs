namespace QLDSV.fe
{
    partial class DSMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSMH));
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.monHocTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.MonHocTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataMH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMH = new System.Windows.Forms.Button();
            this.deleteMH = new System.Windows.Forms.Button();
            this.resMH = new System.Windows.Forms.Button();
            this.saveMH = new System.Windows.Forms.Button();
            this.exitMH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thPeriodInput = new System.Windows.Forms.NumericUpDown();
            this.ltPeriodInput = new System.Windows.Forms.NumericUpDown();
            this.nameMHInput = new System.Windows.Forms.TextBox();
            this.idMHInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.Panel();
            this.search_main = new System.Windows.Forms.TextBox();
            this.editMH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMH)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thPeriodInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltPeriodInput)).BeginInit();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = this.monHocTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataMH);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 585);
            this.panel2.TabIndex = 5;
            // 
            // dataMH
            // 
            this.dataMH.AllowUserToAddRows = false;
            this.dataMH.AllowUserToDeleteRows = false;
            this.dataMH.AllowUserToResizeColumns = false;
            this.dataMH.AllowUserToResizeRows = false;
            this.dataMH.AutoGenerateColumns = false;
            this.dataMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataMH.DataSource = this.monHocBindingSource;
            this.dataMH.Location = new System.Drawing.Point(2, 0);
            this.dataMH.Name = "dataMH";
            this.dataMH.ReadOnly = true;
            this.dataMH.RowHeadersWidth = 51;
            this.dataMH.RowTemplate.Height = 24;
            this.dataMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMH.Size = new System.Drawing.Size(1251, 580);
            this.dataMH.TabIndex = 0;
            this.dataMH.SelectionChanged += new System.EventHandler(this.dataMH_SelectionChanged);
            this.dataMH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataMH_MouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAMH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAMH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOTIET_LT";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOTIET_LT";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SOTIET_TH";
            this.dataGridViewTextBoxColumn4.HeaderText = "SOTIET_TH";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // addMH
            // 
            this.addMH.AutoSize = true;
            this.addMH.BackColor = System.Drawing.Color.Indigo;
            this.addMH.FlatAppearance.BorderSize = 0;
            this.addMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.addMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.addMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMH.ForeColor = System.Drawing.Color.White;
            this.addMH.Image = ((System.Drawing.Image)(resources.GetObject("addMH.Image")));
            this.addMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMH.Location = new System.Drawing.Point(15, 6);
            this.addMH.Margin = new System.Windows.Forms.Padding(3, 2, 50, 3);
            this.addMH.Name = "addMH";
            this.addMH.Size = new System.Drawing.Size(84, 46);
            this.addMH.TabIndex = 0;
            this.addMH.Text = "Thêm";
            this.addMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addMH.UseVisualStyleBackColor = false;
            this.addMH.Click += new System.EventHandler(this.addMH_Click);
            // 
            // deleteMH
            // 
            this.deleteMH.AutoSize = true;
            this.deleteMH.BackColor = System.Drawing.Color.Indigo;
            this.deleteMH.FlatAppearance.BorderSize = 0;
            this.deleteMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.deleteMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.deleteMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMH.ForeColor = System.Drawing.Color.White;
            this.deleteMH.Image = ((System.Drawing.Image)(resources.GetObject("deleteMH.Image")));
            this.deleteMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteMH.Location = new System.Drawing.Point(289, 6);
            this.deleteMH.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.deleteMH.Name = "deleteMH";
            this.deleteMH.Size = new System.Drawing.Size(73, 46);
            this.deleteMH.TabIndex = 1;
            this.deleteMH.Text = "Xóa";
            this.deleteMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteMH.UseVisualStyleBackColor = false;
            this.deleteMH.Click += new System.EventHandler(this.deleteMH_Click);
            // 
            // resMH
            // 
            this.resMH.AutoSize = true;
            this.resMH.BackColor = System.Drawing.Color.Indigo;
            this.resMH.FlatAppearance.BorderSize = 0;
            this.resMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.resMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.resMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resMH.ForeColor = System.Drawing.Color.White;
            this.resMH.Image = ((System.Drawing.Image)(resources.GetObject("resMH.Image")));
            this.resMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resMH.Location = new System.Drawing.Point(415, 6);
            this.resMH.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.resMH.Name = "resMH";
            this.resMH.Size = new System.Drawing.Size(101, 46);
            this.resMH.TabIndex = 3;
            this.resMH.Text = "Phục hồi";
            this.resMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resMH.UseVisualStyleBackColor = false;
            this.resMH.Click += new System.EventHandler(this.resMH_Click);
            // 
            // saveMH
            // 
            this.saveMH.AutoSize = true;
            this.saveMH.BackColor = System.Drawing.Color.Indigo;
            this.saveMH.FlatAppearance.BorderSize = 0;
            this.saveMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.saveMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.saveMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMH.ForeColor = System.Drawing.Color.White;
            this.saveMH.Image = ((System.Drawing.Image)(resources.GetObject("saveMH.Image")));
            this.saveMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveMH.Location = new System.Drawing.Point(569, 6);
            this.saveMH.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.saveMH.Name = "saveMH";
            this.saveMH.Size = new System.Drawing.Size(75, 46);
            this.saveMH.TabIndex = 5;
            this.saveMH.Text = "Ghi";
            this.saveMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveMH.UseVisualStyleBackColor = false;
            this.saveMH.Click += new System.EventHandler(this.saveMH_Click);
            // 
            // exitMH
            // 
            this.exitMH.AutoSize = true;
            this.exitMH.BackColor = System.Drawing.Color.Indigo;
            this.exitMH.FlatAppearance.BorderSize = 0;
            this.exitMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.exitMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.exitMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMH.ForeColor = System.Drawing.Color.White;
            this.exitMH.Image = ((System.Drawing.Image)(resources.GetObject("exitMH.Image")));
            this.exitMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitMH.Location = new System.Drawing.Point(697, 6);
            this.exitMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitMH.Name = "exitMH";
            this.exitMH.Size = new System.Drawing.Size(85, 46);
            this.exitMH.TabIndex = 6;
            this.exitMH.Text = "Thoát";
            this.exitMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitMH.UseVisualStyleBackColor = false;
            this.exitMH.Click += new System.EventHandler(this.exitMH_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.thPeriodInput);
            this.panel1.Controls.Add(this.ltPeriodInput);
            this.panel1.Controls.Add(this.nameMHInput);
            this.panel1.Controls.Add(this.idMHInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 656);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 253);
            this.panel1.TabIndex = 6;
            // 
            // thPeriodInput
            // 
            this.thPeriodInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thPeriodInput.Location = new System.Drawing.Point(887, 139);
            this.thPeriodInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thPeriodInput.Name = "thPeriodInput";
            this.thPeriodInput.ReadOnly = true;
            this.thPeriodInput.Size = new System.Drawing.Size(228, 30);
            this.thPeriodInput.TabIndex = 11;
            // 
            // ltPeriodInput
            // 
            this.ltPeriodInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ltPeriodInput.Location = new System.Drawing.Point(375, 136);
            this.ltPeriodInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltPeriodInput.Name = "ltPeriodInput";
            this.ltPeriodInput.ReadOnly = true;
            this.ltPeriodInput.Size = new System.Drawing.Size(228, 30);
            this.ltPeriodInput.TabIndex = 10;
            // 
            // nameMHInput
            // 
            this.nameMHInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameMHInput.Location = new System.Drawing.Point(887, 82);
            this.nameMHInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameMHInput.Name = "nameMHInput";
            this.nameMHInput.Size = new System.Drawing.Size(228, 30);
            this.nameMHInput.TabIndex = 9;
            // 
            // idMHInput
            // 
            this.idMHInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idMHInput.Location = new System.Drawing.Point(375, 82);
            this.idMHInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idMHInput.Name = "idMHInput";
            this.idMHInput.Size = new System.Drawing.Size(228, 30);
            this.idMHInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(690, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiết thực hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(690, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(208, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số tiết lý thuyết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(208, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin môn học";
            // 
            // buttons
            // 
            this.buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttons.Controls.Add(this.search_main);
            this.buttons.Controls.Add(this.editMH);
            this.buttons.Controls.Add(this.exitMH);
            this.buttons.Controls.Add(this.saveMH);
            this.buttons.Controls.Add(this.addMH);
            this.buttons.Controls.Add(this.deleteMH);
            this.buttons.Controls.Add(this.resMH);
            this.buttons.Location = new System.Drawing.Point(3, 3);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(1251, 62);
            this.buttons.TabIndex = 1;
            // 
            // search_main
            // 
            this.search_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.search_main.Location = new System.Drawing.Point(1008, 22);
            this.search_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.search_main.Name = "search_main";
            this.search_main.Size = new System.Drawing.Size(238, 30);
            this.search_main.TabIndex = 13;
            this.search_main.Text = "search....";
            this.search_main.TextChanged += new System.EventHandler(this.searchMain_TextChanged);
            // 
            // editMH
            // 
            this.editMH.AutoSize = true;
            this.editMH.BackColor = System.Drawing.Color.Indigo;
            this.editMH.FlatAppearance.BorderSize = 0;
            this.editMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.editMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.editMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMH.ForeColor = System.Drawing.Color.White;
            this.editMH.Image = ((System.Drawing.Image)(resources.GetObject("editMH.Image")));
            this.editMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editMH.Location = new System.Drawing.Point(152, 6);
            this.editMH.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.editMH.Name = "editMH";
            this.editMH.Size = new System.Drawing.Size(84, 46);
            this.editMH.TabIndex = 8;
            this.editMH.Text = "Sửa";
            this.editMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editMH.UseVisualStyleBackColor = false;
            this.editMH.Click += new System.EventHandler(this.editMH_Click);
            // 
            // DSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSMH";
            this.Size = new System.Drawing.Size(1257, 884);
            this.Load += new System.EventHandler(this.DSMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thPeriodInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltPeriodInput)).EndInit();
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLDSVDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addMH;
        private System.Windows.Forms.Button deleteMH;
        private System.Windows.Forms.Button resMH;
        private System.Windows.Forms.Button saveMH;
        private System.Windows.Forms.Button exitMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown thPeriodInput;
        private System.Windows.Forms.NumericUpDown ltPeriodInput;
        private System.Windows.Forms.TextBox nameMHInput;
        private System.Windows.Forms.TextBox idMHInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel buttons;
        private System.Windows.Forms.DataGridView dataMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button editMH;
        private System.Windows.Forms.TextBox search_main;
    }
}
