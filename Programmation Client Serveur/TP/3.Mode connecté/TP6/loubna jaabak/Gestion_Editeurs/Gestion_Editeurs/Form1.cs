using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Editeurs
{
    public partial class Form1 : Form
    {
        Gestion_Editeurs gs = new Gestion_Editeurs();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Actualiser();
        }
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txt_ID.Text);
            string Nom = txt_Nom.Text;
            string Categorie = txt_cat.Text;
            if (new Gestion_Editeurs().getEditeur(Id) == -1)
            {
                Editeur ets = new Editeur(Id, Nom, Categorie);
                gs.Ajouter(ets);
                MessageBox.Show("l'editeur a ete ajouter avec succes");
            }
            else
            {
                MessageBox.Show("n'est pas ajouter");

            }

        }
        private void Actualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_Editeurs().Afficher();
        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_ID.Text);
                new Gestion_Editeurs().Supprimer(id);
                this.Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btn_Vider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Vider  les champs?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txt_ID.Text = "";
                txt_Nom.Text = "";
                txt_cat.Text = "";
            }
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {

            this.Actualiser();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Editeur et = new Editeur();
            et.Id = int.Parse(txt_ID.Text);
            et.Nom = txt_Nom.Text;
            et.Categorie = txt_cat.Text;
            int trouve = new Gestion_Editeurs().getEditeur(et.Id);
            if (trouve != -1)
            {
            new Gestion_Editeurs().Modifier(et);
            this.Actualiser();
        }
                else
                {
                    MessageBox.Show("l'editeur n'existe pas !!!");
                }

}
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Quitter?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                My_Connexion.Close();
                this.Close();
            }
        }

        private void btn_rech_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                new Gestion_Editeurs().getEditeur(id);
                if (new Gestion_Editeurs().getEditeur(id) != -1)
                {
                    MessageBox.Show("l'editeur est existe");
                }
                else
                {
                    MessageBox.Show("l'editeur n'existe pas!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!!!!!!!!!");
            }
        }

     
    }
}
