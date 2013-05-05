using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CitesDataProcessing
{
    public partial class ExcelToSqlsever2008 : Form
    {
        public ExcelToSqlsever2008()
        {
            InitializeComponent();
        }

        //选择导入excel文件
        private void button_execlFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFile = new OpenFileDialog();
            if (mOpenFile.ShowDialog()==DialogResult.OK)
            {
               textBox_excelFilePath.Text=mOpenFile.FileName.ToString();
            }
        }

        //导入到数据库
        private void button_importToDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
