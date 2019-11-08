using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionStagiaires.PackageStagiaires
{
    public partial class FormGestionStagiaires : Form
    {
        public FormGestionStagiaires()
        {
            InitializeComponent();
            Actualiser();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormStagiaire Ajouter = new FormStagiaire();
            Ajouter.ShowDialog();
            Actualiser();
        }

       

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            FormUpdateStagiaire Update = new FormUpdateStagiaire();
            Update.Update(index);
            Update.ShowDialog();
            Actualiser();
        }

        public void Actualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new GestionStagiaires().Afficher();
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           
                int index = dataGridView1.CurrentCell.RowIndex;
                Stagiaire s = new GestionStagiaires().getStagiaire(index);
                DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer le stagiaire " + s.Nom + " - " + s.Prenom, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    new GestionStagiaires().Supprimer(index);
                    Actualiser();
                }
                else
                    MessageBox.Show("Supression annuler");
            


        }
    }
}
