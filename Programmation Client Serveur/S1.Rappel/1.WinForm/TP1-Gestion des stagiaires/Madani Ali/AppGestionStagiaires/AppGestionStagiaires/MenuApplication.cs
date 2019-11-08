using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppGestionStagiaires.PackageStagiaires;
using TP1.PackageGroupes;
namespace TP1
{
    public partial class MenuApplication : Form
    {
        public MenuApplication()
        {
            InitializeComponent();
        }

        private void gestionDesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionStagiaires(true);
            FormGestionStagiaires fgs = new FormGestionStagiaires();
            fgs.Show();
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionGroupes fgg = new FormGestionGroupes();
            fgg.Show();
        }
    }
}
