using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsF.DataTableAdapters;

namespace WindowsF
{
    public partial class Commande : Form
    {
        public void Actualiser()
        {
            Data S = new Data();
            new CommandeTableAdapter().Fill(S.Commande);
            new ProduitTableAdapter().Fill(S.Produit);
            bindingSource1.DataSource = S.Commande.ToList<Data.CommandeRow>();
        }

        public Commande()
        {
            InitializeComponent();
        }

        private void afficherSansJointureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SansJointure f = new SansJointure();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboProduit.DataSource = new ProduitTableAdapter().GetData();
            Actualiser();
        }

        private void BtnDebut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void BtnPresident_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            CommandeTableAdapter X = new CommandeTableAdapter();
            X.Insert(Convert.ToInt32(TxtId.Text), TxtDescription.Text, Convert.ToDecimal(TxtPrix.Text), Convert.ToInt32(ComboProduit.SelectedValue));
            Actualiser();
        }

        private void ComboProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Data.CommandeRow S = new CommandeTableAdapter().GetData().FindByIdCommande(Convert.ToInt32(TxtId.Text));
            S.Descriptions = TxtDescription.Text;
            S.Prix = Convert.ToDecimal(TxtPrix.Text);
            S.ProduitId = Convert.ToInt32(ComboProduit.SelectedValue);
            new CommandeTableAdapter().Update(S);
            Actualiser();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer", "Message Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Data.CommandeRow S = new CommandeTableAdapter().GetData().FindByIdCommande(Convert.ToInt32(TxtId.Text));
                S.Delete();
                new CommandeTableAdapter().Update(S);
                Actualiser();
            }
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            TxtId.Clear();
            TxtDescription.Clear();
            TxtPrix.Clear();
        }

        private void afficherAvecJointureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvecJointure F = new AvecJointure();
            F.ShowDialog();
        }
    }
}
