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
        string Mood = "Changed";
        public Ville()
        {
            InitializeComponent();
            cb_region.DataSource = villes.LesRegion();
            cb_region.ValueMember = "id";
            cb_region.DisplayMember = "Nom_region";
            dgvRgionView.DataSource = villes.Show();
            
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            if (Mood == "Added")
            {
                var rg = regions.Find((int)cb_region.SelectedValue);
                villes.Added(new MesClasses.Ville(0, txtName.Text, rg, Convert.ToInt32(txtTotalVille.Text)));
                MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mood = "changed";
            }
            else
            {
                var rg = regions.Find((int)cb_region.SelectedValue);
                int id= ((int)cb_region.SelectedValue);
                villes.Update(new MesClasses.Ville(id, txtName.Text, rg, Convert.ToInt32(txtTotalVille.Text)));
                MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    var txt = (TextBox)item;
                    txt.Clear();
                }
            }
            Mood = "Added";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //delete
            regions.Delete((int)dgvRgionView.CurrentRow.Cells[0].Value);
            MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvRgionView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtName.Text = dgvRgionView.CurrentRow.Cells[1].Value.ToString();
                txtTotalVille.Text = dgvRgionView.CurrentRow.Cells[3].Value.ToString();
                cb_region.Text = dgvRgionView.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                return;
            }
           
        }
    }
}
