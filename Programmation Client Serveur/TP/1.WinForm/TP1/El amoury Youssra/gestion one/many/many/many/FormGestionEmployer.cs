using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace many
{
    public partial class FormGestionEmployer : Form
    {
        public FormGestionEmployer()
        {
            InitializeComponent();
        }

        GestionEntreprise p = new GestionEntreprise();

        GestionEmployer g = new GestionEmployer();

        public void chargerData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = g.Afficher() ;     
        }

        public void changercombo()
        {
            p.Ajouter(new Entreprise(1,"Entreprise1"));
            p.Ajouter(new Entreprise(2, "Entreprise2"));
            comboBox1.DataSource = p.Afficher();
        }

        public void Vide()
        {
            txtId.Clear();
            txtNom.Clear();
            txtprenom.Clear();
        }

        public void affi(Employer e)
        {
            txtId.Text = e.Id.ToString();
            txtNom.Text = e.Nom;
            txtprenom.Text = e.Prenom;
            comboBox1.Text = e.Entreprise.Nom;
        }

        private void FormGestionEmployer_Load(object sender, EventArgs e)
        {
            changercombo();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                int p = dataGridView1.CurrentRow.Index;
                Employer o = g.Afficher()[p];
                affi(o);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
               bool i= g.Ajouter(new Employer(int.Parse(txtId.Text), txtNom.Text, txtprenom.Text, new Entreprise() { Nom = comboBox1.Text }));
                if(i==false) MessageBox.Show("Existe deja", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chargerData();
                Vide();
            }
            catch (Exception)
            {
                MessageBox.Show("Donnes incorrect","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                bool i = g.Supprimer(int.Parse(txtId.Text));
                if (i == false) MessageBox.Show("n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chargerData();
                Vide();
            }
            catch (Exception)
            {
                MessageBox.Show("Donnes incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                bool i = g.Modifier(new Employer(int.Parse(txtId.Text), txtNom.Text, txtprenom.Text, new Entreprise() { Nom = comboBox1.Text }));
                if (i == false) MessageBox.Show("Donnes incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chargerData();
                Vide();
            }
            catch (Exception)
            {
                MessageBox.Show("Donnes incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
