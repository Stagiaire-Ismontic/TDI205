using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionStagiaires.PackageGroupe
{
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
        }

        private void brEnregistrer_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            GestionGroupes.Ajouter(g);

        }

        private void FormGroupe_Load(object sender, EventArgs e)
        {

        }
    }
}
