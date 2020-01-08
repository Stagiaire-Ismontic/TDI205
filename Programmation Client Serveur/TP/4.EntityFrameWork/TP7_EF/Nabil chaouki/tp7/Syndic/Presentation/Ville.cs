using Syndic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic.Presentation
{
    public partial class Ville : Form
    {
        VilleServices villes = new VilleServices();
        RegionService regions = new RegionService();
        public Ville()
        {
            InitializeComponent();
            cb_region.DataSource = villes.LesRegion();
            cb_region.ValueMember = "id";
            cb_region.DisplayMember = "Nom_region";
            
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            var rg = regions.Find((int)cb_region.SelectedValue);
            villes.Added(new MesClasses.Ville(0, txtName.Text, rg, Convert.ToInt32(txtTotalRegion.Text)));
            MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
