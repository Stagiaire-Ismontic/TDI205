using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            //string prenom = this.txtprenom.Text;
            //string nom = this.txtnom.Text;
            //string email = this.txtemail.Text;
            //string Cin = this.txtcin.Text;
            var cate = d.Users.Where(c => c.ID == id).Count();
            if (cate == 0)
            {
                User a = new User();
                a.ID = int.Parse(this.txtId.Text);
                a.Name = this.txtnom.Text;
                a.LastName = this.txtprenom.Text;
                a.Email = this.txtemail.Text;
                a.CIN = this.txtcin.Text;
                a.Birth = this.dateTimePicker1.Value;
                d.Users.Add(a);
                d.SaveChanges();
                this.chargerdata();

                MessageBox.Show("ajouter avec succes");
                this.txtId.Text = "";
                this.txtnom.Text = "";
                this.txtprenom.Text = "";
                this.txtemail.Text = "";
                this.txtcin.Text = "";
                
            }
            else
            {
                MessageBox.Show("error");
            }



        }
        public void chargerdata()
        {
            d = new budgetEntities();
            dataGridView1.DataSource = d.Users.Select(p => new { ID_User = p.ID, Nom_Catégorie = p.Name, Prenom = p.LastName, age = p.Birth, Email = p.Email, CIN = p.CIN }).ToList();


        }
        public budgetEntities d;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
            //d = new budgetEntities();
            //dataGridView1.DataSource = d.Users.Select(p => new { ID_User = p.ID, Nom_Catégorie = p.Name, Prenom = p.LastName, age = p.Birth, Email = p.Email, CIN = p.CIN }).ToList();

            this.chargerdata();

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    User cat = d.Users.Where(c => c.ID == id).First();
                    d.Users.Remove(cat);

                    d.SaveChanges();
                    this.chargerdata();

                    MessageBox.Show("USer supprimer avec succes");
                }
                catch
                {
                    MessageBox.Show("Userr n'existe pas ");
                }

            }
        }

        private void btnmodifer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                User cat = d.Users.Where(c => c.ID == id).First();
                cat.ID = int.Parse(this.txtId.Text);
                 cat.Name = this.txtnom.Text;
               cat.LastName = this.txtprenom.Text;
                cat.Email = this.txtemail.Text;
                cat.CIN = this.txtcin.Text;
                cat.Birth = this.dateTimePicker1.Value;
                d.SaveChanges();
                this.chargerdata();

                MessageBox.Show("User mdofier avec succes");
                this.txtId.Text = "";
                this.txtnom.Text = "";
                this.txtprenom.Text = "";
                this.txtemail.Text = "";
                this.txtcin.Text = "";
            }
            catch
            {
                MessageBox.Show("User n'existe pas ");
            }
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            this.panel1.Show();

        }
    }
}

