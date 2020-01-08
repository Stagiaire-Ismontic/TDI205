using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApp.Services;
using FormsApp.Classes;

namespace FormsApp.Forms
{
    public partial class RegionForm : Form
    {
        GestionRegion GestR = new GestionRegion();

        public RegionForm()
        {
            InitializeComponent();
        }

        public void ActualiserDataGrid()
        {
            dataGridViewRegion.DataSource = null;
            dataGridViewRegion.DataSource = GestR.GetList();
        }

        public void Vide()
        {
            TxtCode.Clear();
            TxtNom.Clear();
            TxtPopulation.Clear();
            TxtTotalVille.Clear();
        }

        public void Afficher(Classes.Region R)
        {
            TxtCode.Text = R.Id.ToString();
            TxtNom.Text = R.NomRegion;
            TxtPopulation.Text = R.Population.ToString();
            TxtTotalVille.Text = R.TotalRegion.ToString();
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            ActualiserDataGrid();
            TxtCode.Enabled = false;
        }

        private void dataGridViewRegion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRegion.SelectedRows.Count >= 0)
            {
                int i = dataGridViewRegion.CurrentRow.Index;
                Classes.Region R = GestR.GetList()[i];
                Afficher(R);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNom.Text!="")
                {
                    GestR.Add(new Classes.Region() { NomRegion = TxtNom.Text, Population=Convert.ToInt32(TxtPopulation.Text),TotalRegion=Convert.ToDouble(TxtTotalVille.Text) });
                    ActualiserDataGrid();
                    Vide();
                }
                else
                {
                    MessageBox.Show("Remplir tous les donnees!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Le Format des Donnees est incorect!!","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtCode.Text != "") && (TxtNom.Text != ""))
                {
                    bool l = GestR.Update(new Classes.Region(Convert.ToInt32(TxtCode.Text), TxtNom.Text, Convert.ToInt32(TxtPopulation.Text), Convert.ToDouble(TxtTotalVille.Text)));
                    if (l == false) MessageBox.Show("N'existe pas!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGrid();
                    Vide();
                }
                else
                {
                    MessageBox.Show("Remplir tous les donnees!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Le Format des Donnees est incorect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Supprimer", "Message Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    bool l = GestR.Delete(Convert.ToInt32(TxtCode.Text));
                    if (l == false) MessageBox.Show("N'existe pas!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGrid();
                    Vide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Le Format des Donnees est incorect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
