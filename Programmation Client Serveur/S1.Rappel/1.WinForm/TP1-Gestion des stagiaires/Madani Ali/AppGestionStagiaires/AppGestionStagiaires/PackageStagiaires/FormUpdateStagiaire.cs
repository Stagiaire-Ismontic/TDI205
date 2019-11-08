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
    public partial class FormUpdateStagiaire : Form
    {
        public FormUpdateStagiaire()
        {
            InitializeComponent();
            cmbGroupes.DataSource = new GestionGroupes().Afficher();
            cmbGroupes.DisplayMember = "Nom";
        }

        public void Update(int index)
        {
            Stagiaire s = new GestionStagiaires().getStagiaire(index);
            lblId.Text = s.Id.ToString();
            txtNom.Text = s.Nom;
            txtPrenom.Text = s.Prenom;
            cmbGroupes.SelectedItem = s.Groupe;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Groupe g = (Groupe)cmbGroupes.SelectedItem;
            Stagiaire s = new Stagiaire(id, txtNom.Text, txtPrenom.Text,g);
            new GestionStagiaires().Modifier(s);
        }
    }
}
