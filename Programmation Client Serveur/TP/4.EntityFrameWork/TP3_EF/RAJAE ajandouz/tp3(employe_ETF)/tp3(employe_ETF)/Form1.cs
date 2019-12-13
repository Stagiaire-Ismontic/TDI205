using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3_employe_ETF_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Acttualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new GestionEmploye().Afficher();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ajouter
            var Em = new Employe()
            {
                id = Convert.ToInt32(txid.Text),
                Nom = txnom.Text,
                Prenom = txprenom.Text,
                Adress = txadress.Text
            };
            int id = Convert.ToInt32(txid.Text);
            if (new GestionEmploye().recherche(id) == 0)
            {

                MessageBox.Show("Bienvenue,L'employe a ete ajouter avec succes ");
                new GestionEmploye().Ajouter(Em);
                this.Acttualiser();
            }
            else
            {
                MessageBox.Show("N'existe pas !!!! ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //anuller
            txid.Text = "";
            txnom.Text = "";
            txprenom.Clear();
            txadress.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            // supprimer
            int id = Convert.ToInt32(txid.Text);

            if (new GestionEmploye().recherche(id) != 0)
            {
                new GestionEmploye().supprimer(id);
                MessageBox.Show("L'employe a ete  supprimer");

            }
            else
            {
                MessageBox.Show("L'employe n'est pas supprimer");

            }
            this.Acttualiser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //modifier
            var em = new Employe
            {
                id = int.Parse(txid.Text),
                Nom = txnom.Text,
                Prenom = txprenom.Text,
                Adress = txadress.Text
            };
            if (new GestionEmploye().recherche(em.id) != 0)
            {
                new GestionEmploye().modifier(em);
                MessageBox.Show("L'Employe a ete modifier");
                this.Acttualiser();

            }
            else
            {
                MessageBox.Show("L'employe n'est pas modifier");
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            // stop
            if (MessageBox.Show("Voulez-vous Quitter?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
