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
            this.Manage = new System.Windows.Forms.Button();
            this.TK = new System.Windows.Forms.Button();
            this.DSLTC = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.content = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manageController = new System.Windows.Forms.Panel();
            this.printController = new System.Windows.Forms.Panel();
            this.pBDTK = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.pDSLTC = new System.Windows.Forms.Button();
            this.pSVDK = new System.Windows.Forms.Button();
            this.pBDLTC = new System.Windows.Forms.Button();
            this.pPD = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.manageTimer = new System.Windows.Forms.Timer(this.components);
            this.Logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printTimer = new System.Windows.Forms.Timer(this.components);
            this.autoBackupTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.manageController.SuspendLayout();
            this.printController.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1510, 55);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1473, 14);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 26);
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
            this.DML.BackColor = System.Drawing.Color.BlueViolet;
            this.DML.FlatAppearance.BorderSize = 0;
            this.DML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DML.ForeColor = System.Drawing.Color.White;
            this.DML.Location = new System.Drawing.Point(0, 58);
            this.DML.Name = "DML";
            this.DML.Size = new System.Drawing.Size(253, 52);
            this.DML.TabIndex = 0;
            this.DML.Text = "Danh mục lớp";
            this.DML.UseVisualStyleBackColor = false;
            this.DML.Click += new System.EventHandler(this.DML_Click);
            // 
            // DSMH
            // 
            this.DSMH.BackColor = System.Drawing.Color.BlueViolet;
            this.DSMH.FlatAppearance.BorderSize = 0;
            this.DSMH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DSMH.ForeColor = System.Drawing.Color.White;
            this.DSMH.Location = new System.Drawing.Point(0, 107);
            this.DSMH.Name = "DSMH";
            this.DSMH.Size = new System.Drawing.Size(253, 52);
            this.DSMH.TabIndex = 2;
            this.DSMH.Text = "Danh sách môn học";
            this.DSMH.UseVisualStyleBackColor = false;
            this.DSMH.Click += new System.EventHandler(this.DSMH_Click);
            // 
            // ND
            // 
            this.ND.BackColor = System.Drawing.Color.BlueViolet;
            this.ND.FlatAppearance.BorderSize = 0;
            this.ND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.ND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ND.ForeColor = System.Drawing.Color.White;
            this.ND.Location = new System.Drawing.Point(0, 203);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(253, 52);
            this.ND.TabIndex = 3;
            this.ND.Text = "Nhập điểm";
            this.ND.UseVisualStyleBackColor = false;
            this.ND.Click += new System.EventHandler(this.ND_Click);
            // 
            // Manage
            // 
            this.Manage.FlatAppearance.BorderSize = 0;
            this.Manage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Manage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Manage.ForeColor = System.Drawing.Color.White;
            this.Manage.Location = new System.Drawing.Point(0, 0);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(253, 60);
            this.Manage.TabIndex = 9;
            this.Manage.Text = "Quản lý";
            this.Manage.UseVisualStyleBackColor = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // TK
            // 
            this.TK.BackColor = System.Drawing.Color.BlueViolet;
            this.TK.FlatAppearance.BorderSize = 0;
            this.TK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.TK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.TK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TK.ForeColor = System.Drawing.Color.White;
            this.TK.Location = new System.Drawing.Point(0, 252);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(253, 52);
            this.TK.TabIndex = 8;
            this.TK.Text = "Tạo tài khoản";
            this.TK.UseVisualStyleBackColor = false;
            this.TK.Click += new System.EventHandler(this.TK_Click);
            // 
            // DSLTC
            // 
            this.DSLTC.BackColor = System.Drawing.Color.BlueViolet;
            this.DSLTC.FlatAppearance.BorderSize = 0;
            this.DSLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DSLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DSLTC.ForeColor = System.Drawing.Color.White;
            this.DSLTC.Location = new System.Drawing.Point(0, 156);
            this.DSLTC.Name = "DSLTC";
            this.DSLTC.Size = new System.Drawing.Size(253, 52);
            this.DSLTC.TabIndex = 6;
            this.DSLTC.Text = "Danh sách lớp tín chỉ";
            this.DSLTC.UseVisualStyleBackColor = false;
            this.DSLTC.Click += new System.EventHandler(this.DSLTC_Click);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(89, 71);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(57, 26);
            this.role.TabIndex = 5;
            this.role.Text = "Role";
            this.role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(65, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 32);
            this.name.TabIndex = 4;
            this.name.Text = "Username";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(253, 55);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1257, 884);
            this.content.TabIndex = 3;
            // 
            // buttonPanel
            // 
            this.buttonPanel.AutoSize = true;
            this.buttonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPanel.BackColor = System.Drawing.Color.Indigo;
            this.buttonPanel.Controls.Add(this.manageController);
            this.buttonPanel.Controls.Add(this.printController);
            this.buttonPanel.Controls.Add(this.backup);
            this.buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonPanel.Location = new System.Drawing.Point(3, 135);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(259, 198);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.WrapContents = false;
            // 
            // manageController
            // 
            this.manageController.BackColor = System.Drawing.Color.Indigo;
            this.manageController.Controls.Add(this.Manage);
            this.manageController.Controls.Add(this.TK);
            this.manageController.Controls.Add(this.DML);
            this.manageController.Controls.Add(this.DSMH);
            this.manageController.Controls.Add(this.DSLTC);
            this.manageController.Controls.Add(this.ND);
            this.manageController.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageController.Location = new System.Drawing.Point(3, 3);
            this.manageController.MaximumSize = new System.Drawing.Size(253, 307);
            this.manageController.MinimumSize = new System.Drawing.Size(253, 60);
            this.manageController.Name = "manageController";
            this.manageController.Size = new System.Drawing.Size(253, 60);
            this.manageController.TabIndex = 0;
            // 
            // printController
            // 
            this.printController.BackColor = System.Drawing.Color.Indigo;
            this.printController.Controls.Add(this.pBDTK);
            this.printController.Controls.Add(this.Print);
            this.printController.Controls.Add(this.pDSLTC);
            this.printController.Controls.Add(this.pSVDK);
            this.printController.Controls.Add(this.pBDLTC);
            this.printController.Controls.Add(this.pPD);
            this.printController.Dock = System.Windows.Forms.DockStyle.Top;
            this.printController.Location = new System.Drawing.Point(3, 69);
            this.printController.MaximumSize = new System.Drawing.Size(253, 307);
            this.printController.MinimumSize = new System.Drawing.Size(253, 60);
            this.printController.Name = "printController";
            this.printController.Size = new System.Drawing.Size(253, 60);
            this.printController.TabIndex = 10;
            // 
            // pBDTK
            // 
            this.pBDTK.BackColor = System.Drawing.Color.BlueViolet;
            this.pBDTK.FlatAppearance.BorderSize = 0;
            this.pBDTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pBDTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pBDTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBDTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pBDTK.ForeColor = System.Drawing.Color.White;
            this.pBDTK.Location = new System.Drawing.Point(0, 252);
            this.pBDTK.Name = "pBDTK";
            this.pBDTK.Size = new System.Drawing.Size(253, 52);
            this.pBDTK.TabIndex = 8;
            this.pBDTK.Text = "Bảng điểm tổng kết";
            this.pBDTK.UseVisualStyleBackColor = false;
            this.pBDTK.Click += new System.EventHandler(this.pBDTK_Click);
            // 
            // Print
            // 
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Print.ForeColor = System.Drawing.Color.White;
            this.Print.Location = new System.Drawing.Point(0, 0);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(253, 60);
            this.Print.TabIndex = 9;
            this.Print.Text = "In ấn";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // pDSLTC
            // 
            this.pDSLTC.BackColor = System.Drawing.Color.BlueViolet;
            this.pDSLTC.FlatAppearance.BorderSize = 0;
            this.pDSLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pDSLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pDSLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pDSLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pDSLTC.ForeColor = System.Drawing.Color.White;
            this.pDSLTC.Location = new System.Drawing.Point(0, 58);
            this.pDSLTC.Name = "pDSLTC";
            this.pDSLTC.Size = new System.Drawing.Size(253, 52);
            this.pDSLTC.TabIndex = 0;
            this.pDSLTC.Text = "Danh sách lớp tín chỉ";
            this.pDSLTC.UseVisualStyleBackColor = false;
            this.pDSLTC.Click += new System.EventHandler(this.pDSLTC_Click);
            // 
            // pSVDK
            // 
            this.pSVDK.BackColor = System.Drawing.Color.BlueViolet;
            this.pSVDK.FlatAppearance.BorderSize = 0;
            this.pSVDK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pSVDK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pSVDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pSVDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pSVDK.ForeColor = System.Drawing.Color.White;
            this.pSVDK.Location = new System.Drawing.Point(0, 107);
            this.pSVDK.Name = "pSVDK";
            this.pSVDK.Size = new System.Drawing.Size(253, 52);
            this.pSVDK.TabIndex = 2;
            this.pSVDK.Text = "Sinh viên đăng ký";
            this.pSVDK.UseVisualStyleBackColor = false;
            this.pSVDK.Click += new System.EventHandler(this.pSVDK_Click);
            // 
            // pBDLTC
            // 
            this.pBDLTC.BackColor = System.Drawing.Color.BlueViolet;
            this.pBDLTC.FlatAppearance.BorderSize = 0;
            this.pBDLTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pBDLTC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pBDLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBDLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pBDLTC.ForeColor = System.Drawing.Color.White;
            this.pBDLTC.Location = new System.Drawing.Point(0, 156);
            this.pBDLTC.Name = "pBDLTC";
            this.pBDLTC.Size = new System.Drawing.Size(253, 52);
            this.pBDLTC.TabIndex = 6;
            this.pBDLTC.Text = "Bảng điểm lớp tín chỉ\r\n";
            this.pBDLTC.UseVisualStyleBackColor = false;
            this.pBDLTC.Click += new System.EventHandler(this.pBDLTC_Click);
            // 
            // pPD
            // 
            this.pPD.BackColor = System.Drawing.Color.BlueViolet;
            this.pPD.FlatAppearance.BorderSize = 0;
            this.pPD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pPD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pPD.ForeColor = System.Drawing.Color.White;
            this.pPD.Location = new System.Drawing.Point(0, 203);
            this.pPD.Name = "pPD";
            this.pPD.Size = new System.Drawing.Size(253, 52);
            this.pPD.TabIndex = 3;
            this.pPD.Text = "Phiếu điểm";
            this.pPD.UseVisualStyleBackColor = false;
            this.pPD.Click += new System.EventHandler(this.pPD_Click);
            // 
            // backup
            // 
            this.backup.FlatAppearance.BorderSize = 0;
            this.backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backup.ForeColor = System.Drawing.Color.White;
            this.backup.Location = new System.Drawing.Point(3, 135);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(253, 60);
            this.backup.TabIndex = 10;
            this.backup.Text = "Sao lưu";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // manageTimer
            // 
            this.manageTimer.Interval = 10;
            this.manageTimer.Tick += new System.EventHandler(this.manageTimer_Tick);
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
            this.Logout.Location = new System.Drawing.Point(64, 829);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(122, 52);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.buttonPanel);
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 884);
            this.panel2.TabIndex = 2;
            // 
            // printTimer
            // 
            this.printTimer.Interval = 10;
            this.printTimer.Tick += new System.EventHandler(this.printTimer_Tick);
            // 
            // autoBackupTimer
            // 
            this.autoBackupTimer.Interval = 900000;
            this.autoBackupTimer.Tick += new System.EventHandler(this.autoBackupTimer_Tick);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1510, 939);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.manageController.ResumeLayout(false);
            this.printController.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button DML;
        private System.Windows.Forms.Button DSMH;
        private System.Windows.Forms.Button ND;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DSLTC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel content;
        private System.Windows.Forms.Button TK;
        private System.Windows.Forms.Button Manage;
        private System.Windows.Forms.Panel manageController;
        private System.Windows.Forms.Timer manageTimer;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel printController;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button pBDTK;
        private System.Windows.Forms.Button pDSLTC;
        private System.Windows.Forms.Button pSVDK;
        private System.Windows.Forms.Button pBDLTC;
        private System.Windows.Forms.Button pPD;
        private System.Windows.Forms.Timer printTimer;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.Timer autoBackupTimer;
    }
}