using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page
{
    public partial class form_gere_proj : Form
    {
        static List<Projet> et = new List<Projet>();
        Projet t;

        public form_gere_proj()
        {
            InitializeComponent();
        }

        private void Actualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Gestion_Projets().getProjet();
        }

        private void button1_Click(object sender, EventArgs e)//Ajouter
        {
            try
            {
                Projet et = new Projet();
                et.NOM1 = textBox2.Text;
                et.PRENOM1 = textBox3.Text;
                et.ID1 = int.Parse(textBox1.Text);
                new Gestion_Projets().Ajouter(et);
                new Exception("le projet a ete ajouter avec succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void button6_Click(object sender, EventArgs e)//Nouveau
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            label_id.Text = "";
        
            lbl_date_Modification.Text = "";
            lbl_date_Creation.Text = DateTime.Now.ToShortDateString();
        }
        public void Afficher(Projet t)
        {
            if (t != null)
            {
                label_id.Text = t.ID1.ToString();
                t.NOM1 = textBox2.Text;
                t.PRENOM1 = textBox3.Text;
                t.ID1 = int.Parse(textBox1.Text);
                lbl_date_Creation.Text = t.DateCreation1.ToString();
               
                if (t.DateModification1.Year != 1)

        lbl_date_Modification.Text = t.DateModification1.ToShortDateString();
        dataGridView1.Rows.Add( this.t.NOM1, this.t.PRENOM1,this.t.ID1.ToString());
            }
        }
        private void button7_Click(object sender, EventArgs e)//Enregistrer
        {
            Projet t=new Projet();
   
            t.NOM1 = textBox2.Text.ToUpper();
            t.PRENOM1 = textBox3.Text.ToUpper();
            t.ID1 = int.Parse(textBox1.Text);
            new Gestion_Projets().Ajouter(t);
            this.Actualiser();
             
    }
        private void btn_precedent_Click(object sender, EventArgs e)
        {
            if (label_id.Text != "" && label_id.Text != "-")
            {

                Projet edit = new Gestion_Projets().precedent(int.Parse(label_id.Text));
                this.Afficher(t);
            }
        }
        private void btn_debut_Click(object sender, EventArgs e)
        {
            Projet et = new Gestion_Projets().debut();
            this.Afficher(et);
        }
        private void button2_Click(object sender, EventArgs e)//supprimer
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                new Gestion_Projets().Supprimer(id);
                //metode 1
                this.Actualiser();
                //methode 2
                //btn_debut_Click(this, null);
                //this.Actualiser();

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)//modifier
        {
            try {
                int id = int.Parse(label_id.Text);
                Projet et = new Gestion_Projets().rechercher(id);

                et.NOM1 = textBox2.Text;
                et.PRENOM1 = textBox3.Text;
                et.ID1 = int.Parse(textBox1.Text);

                new Gestion_Projets().Modifier(et);
                this.Actualiser();

            }
            catch (Exception ex)
            {
                MessageBox.Show("!!!!!!!!!!!!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)//rechercher
        {
            int id = Convert.ToInt32(textBox1.Text);
       new Gestion_Projets().rechercher(id);
            if (new Gestion_Projets().rechercher(id) != null)
            {
                MessageBox.Show("le projet est existe");
            }
            else
            {
                MessageBox.Show("le projet n'existe pas!!");
            }

        }
        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if (label_id.Text != "" && label_id.Text != "-")
            {
                Projet edit = new Gestion_Projets().suivant(int.Parse(label_id.Text));
                this.Afficher(edit);
            }
        }
        private void btn_fin_Click(object sender, EventArgs e)
        {
            Projet et = new Gestion_Projets().fin();
                this.Afficher(t);
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Gestion_Projets gp = new Gestion_Projets();
            label_id.Text = gp.Et.Count.ToString();
            this.Actualiser();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int position = dataGridView1.SelectedRows[0].Index;
                Projet p = new Gestion_Projets().getProjet()[position];
                this.Afficher(p);
            }
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
    }
}
