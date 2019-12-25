using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace tpbudegtdataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void chargerdata()
        {
            new DataSet1TableAdapters.UserrTableAdapter().Fill(dataSet1.Userr);
            bindingSource1.DataSource = dataSet1.Userr;

            //    bindingSource1.DataSource = new DataSet1TableAdapters.UserrTableAdapter().GetData();
            //txtId.DataBindings.Add("Text", bindingSource1, "ID");
            //txtnom.DataBindings.Add("Text", bindingSource1, "FirstName");
            //txtprenom.DataBindings.Add("Text", bindingSource1, "LastName");
            //txtcin.DataBindings.Add("Text", bindingSource1, "CIN");
            //    comboBox1.DataSource = new DataSet1TableAdapters.salaireTableAdapter().GetData();
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Userr' table. You can move, or remove it, as needed.
            //this.userrTableAdapter.Fill(this.dataSet1.Userr);
            // TODO: This line of code loads data into the 'dataSet1.salaire' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet1.salaire' table. You can move, or remove it, as needed.
            //this.salaireTableAdapter.Fill(this.dataSet1.salaire);
            // TODO: This line of code loads data into the 'dataSet1.Userr' table. You can move, or remove it, as needed.
            ////this.userrTableAdapter.Fill(this.dataSet1.Userr);

            this.chargerdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.UserrTableAdapter usr = new DataSet1TableAdapters.UserrTableAdapter();
            usr.Insert(Convert.ToInt32(txtId.Text), txtnom.Text, txtprenom.Text, txtcin.Text/*Convert.ToInt32(comboBox1.SelectedValue)*/);
            this.txtprenom.Text = "";

            this.txtId.Text = "";

            this.txtnom.Text = "";

            this.txtcin.Text = "";
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            this.chargerdata();
        }

        //private void btnsupprimer_Click(object sender, EventArgs e)
        //{
        //    DataSet1.UserrRow s = new DataSet1TableAdapters.UserrTableAdapter().GetData().FindByID(Convert.ToInt32(this.txtId.Text));
        //    s.Delete();
        //    new DataSet1TableAdapters.UserrTableAdapter().Update(s);


        //}

        private void btnmodifer_Click(object sender, EventArgs e)
        {
            DataSet1.UserrRow s = new DataSet1TableAdapters.UserrTableAdapter().GetData().FindByID(Convert.ToInt32(this.txtId.Text));
            s.CIN = this.txtcin.Text;
            s.FirstName = this.txtprenom.Text;
            s.LastName = this.txtnom.Text;
            new DataSet1TableAdapters.UserrTableAdapter().Update(s);
            this.chargerdata();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        
        private void btnsupprimer_Click_1(object sender, EventArgs e)
        {
            DataSet1.UserrRow s = new DataSet1TableAdapters.UserrTableAdapter().GetData().FindByID(Convert.ToInt32(this.txtId.Text));
            s.Delete();
            new DataSet1TableAdapters.UserrTableAdapter().Update(s);
            this.chargerdata();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataSet1 ds = new DataSet1();
            new DataSet1TableAdapters.UserrTableAdapter().FillByCIN(ds.Userr, this.txtrecherche.Text);
            new DataSet1TableAdapters.salaireTableAdapter().Fill(ds.salaire);
            dataGridView1.DataSource = ds.Userr.ToList<DataSet1.UserrRow>(); 



        }
    }
}
