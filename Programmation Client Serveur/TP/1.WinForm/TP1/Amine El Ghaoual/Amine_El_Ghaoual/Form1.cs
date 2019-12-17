using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amine_El_Ghaoual
{
    public partial class Form1 : Form
    {
        public GestionPerson Gp = new GestionPerson();

        public gestionGenre g = new gestionGenre();
        public Form1()
        {
            InitializeComponent();
        }
        private void Afficher(Personne p)
        {

            labelid.Text = p.Id.ToString();
            textBox2.Text = p.nom;
            textBox3.Text = p.prenom;
            textBox4.Text = p.age.ToString();
            comboBox1.Text = p.Genre.ToString();
        }
        public void Vide()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        public void ok()
        {
            g.Ajouter(new Genre("Homme"));
            g.Ajouter(new Genre("Femme"));
            comboBox1.DataSource = g.afficher();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                string prenom = this.textBox3.Text;
                int age = int.Parse(this.textBox4.Text);
                Gp.Ajouter(new Personne(nom, prenom, age, new Genre(comboBox1.Text)));
                Actualiser();
                Vide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualiser()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Gp.afficher();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.textBox2.Text;
                string prenom = this.textBox3.Text;
                int age = int.Parse(this.textBox4.Text);
                int id = int.Parse(labelid.Text);
                Genre g = new Genre(comboBox1.Text);
                bool b = Gp.Modifier(new Personne() { Id = id, Nom = nom, Age = age, Prenom = prenom, Genre = g });
                if (b == false) MessageBox.Show("N'existe pas","erreur",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Actualiser();
                this.Vide();
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
               bool l= Gp.Suprimer(int.Parse(labelid.Text));
                if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Actualiser();
                this.Vide();
            }
            catch (Exception)
            {

                MessageBox.Show("Select votre person a supprimer","erreur",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Personne> l = Gp.afficher();
            List<Personne> ls = new List<Personne>();
            foreach(var item in l)
            {
                if(item.nom.Contains(textBox2.Text))
                {
                    ls.Add(item);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ls;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelid.Hide();
            ok();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                int position = dataGridView1.CurrentRow.Index;
                Personne p = new Personne();
                p = Gp.afficher()[position];
                Afficher(p);
            }

        }
    }
}
