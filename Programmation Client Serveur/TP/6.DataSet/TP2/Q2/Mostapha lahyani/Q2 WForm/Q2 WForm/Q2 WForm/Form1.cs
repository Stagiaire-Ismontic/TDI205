using System;
using Q2_WForm.DSTableAdapters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        tblClientTableAdapter cll = new tblClientTableAdapter();

        public void Actualiser()
        {
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = new tblClientTableAdapter().GetData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = new tblClientTableAdapter().GetData();

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            string cin = txtCIN.Text;
            int id = int.Parse(txtid.Text);
            string name = txtFirst_Name.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            int nb_phone = int.Parse(txtnb_Phone.Text);
            cll.Insert(cin, id, name, lname, nb_phone, email);
            this.Actualiser();

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            DS.tblClientDataTable cl_dataset = new DS.tblClientDataTable();
            cll.Fill(cl_dataset);
            string cin = txtCIN.Text;
            int id = int.Parse(txtid.Text);
            string name = txtFirst_Name.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            int nb_phone = int.Parse(txtnb_Phone.Text);
            DS.tblClientRow clrow = cl_dataset.FindById(id);

            if (clrow != null)
            {

                clrow.Cin = cin;
                clrow.Fname = name;
                clrow.Lname = lname;
                clrow.Nb_Phone = nb_phone;
                clrow.Email = email;
                this.Actualiser();
                MessageBox.Show("La Modification termine avec succes");
            }
            else
            {
                MessageBox.Show("Le Client n'existe pas!!!!!");
            }
        }

        private void BtnDebut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            string message = "Voullez vous vraiment supprimer ce Employe";
            if (MessageBox.Show(message, "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DS.tblClientRow Em = new tblClientTableAdapter().GetData().FindById(int.Parse(txtid.Text));

                Em.Delete();
                new tblClientTableAdapter().Update(Em);

                this.Actualiser();
            }
        }

      
    }
}
