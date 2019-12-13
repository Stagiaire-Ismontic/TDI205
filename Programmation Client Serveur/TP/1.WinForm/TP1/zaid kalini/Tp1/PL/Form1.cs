using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tp1.BL;

namespace Tp1
{
    public partial class Form1 : Form
    {
        ListeStagiare lst = new ListeStagiare();
        BindingManagerBase bmb;
        public Form1()
        {
            InitializeComponent();
            
           
        }
        void effacer()
        {
            foreach(Control c in Controls)
            {
               if(c is TextBox)
                {
                    var text = (TextBox)c;
                    text.Clear();
                }
                if (c is RadioButton)
                {
                    rb_male.Checked = true;
                }
            }
        }
        void Afficher()
        {
            for (int i = 0; i < lst.Count; i++)
            {
                dataGridView1.Rows.Add(ListeStagiare.lst1[i].NumStagiare, ListeStagiare.lst1[i].Nom, ListeStagiare.lst1[i].Prenom, ListeStagiare.lst1[i].Age, ListeStagiare.lst1[i].sexe, ListeStagiare.lst1[i].situation);
            }
        }
        void Afficher(int i)
        {

            try
            {

                txt_num.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_Nom.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_prenom.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_age.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Male")
                    rb_male.Checked = true;
                else
                    rb_female.Checked = true;
                comboBox1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }

        }
        AjouterParRequête aj = new AjouterParRequête();
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            MoveSide(sender);
            try
            {
                dataGridView1.Rows.Clear();
                if (lst.rechercher(Convert.ToInt32(txt_num.Text)) == null)
                {
                    if (rb_female.Checked)
                    {
                        lst.Ajouter(new Stagiare(Convert.ToInt32(txt_num.Text), txt_Nom.Text, txt_prenom.Text, Convert.ToInt32(txt_age.Text), rb_female.Text, comboBox1.Text));
                        Afficher();
                        aj = new AjouterParRequête(new Stagiare(Convert.ToInt32(txt_num.Text), txt_Nom.Text, txt_prenom.Text, Convert.ToInt32(txt_age.Text), rb_female.Text, comboBox1.Text));
                        MessageBox.Show("Vous avez ajouter le stagier avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        effacer();
                    }
                    else
                    {
                        lst.Ajouter(new Stagiare(Convert.ToInt32(txt_num.Text), txt_Nom.Text, txt_prenom.Text, Convert.ToInt32(txt_age.Text), rb_male.Text, comboBox1.Text));
                        Afficher();
                        aj = new AjouterParRequête(new Stagiare(Convert.ToInt32(txt_num.Text), txt_Nom.Text, txt_prenom.Text, Convert.ToInt32(txt_age.Text), rb_female.Text, comboBox1.Text));
                        MessageBox.Show("Vous avez ajouter le stagier avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        effacer();
                    }
             
                }
                else
                    MessageBox.Show("Ce stagiare existe deja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void btn_Suprimer_Click(object sender, EventArgs e)
        {
            MoveSide(sender);
            try
            {
                lst.suprimer(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                return;
            }
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                txt_num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_age.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Male")
                    rb_male.Checked = true;
                else
                    rb_female.Checked = true;
                comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                return;
            }
            
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                MoveSide(sender);
                if (lst.rechercher(Convert.ToInt32(txt_num.Text)) != null)
                {
                    if (rb_female.Checked)
                    {
                        lst.update(new Stagiare(Convert.ToInt32(txt_num.Text), txt_Nom.Text, txt_prenom.Text, Convert.ToInt32(txt_age.Text), rb_female.Text, comboBox1.Text),Convert.ToInt32(txt_num.Text));
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < lst.Count; i++)
                        {
                            dataGridView1.Rows.Add(ListeStagiare.lst1[i].NumStagiare, ListeStagiare.lst1[i].Nom, ListeStagiare.lst1[i].Prenom, ListeStagiare.lst1[i].Age, ListeStagiare.lst1[i].sexe, ListeStagiare.lst1[i].situation);
                        }
                        MessageBox.Show("Vous avez modifier le stagier avec succes", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        effacer();
                    }
                    else
                    {
                        lst.update(new Stagiare(Convert.ToInt32(txt_num.Text), txt_Nom.Text, txt_prenom.Text, Convert.ToInt32(txt_age.Text), rb_male.Text, comboBox1.Text),Convert.ToInt32(txt_num.Text));
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < lst.Count; i++)
                        {
                            dataGridView1.Rows.Add(ListeStagiare.lst1[i].NumStagiare, ListeStagiare.lst1[i].Nom, ListeStagiare.lst1[i].Prenom, ListeStagiare.lst1[i].Age, ListeStagiare.lst1[i].sexe, ListeStagiare.lst1[i].situation);
                        }
                        MessageBox.Show("Vous avez modifier le stagier avec succes", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        effacer();
                    }

                }
                else
                    MessageBox.Show("Ce stagiare n'existe pas", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }

        public void MoveSide(object sender)
        {
            if(sender is Button)
            {
                var btn = (Button)sender;
                sidePanel.Top = btn.Top ;
                sidePanel.Height= btn.Height;
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {
           

            Close();

        }

        private void Label8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            effacer();
            txt_num.Text = numInscr();
            

        }
        int move, moveX, moveY;

        private void FlowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void FlowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
          
        }
        int i;


        private void FlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
        string numInscr()
        {
            int n = lst.Count;
            if (n == 0)
            {
                return "1" + DateTime.Now.Year;
            }
            else
                return (n + 1) + DateTime.Now.Year.ToString();
        }
    }
}
