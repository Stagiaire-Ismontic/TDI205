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
    public partial class rechercherForm : Form
    {
        public rechercherForm()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            DS_TeamPlayer tp = new DS_TeamPlayer();
            new PlayersTableAdapter().FillByName(tp.Players,txtrechercher.Text);
            new TeamsTableAdapter().Fill(tp.Teams);
            playersRowBindingSource.DataSource = tp.Players.ToList<DS_TeamPlayer.PlayersRow>();
        }

        private void rechercherForm_Load(object sender, EventArgs e)
        {
            DS_TeamPlayer tp = new DS_TeamPlayer();
            new PlayersTableAdapter().FillByName(tp.Players, txtrechercher.Text);
            new TeamsTableAdapter().Fill(tp.Teams);
            playersRowBindingSource.DataSource = tp.Players.ToList<DS_TeamPlayer.PlayersRow>();
        }
    }
}
