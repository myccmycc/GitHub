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
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        //数据查询模块
        private void button_query_form_Click(object sender, EventArgs e)
        {
            QuerySpeciesForm QuerySpeciesForm=new QuerySpeciesForm();
            QuerySpeciesForm.Show();
        }

        //数据导入模块
        private void button_data_import_Click(object sender, EventArgs e)
        {
            ExcelToSqlsever2008 myExcelToSqlsever2008 = new ExcelToSqlsever2008();
            myExcelToSqlsever2008.Show();
        }

        private void button_access_Click(object sender, EventArgs e)
        {
            ExcelToAccessForm myExcelToAccessForm = new ExcelToAccessForm();
            myExcelToAccessForm.Show();
        }
    }
}
