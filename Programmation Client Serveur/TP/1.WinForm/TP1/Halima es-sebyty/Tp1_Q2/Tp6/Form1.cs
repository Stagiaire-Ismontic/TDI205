using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Data.SqlClient;
using System.Diagnostics;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp6
{
    public partial class Form1 : Form
    {       public Form1()

        {
            InitializeComponent();
        }
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {  
                bibliotheque bib = new bibliotheque();

                 bib.id = int.Parse(txt_id.Text);
                 bib.nom = txt_nom.Text;
                 bib.id_livre = int.Parse(txt_id.Text);

                if (new Gestion_Biblio().Rechercher(bib) ==null)
                {
                    new Gestion_Biblio().Ajouter(bib);
                    MessageBox.Show("Ajouter avec succes!!!!");
                    this.Chargeer();
                }
                else
                {
                    MessageBox.Show("Deja existe!!!!");
                }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            public void Chargeer()
            {
      
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_Biblio().Afficher();
            }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Chargeer();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Quitter?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous Vider  les champs?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txt_id.Text = "";
                txt_nom.Text = "";
                txt_categorie.Text = "";
            }
        }
        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                bibliotheque bib = new bibliotheque();

                bib.id = int.Parse(txt_id.Text);
                bib.nom = txt_nom.Text;
                bib.id_livre =int.Parse( txt_categorie.Text);

                if (new Gestion_Biblio().Rechercher(bib) != null)
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

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                bibliotheque bib = new bibliotheque();

                bib.id = int.Parse(txt_id.Text);
                bib.nom = txt_nom.Text;
                bib.id_livre =int.Parse( txt_categorie.Text);

                new Gestion_Biblio().Supprimer(bib);
                this.Chargeer();
                MessageBox.Show(" Supprimer avec succes!!!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Supprimer!!");
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            bibliotheque bib = new bibliotheque();

            bib.id = int.Parse(txt_id.Text);
            bib.nom = txt_nom.Text;
            bib.id_livre = int.Parse(txt_categorie.Text);

            if (new Gestion_Biblio().Rechercher(bib) != null)
            {
                
                new Gestion_Biblio().Modifier(bib);
                this.Chargeer();
                MessageBox.Show("l'editeur a ete modifier  !!!");
            }
            else
            {
                MessageBox.Show("l'editeur n'existe pas !!!");
            }
        }
    }
}
