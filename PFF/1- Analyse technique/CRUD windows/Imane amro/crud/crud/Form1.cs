using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chargerdata();
        }
        GestionEtudiant GE = new GestionEtudiant();
        

        private void button1_Click(object sender, EventArgs e)
        {
            {

                int id = int.Parse(this.textBox1.Text);
                string nom = this.textBox2.Text;
                string Prenom = this.textBox3.Text;
                string cin = this.textBox4.Text;
                Etudiant a = new Etudiant(id, nom, Prenom, cin);
                GE.ajouter(a);
                MessageBox.Show("stagiaire ajouter avec succes");
                this.Chargerdata();

            }
            annlee();
        }

        private void Chargerdata()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = GE.Ls;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            GE.Supprimer(id);
            this.Chargerdata();
            annlee();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Text);
            Etudiant stg = GE.Rechercher(id);
            stg.Nom = textBox2.Text;
            stg.Prenom = textBox3.Text;
            GE.modifier(stg);
            this.Chargerdata();
            annlee();
        }
        public void annlee()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            

        }


        
    }

  

}
    

