using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chargerData();
        }
        GestionGroupes gg = new GestionGroupes();
        private void chargerData()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gg.liste;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            groupe c = new groupe(id, nom);
            gg.ajouter(c);
            this.chargerData();
            MessageBox.Show("groupe ajouté avec succes");
            this.annuler();
            MessageBox.Show(gg.liste[0].Nom);
        }
        public void annuler()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupe g = new groupe();
            g.Id = int.Parse(textBox1.Text);
            g.Nom = textBox2.Text;
            gg.rechercher(g);
            gg.modifier(g);
            this.chargerData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupe g = new groupe();
            g.Id = int.Parse(textBox1.Text);
            g.Nom = textBox2.Text;
            gg.supprimer(g);
            this.chargerData();

        }
    }
}
