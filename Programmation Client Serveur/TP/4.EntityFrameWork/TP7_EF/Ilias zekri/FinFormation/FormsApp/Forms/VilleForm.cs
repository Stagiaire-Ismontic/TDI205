using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApp.Classes;
using FormsApp.Services;
using System.Windows.Forms;

namespace FormsApp.Forms
{
    public partial class VilleForm : Form
    {
        public VilleForm()
        {
            InitializeComponent();
        }

        GestionVille GestV = new GestionVille();

        GestionRegion GestR = new GestionRegion();

        public void ActualiserDataGrid()
        {
            dataGridViewVille.DataSource = null;
            dataGridViewVille.DataSource = GestV.GetList();
        }

        public void ActualiserCombo()
        {
            ComboRegion.DataSource = GestR.GetList();
        }

        public void Afficher(Ville V)
        {
            TxtCode.Text = V.Id.ToString();
            TxtNom.Text = V.NomVille;
            TxtTotalVille.Text = V.TotalVille.ToString();
            ComboRegion.DisplayMember = V.Region.NomRegion;
            ComboRegion.SelectedValue = V.Region.Id;
        }

        public void Vide()
        {
            TxtCode.Clear();
            TxtNom.Clear();
            TxtTotalVille.Clear();
        }

        private void VilleForm_Load(object sender, EventArgs e)
        {
            ActualiserCombo();
            ActualiserDataGrid();
            TxtCode.Enabled = false;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNom.Text != "")
                {
                    Classes.Region R = GestR.Find(Convert.ToInt32(ComboRegion.SelectedValue));
                    GestV.Add(new Ville() { NomVille=TxtNom.Text,Region=R, TotalVille=Convert.ToDouble(TxtTotalVille.Text)});
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

        private void dataGridViewVille_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVille.SelectedRows.Count >= 0)
            {
                int i = dataGridViewVille.CurrentRow.Index;
                Classes.Ville v = GestV.GetList()[i];
                Afficher(v);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNom.Text != "")
                {
                    Classes.Region R = GestR.Find(Convert.ToInt32(ComboRegion.SelectedValue));
                    bool l = GestV.Update(new Ville() {Id=Convert.ToInt32(TxtCode.Text), NomVille = TxtNom.Text, Region = R, TotalVille = Convert.ToDouble(TxtTotalVille.Text) });
                    if (l == false) MessageBox.Show("N'existe pas!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    bool l = GestV.Delete(Convert.ToInt32(TxtCode.Text));
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

        private void ComboRegion_MouseClick(object sender, MouseEventArgs e)
        {
            ActualiserCombo();
        }
    }
}
