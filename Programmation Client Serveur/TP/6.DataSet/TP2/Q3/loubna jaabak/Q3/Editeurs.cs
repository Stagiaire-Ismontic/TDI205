using Q3.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Editeurs : Form
    {
        public Editeurs()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            dataGridView1.DataSource = null;
            DS ds = new DS();
            new EditeurTableAdapter().Fill(ds.Editeur);
            new LivreTableAdapter().Fill(ds.Livre);
            dataGridView1.DataSource = ds.Editeur.ToList<DS.EditeurRow>();

        }

        private void but_Rechercher_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DS ds = new DS();
            new EditeurTableAdapter().FindByNom(ds.Editeur, Nom: textBox_Recherche.Text);
            new LivreTableAdapter().Fill(ds.Livre);
            dataGridView1.DataSource = ds.Editeur.ToList<DS.EditeurRow>();
        }
    }
}
