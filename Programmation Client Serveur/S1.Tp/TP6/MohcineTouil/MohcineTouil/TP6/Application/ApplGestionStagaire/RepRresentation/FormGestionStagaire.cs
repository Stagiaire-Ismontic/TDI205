using ApplGestionStagaire.RepGestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplGestionStagaire.RepClass
{
    public partial class FormGestionStagaire : Form
    {
        
        public FormGestionStagaire()
        {
            InitializeComponent();
        }

        private void VideChamps()
        {
            txt_id.Text = "";
            txt_nom.Text = "";
            txt_cin.Text = "";
        }
        private void Btn_Afficher_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource=RepGestion.GestionStagaire.Afficher();
            
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Stagaire s = new Stagaire();
            s.Id = int.Parse(txt_id.Text);
            s.Nom = txt_nom.Text;
            s.Cin = txt_cin.Text;
            GestionStagaire.Ajouter(s);
            VideChamps();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            Stagaire s = new Stagaire();
            s.Id = int.Parse(txt_id.Text);
            GestionStagaire.Supprimer(s.Id);
            VideChamps();
        }

        private void Btn_modifier_Click(object sender, EventArgs e)
        {
            Stagaire s = new Stagaire();
            s.Id = int.Parse(txt_id.Text);
            s.Nom = txt_nom.Text;
            s.Cin = txt_cin.Text;
            GestionStagaire.Modifier(s);
            VideChamps();
        }
    }
}
