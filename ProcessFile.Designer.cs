namespace RunbeckProcessFile
{
    partial class ProcessFileForm
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
            this.ProcessFile = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.FieldsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommaDelimited = new System.Windows.Forms.RadioButton();
            this.TabDelimited = new System.Windows.Forms.RadioButton();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ValidRecordsCount = new System.Windows.Forms.Label();
            this.InvalidRecordsCount = new System.Windows.Forms.Label();
            this.TotalRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessFile
            // 
            this.ProcessFile.Enabled = false;
            this.ProcessFile.Location = new System.Drawing.Point(58, 292);
            this.ProcessFile.Name = "ProcessFile";
            this.ProcessFile.Size = new System.Drawing.Size(141, 32);
            this.ProcessFile.TabIndex = 0;
            this.ProcessFile.Text = "Process File";
            this.ProcessFile.UseVisualStyleBackColor = true;
            this.ProcessFile.Click += new System.EventHandler(this.ProcessFile_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(685, 293);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(98, 31);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "Close";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Location = new System.Drawing.Point(685, 66);
            this.OpenFileDialog.Name = "OpenFileDialog";
            this.OpenFileDialog.Size = new System.Drawing.Size(31, 23);
            this.OpenFileDialog.TabIndex = 2;
            this.OpenFileDialog.Text = "...";
            this.OpenFileDialog.UseVisualStyleBackColor = true;
            this.OpenFileDialog.Click += new System.EventHandler(this.OpenFileDialog_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(58, 67);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(612, 22);
            this.FileName.TabIndex = 3;
            // 
            // FieldsCount
            // 
            this.FieldsCount.Location = new System.Drawing.Point(58, 168);
            this.FieldsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FieldsCount.Name = "FieldsCount";
            this.FieldsCount.Size = new System.Drawing.Size(53, 22);
            this.FieldsCount.TabIndex = 4;
            this.FieldsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Name (click on ellipsis to browse)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Fields per Record";
            // 
            // CommaDelimited
            // 
            this.CommaDelimited.AutoSize = true;
            this.CommaDelimited.Checked = true;
            this.CommaDelimited.Location = new System.Drawing.Point(61, 112);
            this.CommaDelimited.Name = "CommaDelimited";
            this.CommaDelimited.Size = new System.Drawing.Size(138, 21);
            this.CommaDelimited.TabIndex = 7;
            this.CommaDelimited.TabStop = true;
            this.CommaDelimited.Text = "Comma Delimited";
            this.CommaDelimited.UseVisualStyleBackColor = true;
            // 
            // TabDelimited
            // 
            this.TabDelimited.AutoSize = true;
            this.TabDelimited.Location = new System.Drawing.Point(218, 112);
            this.TabDelimited.Name = "TabDelimited";
            this.TabDelimited.Size = new System.Drawing.Size(116, 21);
            this.TabDelimited.TabIndex = 8;
            this.TabDelimited.Text = "Tab Delimited";
            this.TabDelimited.UseVisualStyleBackColor = true;
            // 
            // FileDialog
            // 
            this.FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // ValidRecordsCount
            // 
            this.ValidRecordsCount.AutoSize = true;
            this.ValidRecordsCount.Location = new System.Drawing.Point(58, 246);
            this.ValidRecordsCount.Name = "ValidRecordsCount";
            this.ValidRecordsCount.Size = new System.Drawing.Size(0, 17);
            this.ValidRecordsCount.TabIndex = 9;
            // 
            // InvalidRecordsCount
            // 
            this.InvalidRecordsCount.AutoSize = true;
            this.InvalidRecordsCount.Location = new System.Drawing.Point(58, 263);
            this.InvalidRecordsCount.Name = "InvalidRecordsCount";
            this.InvalidRecordsCount.Size = new System.Drawing.Size(0, 17);
            this.InvalidRecordsCount.TabIndex = 10;
            // 
            // TotalRecords
            // 
            this.TotalRecords.AutoSize = true;
            this.TotalRecords.Location = new System.Drawing.Point(58, 216);
            this.TotalRecords.Name = "TotalRecords";
            this.TotalRecords.Size = new System.Drawing.Size(0, 17);
            this.TotalRecords.TabIndex = 11;
            // 
            // ProcessFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 348);
            this.Controls.Add(this.TotalRecords);
            this.Controls.Add(this.InvalidRecordsCount);
            this.Controls.Add(this.ValidRecordsCount);
            this.Controls.Add(this.TabDelimited);
            this.Controls.Add(this.CommaDelimited);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldsCount);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.OpenFileDialog);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.ProcessFile);
            this.Name = "ProcessFileForm";
            this.Text = "Process File";
            this.Load += new System.EventHandler(this.ProcessFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FieldsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessFile;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button OpenFileDialog;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.NumericUpDown FieldsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CommaDelimited;
        private System.Windows.Forms.RadioButton TabDelimited;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label ValidRecordsCount;
        private System.Windows.Forms.Label InvalidRecordsCount;
        private System.Windows.Forms.Label TotalRecords;
    }
}

