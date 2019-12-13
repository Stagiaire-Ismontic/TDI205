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
        public Form1()
        {
            InitializeComponent();
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
    }
            
}
