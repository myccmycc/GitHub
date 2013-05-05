namespace CitesDataProcessing
{
    partial class ExcelToSqlsever2008
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
            this.textBox_excelFilePath = new System.Windows.Forms.TextBox();
            this.button_execlFilePath = new System.Windows.Forms.Button();
            this.button_importToDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_excelFilePath
            // 
            this.textBox_excelFilePath.Location = new System.Drawing.Point(164, 34);
            this.textBox_excelFilePath.Name = "textBox_excelFilePath";
            this.textBox_excelFilePath.Size = new System.Drawing.Size(439, 20);
            this.textBox_excelFilePath.TabIndex = 0;
            // 
            // button_execlFilePath
            // 
            this.button_execlFilePath.Location = new System.Drawing.Point(26, 31);
            this.button_execlFilePath.Name = "button_execlFilePath";
            this.button_execlFilePath.Size = new System.Drawing.Size(92, 23);
            this.button_execlFilePath.TabIndex = 1;
            this.button_execlFilePath.Text = "Excel文件";
            this.button_execlFilePath.UseVisualStyleBackColor = true;
            this.button_execlFilePath.Click += new System.EventHandler(this.button_execlFilePath_Click);
            // 
            // button_importToDatabase
            // 
            this.button_importToDatabase.Location = new System.Drawing.Point(26, 92);
            this.button_importToDatabase.Name = "button_importToDatabase";
            this.button_importToDatabase.Size = new System.Drawing.Size(92, 23);
            this.button_importToDatabase.TabIndex = 2;
            this.button_importToDatabase.Text = "导入到数据库";
            this.button_importToDatabase.UseVisualStyleBackColor = true;
            this.button_importToDatabase.Click += new System.EventHandler(this.button_importToDatabase_Click);
            // 
            // ExcelToSqlsever2008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 529);
            this.Controls.Add(this.button_importToDatabase);
            this.Controls.Add(this.button_execlFilePath);
            this.Controls.Add(this.textBox_excelFilePath);
            this.Name = "ExcelToSqlsever2008";
            this.Text = "Excel导入到数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_excelFilePath;
        private System.Windows.Forms.Button button_execlFilePath;
        private System.Windows.Forms.Button button_importToDatabase;

    }
}