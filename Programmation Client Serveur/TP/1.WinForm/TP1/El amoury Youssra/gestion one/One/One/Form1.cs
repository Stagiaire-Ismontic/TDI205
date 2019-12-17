using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.chargerData();
        }
        GestionEmployer g = new GestionEmployer();
        public void chargerData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = g.List;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.txtId.Text);
            var nom = this.txtNom.Text;
            var prenom = this.txtprenom.Text;
            Employer a = new Employer(id,nom, prenom);
            g.Ajouter(a);
            this.chargerData();
            clean();
            MessageBox.Show("ajout avec succes entrer un autre employer");
           
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
       
            this.dataGridView1.DataSource = this.g.List;
        }

        private void clean()
        {
            this.txtId.Clear();
            this.txtNom.Clear();
            this.txtprenom.Clear();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
            var id=int.Parse(this.txtId.Text);
            g.Supprimer(id);
            this.chargerData();

           
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.txtId.Text);
            Employer ea = g.Chercher(id);
            ea.Nom = this.txtNom.Text;
            ea.Prenom = this.txtprenom.Text;
            g.Modifier(ea);this.chargerData();
            this.clean();



        }
    }
}
