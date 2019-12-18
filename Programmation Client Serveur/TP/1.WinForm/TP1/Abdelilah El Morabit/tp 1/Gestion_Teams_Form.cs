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
    public partial class Gestion_Teams_Form : Form
    {
        GestionTeam gt = new GestionTeam();
        public Gestion_Teams_Form()
        {
            InitializeComponent();
        }
        public void cleartxt()
        {
            txt_id.Clear();
            txt_name.Clear();
            
        }
        public void refdgv()
        {
            dgvGestionTeams.Rows.Clear();
            foreach (Team t in gt.LstTeams)
            {
                dgvGestionTeams.Rows.Add(t.Id, t.Name);
            }
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int a;
            if ((txt_name.Text.Trim() != "") && int.TryParse(txt_id.Text, out a))
            {
                if (gt.ajouter(new Team(a, txt_name.Text)))
                {
                    MessageBox.Show("team a ete ajouter avec succes");
                    refdgv();
                    cleartxt();
                }
                else MessageBox.Show("ce team exist deja");
            }
            else MessageBox.Show("remplire tout le chomp!!");
        }

        private void Gestion_Teams_Form_Load(object sender, EventArgs e)
        {
            refdgv();
            btnCancel.Visible = false;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int index = dgvGestionTeams.CurrentCell.RowIndex;
            if (gt.delete(gt.LstTeams[index]))
            {
                MessageBox.Show("a ete suprimmer avec succes");
                refdgv();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "Modifier")
            {
                int index = dgvGestionTeams.CurrentCell.RowIndex;
                txt_id.Text = gt.LstTeams[index].Id.ToString();
                txt_id.ReadOnly = true;
                txt_name.Text = gt.LstTeams[index].Name.ToString();
                btnModifier.Text = "Valider";
                btnCancel.Visible = true;
            }
            else
            {
                int c;
                
                if ((txt_name.Text.Trim() != "") && int.TryParse(txt_id.Text, out c))
                {
                    if(gt.update(new Team(c, txt_name.Text))) { 
                        txt_id.ReadOnly = false;
                        btnModifier.Text = "Modifier";
                        btnCancel.Visible = false;
                        MessageBox.Show("les donnes de player a ete modifier avec succes");
                        refdgv();
                        cleartxt();
                    }
                    else
                    {
                        MessageBox.Show("le nom deja exist");
                    }

                }
                else MessageBox.Show("remplire tout le chomp!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleartxt();
            btnCancel.Visible = false;
            btnModifier.Text = "Modifier";
        }
    }
}
