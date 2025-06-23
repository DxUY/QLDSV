namespace QLDSV.Fe
{
    partial class XD
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.dANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.khoa = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.Label();
            this.main = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dANGKYBindingSource
            // 
            this.dANGKYBindingSource.DataMember = "DANGKY";
            this.dANGKYBindingSource.DataSource = this.qLDSVDataSet;
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
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title.Location = new System.Drawing.Point(130, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(212, 26);
            this.title.TabIndex = 4;
            this.title.Text = "Thông tin sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(377, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(377, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(377, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(377, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Sinh Viên:";
            // 
            // khoa
            // 
            this.khoa.AutoSize = true;
            this.khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.khoa.Location = new System.Drawing.Point(588, 175);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(113, 25);
            this.khoa.TabIndex = 18;
            this.khoa.Text = "placeholder";
            // 
            // lop
            // 
            this.lop.AutoSize = true;
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lop.Location = new System.Drawing.Point(588, 136);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(113, 25);
            this.lop.TabIndex = 17;
            this.lop.Text = "placeholder";
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ten.Location = new System.Drawing.Point(588, 99);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(113, 25);
            this.ten.TabIndex = 16;
            this.ten.Text = "placeholder";
            // 
            // masv
            // 
            this.masv.AutoSize = true;
            this.masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.masv.Location = new System.Drawing.Point(588, 61);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(113, 25);
            this.masv.TabIndex = 15;
            this.masv.Text = "placeholder";
            // 
            // main
            // 
            this.main.AccessibleName = "Table";
            this.main.AllowEditing = false;
            this.main.AllowGrouping = false;
            this.main.AllowSorting = false;
            this.main.AutoGenerateColumns = false;
            this.main.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowSorting = false;
            gridTextColumn1.HeaderText = "Mã LTC";
            gridTextColumn1.MappingName = "MALTC";
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowSorting = false;
            gridTextColumn2.HeaderText = "Tên Môn Học";
            gridTextColumn2.MappingName = "TENMH";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowSorting = false;
            gridTextColumn3.HeaderText = "Điểm CC";
            gridTextColumn3.MappingName = "Diem_CC";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowGrouping = false;
            gridTextColumn4.AllowSorting = false;
            gridTextColumn4.HeaderText = "Điểm GK";
            gridTextColumn4.MappingName = "Diem_GK";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.AllowSorting = false;
            gridTextColumn5.HeaderText = "Điểm CK";
            gridTextColumn5.MappingName = "Diem_CK";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowGrouping = false;
            gridTextColumn6.AllowSorting = false;
            gridTextColumn6.HeaderText = "Điểm TK";
            gridTextColumn6.MappingName = "DIEM_TK";
            this.main.Columns.Add(gridTextColumn1);
            this.main.Columns.Add(gridTextColumn2);
            this.main.Columns.Add(gridTextColumn3);
            this.main.Columns.Add(gridTextColumn4);
            this.main.Columns.Add(gridTextColumn5);
            this.main.Columns.Add(gridTextColumn6);
            this.main.Location = new System.Drawing.Point(3, 219);
            this.main.Name = "main";
            this.main.PreviewRowHeight = 35;
            this.main.ShowGroupDropArea = true;
            this.main.Size = new System.Drawing.Size(1251, 662);
            this.main.TabIndex = 19;
            this.main.Text = "sfDataGrid1";
            // 
            // XD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Name = "XD";
            this.Size = new System.Drawing.Size(1257, 884);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource dANGKYBindingSource;
        private QLDSVDataSetTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label khoa;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label masv;
        private Syncfusion.WinForms.DataGrid.SfDataGrid main;
    }
}
