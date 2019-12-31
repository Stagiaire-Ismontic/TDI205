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
    public partial class AvecJointure : Form
    {
        public AvecJointure()
        {
            InitializeComponent();
        }

        public void Actualiser()
        {
            Data S = new Data();
            new CommandeTableAdapter().Fill(S.Commande);
            new ProduitTableAdapter().Fill(S.Produit);
            bindingSource1.DataSource = S.Commande.ToList<Data.CommandeRow>();
        }

        private void AvecJointure_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = null;
            Data S = new Data();
            new SelectDescriptionsJointureTableAdapter().Fill(S.Select_Descriptions_Jointure, TxtRecherche.Text);
            new ProduitTableAdapter().Fill(S.Produit);
            bindingSource1.DataSource = S.Select_Descriptions_Jointure.ToList<Data.Select_Descriptions_JointureRow>();
        }
        } 
}
