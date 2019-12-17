using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1gestionbudget
{
    public partial class Form1 : Form
    {
        serviceudget Sevice = new serviceudget();
        User g = new User();
        List<Budget> b = new List<Budget>();
        public Form1()
        {
            InitializeComponent();
            b.Add(new Budget("stable", 1));
            b.Add(new Budget("Non stable", 2));
            comboBox1.DataSource = b;
            comboBox1.DisplayMember = "Type_salaire";
           



        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

            g.ID = int.Parse(this.txtId.Text);
            g.LastName = this.txtprenom.Text;
            g.Name = this.txtnom.Text;
            g.Email = this.txtemail.Text;
            g.CIN = this.txtcin.Text;
            Sevice.add(g);
            MessageBox.Show("ajouter avec succes");

            this.txtId.Text = "";
            this.txtnom.Text = "";
            this.txtemail.Text = "";
            this.txtcin.Text = "";
            this.txtprenom.Text = "";


        }

        private void btnmodifer_Click(object sender, EventArgs e)
        {

            g.ID = int.Parse(this.txtId.Text);
            g.LastName = this.txtprenom.Text;
            g.Name = this.txtnom.Text;
            g.Email = this.txtemail.Text;
            g.CIN = this.txtcin.Text;
            Sevice.Update(g);
            MessageBox.Show("Updated");

            this.txtId.Text = "";
            this.txtnom.Text = "";
            this.txtemail.Text = "";
            this.txtcin.Text = "";
            this.txtprenom.Text = "";

        }

        private void btnafficher_Click(object sender, EventArgs e)

        {
            this.chargerdata();
            

        }
        public void chargerdata()
        {

            this.dataGridView1.Rows.Clear();
            foreach(User g in Sevice.U1)
            {
                this.dataGridView1.Rows.Add(g.Name, g.LastName,g.ID,g.CIN,g.Email);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chargerdata();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

            int id = int.Parse(this.txtId.Text);
            Sevice.delete(id);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
            
}
