using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSet_Q2.DS_TeamPlayerTableAdapters;

namespace DataSet_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Actualiser()
        {
            DS_TeamPlayer tp = new DS_TeamPlayer();
            new PlayersTableAdapter().Fill(tp.Players);
            new TeamsTableAdapter().Fill(tp.Teams);
            bindingSource1.DataSource = tp.Players.ToList<DS_TeamPlayer.PlayersRow>();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualiser();
            cmbTeam.DataSource = new TeamsTableAdapter().GetData();
            txtID.DataBindings.Add("Text", bindingSource1, "Id");
            
        }

        private void btnDebut_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btnPresedant_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
                PlayersTableAdapter pt = new PlayersTableAdapter();
                pt.Insert(int.Parse(txtID.Text), txtName.Text, int.Parse(txtNumber.Text), double.Parse(txtSalaire.Text),Convert.ToInt32(cmbTeam.SelectedValue));
                this.Actualiser();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNumber.Clear();
            txtName.Clear();
            txtSalaire.Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DS_TeamPlayer.PlayersRow pr = new PlayersTableAdapter().GetData().FindById(int.Parse(txtID.Text));
            pr.name = txtName.Text;
            pr.number = int.Parse(txtNumber.Text);
            pr.salaire =double.Parse(txtSalaire.Text);
            pr.TeamId = Convert.ToInt32(cmbTeam.SelectedValue);
            new PlayersTableAdapter().Update(pr);
            this.Actualiser();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure", "supprution", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DS_TeamPlayer.PlayersRow pr = new PlayersTableAdapter().GetData().FindById(int.Parse(txtID.Text));
                pr.Delete();
                new PlayersTableAdapter().Update(pr);
                this.Actualiser();

            }
        }
    }
}
