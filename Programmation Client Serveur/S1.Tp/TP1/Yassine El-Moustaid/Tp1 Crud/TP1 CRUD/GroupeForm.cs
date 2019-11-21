using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_CRUD
{
    public partial class GroupeForm : Form
    {
        public GroupeForm()
        {
            InitializeComponent();
        }
        List<Groupe> lstgrp = new List<Groupe>();
        private void btnAjtGrp_Click(object sender, EventArgs e)
        {
            try
            {
                
                if ((txtID.Text==null)&&(txtNDGrp.Text==null)) throw new Exception("remplir tout les champ");
                else
                {
                    bool exist = false;
                   foreach(Groupe g in lstgrp)
                    {
                        if (g.ID1 == int.Parse(txtID.Text)) exist = true;
                    }
                    if (exist) throw new Exception("ce groupe deja exist");
                    else
                    {
                        lstgrp.Add(new Groupe(int.Parse(txtID.Text), txtNDGrp.Text));
                        txtNDGrp.Text = null;
                        txtID.Text = null;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
