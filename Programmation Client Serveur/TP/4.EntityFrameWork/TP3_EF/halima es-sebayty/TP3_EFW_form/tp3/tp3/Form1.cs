using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Acttualiser(int id)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_de_bibliotheque().Afficher(id);
        }




        private void btn_ajouter_Click(object sender, EventArgs e)
        {
           
            
                var edit = new editeur
                {
                     id = Convert.ToInt32(text_id.Text),
                     nom = text_nom.Text,
                     prenom = text_prenom.Text,
                     numero_inscription = Convert.ToInt32(text_nb_inscription.Text),
                     id_livre = Convert.ToInt32(text_ID_livre.Text)

                };

            int idLV = Convert.ToInt32(text_ID_livre.Text);


                if (new Gestion_de_bibliotheque().recherche(idLV) !=0)
                {
                     this.Acttualiser(Convert.ToInt32(text_ID_livre.Text));
                     MessageBox.Show("Bienveneux dans votre bibliotheque \n la liste de votre livre a ete afficher ");

                        new Gestion_de_bibliotheque().Ajouter(edit);
                 }
                else
                 {
                    MessageBox.Show("desole le livre n'existe pas dans la bibliotheque !!!! ");
                 }

           

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(text_id.Text);
            new Gestion_de_bibliotheque().supprimer(id);   
           
        }
        
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(text_id.Text);
            int id_lv = Convert.ToInt32(text_ID_livre.Text);
            new Gestion_de_bibliotheque().modifier(id,id_lv);
            this.Acttualiser(id_lv);
            
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            text_id.Text = "";
            text_nom.Text = "";
            text_prenom.Text = "";
            text_nb_inscription.Text = "";
            text_ID_livre.Text = "";
        }

        private void btn_reche_Click(object sender, EventArgs e)
        {
            int id_lv = Convert.ToInt32(text_recherche.Text);
            int trouve=new Gestion_de_bibliotheque().recherche(id_lv);

            if (trouve != 0)
            {

                MessageBox.Show("Bienveneau le livre a ete existe dans la bibliotheque \n saisir votre informations pour afficher la liste des livres");
            }
            else
            {
                MessageBox.Show("Desole le livre n'existe pas", "erreur!!!!!");
            }

        }
    }
}
