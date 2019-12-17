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
    public partial class Form1 : Form
    {
        GestionOrders GO;
        GestionCostumers GC ;
        Form3 f;
        public Form1(Form3 f, GestionOrders Po, GestionCostumers GC):this()
        {
            this.GC = GC;
            this.GO = Po;
            this.f = f;
            dataa();
            data();
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            int id = this.comboBox1.SelectedIndex;
            Orders o = new Orders(num, nom, GC.LstO[id]);
            if (this.GO.ajouter(o)) { MessageBox.Show("done");}
            else
            {
                MessageBox.Show("big problem");
            }
            data();
            dataa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox1.Text);
            if (this.GO.Supprimer(num)) MessageBox.Show("done");
            else
            {
                MessageBox.Show("big problem");
            }
            data();
            dataa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            int id = this.comboBox1.SelectedIndex;
            Orders o = new Orders(num, nom, GC.recherche(id));
            if (GO.Modifier(o)) MessageBox.Show("done");
            else
            {
                MessageBox.Show("big problem");
            }
            data();
            dataa();
        }
        
        public void data()
        {
            this.dataGridView1.Rows.Clear();
            this.GO.LstO.ForEach(a => this.dataGridView1.Rows.Add(a.NumOrder, a.NamOrder1,a.C.NomEtPrenom));
        }
        public void dataa()
        {
            comboBox1.ResetText();
            this.comboBox1.Items.Clear();
            this.GC.LstO.ForEach(o => this.comboBox1.Items.Add(o.NomEtPrenom));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Dispose();
        }
    }
}
