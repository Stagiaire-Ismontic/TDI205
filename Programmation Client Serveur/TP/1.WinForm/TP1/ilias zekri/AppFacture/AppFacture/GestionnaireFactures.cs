using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacture
{
    public partial class GestionnaireFactures : Form
    {
        GestionFacture gf = new GestionFacture();
        public GestionnaireFactures()
        {
            InitializeComponent();
        }

        private void Afficher(Facture f)
        {

            lblId.Text = f.Id.ToString();
            lblDate.Text = f.Date.ToShortDateString();
            TxtTitre.Text = f.Titre;
            TxtSomme.Text = Convert.ToString(f.Somme);
        }

        public void Vide()
        {
            TxtTitre.Clear();
            TxtSomme.Clear();
            lblId.Text = Convert.ToString(AppFacture.GestionFacture.Indice+1);
        }

        public void Actualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =gf.Donne();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                int position = dataGridView1.CurrentRow.Index;
                Facture f = new Facture();
                f = gf.Donne()[position];
                this.Afficher(f);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblId.Text = Convert.ToString(AppFacture.GestionFacture.Indice + 1);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Facture f = new Facture();
                if (TxtTitre.Text == "")
                {
                    MessageBox.Show("Obligatoire!","Erreur",MessageBoxButtons.OK);
                }
                else
                {
                    f.Titre = TxtTitre.Text;
                    f.Somme = Convert.ToDouble(TxtSomme.Text);
                    f.Date = Convert.ToDateTime(lblDate.Text);
                    bool l= gf.Ajouter(f);
                    if (l == false) MessageBox.Show("Existe deja!", "Erreur", MessageBoxButtons.OK);
                    else
                    {
                        this.Vide();
                        this.Actualiser();
                    }
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Facture f = new Facture();
                f.Id = int.Parse(lblId.Text);
                f.Titre = TxtTitre.Text;
                f.Somme = Convert.ToDouble(TxtSomme.Text);
                f.Date = Convert.ToDateTime(lblDate.Text);
                bool l = gf.Modifier(f);
                if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK);
                else
                {
                    this.Vide();
                    this.Actualiser();
                }
            }
            catch(Exception)
            {
                 MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Facture f = new Facture();
                f.Id = int.Parse(lblId.Text);
                bool l = gf.Supprimer(f);
                if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK);
                else
                {
                    this.Vide();
                    this.Actualiser();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

  
    }
}
