using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Acttualiser();
        }

        private void BTN_VIDER_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Vider  les champs?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txt_idEdit.Text = "";
                txt_NOMedit.Text = "";
                txt_CATEGORIE.Text = "";
                txt_Livre.Text = "";
            }
        }

        private void btn_QUITTER_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Quitter?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
    }
        public void Acttualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_Editeurs().Afficher();
        }
        private void btn_AJOUTER_Click(object sender, EventArgs e)
        {
            var edit = new Editeur
            {
                id = Convert.ToInt32(txt_idEdit.Text),
                Nom = txt_NOMedit.Text,
                categorie = txt_CATEGORIE.Text,
                id_livre = int.Parse(txt_Livre.Text),
            };
            if (new Gestion_Editeurs ().recherche(edit.id) == 0)
            {
              
                MessageBox.Show("Bienvenue,L'editeur a ete ajouter avec succes ");
                new Gestion_Editeurs().Ajouter(edit);
                this.Acttualiser();
            }
            else
            {
                MessageBox.Show("N'existe pas !!!! ");
            }
          
         
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_idEdit.Text);

            if (new Gestion_Editeurs().recherche(id) != 0)
            {
                new Gestion_Editeurs().supprimer(id);
                MessageBox.Show("L'editeur a ete  supprimer");
                 
            }
            else
            {
                MessageBox.Show("L'editeur n'est pas supprimer");

            }
           }

        private void btn_MODIFIER_Click(object sender, EventArgs e)
        {

            var edit = new Editeur
            {
                id = int.Parse(txt_idEdit.Text),
                Nom = txt_NOMedit.Text,
                categorie = txt_CATEGORIE.Text,
                id_livre = int.Parse(txt_Livre.Text),
            };
            if (new Gestion_Editeurs().recherche(edit.id) != 0)
            {
                new Gestion_Editeurs().modifier(edit);
                MessageBox.Show("L'editeur a ete modifier");
                this.Acttualiser();

            }
            else
            {
                MessageBox.Show("L'editeur n'est pas modifier");
            }
        }

        private void btn_RECHERCHER_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_idEdit.Text);
            int trouve = new Gestion_Editeurs().recherche(id);

            if (trouve != 0)
            {

                MessageBox.Show("L'Editeur existe");
            }
            else
            {
                MessageBox.Show("N'est pas existe", "erreur!!!!!");
            }
        }
    }
}
