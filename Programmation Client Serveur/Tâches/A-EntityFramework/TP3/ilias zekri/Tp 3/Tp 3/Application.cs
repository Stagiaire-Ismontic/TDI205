using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_3
{
    public partial class Application : Form
    {
        GestionnaireControles Gc = new GestionnaireControles();
        public Application()
        {
            InitializeComponent();
        }

        public void Vide()
        {
            TxtNom.Clear();
            TxtNote.Clear();
        }

        public void Actualiser()
        {
            dataGridViewC.AutoGenerateColumns = false;
            dataGridViewC.DataSource = null;
            dataGridViewC.DataSource = Gc.Select();
        }

        public void Afficher(Controle C)
        {
            TxtNom.Text = C.Nom;
            TxtNote.Text = C.Note.ToString();
            labeltt.Text = C.Id.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualiser();
            labeltt.Hide();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtNom.Text != "") && (TxtNote.Text != ""))
                {
                    Gc.Insert(new Controle() { Nom = TxtNom.Text, Note = Convert.ToDouble(TxtNote.Text) });
                    Vide();
                    Actualiser();
                }
                else
                {
                    MessageBox.Show("Remplir tous les champs", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees est incorrect", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtNom.Text != "") && (TxtNote.Text != ""))
                {
                    bool b= Gc.Update(new Controle() {Id=int.Parse(labeltt.Text), Nom = TxtNom.Text, Note = Convert.ToDouble(TxtNote.Text) });
                    if(b==false) MessageBox.Show("N'existe pas", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vide();
                    Actualiser();
                }
                else
                {
                    MessageBox.Show("Remplir tous les champs", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees est incorrect", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = Gc.Delete(int.Parse(labeltt.Text));
                if (b == false) MessageBox.Show("N'existe pas", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vide();
                Actualiser();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format des donnees est incorrect", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewC_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewC.SelectedRows.Count >= 0)
            {
                int position = dataGridViewC.CurrentRow.Index;
                Controle f = Gc.Select()[position];
                this.Afficher(f);
            }
        }
    }
}
