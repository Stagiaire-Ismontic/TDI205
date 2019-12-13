using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp6.PackageEtudiants;

namespace tp6
{
    public partial class Form1 : Form
    {
     
        GestionEtudiant ge = new GestionEtudiant();
        public Form1()
        {
            InitializeComponent();
            Chargerdata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void buttonajouter_Click(object sender, EventArgs e)
        {


            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;

            string cin= textBox4.Text;
            
            Etudiant a = new Etudiant(id,nom, prenom, cin);
            ge.Ajouter(a);
            Chargerdata();

            MessageBox.Show("stagiaire ajouter avec succes");
        }

        private void buttonmodi_Click(object sender, EventArgs e)
        {

            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;
           string cin =textBox4.Text;

            Etudiant a = new Etudiant(id, nom, prenom, cin);
            ge.Modifier(a);
            this.Chargerdata();
        }

        private void buttonsu_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            ge.Supprimer(id);
            this.Chargerdata();
        }

        private void buttonaff_Click(object sender, EventArgs e)
        {
            this.Chargerdata();
        }
        private void Chargerdata()
        {
            this.dataGridView1.DataSource = null;
            dataGridView1.DataSource = ge.Afficher();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

