using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace GestionGroupe
{
    public partial class Form1 : Form
    {
        GestionnairePersonne pr = new GestionnairePersonne();
        public Form1()
        {
            InitializeComponent();
        }
        private void Vide()
        {
            txtbid.Text = "";
            txtbnom.Text = "";
            txtbage.Text = "";
        }

        private void Actualiser()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pr.GetProjet();
        }
        private void Afficher(Personne p)
        {

            txtbid.Text = p.Id.ToString();
            txtbage.Text = p.Age.ToString();
            txtbnom.Text = p.Nom;
        }
        private void Charger_personne(object sender, EventArgs e)
        {
            this.Actualiser();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
                if ((txtbnom.Text != "") || (txtbage.Text != "") || (txtbid.Text != ""))
                {
                    Personne p = new Personne();
                    p.Nom = txtbnom.Text;
                    p.Age = Convert.ToInt32(txtbage.Text);
                    p.Id = Convert.ToInt32(txtbid.Text);
                    new GestionnairePersonne().Ajouter(p);
                    int id = int.Parse(Console.ReadLine());
                    this.Actualiser();
                }
                else
                {
                    MessageBox.Show("erreur", "remplissez les champs", MessageBoxButtons.OK);
                }
            
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            
                int Id = int.Parse(txtbid.Text);
                Personne p = new GestionnairePersonne().Rechercher(Id);
                p.Nom = txtbnom.Text;
                p.Age = Convert.ToInt32(txtbage.Text);
                new GestionnairePersonne().Modifier(p);
                this.Actualiser();
            }
        

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            
                int Id = int.Parse(txtbid.Text);
                new GestionnairePersonne().Supprimer(Id);
                this.Actualiser();
            }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    int position = dataGridView1.CurrentRow.Index;
                    Personne p = new GestionnairePersonne().GetProjet()[position];
                    this.Afficher(p);
            }
        }
    }
}
