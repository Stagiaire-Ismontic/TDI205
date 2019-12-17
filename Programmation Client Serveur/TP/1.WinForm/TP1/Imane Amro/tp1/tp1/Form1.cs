using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chargerData();
        }

        GestionEtudiants gc = new GestionEtudiants();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void chargerData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gc.Etd;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
           string cin = textBox4.Text;
            string nomEtablissement = textBox5.Text;
            string adress = textBox6.Text;
           etudiant c = new etudiant(id, nom, prenom, cin,nomEtablissement,adress );
            gc.ajouter(c);
            this.chargerData();
            MessageBox.Show("Etudiant ajoutée avec succes");
            this.annuler();
        }
        public void annuler()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            etudiant c = gc.rechercher(id);
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
            string cin = textBox4.Text;
            string nomEtablissement = textBox5.Text;
            string adress = textBox6.Text;
            this.chargerData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            gc.delete(id);
            this.chargerData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
