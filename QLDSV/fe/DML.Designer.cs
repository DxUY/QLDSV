namespace QLDSV.fe
{
    partial class DML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DML));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.addSV = new System.Windows.Forms.Button();
            this.deleteSV = new System.Windows.Forms.Button();
            this.resSV = new System.Windows.Forms.Button();
            this.saveSV = new System.Windows.Forms.Button();
            this.sv_main = new System.Windows.Forms.Panel();
            this.search_sub = new System.Windows.Forms.TextBox();
            this.subData = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANGHIHOC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.subButtons = new System.Windows.Forms.Panel();
            this.editSV = new System.Windows.Forms.Button();
            this.exitSV = new System.Windows.Forms.Button();
            this.addDML = new System.Windows.Forms.Button();
            this.deleteDML = new System.Windows.Forms.Button();
            this.resDML = new System.Windows.Forms.Button();
            this.saveDML = new System.Windows.Forms.Button();
            this.exitDML = new System.Windows.Forms.Button();
            this.mainButtons = new System.Windows.Forms.Panel();
            this.editDML = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.idSV = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.classId = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Panel();
            this.isStudyCheck = new System.Windows.Forms.CheckBox();
            this.genderCheck = new System.Windows.Forms.CheckBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.bdayInput = new System.Windows.Forms.TextBox();
            this.classIdInput = new System.Windows.Forms.TextBox();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.idSVInput = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.isStudy = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Panel();
            this.search_main = new System.Windows.Forms.TextBox();
            this.mainData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.LopTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.sinhVienTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.SinhVienTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.majorInput = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.Label();
            this.courseDMLInput = new System.Windows.Forms.TextBox();
            this.nameDMLInput = new System.Windows.Forms.TextBox();
            this.idDMLInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameDML = new System.Windows.Forms.Label();
            this.idDML = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sv_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.subButtons.SuspendLayout();
            this.mainButtons.SuspendLayout();
            this.sub.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // addSV
            // 
            this.addSV.AutoSize = true;
            this.addSV.BackColor = System.Drawing.Color.Indigo;
            this.addSV.FlatAppearance.BorderSize = 0;
            this.addSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.addSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.addSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSV.ForeColor = System.Drawing.Color.White;
            this.addSV.Image = ((System.Drawing.Image)(resources.GetObject("addSV.Image")));
            this.addSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSV.Location = new System.Drawing.Point(17, 9);
            this.addSV.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.addSV.Name = "addSV";
            this.addSV.Size = new System.Drawing.Size(84, 46);
            this.addSV.TabIndex = 7;
            this.addSV.Text = "Thêm";
            this.addSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addSV.UseVisualStyleBackColor = false;
            this.addSV.Click += new System.EventHandler(this.addSV_Click);
            // 
            // deleteSV
            // 
            this.deleteSV.AutoSize = true;
            this.deleteSV.BackColor = System.Drawing.Color.Indigo;
            this.deleteSV.FlatAppearance.BorderSize = 0;
            this.deleteSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.deleteSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.deleteSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSV.ForeColor = System.Drawing.Color.White;
            this.deleteSV.Image = ((System.Drawing.Image)(resources.GetObject("deleteSV.Image")));
            this.deleteSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteSV.Location = new System.Drawing.Point(291, 9);
            this.deleteSV.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.deleteSV.Name = "deleteSV";
            this.deleteSV.Size = new System.Drawing.Size(76, 46);
            this.deleteSV.TabIndex = 7;
            this.deleteSV.Text = "Xóa";
            this.deleteSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteSV.UseVisualStyleBackColor = false;
            this.deleteSV.Click += new System.EventHandler(this.deleteSV_Click);
            // 
            // resSV
            // 
            this.resSV.AutoSize = true;
            this.resSV.BackColor = System.Drawing.Color.Indigo;
            this.resSV.FlatAppearance.BorderSize = 0;
            this.resSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.resSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.resSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resSV.ForeColor = System.Drawing.Color.White;
            this.resSV.Image = ((System.Drawing.Image)(resources.GetObject("resSV.Image")));
            this.resSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resSV.Location = new System.Drawing.Point(420, 9);
            this.resSV.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.resSV.Name = "resSV";
            this.resSV.Size = new System.Drawing.Size(101, 46);
            this.resSV.TabIndex = 7;
            this.resSV.Text = "Phục hồi";
            this.resSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resSV.UseVisualStyleBackColor = false;
            this.resSV.Click += new System.EventHandler(this.resSV_Click);
            // 
            // saveSV
            // 
            this.saveSV.AutoSize = true;
            this.saveSV.BackColor = System.Drawing.Color.Indigo;
            this.saveSV.FlatAppearance.BorderSize = 0;
            this.saveSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.saveSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.saveSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSV.ForeColor = System.Drawing.Color.White;
            this.saveSV.Image = ((System.Drawing.Image)(resources.GetObject("saveSV.Image")));
            this.saveSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveSV.Location = new System.Drawing.Point(574, 9);
            this.saveSV.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.saveSV.Name = "saveSV";
            this.saveSV.Size = new System.Drawing.Size(75, 46);
            this.saveSV.TabIndex = 7;
            this.saveSV.Text = "Ghi";
            this.saveSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveSV.UseVisualStyleBackColor = false;
            this.saveSV.Click += new System.EventHandler(this.saveSV_Click);
            // 
            // sv_main
            // 
            this.sv_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sv_main.Controls.Add(this.search_sub);
            this.sv_main.Controls.Add(this.subData);
            this.sv_main.Controls.Add(this.subButtons);
            this.sv_main.Location = new System.Drawing.Point(422, 441);
            this.sv_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sv_main.Name = "sv_main";
            this.sv_main.Size = new System.Drawing.Size(832, 442);
            this.sv_main.TabIndex = 11;
            // 
            // search_sub
            // 
            this.search_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_sub.ForeColor = System.Drawing.SystemColors.WindowText;
            this.search_sub.Location = new System.Drawing.Point(587, 88);
            this.search_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.search_sub.Name = "search_sub";
            this.search_sub.Size = new System.Drawing.Size(238, 30);
            this.search_sub.TabIndex = 13;
            this.search_sub.Text = "search....";
            this.search_sub.TextChanged += new System.EventHandler(this.searchSub_TextChanged);
            // 
            // subData
            // 
            this.subData.AllowUserToAddRows = false;
            this.subData.AllowUserToDeleteRows = false;
            this.subData.AllowUserToResizeColumns = false;
            this.subData.AllowUserToResizeRows = false;
            this.subData.AutoGenerateColumns = false;
            this.subData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.subData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HO,
            this.TEN,
            this.MALOP,
            this.PHAI,
            this.NGAYSINH,
            this.DIACHI,
            this.DANGHIHOC,
            this.PASSWORD});
            this.subData.DataSource = this.sinhVienBindingSource;
            this.subData.Location = new System.Drawing.Point(3, 129);
            this.subData.Name = "subData";
            this.subData.ReadOnly = true;
            this.subData.RowHeadersWidth = 51;
            this.subData.RowTemplate.Height = 24;
            this.subData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subData.Size = new System.Drawing.Size(824, 308);
            this.subData.TabIndex = 8;
            this.subData.SelectionChanged += new System.EventHandler(this.subData_SelectionChanged);
            this.subData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subData_MouseDown);
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "MASV";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            this.MASV.Width = 125;
            // 
            // HO
            // 
            this.HO.DataPropertyName = "HO";
            this.HO.HeaderText = "HO";
            this.HO.MinimumWidth = 6;
            this.HO.Name = "HO";
            this.HO.ReadOnly = true;
            this.HO.Width = 125;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "TEN";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            this.TEN.Width = 125;
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "MALOP";
            this.MALOP.MinimumWidth = 6;
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            this.MALOP.Width = 125;
            // 
            // PHAI
            // 
            this.PHAI.DataPropertyName = "PHAI";
            this.PHAI.HeaderText = "PHAI";
            this.PHAI.MinimumWidth = 6;
            this.PHAI.Name = "PHAI";
            this.PHAI.ReadOnly = true;
            this.PHAI.Width = 125;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "NGAYSINH";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            this.NGAYSINH.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "DIACHI";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 125;
            // 
            // DANGHIHOC
            // 
            this.DANGHIHOC.DataPropertyName = "DANGHIHOC";
            this.DANGHIHOC.HeaderText = "DANGHIHOC";
            this.DANGHIHOC.MinimumWidth = 6;
            this.DANGHIHOC.Name = "DANGHIHOC";
            this.DANGHIHOC.ReadOnly = true;
            this.DANGHIHOC.Width = 125;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            dataGridViewCellStyle1.NullValue = "123456";
            this.PASSWORD.DefaultCellStyle = dataGridViewCellStyle1;
            this.PASSWORD.HeaderText = "PASSWORD";
            this.PASSWORD.MinimumWidth = 6;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Width = 125;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "FK_SinhVien_MALOP";
            this.sinhVienBindingSource.DataSource = this.lopBindingSource;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subButtons
            // 
            this.subButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subButtons.Controls.Add(this.editSV);
            this.subButtons.Controls.Add(this.exitSV);
            this.subButtons.Controls.Add(this.addSV);
            this.subButtons.Controls.Add(this.saveSV);
            this.subButtons.Controls.Add(this.resSV);
            this.subButtons.Controls.Add(this.deleteSV);
            this.subButtons.Location = new System.Drawing.Point(3, 3);
            this.subButtons.Name = "subButtons";
            this.subButtons.Size = new System.Drawing.Size(824, 70);
            this.subButtons.TabIndex = 8;
            // 
            // editSV
            // 
            this.editSV.AutoSize = true;
            this.editSV.BackColor = System.Drawing.Color.Indigo;
            this.editSV.FlatAppearance.BorderSize = 0;
            this.editSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.editSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.editSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSV.ForeColor = System.Drawing.Color.White;
            this.editSV.Image = ((System.Drawing.Image)(resources.GetObject("editSV.Image")));
            this.editSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editSV.Location = new System.Drawing.Point(154, 9);
            this.editSV.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.editSV.Name = "editSV";
            this.editSV.Size = new System.Drawing.Size(84, 46);
            this.editSV.TabIndex = 8;
            this.editSV.Text = "Sửa";
            this.editSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editSV.UseVisualStyleBackColor = false;
            this.editSV.Click += new System.EventHandler(this.editSV_Click);
            // 
            // exitSV
            // 
            this.exitSV.AutoSize = true;
            this.exitSV.BackColor = System.Drawing.Color.Indigo;
            this.exitSV.FlatAppearance.BorderSize = 0;
            this.exitSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.exitSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.exitSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitSV.ForeColor = System.Drawing.Color.White;
            this.exitSV.Image = ((System.Drawing.Image)(resources.GetObject("exitSV.Image")));
            this.exitSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitSV.Location = new System.Drawing.Point(702, 9);
            this.exitSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitSV.Name = "exitSV";
            this.exitSV.Size = new System.Drawing.Size(85, 46);
            this.exitSV.TabIndex = 7;
            this.exitSV.Text = "Thoát";
            this.exitSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitSV.UseVisualStyleBackColor = false;
            this.exitSV.Click += new System.EventHandler(this.exitSV_Click);
            // 
            // addDML
            // 
            this.addDML.AutoSize = true;
            this.addDML.BackColor = System.Drawing.Color.Indigo;
            this.addDML.FlatAppearance.BorderSize = 0;
            this.addDML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.addDML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.addDML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDML.ForeColor = System.Drawing.Color.White;
            this.addDML.Image = ((System.Drawing.Image)(resources.GetObject("addDML.Image")));
            this.addDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDML.Location = new System.Drawing.Point(17, 7);
            this.addDML.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.addDML.Name = "addDML";
            this.addDML.Size = new System.Drawing.Size(84, 46);
            this.addDML.TabIndex = 0;
            this.addDML.Text = "Thêm";
            this.addDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addDML.UseVisualStyleBackColor = false;
            this.addDML.Click += new System.EventHandler(this.addDML_Click);
            // 
            // deleteDML
            // 
            this.deleteDML.AutoSize = true;
            this.deleteDML.BackColor = System.Drawing.Color.Indigo;
            this.deleteDML.FlatAppearance.BorderSize = 0;
            this.deleteDML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.deleteDML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.deleteDML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDML.ForeColor = System.Drawing.Color.White;
            this.deleteDML.Image = ((System.Drawing.Image)(resources.GetObject("deleteDML.Image")));
            this.deleteDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDML.Location = new System.Drawing.Point(291, 7);
            this.deleteDML.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.deleteDML.Name = "deleteDML";
            this.deleteDML.Size = new System.Drawing.Size(73, 46);
            this.deleteDML.TabIndex = 1;
            this.deleteDML.Text = "Xóa";
            this.deleteDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteDML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteDML.UseVisualStyleBackColor = false;
            this.deleteDML.Click += new System.EventHandler(this.deleteDML_Click);
            // 
            // resDML
            // 
            this.resDML.AutoSize = true;
            this.resDML.BackColor = System.Drawing.Color.Indigo;
            this.resDML.FlatAppearance.BorderSize = 0;
            this.resDML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.resDML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.resDML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resDML.ForeColor = System.Drawing.Color.White;
            this.resDML.Image = ((System.Drawing.Image)(resources.GetObject("resDML.Image")));
            this.resDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resDML.Location = new System.Drawing.Point(417, 7);
            this.resDML.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.resDML.Name = "resDML";
            this.resDML.Size = new System.Drawing.Size(101, 46);
            this.resDML.TabIndex = 3;
            this.resDML.Text = "Phục hồi";
            this.resDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resDML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resDML.UseVisualStyleBackColor = false;
            this.resDML.Click += new System.EventHandler(this.resDML_Click);
            // 
            // saveDML
            // 
            this.saveDML.AutoSize = true;
            this.saveDML.BackColor = System.Drawing.Color.Indigo;
            this.saveDML.FlatAppearance.BorderSize = 0;
            this.saveDML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.saveDML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.saveDML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDML.ForeColor = System.Drawing.Color.White;
            this.saveDML.Image = ((System.Drawing.Image)(resources.GetObject("saveDML.Image")));
            this.saveDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDML.Location = new System.Drawing.Point(571, 7);
            this.saveDML.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.saveDML.Name = "saveDML";
            this.saveDML.Size = new System.Drawing.Size(75, 46);
            this.saveDML.TabIndex = 5;
            this.saveDML.Text = "Ghi";
            this.saveDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveDML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveDML.UseVisualStyleBackColor = false;
            this.saveDML.Click += new System.EventHandler(this.saveDML_Click);
            // 
            // exitDML
            // 
            this.exitDML.AutoSize = true;
            this.exitDML.BackColor = System.Drawing.Color.Indigo;
            this.exitDML.FlatAppearance.BorderSize = 0;
            this.exitDML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.exitDML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.exitDML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitDML.ForeColor = System.Drawing.Color.White;
            this.exitDML.Image = ((System.Drawing.Image)(resources.GetObject("exitDML.Image")));
            this.exitDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitDML.Location = new System.Drawing.Point(699, 7);
            this.exitDML.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.exitDML.Name = "exitDML";
            this.exitDML.Size = new System.Drawing.Size(85, 46);
            this.exitDML.TabIndex = 6;
            this.exitDML.Text = "Thoát";
            this.exitDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitDML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitDML.UseVisualStyleBackColor = false;
            this.exitDML.Click += new System.EventHandler(this.exitDML_Click);
            // 
            // mainButtons
            // 
            this.mainButtons.AutoSize = true;
            this.mainButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainButtons.Controls.Add(this.editDML);
            this.mainButtons.Controls.Add(this.exitDML);
            this.mainButtons.Controls.Add(this.saveDML);
            this.mainButtons.Controls.Add(this.resDML);
            this.mainButtons.Controls.Add(this.deleteDML);
            this.mainButtons.Controls.Add(this.addDML);
            this.mainButtons.Location = new System.Drawing.Point(1, 0);
            this.mainButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainButtons.Name = "mainButtons";
            this.mainButtons.Size = new System.Drawing.Size(1253, 66);
            this.mainButtons.TabIndex = 1;
            // 
            // editDML
            // 
            this.editDML.AutoSize = true;
            this.editDML.BackColor = System.Drawing.Color.Indigo;
            this.editDML.FlatAppearance.BorderSize = 0;
            this.editDML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.editDML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.editDML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDML.ForeColor = System.Drawing.Color.White;
            this.editDML.Image = ((System.Drawing.Image)(resources.GetObject("editDML.Image")));
            this.editDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editDML.Location = new System.Drawing.Point(154, 7);
            this.editDML.Margin = new System.Windows.Forms.Padding(3, 2, 50, 2);
            this.editDML.Name = "editDML";
            this.editDML.Size = new System.Drawing.Size(84, 46);
            this.editDML.TabIndex = 7;
            this.editDML.Text = "Sửa";
            this.editDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editDML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editDML.UseVisualStyleBackColor = false;
            this.editDML.Click += new System.EventHandler(this.editDML_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title.Location = new System.Drawing.Point(1, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(233, 29);
            this.title.TabIndex = 2;
            this.title.Text = "Thông tin sinh viên";
            // 
            // idSV
            // 
            this.idSV.AutoSize = true;
            this.idSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idSV.Location = new System.Drawing.Point(4, 65);
            this.idSV.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.idSV.Name = "idSV";
            this.idSV.Size = new System.Drawing.Size(73, 25);
            this.idSV.TabIndex = 3;
            this.idSV.Text = "Mã SV";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lName.Location = new System.Drawing.Point(4, 115);
            this.lName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(37, 25);
            this.lName.TabIndex = 4;
            this.lName.Text = "Họ";
            // 
            // classId
            // 
            this.classId.AutoSize = true;
            this.classId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classId.Location = new System.Drawing.Point(4, 165);
            this.classId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.classId.Name = "classId";
            this.classId.Size = new System.Drawing.Size(78, 25);
            this.classId.TabIndex = 5;
            this.classId.Text = "Mã Lớp";
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sub.Controls.Add(this.isStudyCheck);
            this.sub.Controls.Add(this.genderCheck);
            this.sub.Controls.Add(this.passwordInput);
            this.sub.Controls.Add(this.addressInput);
            this.sub.Controls.Add(this.bdayInput);
            this.sub.Controls.Add(this.classIdInput);
            this.sub.Controls.Add(this.fNameInput);
            this.sub.Controls.Add(this.lNameInput);
            this.sub.Controls.Add(this.idSVInput);
            this.sub.Controls.Add(this.pass);
            this.sub.Controls.Add(this.isStudy);
            this.sub.Controls.Add(this.address);
            this.sub.Controls.Add(this.bday);
            this.sub.Controls.Add(this.fName);
            this.sub.Controls.Add(this.gender);
            this.sub.Controls.Add(this.classId);
            this.sub.Controls.Add(this.lName);
            this.sub.Controls.Add(this.idSV);
            this.sub.Controls.Add(this.title);
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sub.Location = new System.Drawing.Point(1, 441);
            this.sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(419, 442);
            this.sub.TabIndex = 3;
            // 
            // isStudyCheck
            // 
            this.isStudyCheck.AutoSize = true;
            this.isStudyCheck.Location = new System.Drawing.Point(110, 370);
            this.isStudyCheck.Name = "isStudyCheck";
            this.isStudyCheck.Size = new System.Drawing.Size(18, 17);
            this.isStudyCheck.TabIndex = 25;
            this.isStudyCheck.UseVisualStyleBackColor = true;
            // 
            // genderCheck
            // 
            this.genderCheck.AutoSize = true;
            this.genderCheck.Location = new System.Drawing.Point(61, 218);
            this.genderCheck.Name = "genderCheck";
            this.genderCheck.Size = new System.Drawing.Size(18, 17);
            this.genderCheck.TabIndex = 24;
            this.genderCheck.UseVisualStyleBackColor = true;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordInput.Location = new System.Drawing.Point(107, 407);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.ReadOnly = true;
            this.passwordInput.Size = new System.Drawing.Size(306, 30);
            this.passwordInput.TabIndex = 23;
            // 
            // addressInput
            // 
            this.addressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressInput.Location = new System.Drawing.Point(81, 310);
            this.addressInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.addressInput.Name = "addressInput";
            this.addressInput.ReadOnly = true;
            this.addressInput.Size = new System.Drawing.Size(333, 30);
            this.addressInput.TabIndex = 22;
            // 
            // bdayInput
            // 
            this.bdayInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bdayInput.Location = new System.Drawing.Point(107, 260);
            this.bdayInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.bdayInput.Name = "bdayInput";
            this.bdayInput.ReadOnly = true;
            this.bdayInput.Size = new System.Drawing.Size(307, 30);
            this.bdayInput.TabIndex = 21;
            // 
            // classIdInput
            // 
            this.classIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classIdInput.Location = new System.Drawing.Point(92, 160);
            this.classIdInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.classIdInput.Name = "classIdInput";
            this.classIdInput.ReadOnly = true;
            this.classIdInput.Size = new System.Drawing.Size(322, 30);
            this.classIdInput.TabIndex = 20;
            // 
            // fNameInput
            // 
            this.fNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fNameInput.Location = new System.Drawing.Point(204, 110);
            this.fNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.ReadOnly = true;
            this.fNameInput.Size = new System.Drawing.Size(210, 30);
            this.fNameInput.TabIndex = 19;
            // 
            // lNameInput
            // 
            this.lNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lNameInput.Location = new System.Drawing.Point(47, 105);
            this.lNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.ReadOnly = true;
            this.lNameInput.Size = new System.Drawing.Size(98, 30);
            this.lNameInput.TabIndex = 18;
            // 
            // idSVInput
            // 
            this.idSVInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idSVInput.Location = new System.Drawing.Point(83, 60);
            this.idSVInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.idSVInput.Name = "idSVInput";
            this.idSVInput.ReadOnly = true;
            this.idSVInput.Size = new System.Drawing.Size(331, 30);
            this.idSVInput.TabIndex = 12;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass.Location = new System.Drawing.Point(4, 415);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(98, 25);
            this.pass.TabIndex = 17;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isStudy
            // 
            this.isStudy.AutoSize = true;
            this.isStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isStudy.Location = new System.Drawing.Point(4, 365);
            this.isStudy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.isStudy.Name = "isStudy";
            this.isStudy.Size = new System.Drawing.Size(100, 25);
            this.isStudy.TabIndex = 16;
            this.isStudy.Text = "Nghỉ học?";
            this.isStudy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.address.Location = new System.Drawing.Point(4, 315);
            this.address.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(71, 25);
            this.address.TabIndex = 15;
            this.address.Text = "Địa chỉ";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bday
            // 
            this.bday.AutoSize = true;
            this.bday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bday.Location = new System.Drawing.Point(2, 265);
            this.bday.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(99, 25);
            this.bday.TabIndex = 14;
            this.bday.Text = "Ngày sinh";
            this.bday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fName.Location = new System.Drawing.Point(151, 115);
            this.fName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(47, 25);
            this.fName.TabIndex = 12;
            this.fName.Text = "Tên";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gender.Location = new System.Drawing.Point(4, 215);
            this.gender.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(51, 25);
            this.gender.TabIndex = 10;
            this.gender.Text = "Phái";
            this.gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            this.main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main.Controls.Add(this.search_main);
            this.main.Controls.Add(this.mainData);
            this.main.Controls.Add(this.khoaComboBox);
            this.main.Controls.Add(this.label1);
            this.main.Location = new System.Drawing.Point(1, 71);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(895, 365);
            this.main.TabIndex = 12;
            // 
            // search_main
            // 
            this.search_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.search_main.Location = new System.Drawing.Point(638, 11);
            this.search_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.search_main.Name = "search_main";
            this.search_main.Size = new System.Drawing.Size(238, 30);
            this.search_main.TabIndex = 12;
            this.search_main.Text = "search....";
            this.search_main.TextChanged += new System.EventHandler(this.searchMain_TextChanged);
            // 
            // mainData
            // 
            this.mainData.AllowUserToAddRows = false;
            this.mainData.AllowUserToDeleteRows = false;
            this.mainData.AllowUserToResizeColumns = false;
            this.mainData.AllowUserToResizeRows = false;
            this.mainData.AutoGenerateColumns = false;
            this.mainData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mainData.DataSource = this.lopBindingSource;
            this.mainData.Location = new System.Drawing.Point(3, 51);
            this.mainData.Name = "mainData";
            this.mainData.ReadOnly = true;
            this.mainData.RowHeadersWidth = 51;
            this.mainData.RowTemplate.Height = 24;
            this.mainData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainData.Size = new System.Drawing.Size(887, 309);
            this.mainData.TabIndex = 8;
            this.mainData.SelectionChanged += new System.EventHandler(this.mainData_SelectionChanged);
            this.mainData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainData_MouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOP";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENLOP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KHOAHOC";
            this.dataGridViewTextBoxColumn3.HeaderText = "KHOAHOC";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAKHOA";
            this.dataGridViewTextBoxColumn4.HeaderText = "MAKHOA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // khoaComboBox
            // 
            this.khoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.khoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.khoaComboBox.FormattingEnabled = true;
            this.khoaComboBox.Location = new System.Drawing.Point(207, 8);
            this.khoaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khoaComboBox.Name = "khoaComboBox";
            this.khoaComboBox.Size = new System.Drawing.Size(255, 33);
            this.khoaComboBox.TabIndex = 8;
            this.khoaComboBox.SelectedIndexChanged += new System.EventHandler(this.khoaComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(131, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "KHOA";
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = this.lopTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.majorInput);
            this.panel1.Controls.Add(this.major);
            this.panel1.Controls.Add(this.courseDMLInput);
            this.panel1.Controls.Add(this.nameDMLInput);
            this.panel1.Controls.Add(this.idDMLInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameDML);
            this.panel1.Controls.Add(this.idDML);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(898, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 366);
            this.panel1.TabIndex = 12;
            // 
            // majorInput
            // 
            this.majorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.majorInput.Location = new System.Drawing.Point(111, 325);
            this.majorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.majorInput.Name = "majorInput";
            this.majorInput.ReadOnly = true;
            this.majorInput.Size = new System.Drawing.Size(222, 30);
            this.majorInput.TabIndex = 11;
            // 
            // major
            // 
            this.major.AutoSize = true;
            this.major.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.major.Location = new System.Drawing.Point(9, 339);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(59, 25);
            this.major.TabIndex = 10;
            this.major.Text = "Khoa";
            this.major.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseDMLInput
            // 
            this.courseDMLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseDMLInput.Location = new System.Drawing.Point(111, 243);
            this.courseDMLInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.courseDMLInput.Name = "courseDMLInput";
            this.courseDMLInput.ReadOnly = true;
            this.courseDMLInput.Size = new System.Drawing.Size(222, 30);
            this.courseDMLInput.TabIndex = 9;
            // 
            // nameDMLInput
            // 
            this.nameDMLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameDMLInput.Location = new System.Drawing.Point(111, 161);
            this.nameDMLInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.nameDMLInput.Name = "nameDMLInput";
            this.nameDMLInput.ReadOnly = true;
            this.nameDMLInput.Size = new System.Drawing.Size(222, 30);
            this.nameDMLInput.TabIndex = 8;
            // 
            // idDMLInput
            // 
            this.idDMLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idDMLInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idDMLInput.Location = new System.Drawing.Point(111, 79);
            this.idDMLInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 50);
            this.idDMLInput.Name = "idDMLInput";
            this.idDMLInput.ReadOnly = true;
            this.idDMLInput.Size = new System.Drawing.Size(222, 30);
            this.idDMLInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(9, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khóa học";
            // 
            // nameDML
            // 
            this.nameDML.AutoSize = true;
            this.nameDML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameDML.Location = new System.Drawing.Point(9, 169);
            this.nameDML.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.nameDML.Name = "nameDML";
            this.nameDML.Size = new System.Drawing.Size(78, 25);
            this.nameDML.TabIndex = 4;
            this.nameDML.Text = "Tên lớp";
            // 
            // idDML
            // 
            this.idDML.AutoSize = true;
            this.idDML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idDML.Location = new System.Drawing.Point(9, 84);
            this.idDML.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.idDML.Name = "idDML";
            this.idDML.Size = new System.Drawing.Size(71, 25);
            this.idDML.TabIndex = 3;
            this.idDML.Text = "Mã lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thông tin lớp học";
            // 
            // DML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main);
            this.Controls.Add(this.sv_main);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mainButtons);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DML";
            this.Size = new System.Drawing.Size(1257, 885);
            this.Load += new System.EventHandler(this.DML_Load);
            this.sv_main.ResumeLayout(false);
            this.sv_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.subButtons.ResumeLayout(false);
            this.subButtons.PerformLayout();
            this.mainButtons.ResumeLayout(false);
            this.mainButtons.PerformLayout();
            this.sub.ResumeLayout(false);
            this.sub.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button addSV;
        private System.Windows.Forms.Button deleteSV;
        private System.Windows.Forms.Button resSV;
        private System.Windows.Forms.Button saveSV;
        private System.Windows.Forms.Panel sv_main;
        private System.Windows.Forms.Button addDML;
        private System.Windows.Forms.Button deleteDML;
        private System.Windows.Forms.Button resDML;
        private System.Windows.Forms.Button saveDML;
        private System.Windows.Forms.Button exitDML;
        private System.Windows.Forms.Panel mainButtons;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label idSV;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label classId;
        private System.Windows.Forms.Panel sub;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox khoaComboBox;
        private System.Windows.Forms.Button exitSV;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLDSVDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLDSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.Panel subButtons;
        private System.Windows.Forms.DataGridView mainData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView subData;
        private System.Windows.Forms.Button editDML;
        private System.Windows.Forms.Button editSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DANGHIHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox majorInput;
        private System.Windows.Forms.Label major;
        private System.Windows.Forms.TextBox courseDMLInput;
        private System.Windows.Forms.TextBox nameDMLInput;
        private System.Windows.Forms.TextBox idDMLInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameDML;
        private System.Windows.Forms.Label idDML;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label bday;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label isStudy;
        private System.Windows.Forms.CheckBox isStudyCheck;
        private System.Windows.Forms.CheckBox genderCheck;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox bdayInput;
        private System.Windows.Forms.TextBox classIdInput;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.TextBox idSVInput;
        private System.Windows.Forms.TextBox search_main;
        private System.Windows.Forms.TextBox search_sub;
    }
}
