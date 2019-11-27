using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cruud
{
    
    public partial class Form1 : Form
    {
        GestionStagaires gs = new GestionStagaires();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(this.textBox1.Text);
                string nom = this.textBox2.Text;
                string prenom = this.textBox3.Text;
                gs.ajouter(new Stagiaire(i, nom, prenom));
                MessageBox.Show("stagiaire ajouté!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                int i = int.Parse(this.textBox1.Text);
                string nom = this.textBox2.Text;
                string prenom = this.textBox3.Text;
                this.gs.modifier(new Stagiaire(i, nom, prenom));
                MessageBox.Show("stagiare modifié");
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
                int i = int.Parse(this.textBox1.Text);
                
                if (MessageBox.Show("vous etes sure","attention",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.gs.supprimer(i);
                MessageBox.Show("stagiare supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Stagiaire> lst = this.gs.affiche();
            this.dataGridView1.DataSource = lst;
        }
    }
}
