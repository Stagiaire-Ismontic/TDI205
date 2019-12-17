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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.chargerData();
        }
        public void chargerData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = g.E.Ls;
        }
        private GestionEntreprise g = new GestionEntreprise();
        private void button1_Click(object sender, EventArgs e)
        {
            var nom = this.txtNom.Text;
            var prenom = this.txtPrenom.Text;
           int idEntreprise =int.Parse( this.txtIdEntreprise.Text);
            Employer ea = new Employer(nom, prenom, idEntreprise);
            g.Ajouter(ea);
            clear();
            this.chargerData();
        }
        private void clear()
        {
            this.txtIdEntreprise.Clear();
            this.txtNom.Clear();
            this.txtPrenom.Clear();
        }
    }
}
