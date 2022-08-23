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
    public partial class account : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger";
        OracleConnection conn;
        public account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into user_accountt values(:id,:f_name,:l_name,:email,:address)";
            cmd.Parameters.Add("id", textBox1.Text);
            cmd.Parameters.Add("f_name", textBox2.Text);
            cmd.Parameters.Add("l_name", textBox3.Text);
            cmd.Parameters.Add("email", textBox4.Text);
            cmd.Parameters.Add("address", textBox5.Text);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("account is created successufully");


            }
        }

        private void account_Load(object sender, EventArgs e)
        {

        }
    }
}
