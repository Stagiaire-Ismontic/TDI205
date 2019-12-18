using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_1
{
    public partial class Gestion_Players_Form : Form
    {
        public Gestion_Players_Form()
        {
            InitializeComponent();
        }
        GestiontPlayer gp = new GestiontPlayer();
        public void cleartxt()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_number.Clear();
            txt_salaire.Clear();
        }
        public void refdgv()
        {
            dgvGestionplayer.Rows.Clear();
            foreach(Player p in gp.Lstp)
            {
                dgvGestionplayer.Rows.Add(p.Id, p.Name, p.Number, p.Salaier);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refdgv();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int a,c ;
            double b;
            if((txt_name.Text.Trim()!="")&&int.TryParse(txt_number.Text,out a)&&double.TryParse(txt_salaire.Text,out b)&&int.TryParse(txt_id.Text, out c))
            {
                if (gp.ajouter(new Player(c, txt_name.Text, a, b)))
                {
                    MessageBox.Show("player a ete ajouter avec succes");
                    refdgv();
                    cleartxt();
                }
                else MessageBox.Show("ce player exist deja");
            }
            else MessageBox.Show("remplire tout le chomp!!");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int index = dgvGestionplayer.CurrentCell.RowIndex;
            if (gp.delete(gp.Lstp[index])) {
                MessageBox.Show("a ete suprimmer avec succes");
                refdgv();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "Modifier") { 
            int index = dgvGestionplayer.CurrentCell.RowIndex;
            txt_id.Text = gp.Lstp[index].Id.ToString() ;
            txt_id.ReadOnly = true;
            txt_name.Text = gp.Lstp[index].Name.ToString();
            txt_number.Text = gp.Lstp[index].Number.ToString();
            txt_salaire.Text = gp.Lstp[index].Salaier.ToString();
                btnModifier.Text = "Valider";
            }
            else
            {
                int a, c;
                double b;
                if ((txt_name.Text.Trim() != "") && int.TryParse(txt_number.Text, out a) && double.TryParse(txt_salaire.Text, out b) && int.TryParse(txt_id.Text, out c))
                {
                    gp.update(new Player(c, txt_name.Text, a, b));
                    txt_id.ReadOnly = false;
                    btnModifier.Text = "Modifier";
                    MessageBox.Show("les donnes de player a ete modifier avec succes");
                    refdgv();
                    cleartxt();
                }
                else MessageBox.Show("remplire tout le chomp!!");
            }


        }
    }
}
