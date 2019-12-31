using Q3.T2.EmplDataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3.T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Recherche
         

        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employe E = new Employe();
            E.Show();
        }

    }
}
