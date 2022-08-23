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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select R_Type from room  ";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                comboBox1.Items.Add(dr[0]);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Cap from room  ";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                comboBox2.Items.Add(dr[0]);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PR_Room from room  ";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                comboBox3.Items.Add(dr[0]);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_room";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("type", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("capacity", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("price", comboBox3.SelectedItem.ToString());
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox4.Items.Add(dr[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into booking_rooms values(:room_id,:user_id)";
            cmd.Parameters.Add("room_id", comboBox4.SelectedItem.ToString());
            cmd.Parameters.Add("user_id", textBox2.Text);
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Enjoy your stay");
                cmd.CommandText = "update  availability set availableRoom ='no'where R_ID =:room_id";

            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int offer;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getoffer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("user_offer", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            offer = Convert.ToInt32(cmd.Parameters["user_offer"].Value.ToString());
            textBox1.Text = offer.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update  availability set availableRoom ='no' where R_ID =:room_id";
            cmd.Parameters.Add("room_id", comboBox4.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("room is booked for you");
                

            }

        }
    }
}
