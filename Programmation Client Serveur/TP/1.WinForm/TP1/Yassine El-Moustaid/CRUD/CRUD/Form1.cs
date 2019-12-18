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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GestionEntraineur ge = new GestionEntraineur();
        public void refreshdtg()
        {
            dataGridView1.Rows.Clear();
            foreach (Entraineur e in ge.Lste)
            {
                dataGridView1.Rows.Add(e.Id, e.Nom,e.Prenom);
            }
        }
        public void cleartxt()
        {
            txt_ID.Clear();
            txt_nom.Clear();
            txt_prenom.Clear();
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int a;
            if ((txt_nom.Text.Trim() != "") && int.TryParse(txt_ID.Text, out a)&&((txt_prenom.Text.Trim() != "")))
            {
                if (ge.add(new Entraineur(a, txt_nom.Text,txt_prenom.Text)))
                {
                    MessageBox.Show("entraineur a ete ajouter avec succes");
                    refreshdtg();
                    cleartxt();
                }
                else MessageBox.Show("ce entraineur exist deja");
            }
            else MessageBox.Show("remplire tout les champs!!");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ge.find_entraineur(int.Parse(txt_ID.Text)) != null)
            {
                int a;
                if ((txt_nom.Text.Trim() != "") && int.TryParse(txt_ID.Text, out a) && ((txt_prenom.Text.Trim() != "")))
                {
                    ge.update(new Entraineur(a, txt_nom.Text,txt_prenom.Text));
                    MessageBox.Show("les donner d'entraineur est modifier avec succes");
                    refreshdtg();
                    cleartxt();
                }
                else MessageBox.Show("remplire tout les champs");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (ge.delete(ge.Lste[index]))
            {
                MessageBox.Show("suprimmer avec succes");
                refreshdtg();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshdtg();
        }
    }
}
