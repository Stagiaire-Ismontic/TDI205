using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Services;
using WindowsFormsApp2.Entities;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        AdminService admn = new AdminService();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;
            string password = this.textBox4.Text;
            Admins a = new Admins() { Id=id,Nom=nom,Prenom=prenom,Passwsord=password };
            this.admn.Add(a);
            updateData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            this.admn.Delete(id);
            updateData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;
            string password = this.textBox4.Text;
            Admins a = new Admins() { Id = id, Nom = nom, Prenom = prenom, Passwsord = password };
            this.admn.Update(a);
            updateData();
        }

        private void updateData() {
            this.dataGridView1.DataSource = this.admn.getAdmins();
        }
    }
}
