using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Groupe ls = new Groupe();
        List<stagiare> l = new List<stagiare>();


        private void buttonajouter_Click(object sender, EventArgs e)
        {
            {

                int id = int.Parse(this.textBox1.Text);
                string nom = this.textBox2.Text;
                string Prenom = this.textBox3.Text;
                string groupe = this.textBox5.Text;
                stagiare a = new stagiare(id, nom, Prenom);
                ls.ajouter(a);
                MessageBox.Show("stagiaire ajouter avec succes");
                this.Chargerdata();

            }
        }

        private void Chargerdata()
        {
            this.dataGridView1.Rows.Clear();

            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);

            }
        }
        
        private int rechercher(int id)
        {
            foreach (stagiare c in l)
            {
                if (c.Id == id)
                {
                    return l.IndexOf(c);
                }
            }
            return -1;
        }

        private void buttonsu_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Text);
            new Groupe().Supprimer(id);
            this.Chargerdata();
        }

        private void buttonmodi_Click(object sender, EventArgs e)
        {

           
          
                int id = Convert.ToInt32(textBox1.Text);
                stagiare stg = new Groupe().Rechercher(id);
                stg.Nom = textBox2.Text;
                stg.Prenom = textBox3.Text;
                new Groupe().modifier(stg);
                this.Chargerdata();
            
     

        }


    }

   
}

