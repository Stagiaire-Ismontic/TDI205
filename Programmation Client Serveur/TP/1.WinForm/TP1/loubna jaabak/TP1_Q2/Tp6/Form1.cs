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
                document doc = new document();

                 doc.id = int.Parse(txt_id.Text);
                 doc.nom = txt_nom.Text;
                 doc.type = int.Parse(txt_id.Text);

                if (new Gestion_doc().Rechercher(doc) ==null)
                {
                    new Gestion_doc().Ajouter(doc);
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
            dataGridView1.DataSource = new Gestion_doc().Afficher();
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
                txt_type.Text = "";
            }
        }
        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                document bib = new document();

                bib.id = int.Parse(txt_id.Text);
                bib.nom = txt_nom.Text;
                bib.type =int.Parse( txt_type.Text);

                if (new Gestion_doc().Rechercher(bib) != null)
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
                document doc = new document();

                doc.id = int.Parse(txt_id.Text);
                doc.nom = txt_nom.Text;
                doc.type =int.Parse( txt_type.Text);

                new Gestion_doc().Supprimer(doc);
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
            document doc = new document();

            doc.id = int.Parse(txt_id.Text);
            doc.nom = txt_nom.Text;
            doc.type = int.Parse(txt_type.Text);

            if (new Gestion_doc().Rechercher(doc) != null)
            {
                
                new Gestion_doc().Modifier(doc);
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
