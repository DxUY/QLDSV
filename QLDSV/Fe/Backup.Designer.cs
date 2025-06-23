namespace QLDSV.Fe
{
    partial class Backup
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
            this.main = new System.Windows.Forms.DataGridView();
            this.NGAYSAOLUU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THIETBISAOLUU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOISAOLUU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupData = new System.Windows.Forms.Button();
            this.restoreData = new System.Windows.Forms.Button();
            this.deleteOldChk = new System.Windows.Forms.CheckBox();
            this.restoreByTimeChk = new System.Windows.Forms.CheckBox();
            this.chooseTimeLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.SuspendLayout();
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
            this.NGAYSAOLUU,
            this.KICHTHUOC,
            this.THIETBISAOLUU,
            this.NGUOISAOLUU});
            this.main.Location = new System.Drawing.Point(3, 97);
            this.main.MultiSelect = false;
            this.main.Name = "main";
            this.main.ReadOnly = true;
            this.main.RowHeadersWidth = 51;
            this.main.RowTemplate.Height = 24;
            this.main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.main.Size = new System.Drawing.Size(1251, 589);
            this.main.TabIndex = 0;
            this.main.SelectionChanged += new System.EventHandler(this.main_SelectionChanged);
            // 
            // NGAYSAOLUU
            // 
            this.NGAYSAOLUU.DataPropertyName = "NGAYSAOLUU";
            this.NGAYSAOLUU.HeaderText = "Ngày sao lưu";
            this.NGAYSAOLUU.MinimumWidth = 6;
            this.NGAYSAOLUU.Name = "NGAYSAOLUU";
            this.NGAYSAOLUU.ReadOnly = true;
            // 
            // KICHTHUOC
            // 
            this.KICHTHUOC.DataPropertyName = "KICHTHUOC";
            this.KICHTHUOC.HeaderText = "Kích thước";
            this.KICHTHUOC.MinimumWidth = 6;
            this.KICHTHUOC.Name = "KICHTHUOC";
            this.KICHTHUOC.ReadOnly = true;
            // 
            // THIETBISAOLUU
            // 
            this.THIETBISAOLUU.DataPropertyName = "THIETBISAOLUU";
            this.THIETBISAOLUU.HeaderText = "Thiết bị sao lưu";
            this.THIETBISAOLUU.MinimumWidth = 6;
            this.THIETBISAOLUU.Name = "THIETBISAOLUU";
            this.THIETBISAOLUU.ReadOnly = true;
            // 
            // NGUOISAOLUU
            // 
            this.NGUOISAOLUU.DataPropertyName = "NGUOISAOLUU";
            this.NGUOISAOLUU.HeaderText = "Người sao lưu";
            this.NGUOISAOLUU.MinimumWidth = 6;
            this.NGUOISAOLUU.Name = "NGUOISAOLUU";
            this.NGUOISAOLUU.ReadOnly = true;
            // 
            // backupData
            // 
            this.backupData.AutoSize = true;
            this.backupData.BackColor = System.Drawing.Color.Indigo;
            this.backupData.FlatAppearance.BorderSize = 0;
            this.backupData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.backupData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.backupData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backupData.ForeColor = System.Drawing.Color.White;
            this.backupData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupData.Location = new System.Drawing.Point(1054, 21);
            this.backupData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupData.Name = "backupData";
            this.backupData.Size = new System.Drawing.Size(169, 58);
            this.backupData.TabIndex = 58;
            this.backupData.Text = "Sao lưu dữ liệu";
            this.backupData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backupData.UseVisualStyleBackColor = false;
            this.backupData.Click += new System.EventHandler(this.backupData_Click);
            // 
            // restoreData
            // 
            this.restoreData.AutoSize = true;
            this.restoreData.BackColor = System.Drawing.Color.Indigo;
            this.restoreData.FlatAppearance.BorderSize = 0;
            this.restoreData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.restoreData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.restoreData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.restoreData.ForeColor = System.Drawing.Color.White;
            this.restoreData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restoreData.Location = new System.Drawing.Point(1022, 755);
            this.restoreData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restoreData.Name = "restoreData";
            this.restoreData.Size = new System.Drawing.Size(201, 58);
            this.restoreData.TabIndex = 59;
            this.restoreData.Text = "Xác nhận khôi phục";
            this.restoreData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.restoreData.UseVisualStyleBackColor = false;
            this.restoreData.Click += new System.EventHandler(this.restoreData_Click);
            // 
            // deleteOldChk
            // 
            this.deleteOldChk.AutoSize = true;
            this.deleteOldChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteOldChk.Location = new System.Drawing.Point(409, 705);
            this.deleteOldChk.Name = "deleteOldChk";
            this.deleteOldChk.Size = new System.Drawing.Size(422, 29);
            this.deleteOldChk.TabIndex = 61;
            this.deleteOldChk.Text = "Xóa bản sao lưu cũ trước khi sao lưu bản mới";
            this.deleteOldChk.UseVisualStyleBackColor = true;
            // 
            // restoreByTimeChk
            // 
            this.restoreByTimeChk.AutoSize = true;
            this.restoreByTimeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.restoreByTimeChk.Location = new System.Drawing.Point(466, 37);
            this.restoreByTimeChk.Name = "restoreByTimeChk";
            this.restoreByTimeChk.Size = new System.Drawing.Size(315, 29);
            this.restoreByTimeChk.TabIndex = 63;
            this.restoreByTimeChk.Text = "Khôi phục theo thời gian chỉ định";
            this.restoreByTimeChk.UseVisualStyleBackColor = true;
            this.restoreByTimeChk.CheckedChanged += new System.EventHandler(this.restoreByTimeChk_CheckedChanged);
            // 
            // chooseTimeLabel
            // 
            this.chooseTimeLabel.AutoSize = true;
            this.chooseTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chooseTimeLabel.Location = new System.Drawing.Point(179, 767);
            this.chooseTimeLabel.Name = "chooseTimeLabel";
            this.chooseTimeLabel.Size = new System.Drawing.Size(286, 25);
            this.chooseTimeLabel.TabIndex = 65;
            this.chooseTimeLabel.Text = "Chọn thời điểm muón khôi phục";
            this.chooseTimeLabel.Visible = false;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(490, 767);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(151, 30);
            this.datePicker.TabIndex = 66;
            this.datePicker.Visible = false;
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(678, 767);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(165, 30);
            this.timePicker.TabIndex = 67;
            this.timePicker.Visible = false;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.chooseTimeLabel);
            this.Controls.Add(this.restoreByTimeChk);
            this.Controls.Add(this.deleteOldChk);
            this.Controls.Add(this.restoreData);
            this.Controls.Add(this.backupData);
            this.Controls.Add(this.main);
            this.Name = "Backup";
            this.Size = new System.Drawing.Size(1257, 884);
            this.Load += new System.EventHandler(this.Backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView main;
        private System.Windows.Forms.Button backupData;
        private System.Windows.Forms.Button restoreData;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSAOLUU;
        private System.Windows.Forms.DataGridViewTextBoxColumn KICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THIETBISAOLUU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOISAOLUU;
        private System.Windows.Forms.CheckBox deleteOldChk;
        private System.Windows.Forms.CheckBox restoreByTimeChk;
        private System.Windows.Forms.Label chooseTimeLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}
