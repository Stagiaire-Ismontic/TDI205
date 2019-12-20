using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaidKalini.Services;

namespace ZaidKalini.Presentation
{
    public partial class PLFormateur : Form
    {
        IReposotory<BusnissLayer.Formateur> Service = new FormateurService();
        string etat = "Add";
        void show()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =Service.Show();
        }
        public PLFormateur()
        {
            InitializeComponent();
            comboBox1.DataSource = new ModuleService().Show();
            comboBox1.DisplayMember = "Nom_module";
            comboBox1.ValueMember = "id";
        }

       
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (etat == "Add")
                {
                    Service.Added(new BusnissLayer.Formateur { Id = Service.GetId(), FullName = txtName.Text, Age = Convert.ToInt32(txtAge.Text), Modules = null });
                    MessageBox.Show("You added successfuly", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show();
                    etat = "Change";
                }
                else
                {
                    // get id from datagrid view for update
                    var str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Service.Update(new BusnissLayer.Formateur { Id = Convert.ToInt32(str), FullName = txtName.Text, Age = Convert.ToInt32(txtAge.Text) });
                    show();
                    MessageBox.Show("You Modify successfuly", "Modify", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
        }
            catch
            {
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //btn New
            etat = "Add";
            txtName.Text = "";
            txtAge.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Service.Delete((int)dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show("You Deleted successfuly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show();
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAge.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void Formateur_Load(object sender, EventArgs e)
        {

        }
    }
}
