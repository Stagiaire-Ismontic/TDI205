using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsF.Classes;
using WindowsF.Services;

namespace WindowsF
{
    public partial class Application : Form
    {

        GestionCli GesC = new GestionCli();

        GestionFac GesF = new GestionFac();
        public Application()
        {
            InitializeComponent();
        }

        private void Afficher(Facture f)
        {
            lblId.Text = f.Id.ToString();
            TxtTitre.Text = f.Titre;
            TxtSomme.Text = Convert.ToString(f.Somme);
            comboBox1.Text = f.Client.ToString();
        }

        public void Vide()
        {
            TxtTitre.Clear();
            TxtSomme.Clear();
        }

        public void Actualiser()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GesF.Afficher();
        }

        public void Nou()
        {
            comboBox1.DataSource = GesC.Afficher();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            Actualiser();
            lblId.Hide();
            Nou();
       }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                bool l  = GesF.Modifier(new Facture() { Id = int.Parse(lblId.Text), Titre = TxtTitre.Text, Somme = Convert.ToDouble(TxtSomme.Text), Client = GesC.RechercheNom(comboBox1.Text)});    
                if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Vide();
                this.Actualiser();
            }
            catch (Exception)
            {
                MessageBox.Show("Select votre Facture a Modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAjouter_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (TxtTitre.Text == "")
                    {
                        MessageBox.Show("Remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else

                    {
                        GesF.Ajouter(new Facture(TxtTitre.Text, Convert.ToDouble(TxtSomme.Text), new Client { Nom = comboBox1.Text }));
                            Vide();
                            Actualiser();
                   
                     
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnSupprimer_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    bool l = GesF.Supprimer(new Facture() { Id = int.Parse(lblId.Text) });
                    if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Vide();
                    this.Actualiser();
                }
                catch (Exception)
                {
                    MessageBox.Show("Select votre Facture a Supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnRecherche_Click_1(object sender, EventArgs e)
        {
            {
                List<Facture> l = GesF.Afficher(); ;
                List<Facture> lstf = new List<Facture>();
                foreach (var item in l)
                {
                    if (item.Titre.Contains(TxtRecherche.Text))
                    {
                        lstf.Add(item);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lstf;
            }
        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    int position = dataGridView1.CurrentRow.Index;
                    Facture f = new Facture();
                    f = GesF.Afficher()[position];
                    Afficher(f);
                }
            }
        }


    }
}
