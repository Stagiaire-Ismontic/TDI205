using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1.PackageGroupes;
namespace AppGestionStagiaires.PackageStagiaires
{
    public partial class FormStagiaire : Form
    {
        public FormStagiaire()
        {
            InitializeComponent();
            cmbGroupes.DataSource = new GestionGroupes().Afficher();
            cmbGroupes.DisplayMember = "Nom";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            Groupe g = (Groupe)cmbGroupes.SelectedItem;
            Stagiaire s = new Stagiaire(id, txtNom.Text, txtPrenom.Text,g);
            new GestionStagiaires().Ajouter(s);
        }
    }
}
