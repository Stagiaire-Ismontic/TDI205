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
    public partial class Form2 : Form
    {
        public GestionStagaires GS = new GestionStagaires();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                string prenom = this.textBox3.Text;
                int id = int.Parse(this.textBox1.Text);
                GS.ajouter(id, nom,prenom);
                actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void actualiser()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Stagiaire s in this.GS.lststag)
            {
                this.dataGridView1.Rows.Add(s.Id,s.Nom,s.Prenom);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GS.suprimer(int.Parse(this.textBox1.Text));
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
                string prenom = this.textBox3.Text;
                int id = int.Parse(this.textBox1.Text);
                this.GS.modifier(id, nom,prenom);
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
                this.textBox2.Text = this.GS.recherche(id).Nom;
                this.textBox3.Text = this.GS.recherche(id).Prenom;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
