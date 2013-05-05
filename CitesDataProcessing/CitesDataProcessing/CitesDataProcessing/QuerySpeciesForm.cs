using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace CitesDataProcessing
{
    public partial class QuerySpeciesForm : Form
    {
        public QuerySpeciesForm()
        {
            InitializeComponent();
        }

        //查询信息
        private void button_query_Click(object sender, EventArgs e)
        {
            string keyword = textBox_queryKeyword.Text;

            string myConStr = "Data Source=localhost;Integrated Security=SSPI;Initial Catalog=CITESDATABASE";
            string mySqlStr = "select * from CitesDataAnimal";

            SqlConnection mySqlConnection=new SqlConnection(myConStr);
            mySqlConnection.Open();

            SqlCommand    mySqlCommand=new SqlCommand(mySqlStr,mySqlConnection);

            SqlDataReader mySqlReader=mySqlCommand.ExecuteReader();

            while(mySqlReader.Read())
            {
                MessageBox.Show(mySqlReader.GetString(0) + "," + mySqlReader.GetString(1));
            }

            mySqlReader.Close();
            mySqlConnection.Close();
        }
    }
}
