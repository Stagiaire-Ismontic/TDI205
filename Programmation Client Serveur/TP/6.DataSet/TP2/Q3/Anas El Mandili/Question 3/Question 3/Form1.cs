using Question_3.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3
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
            DataSet1 MyDS = new DataSet1();
            new Etudiant1TableAdapter().FillByEtudiant_Name(MyDS.Etudiant1, textBox1.Text);
            new Etablissement1TableAdapter().Fill(MyDS.Etablissement1);
            dataGridView1.DataSource = MyDS.Etudiant1.ToList<DataSet1.Etudiant1Row>();
        }
    }
}
