using Interface_Maj.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Maj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Actualizer()
        {
            DataSet1 ds = new DataSet1();
            new ClasseTableAdapter().Fill(ds.Classe);
            new PersoneTableAdapter().Fill(ds.Persone);
            bindingSource1.DataSource = ds.Classe.ToList<DataSet1.ClasseRow>();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Actualizer();
            comboBox1.DataSource = new PersoneTableAdapter().GetData();
            textBox1.DataBindings.Add("Text", bindingSource1, "ID");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClasseTableAdapter c = new ClasseTableAdapter();
            c.Insert(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue));
            this.Actualizer();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1.ClasseRow c = new ClasseTableAdapter().GetData().FindByIDClasse(int.Parse(textBox1.Text));
            c.Namee = textBox2.Text;
            c.ID = (int)comboBox1.SelectedValue;
            new ClasseTableAdapter().Update(c);
            this.Actualizer();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg =("Voulez vous vraiment supprimer ce stagiare");
            if (MessageBox.Show(msg, "message de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet1.ClasseRow c = new ClasseTableAdapter().GetData().FindByIDClasse(int.Parse(textBox1.Text));
                c.Delete();
                new ClasseTableAdapter().Update(c);
                this.Actualizer();


            }
        }
    }
}
