using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Gestion_Salle : Form
    {
        public Gestion_Salle()
        {
            InitializeComponent();
        }
        GestionSalle gs = new GestionSalle();
        public void refreshdtg()
        {
            dataGridView1.Rows.Clear();
            foreach (Salle s in gs.Lsts)
            {
                dataGridView1.Rows.Add(s.Id,s.Description);
            }
        }
        public void cleartxt()
        {
            txt_IDSALLE.Clear();
            txt_description.Clear();

        }

        private void Gestion_Salle_Load(object sender, EventArgs e)
        {
            refreshdtg();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int a;
            if ((txt_description.Text.Trim() != "") && int.TryParse(txt_IDSALLE.Text, out a))
            {
                if (gs.add(new Salle(a, txt_description.Text)))
                {
                    MessageBox.Show("salle a ete ajouter avec succes");
                    refreshdtg();
                    cleartxt();
                }
                else MessageBox.Show("cet salle exist deja");
            }
            else MessageBox.Show("remplire tout les champs!!");
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (gs.find_salle(int.Parse(txt_IDSALLE.Text)) != null)
            {
                int a;
                if ((txt_description.Text.Trim() != "") && (int.TryParse(txt_IDSALLE.Text, out a)))
                {
                    gs.update(new Salle(a, txt_description.Text));
                    MessageBox.Show("la description du salle est modifier avec succes");
                    refreshdtg();
                    cleartxt();
                }
                else MessageBox.Show("remplire tout les champs");
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (gs.delete(gs.Lsts[index]))
            {
                MessageBox.Show("suprimmer avec succes");
                refreshdtg();
            }
        }
    }
    
}
