using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassClient
{
    public partial class Form1 : Form
    {
        Client cll = new Client();
        GestionClient GC = new GestionClient();
        GestionCommande GCMD = new GestionCommande();

        public Form1()
        {
            InitializeComponent();
        }

        public void Afficher(Client C)
        {
            txtCIN.Text = C.Cin;
            txtFirst_Name.Text = C.Fname;
            txtLastName.Text = C.Lname;
            txtEmail.Text = C.Email;
            txtnb_Phone.Text = C.Nb_Phone.ToString();
        }
        public void AfficherCMD(Commande dd)
        {
            txt_IDClient.Text = dd.idClient.ToString();
            txt_IDCommande.Text = dd.idCmd.ToString();
            txt_CommaneName.Text = dd.CmdName;
        }

        public void Actualiser()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GC.Get();

            dt.AutoGenerateColumns = false;
            dt.DataSource = null;
            dt.DataSource = GCMD.Getcmd();
        }

        public void Vide()
        {
            txtCIN.Clear();
            txtid.Clear();
            txtFirst_Name.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtnb_Phone.Clear();

            txt_IDClient.Clear();
            txt_IDCommande.Clear();
            txt_CommaneName.Clear();
        }

        void Fill()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in GestionClient.lst_Client)
            {
                dataGridView1.Rows.Add(item.Cin, item.Email, item.Fname, item.Lname, item.Nb_Phone);
            }


            dt.Rows.Clear();
            foreach (var ite in GestionCommande.lst_Cmd)
            {
                dt.Rows.Add(ite.idCmd, ite.idClient, ite.CmdName);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txt_IDCommande.Text != string.Empty)
            {
                try
                {
                    Commande CMD = new Commande();
                    CMD.idCmd = int.Parse(this.txt_IDCommande.Text);
                    CMD.idClient = int.Parse(this.txt_IDClient.Text);
                    CMD.CmdName = this.txt_CommaneName.Text;

                    GCMD.AjouterCMD(CMD);
                    this.Vide();
                    this.Actualiser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "erourr", MessageBoxButtons.OK);
                }
            }
            if (txtCIN.Text != string.Empty)
            {
                try
                {
                    Client c = new Client();
                    c.Cin = this.txtCIN.Text;
                    c.Id = int.Parse(this.txtid.Text);
                    c.Fname = this.txtFirst_Name.Text;
                    c.Lname = this.txtLastName.Text;
                    c.Nb_Phone = int.Parse(this.txtnb_Phone.Text);
                    c.Email = this.txtEmail.Text;
                    GC.Ajouter(c);
                    this.Vide();
                    this.Actualiser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "erourr", MessageBoxButtons.OK);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCIN.Text != string.Empty)
            {
                try
                {
                    if (txtCIN.Text != "")
                    {
                        Client c = new Client();
                        c.Cin = txtCIN.Text;
                        GC.Delete(c);
                        this.Vide();
                        this.Actualiser();
                    }
                    else
                    {
                        throw new Exception("label est vide");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (txt_IDCommande.Text != string.Empty)
            {
                try
                {
                    if (txt_IDCommande.Text != "")
                    {
                        Commande cmd = new Commande();
                        cmd.idCmd = int.Parse(txt_IDCommande.Text);
                        GCMD.DeleteCMD(cmd);
                        this.Vide();
                        this.Actualiser();
                    }
                    else
                    {
                        throw new Exception("label est vide");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnModifie_Click(object sender, EventArgs e)
        {

            if (txtCIN.Text != string.Empty)
            {
                try
                {
                    if (txtCIN.Text != "")
                    {
                        Client c = new Client();
                        c.Cin = txtCIN.Text;
                        c.Id = int.Parse(txtid.Text);
                        c.Fname = txtFirst_Name.Text;
                        c.Lname = txtLastName.Text;
                        c.Email = txtEmail.Text;
                        c.Nb_Phone = int.Parse(txtnb_Phone.Text);
                        new GestionClient().Modifier(c);
                        this.Vide();
                        this.Actualiser();
                    }
                    else
                    {
                        throw new Exception("label est vide");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (txt_IDCommande.Text != string.Empty)
            {
                try
                {
                    if (txt_IDCommande.Text != "")
                    {
                        Commande cmd = new Commande();
                        cmd.idCmd = int.Parse(txt_IDCommande.Text);
                        cmd.idClient = int.Parse(txt_IDClient.Text);
                        cmd.CmdName = txt_CommaneName.Text;
                        new GestionCommande().ModifierCMD(cmd);
                        this.Vide();
                        this.Actualiser();
                    }
                    else
                    {
                        throw new Exception("label est vide");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtCIN.Text != string.Empty)
            {
                dataGridView1.DataSource = null;
                foreach (var item in GestionClient.lst_Client)
                {

                    if (item.Cin.Contains(txtCIN.Text))
                    {
                        dataGridView1.Rows.Add(item.Cin, item.Email, item.Fname, item.Lname, item.Nb_Phone);
                    }
                }
            }
            if (txt_IDCommande.Text != string.Empty)
            {
                dt.DataSource = null;
                foreach (var item in GestionCommande.lst_Cmd)
                {

                    if (item.idCmd.ToString().Contains(txt_IDCommande.Text))
                    {
                        dt.Rows.Add(item.idCmd, item.idClient, item.CmdName);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] str = new string[] { "AAAA", "BBBB", "AABB", "AACC", "CCVV", "GGH", "RR", "TTT", "GG", "RDF", "CX" };
            foreach (var item in str)
            {
                Client c = new Client();
                c.Cin = item;
                c.Id = int.Parse("1");
                c.Fname = item;
                c.Lname = item;
                c.Nb_Phone = int.Parse("12345");
                c.Email = item;
                GC.Ajouter(c);
            }
            this.Actualiser();


            string[] PRT = new string[] { "AA", "BB", "CC", "DD" };
            foreach (var it in PRT)
            {
                Commande CD = new Commande();
                CD.CmdName = it;
                CD.idClient = int.Parse("1");
                CD.idCmd = int.Parse("1");
                GCMD.AjouterCMD(CD);
            }
            this.Actualiser();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                int position = dataGridView1.CurrentRow.Index;
                Client f = new Client();
                f = GC.Get()[position];
                this.Afficher(f);
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                MessageBox.Show("Test");
                if (dt.RowCount >= 0)
                {
                    Commande CD = new Commande();
                    CD = GCMD.Getcmd()[dt.CurrentRow.Index];
                    this.AfficherCMD(CD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
