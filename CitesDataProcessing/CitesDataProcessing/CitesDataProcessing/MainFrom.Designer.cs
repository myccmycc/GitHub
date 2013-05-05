namespace CitesDataProcessing
{
    partial class MainFrom
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
            this.button_data_import = new System.Windows.Forms.Button();
            this.button_query_form = new System.Windows.Forms.Button();
            this.button_access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_data_import
            // 
            this.button_data_import.Location = new System.Drawing.Point(98, 63);
            this.button_data_import.Name = "button_data_import";
            this.button_data_import.Size = new System.Drawing.Size(75, 23);
            this.button_data_import.TabIndex = 0;
            this.button_data_import.Text = "数据导入";
            this.button_data_import.UseVisualStyleBackColor = true;
            this.button_data_import.Click += new System.EventHandler(this.button_data_import_Click);
            // 
            // button_query_form
            // 
            this.button_query_form.Location = new System.Drawing.Point(344, 62);
            this.button_query_form.Name = "button_query_form";
            this.button_query_form.Size = new System.Drawing.Size(75, 23);
            this.button_query_form.TabIndex = 1;
            this.button_query_form.Text = "数据查询";
            this.button_query_form.UseVisualStyleBackColor = true;
            this.button_query_form.Click += new System.EventHandler(this.button_query_form_Click);
            // 
            // button_access
            // 
            this.button_access.Location = new System.Drawing.Point(217, 62);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(75, 23);
            this.button_access.TabIndex = 2;
            this.button_access.Text = "数据导入";
            this.button_access.UseVisualStyleBackColor = true;
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 166);
            this.Controls.Add(this.button_access);
            this.Controls.Add(this.button_query_form);
            this.Controls.Add(this.button_data_import);
            this.Name = "MainFrom";
            this.Text = "CITES数据管理与查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_data_import;
        private System.Windows.Forms.Button button_query_form;
        private System.Windows.Forms.Button button_access;
    }
}