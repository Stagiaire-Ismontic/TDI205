using DatasetTp.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetTp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            DataSet1 DS = new DataSet1();
            new Etudiant1TableAdapter().Fill(DS.Etudiant1);
            new Etablissement1TableAdapter().Fill(DS.Etablissement1);
            bindingSource2.DataSource = DS.Etudiant1.ToList<DataSet1.Etudiant1Row>();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            comboBox1.DataSource = new Etablissement1TableAdapter().GetData();
            textBox1.DataBindings.Add("text", bindingSource2, "Etudiant_Id");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource2.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource2.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource2.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource2.MoveNext();
        }

        private void bnAjouter_Click(object sender, EventArgs e)
        {
            Etudiant1TableAdapter ETA = new Etudiant1TableAdapter();
            ETA.Insert(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text, Convert.ToInt32(comboBox1.SelectedValue));
            Actualiser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedValue = -1;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DataSet1.Etudiant1Row ER = new Etudiant1TableAdapter().GetData().FindByEtudiant_Id(int.Parse(textBox1.Text));
            ER.Etudiant_Name = textBox2.Text;
            ER.Etudiant_Phone = textBox3.Text;
            ER.Etabliss_Id = Convert.ToInt32(comboBox1.SelectedValue);
            new Etudiant1TableAdapter().Update(ER);
            Actualiser();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           string Message = "Are you sure you Want To Delete";
            if (MessageBox.Show(Message,"Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataSet1.Etudiant1Row E = new Etudiant1TableAdapter().GetData().FindByEtudiant_Id(Convert.ToInt32(textBox1.Text));
                E.Delete();
                new Etudiant1TableAdapter().Update(E);
               this.Actualiser();
            }
           
        }

     
    }
}
