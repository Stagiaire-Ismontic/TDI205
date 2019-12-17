using GestionOne.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionOne
{
    public partial class Form1 : Form
    {
        public GestionEtablissement GE = new GestionEtablissement();
        public Form1()
        {
            InitializeComponent();
            actualiser();
        }
       

        public void actualiser()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Etablissement E in this.GE.ListEtabliss1)
            {
                this.dataGridView1.Rows.Add(E.Etabli_Id1, E.Etabli_Nom1, E.Etabli_Des1);

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

      

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                string tel = this.textBox3.Text;
                int id = int.Parse(this.textBox1.Text);
                GE.ajouter(id, nom, tel);
                actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                string tel = this.textBox3.Text;
                int id = int.Parse(this.textBox1.Text);
                this.GE.modifier(id, nom, tel);
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
                GE.suprimer(int.Parse(this.textBox1.Text));
                this.actualiser();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBox1.Text);
                this.textBox2.Text = this.GE.recherche(id).Etabli_Nom1;
                this.textBox3.Text = this.GE.recherche(id).Etabli_Des1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
