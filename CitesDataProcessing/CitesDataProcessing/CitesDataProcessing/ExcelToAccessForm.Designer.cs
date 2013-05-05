namespace CitesDataProcessing
{
    partial class ExcelToAccessForm
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
            this.button_importToDatabase = new System.Windows.Forms.Button();
            this.button_execlFilePath = new System.Windows.Forms.Button();
            this.textBox_excelFilePath = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_importToDatabase
            // 
            this.button_importToDatabase.Location = new System.Drawing.Point(58, 98);
            this.button_importToDatabase.Name = "button_importToDatabase";
            this.button_importToDatabase.Size = new System.Drawing.Size(92, 23);
            this.button_importToDatabase.TabIndex = 5;
            this.button_importToDatabase.Text = "导入到数据库";
            this.button_importToDatabase.UseVisualStyleBackColor = true;
            this.button_importToDatabase.Click += new System.EventHandler(this.button_importToDatabase_Click);
            // 
            // button_execlFilePath
            // 
            this.button_execlFilePath.Location = new System.Drawing.Point(58, 37);
            this.button_execlFilePath.Name = "button_execlFilePath";
            this.button_execlFilePath.Size = new System.Drawing.Size(92, 23);
            this.button_execlFilePath.TabIndex = 4;
            this.button_execlFilePath.Text = "Excel文件";
            this.button_execlFilePath.UseVisualStyleBackColor = true;
            this.button_execlFilePath.Click += new System.EventHandler(this.button_execlFilePath_Click);
            // 
            // textBox_excelFilePath
            // 
            this.textBox_excelFilePath.Location = new System.Drawing.Point(196, 40);
            this.textBox_excelFilePath.Name = "textBox_excelFilePath";
            this.textBox_excelFilePath.Size = new System.Drawing.Size(439, 20);
            this.textBox_excelFilePath.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 357);
            this.dataGridView1.TabIndex = 6;
            // 
            // ExcelToAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_importToDatabase);
            this.Controls.Add(this.button_execlFilePath);
            this.Controls.Add(this.textBox_excelFilePath);
            this.Name = "ExcelToAccessForm";
            this.Text = "ExcelToAccessForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_importToDatabase;
        private System.Windows.Forms.Button button_execlFilePath;
        private System.Windows.Forms.TextBox textBox_excelFilePath;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}