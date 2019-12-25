using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Livre GL = new Gestion_Livre();
            GL.Show();
        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Editeur GE = new Gestion_Editeur();
            GE.Show();
        }
    }
}
