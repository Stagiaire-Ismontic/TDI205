﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStockLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void VideChamps()
        {
            txt_codearticle.Text="";
            txt_designation.Text="";
            txt_prixu.Text="";
            txt_quantite.Text="";
        }

        private void Btn_ajouter_Click(object sender, EventArgs e)
        {
            Article a = new Article();
            a.Code_article = int.Parse(txt_codearticle.Text);
            a.Designation = txt_designation.Text;
            a.Prix_U = float.Parse(txt_prixu.Text);
            a.Quantite = int.Parse(txt_quantite.Text);
            new GestionArticle().Ajouter(a);
        }

        private void Btn_afficher_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new GestionArticle().Afficher();
        }

        private void Btn_supprimer_Click(object sender, EventArgs e)
        {
            Article a = new Article();
            a.Code_article = int.Parse(txt_codearticle.Text);
            new GestionArticle().Supprimer(a);
        }

        private void Btn_modifier_Click(object sender, EventArgs e)
        {
            Article a = new Article();
            a.Code_article = int.Parse(txt_codearticle.Text);
            a.Designation = txt_designation.Text;
            a.Prix_U = float.Parse(txt_prixu.Text);
            a.Quantite = int.Parse(txt_quantite.Text);
            new GestionArticle().Modifier(a);
        }

        private void Btn_nouveau_Click(object sender, EventArgs e)
        {
            VideChamps();
        }

        private void Btn_rechercher_Click(object sender, EventArgs e)
        {
            Article a = new Article();
            a.Code_article = int.Parse(txt_codearticle.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= new GestionArticle().RechercherParObjet(a);

        }

        private void Btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
