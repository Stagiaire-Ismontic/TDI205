using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosutmOrders
{
    public partial class Form2 : Form
    {
        GestionCostumers Go;
        Form3 f;
        public Form2(Form3 f,GestionCostumers go) : this()
        {
            this.Go = go;
            this.f = f;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string s = this.textBox2.Text;
            Costumer c = new Costumer(id, s);
            if (Go.ajouter(c)) MessageBox.Show("done");
            else MessageBox.Show("big problem");
            data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            if (Go.Supprimer(id)) MessageBox.Show("done");
            else MessageBox.Show("big problem");
            data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBox1.Text);
            string s = this.textBox2.Text;
            Costumer c = new Costumer(id, s);
            if (Go.Modifier(c)) {
                data();
                MessageBox.Show("done"); 
            }
            else MessageBox.Show("big problem");
        }

        public void data()
        {
            this.dataGridView1.Rows.Clear();
                this.Go.LstO.ForEach(a => this.dataGridView1.Rows.Add(a.ID,a.NomEtPrenom));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            data();
        }
    }
}
