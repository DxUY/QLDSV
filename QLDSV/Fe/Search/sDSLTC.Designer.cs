namespace QLDSV.Fe.Search
{
    partial class sDSLTC
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
            this.search = new System.Windows.Forms.Button();
            this.hkInput = new System.Windows.Forms.TextBox();
            this.nkInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.khoaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Indigo;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(216, 187);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 58);
            this.search.TabIndex = 35;
            this.search.Text = "Tìm kiếm";
            this.search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // hkInput
            // 
            this.hkInput.BackColor = System.Drawing.Color.Gainsboro;
            this.hkInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hkInput.Location = new System.Drawing.Point(186, 134);
            this.hkInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.hkInput.Name = "hkInput";
            this.hkInput.Size = new System.Drawing.Size(255, 30);
            this.hkInput.TabIndex = 41;
            // 
            // nkInput
            // 
            this.nkInput.BackColor = System.Drawing.Color.Gainsboro;
            this.nkInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nkInput.Location = new System.Drawing.Point(186, 81);
            this.nkInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.nkInput.Name = "nkInput";
            this.nkInput.Size = new System.Drawing.Size(255, 30);
            this.nkInput.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(97, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Niên khóa";
            // 
            // khoaComboBox
            // 
            this.khoaComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.khoaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.khoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.khoaComboBox.FormattingEnabled = true;
            this.khoaComboBox.Location = new System.Drawing.Point(186, 26);
            this.khoaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khoaComboBox.Name = "khoaComboBox";
            this.khoaComboBox.Size = new System.Drawing.Size(255, 33);
            this.khoaComboBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Khoa";
            // 
            // sDSLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.hkInput);
            this.Controls.Add(this.nkInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.khoaComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Name = "sDSLTC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sDSLTC";
            this.Load += new System.EventHandler(this.sDSLTC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox hkInput;
        private System.Windows.Forms.TextBox nkInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox khoaComboBox;
        private System.Windows.Forms.Label label1;
    }
}