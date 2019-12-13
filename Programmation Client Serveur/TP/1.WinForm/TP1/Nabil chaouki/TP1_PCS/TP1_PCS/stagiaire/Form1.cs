using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_PCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Stagiaires> ls = new List<Stagiaires>();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = int.Parse(this.txtid.Text);
                string nom = this.txtnom.Text;
                string Prenom = this.txtprenom.Text;
                int age = int.Parse(this.txtage.Text);
                string groupe = this.txtgroupe.Text;
                ls.Add(new Stagiaires(ids, nom, Prenom, age));

                this.txtage.Text = "";
                this.txtgroupe.Text = "";
                this.txtnom.Text = "";

                this.txtprenom.Text = "";
                this.txtid.Text = "";

                this.Chargerdata();



            }
            catch (Exception err)
            {
                MessageBox.Show(("ERREU"));

            }
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {    
            this.panel1.Show();
        }
        int r;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chargerdata()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Stagiaires s in ls)
            {
                this.dataGridView1.Rows.Add(s.NomS1, s.Prenom1, s.Age, s.IdS1);

            }

        }
        
        private int  rechercher( int id)
        {
          foreach( Stagiaires c in ls)
            {
                if (c.IdS1 == id)
                {
                    return ls.IndexOf(c);
                }
            }
            return -1;
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            ls.RemoveAt(rechercher(r));
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            r = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            this.panel2.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
