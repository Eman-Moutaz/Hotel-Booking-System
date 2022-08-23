using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstr = "Data Source =orcl ;User Id =scott ; Password = tiger;";
            string commandstr = "select R_ID from room   where CAP =:capacity and R_Type =:Type and PR_ROOM = :price and no_Floor=:floor";

            OracleDataAdapter adapter = new OracleDataAdapter(commandstr, connectionstr);
            adapter.SelectCommand.Parameters.Add("capacity", textBox1.Text);
            adapter.SelectCommand.Parameters.Add("Type", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("price", textBox3.Text);
            adapter.SelectCommand.Parameters.Add("floor", textBox4.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
