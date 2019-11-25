using AppGestionTaches.Presentation.GestionProjets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionTaches
{
    public partial class FormApplication : Form
    {
        private object from;

        public FormApplication()
        {
            InitializeComponent();
        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererProjets form = new FormGererProjets();
            form.Show();
        }
    }
}
