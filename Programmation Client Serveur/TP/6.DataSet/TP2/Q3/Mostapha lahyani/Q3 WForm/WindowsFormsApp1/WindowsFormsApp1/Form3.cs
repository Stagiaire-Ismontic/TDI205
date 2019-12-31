using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DSTableAdapters;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            DS DD = new DS();
            new ClientCommandTableAdapter().FillByIDCmd(DD.ClientCommand, int.Parse(this.txtRechercher.Text));
            dataGridView2.DataSource = DD.ClientCommand.ToList<DS.ClientCommandRow>();
        }
    }
}
