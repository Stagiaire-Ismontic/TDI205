using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
  
    public partial class Form1 : Form
    {
        GestionStagiare.GestionStagiare gestion = new GestionStagiare.GestionStagiare();
        public Form1()
        {
            InitializeComponent();
            Afficher();
        }
        //Method afficher
        void Afficher()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestion.Afficher();
        }
        //Ajouter
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                gestion.Ajouter(new GestionStagiare.Stagiare(Convert.ToInt32(id.Text), nom.Text, prenom.Text, cin.Text));
                MessageBox.Show("Votre Operation est effactué", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Afficher();
            }
            catch
            {
                return;
            }
        }
        //modifier
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                gestion.Modifier(new GestionStagiare.Stagiare(index, nom.Text, prenom.Text, cin.Text));
                MessageBox.Show("Votre Operation est effactué", "Modiffier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Afficher();
            }
            catch
            {
                return;
            }
        }
        //Supprimer
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                gestion.Suprimer(index);
                MessageBox.Show("Votre Operation est effactué", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Afficher();
            }
            catch
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
