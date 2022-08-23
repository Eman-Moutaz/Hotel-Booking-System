using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account F1 = new account();
            F1.Show();
        }

        private void showAvailableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F2 = new Form1();
            F2.Show();

        }

        private void bookRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F3 = new Form2();
            F3.Show();
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F4 = new Form3();
            F4.Show();
        }

        private void changeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F5 = new Form4();
            F5.Show();
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 F6 = new Form5();
            F6.Show();
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 F7 = new Form6();
            F7.Show();

        }
    }
}
