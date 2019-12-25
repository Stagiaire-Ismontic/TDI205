using InterfaceMisAjour.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InterfaceMisAjour.DS;

namespace InterfaceMisAjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Actualiser()

        {
            DS ds = new DS();
            new EmployerTableAdapter().Fill(ds.Employer);
            new EntrepriseTableAdapter().Fill(ds.Entreprise);
            bindingSource1.DataSource = ds.Employer.ToList<DS.EmployerRow>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            CmbEntreprise.DataSource = new EntrepriseTableAdapter().GetData();
            txtId.DataBindings.Add("text", bindingSource1, "Id");
        }

        private void btDebut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();

        }

        private void btSuivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void BtFin_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void BtAjouter_Click(object sender, EventArgs e)
        {
            EmployerTableAdapter et = new EmployerTableAdapter();
            et.Insert(/* Convert.ToInt32(txtId.Text), */txtNom.Text, txtPrenom.Text, Convert.ToInt32(CmbEntreprise.SelectedValue));
            this.Actualiser();
        }

        private void BtNouveau_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";

        }

        private void BtModifier_Click(object sender, EventArgs e)
        {
            DS.EmployerRow em = new EmployerTableAdapter().GetData().FindById(Convert.ToInt32(txtId.Text));
            em.Nom = txtNom.Text;
            em.prenom = txtPrenom.Text;
            em.IdEntreprise = (int)CmbEntreprise.SelectedValue;
            new EmployerTableAdapter().Update(em);
            this.Actualiser();
        }

        private void BtSupprimer_Click(object sender, EventArgs e)
        {
            string message="voulez vous vraiment supprimer";
            if(MessageBox.Show(message,"message de confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DS.EmployerRow em = new EmployerTableAdapter().GetData().FindById(Convert.ToInt32(txtId.Text));
                em.Delete();
                new EmployerTableAdapter().Update(em);
                this.Actualiser();
            }

        }

        private void BTChercher_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = null;
            DS ds = new DS();
            new EntrepriseTableAdapter().Fill(ds.Entreprise);
            new EmployerTableAdapter().FillByNom(ds.Employer,txtNomR.Text);
            bindingSource1.DataSource = ds.Employer.ToList<DS.EmployerRow>();
        }
    }
}
