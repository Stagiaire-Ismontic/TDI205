using System;
using WindowsFormsApp1.DSTableAdapters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DS DD = new DS();
            new tblClientTableAdapter().FillByCin(DD.tblClient, this.txtRechercher.Text);
            dataGridView1.DataSource = DD.tblClient.ToList<DS.tblClientRow>();


            
        }
    }
}
