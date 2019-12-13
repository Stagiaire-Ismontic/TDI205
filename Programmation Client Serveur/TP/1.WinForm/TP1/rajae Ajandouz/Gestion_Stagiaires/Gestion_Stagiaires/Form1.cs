using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stagiaires
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Actualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_Stagiaire().GetStagiaire();
        }

        private void button_Ajt_Click(object sender, EventArgs e)
        {
            Stagaire Sg= new Stagaire();
            Sg.prenom = textPrenom.Text;
            Sg.nom = textNom.Text;
            Sg.Tel = texttel.Text;
            Sg.Email = textemail.Text;
            

            new Gestion_Stagiaire().Ajouter(Sg);
        }
        private void Affecher(Stagaire Sg)
        {
            int id= Sg.Id;
            string nom = Sg.nom;
            string prenom = Sg.prenom;
            string tel = Sg.Tel;
            string email = Sg.Email;
            DateTime date = Sg.Datenais;

           dataGridView1.Rows.Add(id,nom,prenom,tel,email,date);

        }

        private void button_Aff_Click(object sender, EventArgs e)
        {
            Gestion_Stagiaire Gs = new Gestion_Stagiaire();

            label1.Text = Gs.List_Stagiaire.Count.ToString();
            this.Actualiser();
        }

        private void button_NV_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textNom.Text = "";
            textPrenom.Text = "";
            textemail.Text = "";
            texttel.Text = "";
            textDatN.Text = "";
        }

        private void button_Sup_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            new Gestion_Stagiaire().Supprimer(id);
            this.Actualiser();
        }
    }
}
