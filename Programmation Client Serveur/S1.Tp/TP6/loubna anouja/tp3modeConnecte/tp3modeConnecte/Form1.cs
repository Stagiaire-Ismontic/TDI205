using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3modeConnecte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GestiondesCommande gc = new GestiondesCommande();
        private void chargerData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gc.Afficher();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int idc = int.Parse(textBox1.Text);
            string code = textBox2.Text;
            string nom = textBox3.Text;
            commande c = new commande(idc, code, nom);
            gc.Ajouter(c);
            this.chargerData();
            MessageBox.Show("commande ajoutée avec succes");
            this.annuler();
        }
        public void annuler()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id =int.Parse(textBox1.Text);
            string Code = textBox2.Text;
            string Nom = textBox3.Text;
            commande c = new commande(id, Code, Nom);
            gc.Modifier(c);
            this.chargerData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            gc.Supprimer(id);
            this.chargerData();
        }
    }
}
