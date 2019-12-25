using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.DataSet1TableAdapters;

namespace TP2
{
    public partial class Gestion_Livre : Form
    {
        public Gestion_Livre()
        {
            InitializeComponent();
        }

        private void btn_reche_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataSet1 ds = new DataSet1();
            new LivreTableAdapter().FillByid(ds.Livre,Convert.ToInt32(text_reche.Text));
            dataGridView1.DataSource = ds.Livre.ToList<DataSet1.LivreRow>();

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
