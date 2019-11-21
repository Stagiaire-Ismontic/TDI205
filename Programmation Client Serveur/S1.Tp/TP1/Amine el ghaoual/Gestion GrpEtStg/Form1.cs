using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_GrpEtStg
{
    public partial class Form1 : Form
    {
        public GestionGroupe GP = new GestionGroupe();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom=this.textBox2.Text;
                int id = int.Parse(this.textBox1.Text);
                GP.ajouter(id, nom);
                actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void actualiser()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Groupe g in this.GP.lstGrp) 
            {
                this.dataGridView1.Rows.Add(g.Id,g.Nom);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GP.suprimer(int.Parse(this.textBox1.Text));
                this.actualiser();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                int id = int.Parse(this.textBox1.Text);
                this.GP.modifier(id,nom);
                this.actualiser();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBox1.Text);
                this.textBox2.Text = this.GP.recherche(id).Nom;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
