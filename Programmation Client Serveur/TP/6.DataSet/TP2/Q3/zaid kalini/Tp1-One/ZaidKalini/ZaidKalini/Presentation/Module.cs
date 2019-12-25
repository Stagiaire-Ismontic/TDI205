﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaidKalini.CrystalReport;
using ZaidKalini.ModeDeconnecter;
using ZaidKalini.Services;

namespace ZaidKalini
{
    public partial class Module : Form
    {
        string etat = "change";
        ModuleService serviceM = new ModuleService();
        BindingManagerBase bmb;
        public Module()
        {
            InitializeComponent();
           
            txtFind.Hide();
            txtModule.DataBindings.Add("Text", serviceM.Show(), "Nom");
            bmb=this.BindingContext[serviceM.Show()];
            show();
            lblPos.Text=bmb.Position+1+"/"+bmb.Count;
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
                serviceM.Ajouter(new BusnissLayer.Modules { Id =id, Nom_module = txtModule.Text });
                MessageBox.Show("You added successfuly", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Program.Modules = serviceM.Show().ToList();
                show();
                etat = "Change";
            }
            else
            {
                // get id from datagrid view for update
                var str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                serviceM.Modifier(new BusnissLayer.Modules { Id = Convert.ToInt32(str), Nom_module = txtModule.Text });
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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var str = serviceM.Show(txtFind.Text);
                dataGridView1.DataSource = str;
                txtModule.Text = str.Rows[0][1].ToString();
            }
            catch
            {
                return;
            }
          

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked) txtFind.Show();
                else
                    txtFind.Hide();
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button last
            bmb.Position = bmb.Count - 1;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button next
            bmb.Position++;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void back_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }

        private void first_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPos.Text = bmb.Position + 1 + "/" + bmb.Count;
        }
    }
}
