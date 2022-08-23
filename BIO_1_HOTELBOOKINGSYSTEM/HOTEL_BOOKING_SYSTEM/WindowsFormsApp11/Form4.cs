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
    public partial class Form4 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet set;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(set.Tables[0]);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionstr = "Data Source =orcl ;User Id =scott ; Password = tiger";
            string commandstr = "select *from  booking_rooms";
            adapter = new OracleDataAdapter(commandstr, connectionstr);
            set = new DataSet();
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }
    }
}
