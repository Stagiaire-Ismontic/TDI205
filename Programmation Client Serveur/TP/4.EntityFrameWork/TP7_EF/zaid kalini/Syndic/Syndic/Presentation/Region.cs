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

namespace Syndic.NewFolder1
{
    public partial class Region : Form
    {
        
        RegionService regions = new RegionService();
        string Mood = "Change";

        public AppContext Context { get; set; }

        public Region()
        {
            InitializeComponent();
            dgvRgionView.DataSource = regions.Show();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            if (Mood == "Added")
            {
                regions.Added(new MesClasses.Region(0, txtName.Text, Convert.ToInt32(txtPopulationTotal.Text), Convert.ToInt32(txtTotalRegion.Text)));
                MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRgionView.DataSource = regions.Show();
                Mood = "change";
            }
            else
            {
                regions.Update(new MesClasses.Region((int)dgvRgionView.CurrentRow.Cells[0].Value, txtName.Text, Convert.ToInt32(txtPopulationTotal.Text), Convert.ToInt32(txtTotalRegion.Text)));
                MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRgionView.DataSource = regions.Show();
            }
        }

        public void Show(AppContext context)
        {
            this.Context = context;
            this.Show();
        }

        private void txtNew_Click(object sender, EventArgs e)
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
            //supprimer
            regions.Delete((int)dgvRgionView.CurrentRow.Cells[0].Value);
            MessageBox.Show("Votre Operation est effactuer", "Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvRgionView.DataSource = regions.Show();
        }

        private void dgvRgionView_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dgvRgionView.CurrentRow.Cells[1].Value.ToString();
            txtPopulationTotal.Text= dgvRgionView.CurrentRow.Cells[2].Value.ToString();
            txtTotalRegion.Text= dgvRgionView.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
