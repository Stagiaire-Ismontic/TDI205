using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSta
{
    public partial class GestStag : Form
    {
        GestionnaireStagiaires G = new GestionnaireStagiaires();
        
        public GestStag()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        public void Vide()
        {
            TxtCin.Clear();
            TxtNom.Clear();
            TxtGroupe.Clear();
            TxtId.Clear();
        }

        public void Actualiser()
        {
            List<Stagiaire> lst = G.Afficher();
            dataGridViewSt.AutoGenerateColumns = false;
            dataGridViewSt.DataSource = null;
            dataGridViewSt.DataSource = lst;
        }

        private void dataGridViewSt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSt.SelectedRows.Count >= 0)
            {
                int position = dataGridViewSt.CurrentRow.Index;
                Stagiaire St = new Stagiaire();
                St = G.Afficher()[position];
                this.Afficher(St);
            }
        }

        private void Afficher(Stagiaire St)
        {
            TxtCin.Text = St.Cin;
            TxtNom.Text = St.Nom;
            TxtGroupe.Text = St.Groupe;
            TxtId.Text = Convert.ToString(St.Id);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtCin.Text != "") || (TxtNom.Text != "")||(TxtId.Text!=""))
                {

                    Stagiaire St = new Stagiaire();
                    St.Cin = TxtCin.Text;
                    St.Nom = TxtNom.Text;
                    St.Id = Convert.ToInt32(TxtId.Text);
                    St.Groupe = TxtGroupe.Text;
                    G.Ajouter(St);
                    this.Vide();
                    this.Actualiser();
                }
                else
                {
                    MessageBox.Show("Champ Obligatoire!!", "Erreur", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCin.Text != "")
                {
                    Stagiaire St = new Stagiaire();
                    St.Id = Convert.ToInt32( TxtId.Text);
                    G.Supprimer(St);
                    this.Actualiser();
                    this.Vide();
                }
                else
                {
                    MessageBox.Show("Champ Obligatoire!!", "Erreur", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtCin.Text != "") || (TxtNom.Text != ""))
                {
                    Stagiaire St = new Stagiaire();
                    St.Cin = TxtCin.Text;
                    St.Nom = TxtNom.Text;
                    St.Id = Convert.ToInt32(TxtId.Text);
                    St.Groupe = TxtGroupe.Text;
                    G.Modifier(St);
                    this.Actualiser();
                    this.Vide();
                }
                else
                {
                    MessageBox.Show("Champ Obligatoire!!", "Erreur", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            this.Actualiser();
        }
    }
}
