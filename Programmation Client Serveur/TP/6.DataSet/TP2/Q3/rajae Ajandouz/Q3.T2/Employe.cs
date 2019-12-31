using Q3.T2.EmplDataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Q3.T2
{
    public partial class Employe : Form
    {
        public Employe()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            dataGridView1.DataSource = null;
            EmplData Ed = new EmplData();
            new EmployeTableAdapter().Fill(Ed.Employe);
            new SalaireTableAdapter().Fill(Ed.Salaire);
            dataGridView1.DataSource = Ed.Employe.ToList<EmplData.EmployeRow>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=null;
            EmplData Ed = new EmplData();
            new EmployeTableAdapter().FillByNom(Ed.Employe,nom:textBox1.Text);
            new SalaireTableAdapter().Fill(Ed.Salaire);
            dataGridView1.DataSource =Ed.Employe .ToList<EmplData.EmployeRow>();
        }
    }
}
