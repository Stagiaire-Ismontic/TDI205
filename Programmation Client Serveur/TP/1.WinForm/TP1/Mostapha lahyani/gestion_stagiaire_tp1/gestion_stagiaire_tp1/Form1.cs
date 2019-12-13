using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_stagiaire_tp1
{
    public partial class Form1 : Form
    {
        GestionSt Gss = new GestionSt();

        public Form1()
        {
            InitializeComponent();
        }

        public void Actu()
        {
            dataGridViewStagiaire.AutoGenerateColumns = false;
            dataGridViewStagiaire.DataSource = null;
            dataGridViewStagiaire.DataSource = Gss.Get();
        }

        public void Vide()
        {
            TxtCin.Clear();
            TxtNom.Clear();
            TxtGroupe.Clear();
            TxtEmail.Clear();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        public void Afficher(Stagiaire st)
        {
            TxtCin.Text = st.Cin;
            TxtEmail.Text = st.Email;
            TxtGroupe.Text = st.Groupe;
            TxtNom.Text = st.NomComple;
        }

        private void dataGridViewStagiaire_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewStagiaire.SelectedRows.Count >= 0)
            {
                int position = dataGridViewStagiaire.CurrentRow.Index;
                Stagiaire St = new Stagiaire();
                St = Gss.Get()[position];
                this.Afficher(St);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCin.Text != "")
                {
                    Stagiaire st = new Stagiaire();
                    st.Cin= TxtCin.Text;
                    st.Email= TxtEmail.Text;
                    st.Groupe= TxtGroupe.Text;
                    st.NomComple= TxtNom.Text;
                    st.Date = Convert.ToDateTime(lblDate.Text);
                    bool l = Gss.Ajouter(st);
                    if (l == false) { MessageBox.Show("Existe Deja!!", "Alert", MessageBoxButtons.OK); }
                    this.Actu();
                    this.Vide();
                }
                else
                {
                    MessageBox.Show("Remplir les donnees!!", "Erreur", MessageBoxButtons.OK);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Format des donnees incorrect!!", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCin.Text != "")
                {
                    Stagiaire st = new Stagiaire();
                    st.Cin = TxtCin.Text;
                    bool l = Gss.Supprimer(st);
                    if (l == false) { MessageBox.Show("N'existe pas!!", "Alert", MessageBoxButtons.OK); }
                    this.Actu();
                    this.Vide();
                }
                else
                {
                    MessageBox.Show("Remplir les donnees!!", "Erreur", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Format des donnees incorrect!!", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtCin.Text != ""))
                {
                    Stagiaire St = new Stagiaire();
                    St.Cin = TxtCin.Text;
                    St.NomComple = TxtNom.Text;
                    St.Groupe = TxtGroupe.Text;
                    St.Email = TxtEmail.Text;
                    St.Date = Convert.ToDateTime(lblDate.Text);
                    bool bl = Gss.Modifier(St);
                    if (bl == false) MessageBox.Show("N'existe Pas!!", "Erreur", MessageBoxButtons.OK);
                    this.Actu();
                    this.Vide();
                }
                else
                {
                    MessageBox.Show("Champ Obligatoire!!", "Erreur", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }
    }
}
