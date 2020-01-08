using System;
using System.Collections.Generic;
using System.ComponentModel;
using WindowsFormsApplication.Classes;
using WindowsFormsApplication.Services;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form : System.Windows.Forms.Form
    {
        GestionCommande Gest = new GestionCommande();

        GestionProduit P = new GestionProduit();
         
        public Form()
        {
            InitializeComponent();

        }

    
        public void aa()
        {
            List<Produit> lst = P.Select();
            CbProduit.DataSource = lst;
           
            CbProduit.DisplayMember = "Nom";
            CbProduit.ValueMember = "ProduitId";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            aa();
            Id.Hide();
            Actualiser();    
        }

        public void Vide()
        {
            TxtDescription.Clear();
            TxtPrix.Clear();
            Id.Text = "-";
        }

        public void Actualiser()
        {
        
            dataGridViewCommande.DataSource = Gest.Select();
        }

        public void Afficher(Commande C)
        {
            TxtDescription.Text = C.Descriptions;
            TxtPrix.Text = C.Prix.ToString();
            Id.Text = C.CommandeId.ToString();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtDescription.Text != "") || (TxtPrix.Text != ""))
                {
                    Produit Pr = P.FindById(Convert.ToInt32(CbProduit.SelectedValue));
                    Gest.Insert(new Commande(TxtDescription.Text, Convert.ToDouble(TxtPrix.Text),Pr));
                    this.Actualiser();
                    this.Vide();
                    MessageBox.Show("Le Commande est ajouter", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Remplir les Champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                bool b=Gest.Delete(int.Parse(Id.Text));
                if(b==false) MessageBox.Show("N'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Le Commande est Supprimer", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Actualiser();
                this.Vide();
            }
            catch (Exception)
            {
                MessageBox.Show("Select votre commande a supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridViewCommande_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCommande.SelectedRows.Count >= 0)
            {
                int position = dataGridViewCommande.CurrentRow.Index;
                Commande C = Gest.Select()[position];
                this.Afficher(C);
            }
          
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Produit Pr = P.FindById(Convert.ToInt32(CbProduit.SelectedValue));
                bool b = Gest.Update(new Commande() { CommandeId=int.Parse(Id.Text),Descriptions= TxtDescription.Text,Prix= Convert.ToDouble(TxtPrix.Text),Produit= Pr });
                if (b == false) MessageBox.Show("N'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Le Commande est Modifier", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Actualiser();
                this.Vide();
            }
            catch (Exception)
            {
                MessageBox.Show("Select votre commande a Modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridViewCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCommande.Columns["BtnS"].Index)
            {
                try
                {
                    int position = dataGridViewCommande.CurrentRow.Index;
                    Commande C = Gest.Select()[position];
                    bool b = Gest.Delete(C.CommandeId);
                    if (b == false) MessageBox.Show("N'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("Le Commande est Supprimer", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Actualiser();
                    this.Vide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Select votre commande a supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
