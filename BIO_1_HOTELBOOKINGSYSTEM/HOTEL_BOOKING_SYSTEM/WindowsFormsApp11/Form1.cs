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
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select R_ID from availability where availableRoom = 'yes' ";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                comboBox1.Items.Add(dr[0]);

            }

        }
    }
}
