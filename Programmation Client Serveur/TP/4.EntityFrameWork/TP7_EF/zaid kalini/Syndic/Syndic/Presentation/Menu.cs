
using Syndic.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic.NewFolder1
{
    public partial class Menu : Form
    {
        AppContext context = new AppContext();
        public Menu()
        {
            InitializeComponent();
        }

        private void syndicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Syndic frm = new Syndic();
            
            frm.MdiParent=this;
            frm.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Region rg = new NewFolder1.Region();
            rg.MdiParent = this;
            rg.Show(this.context);
        }

        private void villeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ville ville = new Ville();
            ville.MdiParent = this;
            ville.Show();
        }

    }
}
