using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        connexion d = new connexion();
        public bool ajouter()
        {
            d.cmd.CommandText = " insert into User values ('" + txtnom + "','" + txtprenom + "','" + txtId.Text + "','" + txtcin.Text + "','" + txtemail.Text + "')";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();
            return true;
        }
        public bool delete()
        {
            d.cmd.CommandText = " delete from User where ID ='" + txtId.Text + "'";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();
            return true;
        }
        public bool Moodifier()
        {
            d.cmd.CommandText = "update User set Nom = '" + txtnom.Text + "',Prenom ='" + txtprenom.Text + "',Moyenne='" + txtemail.Text + "',Age ='" + txtcin.Text + "'where Mat ='" + txtId.Text + "'";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();
            return true;
        }
        public void RemplirGrid()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = " select * from User";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

            if (ajouter() == true)
            {
                MessageBox.Show(" ce stagiaire est ajouter avec succes ");
                RemplirGrid();

            }
            else
            {
                MessageBox.Show(" ce stagiaire existe deja  ");
            }
        }

        private void btnmodifer_Click(object sender, EventArgs e)
        {
            if (Moodifier() == true)
            {
                MessageBox.Show(" ce stagiaire est modifier avec succes ");
                RemplirGrid();

            }
            else
            {
                MessageBox.Show(" ce stagiaire n'existe pas  ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delete() == true)
            {
                MessageBox.Show(" ce stagiaire est supprimer avec succes ");
                RemplirGrid();

            }
        }
    }

}
