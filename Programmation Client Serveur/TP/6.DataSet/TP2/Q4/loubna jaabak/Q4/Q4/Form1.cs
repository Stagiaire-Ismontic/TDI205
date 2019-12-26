using Q4.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Rechercher_Click(object sender, EventArgs e)
        {
            this.editeurByNameRowBindingSource.DataSource = new EditeurByNameTableAdapter().GetDataByName(this.text_Nom.Text);
        }
    }
}
