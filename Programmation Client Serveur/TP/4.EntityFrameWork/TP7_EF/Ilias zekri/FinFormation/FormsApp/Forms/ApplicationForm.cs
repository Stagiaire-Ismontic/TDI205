using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApp.Classes;
using FormsApp.Services;

namespace FormsApp.Forms
{
    public partial class ApplicationForm : Form
    {

        GestionQuartier GestQ = new GestionQuartier();

        GestionVille GestV = new GestionVille();

        public ApplicationForm()
        {
            InitializeComponent();
        }

        public void ActualiserDataGrid()
        {
            dataGridViewQuartier.DataSource = null;
            dataGridViewQuartier.DataSource = GestQ.GetList();
        }

        public void ActualiserCombo()
        {

            ComboVille.DataSource = GestV.GetList();
        }

        public void Afficher(Quartier Q)
        {
            TxtCode.Text = Q.Id.ToString();
            TxtNom.Text = Q.NomQuartier;
            TxtPopulation.Text = Q.Population.ToString();
            TxtTotalQuartier.Text = Q.TotalQuartier.ToString();
            ComboVille.DisplayMember = Q.Ville.NomVille;
            ComboVille.SelectedValue = Q.Ville.Id;
        }

        public void Vide()
        {
            TxtCode.Clear();
            TxtNom.Clear();
            TxtPopulation.Clear();
            TxtTotalQuartier.Clear();
        }

        private void gestionDesVillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VilleForm f = new VilleForm();
            f.ShowDialog();
        }

        private void gestionDesRegionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionForm f = new RegionForm();
            f.ShowDialog();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewQuartier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewQuartier.SelectedRows.Count >= 0)
            {
                int i = dataGridViewQuartier.CurrentRow.Index;
                Quartier Q = GestQ.GetList()[i];
                Afficher(Q);
            }
        }

        private void ApplicationForm_Load_1(object sender, EventArgs e)
        {
            ActualiserCombo();
            ActualiserDataGrid();
            TxtCode.Enabled = false;
        }

        private void ComboVille_MouseClick(object sender, MouseEventArgs e)
        {
            ActualiserCombo();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNom.Text != "")
                {
                    Classes.Ville V = GestV.Find(Convert.ToInt32(ComboVille.SelectedValue));
                    GestQ.Add(new Quartier() { NomQuartier = TxtNom.Text,Ville = V, TotalQuartier = Convert.ToDouble(TxtTotalQuartier.Text),Population=Convert.ToInt32(TxtPopulation.Text) });
                    ActualiserDataGrid();
                    Vide();
                }
                else
                {
                    MessageBox.Show("Remplir tout les donnees!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees est incorrect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNom.Text != "")
                {
                    Classes.Ville V = GestV.Find(Convert.ToInt32(ComboVille.SelectedValue));
                    bool l=GestQ.Update(new Quartier() {Id=Convert.ToInt32(TxtCode.Text), NomQuartier = TxtNom.Text, Ville = V, TotalQuartier = Convert.ToDouble(TxtTotalQuartier.Text), Population = Convert.ToInt32(TxtPopulation.Text) });
                    if(l==false) MessageBox.Show("N'existe pas!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGrid();
                    Vide();
                }
                else
                {
                    MessageBox.Show("Remplir tout les donnees!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees est incorrect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Supprimer", "Message Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bool l = GestQ.Delete(Convert.ToInt32(TxtCode.Text));
                    if (l == false) MessageBox.Show("N'existe pas!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGrid();
                    Vide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees est incorrect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDebut_Click(object sender, EventArgs e)
        {
            Quartier q = GestQ.Debut();
            Afficher(q);
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Quartier q = GestQ.Fin();
            Afficher(q);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            Quartier q = GestQ.Precedent(Convert.ToInt32(TxtCode.Text));
            Afficher(q);
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            Quartier q = GestQ.Suivant(Convert.ToInt32(TxtCode.Text));
            Afficher(q);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find x = new Find();
            x.ShowDialog();
        }
    }
}

