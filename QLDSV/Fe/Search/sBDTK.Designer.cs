namespace QLDSV.Fe.Search
{
    partial class sBDTK
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
            this.lopInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lopInput
            // 
            this.lopInput.BackColor = System.Drawing.Color.Gainsboro;
            this.lopInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lopInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lopInput.Location = new System.Drawing.Point(171, 89);
            this.lopInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.lopInput.Name = "lopInput";
            this.lopInput.Size = new System.Drawing.Size(274, 30);
            this.lopInput.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(92, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã lớp";
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
            this.search.Location = new System.Drawing.Point(214, 181);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 58);
            this.search.TabIndex = 53;
            this.search.Text = "Tìm kiếm";
            this.search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // sBDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.lopInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Name = "sBDTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lopInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
    }
}