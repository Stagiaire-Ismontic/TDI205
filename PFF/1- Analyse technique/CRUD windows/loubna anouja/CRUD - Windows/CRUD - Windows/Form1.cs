using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD___Windows
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            chargerData();
        }
        GestiondesCommande gc = new GestiondesCommande();
        private void chargerData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gc.Cmd;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int idc = int.Parse(textBox1.Text);
            string code = textBox2.Text;
            string nom = textBox3.Text;
            int idl = int.Parse(textBox4.Text);
            DateTime d = DateTime.Parse(textBox5.Text);
            commande c = new commande(idc, code, nom, idl, d);
            gc.ajouter(c);
            this.chargerData();
            MessageBox.Show("commande ajoutée avec succes");
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
            commande c = gc.rechercher(id);
            c.Code = textBox2.Text;
            c.Nom = textBox3.Text;
            c.IdL = int.Parse(textBox4.Text);
            c.DateL = DateTime.Parse(textBox5.Text);
            gc.modifier(c);
            this.chargerData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            gc.delete(id);
            this.chargerData();
        }
    }
}
