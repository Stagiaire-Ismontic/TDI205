using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page
{
    public partial class form_projet : Form
    {
        private object from;
        public form_projet()
        {
            InitializeComponent();
        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_gere_proj form = new form_gere_proj();
            form.Show();
        }
    }
}
