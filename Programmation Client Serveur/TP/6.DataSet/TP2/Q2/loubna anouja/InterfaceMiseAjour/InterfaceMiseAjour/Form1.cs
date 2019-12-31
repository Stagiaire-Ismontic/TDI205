using InterfaceMiseAjour.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceMiseAjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void actualiser()
        {
            DS ds = new DS();
            new commandeTableAdapter().Fill(ds.commande);
            new livraisonTableAdapter().Fill(ds.livraison);
            bindingSource1.DataSource = ds.commande.ToList<DS.commandeRow>();
        }
        public void annuler()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.actualiser();
            textBox1.DataBindings.Add("text", bindingSource1, "Id");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            commandeTableAdapter cmd = new commandeTableAdapter();
            cmd.Insert(textBox2.Text, textBox2.Text);
            this.actualiser();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.annuler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DS.commandeRow c = new commandeTableAdapter().GetData().FindById(Convert.ToInt32(textBox1.text));
        }
    }
}
