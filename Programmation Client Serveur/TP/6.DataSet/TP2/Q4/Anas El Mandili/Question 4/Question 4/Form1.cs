using Question_4.MyDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MyDS DS = new MyDS();
            new Etudiant1TableAdapter().FillByEtudiant_ID(DS.Etudiant1, textBox1.Text);
            new Etablissement1TableAdapter().Fill(DS.Etablissement1);
            bindingSource1.DataSource = DS.Etudiant1.ToList<MyDS.Etudiant1Row>();
        }
    }
}
