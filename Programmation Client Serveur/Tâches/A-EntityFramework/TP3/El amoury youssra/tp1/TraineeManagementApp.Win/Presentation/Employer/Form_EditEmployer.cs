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
    public partial class Form_EditEmployer : Form
    {
        public Form_EditEmployer()
        {
            InitializeComponent();
        }

        public void MiseAjour(Employer g) {

            idTextBox.Text = g.Id.ToString();
            nomTextBox.Text = g.Nom;
            PrenomtxtBox.Text=g.Prenom;
        }

        private void btMiseAjour_Click(object sender, EventArgs e)
        {
            EmployerService EmployerService = new EmployerService();
            Employer g = new Employer();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            g.Prenom = PrenomtxtBox.Text;
            EmployerService.Update(g);
        }
    }
}
