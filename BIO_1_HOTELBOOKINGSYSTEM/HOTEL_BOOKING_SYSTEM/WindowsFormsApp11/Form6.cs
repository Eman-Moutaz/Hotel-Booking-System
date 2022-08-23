using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace WindowsFormsApp11
{
    public partial class Form6 : Form
    {
        CrystalReport1 CR;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, textBox1.Text);
            CR.SetParameterValue(1, textBox2.Text);
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
