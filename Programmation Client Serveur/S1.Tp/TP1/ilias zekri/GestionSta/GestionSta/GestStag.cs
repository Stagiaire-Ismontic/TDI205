using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSta
{
    public partial class GestStag : Form
    {
        Gestionnaire G = new Gestionnaire();

        List<Groupe> lst = new List<GestionSta.Groupe>
        {
            new Groupe("TDI201"),
            new Groupe("TDI205")
        };

        
        public GestStag()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "Nom";
        }

        public void Vide()
        {
            TxtCin.Clear();
            TxtNom.Clear();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        public void Actualiser()
        {
            dataGridViewSt.AutoGenerateColumns = false;
            dataGridViewSt.DataSource = null;
            dataGridViewSt.DataSource = G.Lis();
        }

        private void dataGridViewSt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSt.SelectedRows.Count >= 0)
            {
                int position = dataGridViewSt.CurrentRow.Index;
                Stagiaire St = new Stagiaire();
                St = G.Lis()[position];
                this.Afficher(St);
            }
        }

        private void Afficher(Stagiaire St)
        {
            TxtCin.Text = St.Cin;
            TxtNom.Text = St.Nom;
            comboBox1.Text =Convert.ToString(St.Gr);
            lblDate.Text = Convert.ToString(St.Date.ToShortDateString());
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtCin.Text != "") || (TxtNom.Text != ""))
                {

                    Stagiaire St = new Stagiaire();
                    St.Cin = TxtCin.Text;
                    St.Nom = TxtNom.Text;
                    Groupe g = new Groupe() { Nom = comboBox1.Text };
                    St.Gr = g;
                    St.Date = Convert.ToDateTime(lblDate.Text);
                    bool bl = G.Ajouter(St);
                    if (bl == false) MessageBox.Show("Exist deja!!", "Erreur", MessageBoxButtons.OK);
                    this.Vide();
                    this.Actualiser();
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

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCin.Text != "")
                {
                    Stagiaire St = new Stagiaire();
                    St.Cin = TxtCin.Text;
                    bool bl = G.Supprimer(St);
                    if (bl == false) MessageBox.Show("N'existe Pas!!", "Erreur", MessageBoxButtons.OK);
                    this.Actualiser();
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

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TxtCin.Text != "") || (TxtNom.Text != ""))
                {
                    Stagiaire St = new Stagiaire();
                    St.Cin = TxtCin.Text;
                    St.Nom = TxtNom.Text;
                    Groupe g = new Groupe() { Nom = comboBox1.Text };
                    St.Gr = g;
                    St.Date = Convert.ToDateTime(lblDate.Text);
                    bool bl = G.Modifier(St);
                    if (bl == false) MessageBox.Show("N'existe Pas!!", "Erreur", MessageBoxButtons.OK);
                    this.Actualiser();
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
