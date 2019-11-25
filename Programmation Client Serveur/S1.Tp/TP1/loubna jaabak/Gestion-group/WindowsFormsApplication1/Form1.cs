using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            
            InitializeComponent();

        }

        Gestion_group Gg = new Gestion_group();
        internal Gestion_group Gg1 { get => Gg; set => Gg = value; }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            dataGV.Rows.Add(text_num.Text, text_nom.Text, text_nbStg.Text);

        }
        int trouve = -1;


        private void btn_rech_Click(object sender, EventArgs e)
        { 

            for (int i=0;i<dataGV.Rows.Count;i++)
            {
                if (dataGV.Rows[i].Cells[0].Value.ToString() ==text_recherche.Text)
                {

                    trouve = i;
                }
            }

            if(trouve!=-1)
            {
               MessageBox.Show("le group existe dans la position " + trouve);
            }
            else
             {
              MessageBox.Show("le group n'existe pas !!!!!");
              }

        }

        private void btn_mod_Click(object sender, EventArgs e)
        {

            

            for (int i = 0; i < dataGV.Rows.Count; i++)
            {
                if (dataGV.Rows[i].Cells[0].Value.ToString() == text_mod.Text)
                {

                    trouve = i;
                    gpB1.Visible = true;

                }
            }

        }
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            text_num.Text = "";
            text_nom.Text = "";
            text_nbStg.Text = "";
            text_mod.Text = "";
            text_recherche.Text = "";
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_appliquer_Click(object sender, EventArgs e)
        {

            if (trouve != -1)
            {
                dataGV.Rows[trouve].Cells[0].Value = textNum2.Text;
                dataGV.Rows[trouve].Cells[1].Value = textNom2.Text;
                dataGV.Rows[trouve].Cells[2].Value = textNb2.Text;
            }
            else
            {
                MessageBox.Show("le group n'existe pas !!!!!");
            }
        }

        private void btnAnuler2_Click(object sender, EventArgs e)
        {
            textNum2.Text = "";
            textNom2.Text = "";
            textNb2.Text = "";
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (trouve != -1)
            {
                DialogResult dialog = MessageBox.Show(" Voullez vous vraiment supprimer ce Group ?", "comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {

                    dataGV.Rows.RemoveAt(trouve);
                    MessageBox.Show("la supression est termine !!!!");
                }
                else
                {
                    MessageBox.Show("la supression invalide !!!!");
                }
            }
            else
            {
                MessageBox.Show("le group supprimer deja !!!!!");
            }
        }
    }
}
