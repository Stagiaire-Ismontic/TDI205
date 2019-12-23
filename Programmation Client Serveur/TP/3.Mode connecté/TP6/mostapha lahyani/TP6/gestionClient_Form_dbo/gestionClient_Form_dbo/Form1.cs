using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionClient_Form_dbo
{
    public partial class Form1 : Form
    {
        GestionClient GC = new GestionClient();
        public Form1()
        {
            InitializeComponent();
           
        }

        public void Actu()
        {
            GestionClient.OPEN();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new GestionClient().afficher();
            GestionClient.CLOSE();
        }

        public void Vide()
        {
            txtCIN.Clear();
            txtFirst_Name.Clear();
            txtid.Clear();
            txtLastName.Clear();
        }

        public void Afficher(Client st)
        {
            txtCIN.Text = st.Cin;
            txtid.Text = st.Id.ToString();
            txtFirst_Name.Text = st.Fname;
            txtLastName.Text = st.Lname;
            txtnb_Phone.Text = st.Nb_Phone.ToString();
            txtEmail.Text = st.Email;
        }

        private void dataGridViewClientt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                int position = dataGridView1.CurrentRow.Index;
                Client f = new Client();
                //f = GC.Get()[position];
                this.Afficher(f);
                
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            GestionClient.OPEN();
            try
            { 
                string Cin = txtCIN.Text;
                int Id = int.Parse(txtid.Text);
                string Fname = txtFirst_Name.Text;
                string Lname = txtLastName.Text;
                int Nb_Phone = int.Parse(txtnb_Phone.Text);
                string Email = txtEmail.Text;
                GC.Ajouter(new Client (Cin,Id,Fname,Lname,Nb_Phone,Email));
                this.Vide();
                this.Actu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK);
            }
            GestionClient.CLOSE();
        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            GestionClient.OPEN();
            int id = int.Parse(txtid.Text);
            GC.Delete(id);
            GestionClient.CLOSE();
            this.Actu();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionClient.OPEN();
            string Cin = txtCIN.Text;
            int Id = int.Parse(txtid.Text);
            string Fname = txtFirst_Name.Text;
            string Lname = txtLastName.Text;
            int Nb_Phone = int.Parse(txtnb_Phone.Text);
            string Email = txtEmail.Text;
            Client CL = new Client(Cin, Id, Fname, Lname, Nb_Phone, Email);
            GC.Modifie(CL);
            GestionClient.CLOSE();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Actu();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            GestionClient.OPEN();
            int id=int.Parse(txtid.Text);
            List<Client> lst = GC.Recherche(id);
            if (lst != null)
            {
                foreach (var item in lst)
                {
                    txtCIN.Text = item.Cin.ToString();
                    txtid.Text = item.Id.ToString();
                    txtFirst_Name.Text = item.Fname.ToString();
                    txtLastName.Text = item.Lname.ToString();
                    txtEmail.Text =item.Nb_Phone.ToString();
                    txtnb_Phone.Text = item.Email.ToString();
                }
            }
            GestionClient.CLOSE();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                GestionClient.OPEN();
               int id =int.Parse( dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

                List < Client > ls =        GC.Recherche(id);

                txtCIN.Text = ls[0].Cin;
                txtid.Text = ls[0].Id.ToString();
                txtFirst_Name.Text = ls[0].Fname;
                txtLastName.Text = ls[0].Lname;
                txtnb_Phone.Text = ls[0].Nb_Phone.ToString();
                txtEmail.Text = ls[0].Email;
                GestionClient.CLOSE();
            }
        }
    }
}
