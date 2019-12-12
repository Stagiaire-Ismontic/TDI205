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
    public partial class Form_EmployerManager : Form
    {
        public Form_EmployerManager()
        {
            InitializeComponent();
        }

        private void Actualiser(){
        EmployerService EmployerService = new EmployerService();
        
            EmployerBindingSource.DataSource = null;
            EmployerBindingSource.DataSource = EmployerService.FindAll();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            Form_CreateEmployer f = new Form_CreateEmployer();
            f.ShowDialog();
            this.Actualiser();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            EmployerService EmployerService = new EmployerService();
            Employer g = (Employer)EmployerBindingSource.Current;
            EmployerService.Delete(g.Id);
            this.Actualiser();
        }

        private void FormGestionEmployer_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void btMettreAjour_Click(object sender, EventArgs e)
        {
            Employer g = (Employer)EmployerBindingSource.Current;
            Form_EditEmployer f = new Form_EditEmployer();
            f.MiseAjour(g);
            f.ShowDialog();
            this.Actualiser();
        }
    }
}
