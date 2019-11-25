using AppGestionTaches.GestionProjets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionTaches.Presentation.GestionProjets
{
    public partial class FormGererProjets : Form
    {
        public FormGererProjets()
        {
            InitializeComponent();
        }

        private void Actualiser()
        {
            dataGridViewProjets.AutoGenerateColumns = false;
            dataGridViewProjets.DataSource = null;
            dataGridViewProjets.DataSource = new GestionnaireProjets().GetProjets();
        }

        private void Btn_Nouveau_Click(object sender, EventArgs e)
        {
            lbl_Id.Text = "";
            Txt_Titre.Text = "";
            Txt_Description.Text = "";
            lbl_date_Modification.Text = "";
            lbl_date_Creation.Text = DateTime.Now.ToShortDateString();

        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            Projets p = new Projets();
            p.Titre = Txt_Titre.Text;
            p.Description = Txt_Description.Text;
            new GestionnaireProjets().Ajouter(p);
            this.Actualiser();
        }

        private void FormGererProjets_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void Btn_Debut_Click(object sender, EventArgs e)
        {
            Projets P = new GestionnaireProjets().Debut();
            this.Afficher(P);

        }

        private void Afficher(Projets p)
        {
            if (p != null)
            {
                lbl_Id.Text = p.Id.ToString();
                Txt_Titre.Text = p.Titre;
                Txt_Description.Text = p.Description;
                lbl_date_Creation.Text = p.DateCreation1.ToString();
                if (p.DateModification1.Year != 1)
                {
                    lbl_date_Modification.Text = p.DateModification1.ToShortDateString();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Precedant_Click(object sender, EventArgs e)
        {
            if ((lbl_Id.Text != "") && (lbl_Id.Text != "-")) 
            {
                Projets P = new GestionnaireProjets().Precedent(int.Parse(lbl_Id.Text));
                this.Afficher(P);
            }
        }

        private void Btn_Suivant_Click(object sender, EventArgs e)
        {
            if ((lbl_Id.Text != "") && (lbl_Id.Text != "-"))
            {
                Projets P = new GestionnaireProjets().Suivant(int.Parse(lbl_Id.Text));
                this.Afficher(P);
            }
        }

        private void Btn_Fin_Click(object sender, EventArgs e)
        {
            Projets P = new GestionnaireProjets().Fin();
            this.Afficher(P);
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            try 
            {
                int Id = int.Parse(lbl_Id.Text);
                Projets p = new GestionnaireProjets().RechercheById(Id);
                p.Titre = Txt_Titre.Text;
                p.Description = Txt_Description.Text;
                new GestionnaireProjets().Modifier(p);
                this.Actualiser();
            }
            catch (FormatException)
            {
                MessageBox.Show("Le label lbl_Id est vide!");
            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(lbl_Id.Text);
                new GestionnaireProjets().Supprimer(Id);
                Btn_Debut_Click(this, null);
                this.Actualiser();
            }
            catch (FormatException)
            {
                MessageBox.Show("Le label lbl_Id est vide!");
            }
        }

        private void dataGridViewProjets_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridViewProjets_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (dataGridViewProjets.SelectedRows.Count >= 0)
                {
                    int position = dataGridViewProjets.CurrentRow.Index;
                    Projets p = GestionnaireProjets.liste_projets[position];
                    this.Afficher(p);
                }
            }
            catch
            {
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
