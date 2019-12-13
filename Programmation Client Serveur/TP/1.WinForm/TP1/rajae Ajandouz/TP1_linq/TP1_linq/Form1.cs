using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Chargeer()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_Employe().Afficher();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ajouter
            Employe E = new Employe();
            E.Id = int.Parse(textBox1.Text);
            E.Nom = textBox2.Text;
            E.Prenom = textBox3.Text;
            E.Adress= textBox4.Text;
            if (new Gestion_Employe().Rechercher(E) == null)
            {
                new Gestion_Employe().Ajouter(E);
                MessageBox.Show("Ajouter avec succes!!!!");
                this.Chargeer();
            }
            else
            {
                MessageBox.Show("Deja existe!!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //modifier
            Employe et = new Employe();
            et.Id = int.Parse(textBox1.Text);
            et.Nom = textBox2.Text;
            et.Prenom =textBox3 .Text;
            et.Adress = textBox4.Text;

            if (new Gestion_Employe().Rechercher(et) != null)
            {

                new Gestion_Employe().Modifier(et);
                this.Chargeer();
                MessageBox.Show("l'employe a ete modifier  !!!");
            }
            else
            {
                MessageBox.Show("l'employe n'existe pas !!!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //anuller
            if (MessageBox.Show("Voulez-vous Vider  les champs?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //stop
            if (MessageBox.Show("Voulez-vous Quitter?", "Comfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // rechercher
            try
            {
                Employe ed = new Employe();
                ed.Id = int.Parse(textBox1.Text);
                ed.Nom = textBox2.Text;
                ed.Prenom = textBox3.Text;
                ed.Adress = textBox4.Text;
                if (new Gestion_Employe().Rechercher(ed) != null)
                {
                    MessageBox.Show("l'employe est existe");
                }
                else
                {
                    MessageBox.Show("l'employe n'existe pas!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!!!!!!!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Employe ed = new Employe();
                ed.Id = int.Parse(textBox1.Text);
                ed.Nom = textBox2.Text;
                ed.Prenom = textBox3.Text;
                ed.Adress=textBox4.Text;
                new Gestion_Employe().Supprimer(ed);
                this.Chargeer();
                MessageBox.Show(" Supprimer avec succes!!!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("n'est pas Supprimer!!");
            }
        }
    }
}
