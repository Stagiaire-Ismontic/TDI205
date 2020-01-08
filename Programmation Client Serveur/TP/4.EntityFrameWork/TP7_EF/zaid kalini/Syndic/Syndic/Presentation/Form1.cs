using Syndic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class Syndic : Form
    {
        SyndicServices syndics = new SyndicServices();
        string Mood = "change";
        //BindingManagerBase bmb;

        void Navigate(int id)
        {
            var synd = syndics.Find(id);
            txtFName.Text = synd.Nom_syndic;
            txtLName.Text = synd.Prenom_syndic;
            txtPassword.Text = synd.Mot_de_passe;
            txtTelephone.Text = synd.Telephone;
        }
        
        public Syndic()
        {
            InitializeComponent();

            txtFName.DataBindings.Add("text", syndics.Show(), "Nom_syndic");
            txtLName.DataBindings.Add("text", syndics.Show(), "Prenom_syndic");
            txtTelephone.DataBindings.Add("text", syndics.Show(), "Telephone");
            txtPassword.DataBindings.Add("text", syndics.Show(), "Mot_de_passe");
            bindingSource1.DataSource = this.BindingContext[syndics.Show()];
            dgvSyndicView.DataSource = syndics.Show();
            
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            if (Mood == "Added")
            {
                syndics.Added(new MesClasses.Syndic(0,txtFName.Text, txtLName.Text, txtTelephone.Text, txtPassword.Text));
                MessageBox.Show("Votre Operation est effactuer", "Syndic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSyndicView.DataSource = syndics.Show();
                Mood = "change";
            }
            else
            {
                syndics.Update(new MesClasses.Syndic((int)dgvSyndicView.CurrentRow.Cells[0].Value,txtFName.Text, txtLName.Text, txtTelephone.Text, txtPassword.Text));
                MessageBox.Show("Votre Operation est effactuer", "Syndic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSyndicView.DataSource = syndics.Show();
                Mood = "change";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Navigate(syndics.Show().Count-1);
            bindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if(item is TextBox)
                {
                    var txt = (TextBox)item;
                    txt.Clear();
                }
            }
            Mood = "Added";
        }

        private void dgvSyndicView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Navigate((int)dgvSyndicView.CurrentRow.Cells[0].Value);
            }
            catch
            {
                return;
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vous voulez vraiment effacer ce syndic", "Effacer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                syndics.Delete((int)dgvSyndicView.CurrentRow.Cells[0].Value);
                MessageBox.Show("Votre Operation est effactuer", "Syndic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSyndicView.DataSource = syndics.Show();
            }
        }
    }
}
