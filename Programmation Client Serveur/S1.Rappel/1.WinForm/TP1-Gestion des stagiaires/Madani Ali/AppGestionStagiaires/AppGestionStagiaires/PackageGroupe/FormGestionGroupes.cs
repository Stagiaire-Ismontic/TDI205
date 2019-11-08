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
    public partial class FormGestionGroupes : Form
    {
        public FormGestionGroupes()
        {
            InitializeComponent();
        }

        private void Actualiser(){
            groupeBindingSource.DataSource = null;
            groupeBindingSource.DataSource = GestionGroupes.Afficher();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            FormGroupe f = new FormGroupe();
            f.ShowDialog();
            this.Actualiser();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            Groupe g = (Groupe)groupeBindingSource.Current;
            GestionGroupes.Supprimer(g.Id);
            this.Actualiser();
        }

        private void FormGestionGroupes_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void btMettreAjour_Click(object sender, EventArgs e)
        {
            Groupe g = (Groupe)groupeBindingSource.Current;
            FormGroupeUpdate f = new FormGroupeUpdate();
            f.MiseAjour(g);
            f.ShowDialog();
            this.Actualiser();
        }
    }
}
