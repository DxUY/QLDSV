namespace QLDSV.fe
{
    partial class DSLTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSLTC));
            this.buttons = new System.Windows.Forms.Panel();
            this.search_main = new System.Windows.Forms.TextBox();
            this.editLTC = new System.Windows.Forms.Button();
            this.exitLTC = new System.Windows.Forms.Button();
            this.saveLTC = new System.Windows.Forms.Button();
            this.resLTC = new System.Windows.Forms.Button();
            this.deleteLTC = new System.Windows.Forms.Button();
            this.addLTC = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataLTC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.khoaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.semesterInput = new System.Windows.Forms.NumericUpDown();
            this.cancelClassCheck = new System.Windows.Forms.CheckBox();
            this.groupInput = new System.Windows.Forms.NumericUpDown();
            this.gvIdInput = new System.Windows.Forms.TextBox();
            this.mhIdInput = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gvComboBox = new System.Windows.Forms.ComboBox();
            this.mhComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minSVInput = new System.Windows.Forms.NumericUpDown();
            this.khoaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lOPTINCHITableAdapter = new QLDSV.QLDSVDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.buttons.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSVInput)).BeginInit();
            this.SuspendLayout();
            // 
            // buttons
            // 
            this.buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttons.Controls.Add(this.search_main);
            this.buttons.Controls.Add(this.editLTC);
            this.buttons.Controls.Add(this.exitLTC);
            this.buttons.Controls.Add(this.saveLTC);
            this.buttons.Controls.Add(this.resLTC);
            this.buttons.Controls.Add(this.deleteLTC);
            this.buttons.Controls.Add(this.addLTC);
            this.buttons.Location = new System.Drawing.Point(3, 3);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(1251, 66);
            this.buttons.TabIndex = 4;
            // 
            // search_main
            // 
            this.search_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.search_main.Location = new System.Drawing.Point(1008, 24);
            this.search_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.search_main.Name = "search_main";
            this.search_main.Size = new System.Drawing.Size(238, 30);
            this.search_main.TabIndex = 14;
            this.search_main.Text = "search....";
            this.search_main.TextChanged += new System.EventHandler(this.searchMain_TextChanged);
            // 
            // editLTC
            // 
            this.editLTC.AutoSize = true;
            this.editLTC.BackColor = System.Drawing.Color.Indigo;
            this.editLTC.FlatAppearance.BorderSize = 0;
            this.editLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.editLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.editLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLTC.ForeColor = System.Drawing.Color.White;
            this.editLTC.Image = ((System.Drawing.Image)(resources.GetObject("editLTC.Image")));
            this.editLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editLTC.Location = new System.Drawing.Point(154, 8);
            this.editLTC.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.editLTC.Name = "editLTC";
            this.editLTC.Size = new System.Drawing.Size(84, 46);
            this.editLTC.TabIndex = 9;
            this.editLTC.Text = "Sửa";
            this.editLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editLTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editLTC.UseVisualStyleBackColor = false;
            this.editLTC.Click += new System.EventHandler(this.editLTC_Click);
            // 
            // exitLTC
            // 
            this.exitLTC.AutoSize = true;
            this.exitLTC.BackColor = System.Drawing.Color.Indigo;
            this.exitLTC.FlatAppearance.BorderSize = 0;
            this.exitLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.exitLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.exitLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitLTC.ForeColor = System.Drawing.Color.White;
            this.exitLTC.Image = ((System.Drawing.Image)(resources.GetObject("exitLTC.Image")));
            this.exitLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitLTC.Location = new System.Drawing.Point(703, 8);
            this.exitLTC.Name = "exitLTC";
            this.exitLTC.Size = new System.Drawing.Size(86, 46);
            this.exitLTC.TabIndex = 6;
            this.exitLTC.Text = "Thoát";
            this.exitLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitLTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitLTC.UseVisualStyleBackColor = false;
            this.exitLTC.Click += new System.EventHandler(this.exitLTC_Click);
            // 
            // saveLTC
            // 
            this.saveLTC.AutoSize = true;
            this.saveLTC.BackColor = System.Drawing.Color.Indigo;
            this.saveLTC.FlatAppearance.BorderSize = 0;
            this.saveLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.saveLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.saveLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLTC.ForeColor = System.Drawing.Color.White;
            this.saveLTC.Image = ((System.Drawing.Image)(resources.GetObject("saveLTC.Image")));
            this.saveLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveLTC.Location = new System.Drawing.Point(575, 8);
            this.saveLTC.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.saveLTC.Name = "saveLTC";
            this.saveLTC.Size = new System.Drawing.Size(75, 46);
            this.saveLTC.TabIndex = 5;
            this.saveLTC.Text = "Ghi";
            this.saveLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveLTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveLTC.UseVisualStyleBackColor = false;
            this.saveLTC.Click += new System.EventHandler(this.saveLTC_Click);
            // 
            // resLTC
            // 
            this.resLTC.AutoSize = true;
            this.resLTC.BackColor = System.Drawing.Color.Indigo;
            this.resLTC.FlatAppearance.BorderSize = 0;
            this.resLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.resLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.resLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resLTC.ForeColor = System.Drawing.Color.White;
            this.resLTC.Image = ((System.Drawing.Image)(resources.GetObject("resLTC.Image")));
            this.resLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resLTC.Location = new System.Drawing.Point(420, 8);
            this.resLTC.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.resLTC.Name = "resLTC";
            this.resLTC.Size = new System.Drawing.Size(102, 46);
            this.resLTC.TabIndex = 3;
            this.resLTC.Text = "Phục hồi";
            this.resLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resLTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resLTC.UseVisualStyleBackColor = false;
            this.resLTC.Click += new System.EventHandler(this.resLTC_Click);
            // 
            // deleteLTC
            // 
            this.deleteLTC.AutoSize = true;
            this.deleteLTC.BackColor = System.Drawing.Color.Indigo;
            this.deleteLTC.FlatAppearance.BorderSize = 0;
            this.deleteLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.deleteLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.deleteLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLTC.ForeColor = System.Drawing.Color.White;
            this.deleteLTC.Image = ((System.Drawing.Image)(resources.GetObject("deleteLTC.Image")));
            this.deleteLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteLTC.Location = new System.Drawing.Point(291, 8);
            this.deleteLTC.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.deleteLTC.Name = "deleteLTC";
            this.deleteLTC.Size = new System.Drawing.Size(76, 46);
            this.deleteLTC.TabIndex = 1;
            this.deleteLTC.Text = "Xóa";
            this.deleteLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteLTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteLTC.UseVisualStyleBackColor = false;
            this.deleteLTC.Click += new System.EventHandler(this.deleteLTC_Click);
            // 
            // addLTC
            // 
            this.addLTC.AutoSize = true;
            this.addLTC.BackColor = System.Drawing.Color.Indigo;
            this.addLTC.FlatAppearance.BorderSize = 0;
            this.addLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.addLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.addLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLTC.ForeColor = System.Drawing.Color.White;
            this.addLTC.Image = ((System.Drawing.Image)(resources.GetObject("addLTC.Image")));
            this.addLTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLTC.Location = new System.Drawing.Point(17, 8);
            this.addLTC.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.addLTC.Name = "addLTC";
            this.addLTC.Size = new System.Drawing.Size(84, 46);
            this.addLTC.TabIndex = 0;
            this.addLTC.Text = "Thêm";
            this.addLTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addLTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addLTC.UseVisualStyleBackColor = false;
            this.addLTC.Click += new System.EventHandler(this.addLTC_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataLTC);
            this.panel2.Controls.Add(this.khoaComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 463);
            this.panel2.TabIndex = 8;
            // 
            // dataLTC
            // 
            this.dataLTC.AllowUserToAddRows = false;
            this.dataLTC.AllowUserToDeleteRows = false;
            this.dataLTC.AllowUserToResizeColumns = false;
            this.dataLTC.AllowUserToResizeRows = false;
            this.dataLTC.AutoGenerateColumns = false;
            this.dataLTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLTC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataLTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.dataLTC.DataSource = this.lOPTINCHIBindingSource;
            this.dataLTC.Location = new System.Drawing.Point(3, 49);
            this.dataLTC.Name = "dataLTC";
            this.dataLTC.ReadOnly = true;
            this.dataLTC.RowHeadersWidth = 51;
            this.dataLTC.RowTemplate.Height = 24;
            this.dataLTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLTC.Size = new System.Drawing.Size(1243, 409);
            this.dataLTC.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALTC";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALTC";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NIENKHOA";
            this.dataGridViewTextBoxColumn2.HeaderText = "NIENKHOA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOCKY";
            this.dataGridViewTextBoxColumn3.HeaderText = "HOCKY";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAMH";
            this.dataGridViewTextBoxColumn4.HeaderText = "MAMH";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NHOM";
            this.dataGridViewTextBoxColumn5.HeaderText = "NHOM";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn6.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MAKHOA";
            this.dataGridViewTextBoxColumn7.HeaderText = "MAKHOA";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SOSVTOITHIEU";
            this.dataGridViewTextBoxColumn8.HeaderText = "SOSVTOITHIEU";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HUYLOP";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HUYLOP";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaComboBox
            // 
            this.khoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.khoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.khoaComboBox.FormattingEnabled = true;
            this.khoaComboBox.Location = new System.Drawing.Point(414, 10);
            this.khoaComboBox.Name = "khoaComboBox";
            this.khoaComboBox.Size = new System.Drawing.Size(380, 33);
            this.khoaComboBox.TabIndex = 2;
            this.khoaComboBox.SelectedIndexChanged += new System.EventHandler(this.khoaComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(318, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHOA";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.semesterInput);
            this.panel3.Controls.Add(this.cancelClassCheck);
            this.panel3.Controls.Add(this.groupInput);
            this.panel3.Controls.Add(this.gvIdInput);
            this.panel3.Controls.Add(this.mhIdInput);
            this.panel3.Controls.Add(this.yearInput);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.gvComboBox);
            this.panel3.Controls.Add(this.mhComboBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.minSVInput);
            this.panel3.Controls.Add(this.khoaInput);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 544);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 337);
            this.panel3.TabIndex = 6;
            // 
            // semesterInput
            // 
            this.semesterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.semesterInput.Location = new System.Drawing.Point(256, 118);
            this.semesterInput.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.semesterInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.semesterInput.Name = "semesterInput";
            this.semesterInput.ReadOnly = true;
            this.semesterInput.Size = new System.Drawing.Size(283, 30);
            this.semesterInput.TabIndex = 25;
            this.semesterInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cancelClassCheck
            // 
            this.cancelClassCheck.AutoSize = true;
            this.cancelClassCheck.Enabled = false;
            this.cancelClassCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelClassCheck.Location = new System.Drawing.Point(823, 294);
            this.cancelClassCheck.Name = "cancelClassCheck";
            this.cancelClassCheck.Size = new System.Drawing.Size(18, 17);
            this.cancelClassCheck.TabIndex = 24;
            this.cancelClassCheck.UseVisualStyleBackColor = true;
            // 
            // groupInput
            // 
            this.groupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupInput.Location = new System.Drawing.Point(823, 120);
            this.groupInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.groupInput.Name = "groupInput";
            this.groupInput.ReadOnly = true;
            this.groupInput.Size = new System.Drawing.Size(283, 30);
            this.groupInput.TabIndex = 23;
            this.groupInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gvIdInput
            // 
            this.gvIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvIdInput.Location = new System.Drawing.Point(823, 225);
            this.gvIdInput.Name = "gvIdInput";
            this.gvIdInput.ReadOnly = true;
            this.gvIdInput.Size = new System.Drawing.Size(283, 30);
            this.gvIdInput.TabIndex = 22;
            // 
            // mhIdInput
            // 
            this.mhIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mhIdInput.Location = new System.Drawing.Point(823, 169);
            this.mhIdInput.Name = "mhIdInput";
            this.mhIdInput.ReadOnly = true;
            this.mhIdInput.Size = new System.Drawing.Size(283, 30);
            this.mhIdInput.TabIndex = 21;
            // 
            // yearInput
            // 
            this.yearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearInput.Location = new System.Drawing.Point(823, 66);
            this.yearInput.Name = "yearInput";
            this.yearInput.ReadOnly = true;
            this.yearInput.Size = new System.Drawing.Size(283, 30);
            this.yearInput.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(689, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Hủy lớp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(689, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mã giáo viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(689, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã môn học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(689, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nhóm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(689, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Niên khóa";
            // 
            // gvComboBox
            // 
            this.gvComboBox.Enabled = false;
            this.gvComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvComboBox.FormattingEnabled = true;
            this.gvComboBox.Location = new System.Drawing.Point(256, 230);
            this.gvComboBox.Name = "gvComboBox";
            this.gvComboBox.Size = new System.Drawing.Size(283, 33);
            this.gvComboBox.TabIndex = 14;
            this.gvComboBox.SelectedIndexChanged += new System.EventHandler(this.gvComboBox_SelectedIndexChanged);
            // 
            // mhComboBox
            // 
            this.mhComboBox.Enabled = false;
            this.mhComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mhComboBox.FormattingEnabled = true;
            this.mhComboBox.Location = new System.Drawing.Point(256, 171);
            this.mhComboBox.Name = "mhComboBox";
            this.mhComboBox.Size = new System.Drawing.Size(283, 33);
            this.mhComboBox.TabIndex = 13;
            this.mhComboBox.SelectedIndexChanged += new System.EventHandler(this.mhComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(104, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số sv tối thiểu";
            // 
            // minSVInput
            // 
            this.minSVInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minSVInput.Location = new System.Drawing.Point(256, 287);
            this.minSVInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minSVInput.Name = "minSVInput";
            this.minSVInput.ReadOnly = true;
            this.minSVInput.Size = new System.Drawing.Size(283, 30);
            this.minSVInput.TabIndex = 10;
            this.minSVInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // khoaInput
            // 
            this.khoaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.khoaInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.khoaInput.Location = new System.Drawing.Point(256, 64);
            this.khoaInput.Name = "khoaInput";
            this.khoaInput.ReadOnly = true;
            this.khoaInput.Size = new System.Drawing.Size(283, 30);
            this.khoaInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(104, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(104, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(104, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(104, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thông tin lớp tín chỉ";
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DSLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttons);
            this.Name = "DSLTC";
            this.Size = new System.Drawing.Size(1257, 884);
            this.Load += new System.EventHandler(this.DSLTC_Load);
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSVInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttons;
        private System.Windows.Forms.Button exitLTC;
        private System.Windows.Forms.Button saveLTC;
        private System.Windows.Forms.Button resLTC;
        private System.Windows.Forms.Button deleteLTC;
        private System.Windows.Forms.Button addLTC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox khoaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cancelClassCheck;
        private System.Windows.Forms.NumericUpDown groupInput;
        private System.Windows.Forms.TextBox gvIdInput;
        private System.Windows.Forms.TextBox mhIdInput;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gvComboBox;
        private System.Windows.Forms.ComboBox mhComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown minSVInput;
        private System.Windows.Forms.TextBox khoaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private QLDSVDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataLTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.NumericUpDown semesterInput;
        private System.Windows.Forms.Button editLTC;
        private System.Windows.Forms.TextBox search_main;
    }
}
