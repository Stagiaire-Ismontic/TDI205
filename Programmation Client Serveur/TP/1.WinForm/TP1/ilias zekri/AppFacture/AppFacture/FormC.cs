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
    public partial class FormC : Form
    {
        GestionClient g = new GestionClient();
        public FormC()
        {
            InitializeComponent();
        }

        public void vide()
        {
            TxtNom.Clear();
        }

        private void FormC_Load(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {

            if (TxtNom.Text != "")
            {
                g.Ajouter(new Client() { Nom = TxtNom.Text });
                vide();
            }
            else MessageBox.Show("Remplir les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
