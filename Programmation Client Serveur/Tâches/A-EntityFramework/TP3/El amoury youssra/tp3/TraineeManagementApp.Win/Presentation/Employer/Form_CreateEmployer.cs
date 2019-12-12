using CrudWin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrudWin.Entities
{
    public partial class Form_CreateEmployer : Form
    {
        public Form_CreateEmployer()
        {
            InitializeComponent();
        }

        private void brEnregistrer_Click(object sender, EventArgs e)
        {
            EmployerService EmployerService = new EmployerService();
            Employer g = new Employer();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            g.Prenom=PrenomTxtBox.Text;
            EmployerService.Add(g);
            this.Hide();

        }

        private void FormEmployer_Load(object sender, EventArgs e)
        {

        }
    }
}
