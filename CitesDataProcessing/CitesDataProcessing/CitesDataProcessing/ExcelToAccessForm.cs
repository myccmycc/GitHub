using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;

namespace CitesDataProcessing
{
    public partial class ExcelToAccessForm : Form
    {
        public ExcelToAccessForm()
        {
            InitializeComponent();
        }

        private void button_execlFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFile = new OpenFileDialog();
            if (mOpenFile.ShowDialog() == DialogResult.OK)
            {
                textBox_excelFilePath.Text = mOpenFile.FileName.ToString();
            }
        }

        private void button_importToDatabase_Click(object sender, EventArgs e)
        {
            string conStr = "";
            string sql = "";

            OleDbConnection myOleDbConnection = new OleDbConnection(conStr);
            OleDbCommand myOleDbCommand = new OleDbCommand(sql, myOleDbConnection);

            myOleDbConnection.Open();
            myOleDbCommand.ExecuteNonQuery();

        }
    }
}
