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
        Etudiant e = new Etudiant();
        GestionEtudiant ge = new GestionEtudiant();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void buttonajouter_Click(object sender, EventArgs e)
        {


            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;

            int age = int.Parse(this.textBox4.Text);
            
            Etudiant a = new Etudiant(id,nom, prenom, age);
            ge.Ajouter(a);
            this.actualiser();

            MessageBox.Show("stagiaire ajouter avec succes");
        }

        private void buttonmodi_Click(object sender, EventArgs e)
        {

            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;

            int age = int.Parse(this.textBox4.Text);

            Etudiant a = new Etudiant(id, nom, prenom, age);
            ge.Modifier(a);
            this.actualiser();
        }

        private void buttonsu_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            ge.Supprimer(id);
            this.actualiser();
        }

        private void buttonaff_Click(object sender, EventArgs e)
        {
            this.actualiser();
        }
        private void actualiser()
        {
            List<Etudiant> lst = new List<Etudiant>();
            lst = ge.Afficher();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;
      
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            }
        }
    }

