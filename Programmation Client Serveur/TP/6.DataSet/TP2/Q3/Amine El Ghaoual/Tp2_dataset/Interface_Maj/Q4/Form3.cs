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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataSet1 ds = new DataSet1();
            new ClasseTableAdapter().FillByNamee(ds.Classe, textBox1.Text);
            new PersoneTableAdapter().Fill(ds.Persone);
            bindingSource1.DataSource = ds.Classe.ToList<DataSet1.ClasseRow>();
        }
    }
}
