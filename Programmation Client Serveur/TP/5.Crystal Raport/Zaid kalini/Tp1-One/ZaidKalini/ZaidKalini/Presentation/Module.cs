using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaidKalini.CrystalReport;
using ZaidKalini.Services;

namespace ZaidKalini
{
    public partial class Module : Form
    {
        string etat = "Add";
        ModuleService serviceM = new ModuleService();
        public Module()
        {
            InitializeComponent();
        }
        void show()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = serviceM.Show();

            
           
        }
        private void txtSave_Click(object sender, EventArgs e)
        {
            if (etat == "Add")
            {
                int id = serviceM.GetId();
                serviceM.Added(new BusnissLayer.Modules { Id =id, Nom_module = txtModule.Text });
                MessageBox.Show("You added successfuly", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Modules = serviceM.Show().ToList();
                show();
                etat = "Change";
            }
            else
            {
                // get id from datagrid view for update
                var str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                serviceM.Update(new BusnissLayer.Modules { Id = Convert.ToInt32(str), Nom_module = txtModule.Text });
                show();
                MessageBox.Show("You Modify successfuly", "Modify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
            }
          
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                serviceM.Delete((int)dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show("You Deleted successfuly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show();
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            etat = "Add";
            txtModule.Text = "";
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtModule.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintViewer viewer = new PrintViewer();
            viewer.ShowDialog();
        }
    }
}
