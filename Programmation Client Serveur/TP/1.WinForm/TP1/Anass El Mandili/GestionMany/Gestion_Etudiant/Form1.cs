using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Etudiant
{
    public partial class Form1 : Form
    {
         private GestionEtudiant GE = new  GestionEtudiant();
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                string tel = this.textBox3.Text;
                int id = int.Parse(this.textBox1.Text);
                GE.ajouter(id, nom,tel);
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
            foreach (Etudiant E in this.GE.lststag)
            {
                this.dataGridView1.Rows.Add(E.Etud_Id1,E.Etud_Name1,E.Etud_Tel1);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GE.suprimer(int.Parse(this.textBox1.Text));
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
                string tel = this.textBox3.Text;
                int id = int.Parse(this.textBox1.Text);
                this.GE.modifier(id, nom,tel);
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
                this.textBox2.Text = this.GE.recherche(id).Etud_Name1;
                this.textBox3.Text = this.GE.recherche(id).Etud_Tel1 ;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
