using Q2.TP2.EmplTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2.TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           EmployeTableAdapter Em = new EmployeTableAdapter();
        public void Actualiser()
        {
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = new EmployeTableAdapter().GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TId.Text);
            string Nom = TNom.Text;
            string Prenom = TPrenom.Text;
            string Adress = TAdress.Text;

            Em.Insert(id, Nom, Prenom, Adress);


            this.Actualiser();
        }

        private void Debut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void Précédent_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void Fin_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Empl.EmployeDataTable Emp_data = new Empl.EmployeDataTable();

            Em.Fill(Emp_data);

            int id = Convert.ToInt32(TId.Text);
            string Nom = TNom.Text;
            string Prenom = TPrenom.Text;
            string Adress = TAdress.Text;

            Empl.EmployeRow E = Emp_data.FindByid(id);

            if (E != null)
            {
                E.Nom = Nom;
                E.Prenom = Prenom;
                E.Adress = Adress;
                Em.Update(E);
                this.Actualiser();

                MessageBox.Show("la modification termine avec succes");

            }
            else
            {
                MessageBox.Show("l'Employe n'exeste pas !!!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            string message = "Voullez vous vraiment supprimer ce Employe";
            if (MessageBox.Show(message, "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Empl.EmployeRow Em = new EmployeTableAdapter().GetData().FindByid(Convert.ToInt32(TId.Text));

                Em.Delete();
                new EmployeTableAdapter().Update(Em);

                this.Actualiser();

            }
                    
        }

      
    }
}
