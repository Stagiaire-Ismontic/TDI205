using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacture
{
    public partial class GestionnaireFactures : Form
    {
        GestionFacture gf = new GestionFacture();

        GestionClient gc = new GestionClient();

        public GestionnaireFactures()
        {
            InitializeComponent();
        }

        private void Afficher(Facture f)
        {

            lblId.Text = f.Id.ToString();
            lblDate.Text = f.Date.ToShortDateString();
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
            dataGridView1.DataSource =gf.Donne();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                int position = dataGridView1.CurrentRow.Index;
                Facture f = new Facture();
                f = gf.Donne()[position];
                Afficher(f);
            }
        }

        public void Nou()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = gc.Donne();
            comboBox1.DisplayMember = "Nom";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblId.Hide();
            Nou();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtTitre.Text == "")
                {
                    MessageBox.Show("Remplir tous les champs!","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    gf.Ajouter(new Facture(TxtTitre.Text, Convert.ToDouble(TxtSomme.Text), Convert.ToDateTime(lblDate.Text),new Client() { Nom=comboBox1.Text }));
                    Vide();
                    Actualiser();   
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Le format des donnees est incorrect", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                bool l = gf.Modifier(new Facture() {Id= int.Parse(lblId.Text),Titre= TxtTitre.Text,Somme= Convert.ToDouble(TxtSomme.Text) ,Date= Convert.ToDateTime(lblDate.Text) ,Client= new Client() { Nom = comboBox1.Text }});
                if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Vide();
                this.Actualiser();
            }
            catch(Exception)
            {
                 MessageBox.Show("Select votre Facture a Modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                bool l = gf.Supprimer(int.Parse(lblId.Text));
                if (l == false) MessageBox.Show("N'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Vide();
                this.Actualiser();
            }
            catch(Exception)
            {
                MessageBox.Show("Select votre Facture a Supprimer", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            List<Facture> l = gf.Donne(); ;
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

        private void BtnGest_Click(object sender, EventArgs e)
        {
            FormC C = new FormC();
            C.Show();

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Nou();
        }
    }
}
