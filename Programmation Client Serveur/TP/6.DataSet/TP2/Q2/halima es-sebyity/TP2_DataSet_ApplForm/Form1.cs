using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_DataSet_ApplForm.DataSet1TableAdapters;

namespace TP2_DataSet_ApplForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        LivreTableAdapter lv = new LivreTableAdapter();


        private void Form1_Load(object sender, EventArgs e)
        {
            combo_categ.Items.Add("autre type");

            bindingSource1.DataSource = new LivreTableAdapter().GetData();

        }

        public void Actualliser()
        {
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = new LivreTableAdapter().GetData();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(text_idd.Text);
            string titre = text_titre.Text;
            string categorie = combo_categ.SelectedItem.ToString();
            string nom_auteur = text_NomAut.Text;
            
            lv.Insert(id,titre,categorie,nom_auteur);


              this.Actualliser();
            

        }

        private void btn_debut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            DataSet1.LivreDataTable LV_dataset = new DataSet1.LivreDataTable();

            lv.Fill(LV_dataset);

            int id = Convert.ToInt32(text_idd.Text);
            string titre = text_titre.Text;
            string categorie = combo_categ.SelectedItem.ToString();
            string nom_auteur = text_NomAut.Text;

            DataSet1.LivreRow l = LV_dataset.FindByid(id);

            if(l !=null)
            {
                l.titre = titre;
                l.categorie = categorie;
                l.nom_auteur = nom_auteur;
                lv.Update(l);
                this.Actualliser();

                MessageBox.Show("la modification termine avec socces");

            }
            else
            {
                MessageBox.Show("le livre n'existe pas !!!!!");
            }

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string message = "Voullez vous vraiment supprimer ce livre";
            if(MessageBox.Show(message,"Message de confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
               DataSet1.LivreRow lvv = new LivreTableAdapter().GetData().FindByid(Convert.ToInt32(text_idd.Text));

                lvv.Delete();
                new LivreTableAdapter().Update(lvv);

                this.Actualliser();

            }
                    
                    
                    
       }
    }
}
