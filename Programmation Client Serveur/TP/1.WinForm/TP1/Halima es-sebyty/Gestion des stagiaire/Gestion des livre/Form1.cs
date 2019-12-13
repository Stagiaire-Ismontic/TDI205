using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_livre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private void Actualiser()
           {
             dataGV1.DataSource = null;
             dataGV1.DataSource = new Gestion_des_Stagiaire().GetStagiaire();
            }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Stagiaire stg = new Stagiaire();
            stg.Nom = text_nom.Text;
            stg.Prenom = text_prenom.Text;
            stg.Groupe = text_groupe.Text;
            new Gestion_des_Stagiaire().Ajouter(stg);
        }

        private void bDebut_Click(object sender, EventArgs e)
        {
            Stagiaire lv = new Gestion_des_Stagiaire().Debut();
            this.Actualiser();
            //this.Affecher(lv);
        }

        ////pour affecher les info 

        private void Affecher(Stagiaire stg)
        {
            string nom = stg.Nom;
            string prenom = stg.Prenom;
            string groupe = stg.Groupe;
            dataGV1.Rows.Add(nom, prenom, groupe);

        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Gestion_des_Stagiaire GS = new Gestion_des_Stagiaire();
         
            label_ID.Text = GS.List_stagiaire.Count.ToString();
            this.Actualiser();
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(text_rech.Text);
            new Gestion_des_Stagiaire().Rechercher(id);
            if (new Gestion_des_Stagiaire().Rechercher(id) != null)
            {
                MessageBox.Show("le stagiaire est existe");
            }
            else
            {
                MessageBox.Show("le stagiaire n'existe pas !!!!! ");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(text_rech.Text);
                Stagiaire stg = new Gestion_des_Stagiaire().Rechercher(id);
                stg.Nom = text_nom.Text;
                stg.Prenom = text_prenom.Text;
                stg.Groupe = text_groupe.Text;
                new Gestion_des_Stagiaire().modifier(stg);
                this.Actualiser();
            }
            catch
            {
                throw new Exception("!!!!!!!!!!!!!!!!!!");
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(text_rech.Text);
            new Gestion_des_Stagiaire().Supprimer(id);
            //Stagiaire stg = new Gestion_des_Stagiaire().Debut();
            //Affecher(stg);
            //bDebut_Click(this,null);
            this.Actualiser();

        }

        private void bPrecedant_Click(object sender, EventArgs e)
        {

        }

        private void bSuivant_Click(object sender, EventArgs e)
        {

        }

        private void bFin_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            text_nom.Text = "";
            text_prenom.Text = "";
            text_groupe.Text = "";
            text_rech.Text = "";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
