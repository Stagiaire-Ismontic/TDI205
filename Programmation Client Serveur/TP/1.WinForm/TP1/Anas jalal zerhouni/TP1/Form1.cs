using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        GestionAdmins ga = new GestionAdmins();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;
            string pass = this.textBox4.Text;
            Admins a = new Admins() {Id=id,Nom=nom,Prenom=prenom,Passwsord=pass };
            this.ga.ajouter(a);
            chargerData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            this.ga.supprimer(id);
            chargerData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            string prenom = this.textBox3.Text;
            string pass = this.textBox4.Text;
            Admins a = new Admins() { Id = id, Nom = nom, Prenom = prenom, Passwsord = pass };
            this.ga.modifier(a);
            chargerData();

        }

        private void chargerData()
        {
            this.dataGridView1.Rows.Clear();
            this.ga.getAdmins().ForEach(a=>this.dataGridView1.Rows.Add(a.Id,a.Nom,a.Prenom,a.Passwsord));
        }
    }
}
