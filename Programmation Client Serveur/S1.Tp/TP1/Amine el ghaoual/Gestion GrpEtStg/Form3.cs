using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_GrpEtStg
{
    public partial class Form3 : Form
    {

       Form1 f1 = new Form1();
       Form2 f2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            
        }



        private void groupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            f1.Show();
            
        }

        private void gestionStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            f2.Show();

        }
    }
}
