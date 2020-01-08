using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApp.Classes;
using FormsApp.Services;

namespace FormsApp.Forms
{
    public partial class Find : Form
    {
        GestionQuartier q = new GestionQuartier();
        public Find()
        {
            InitializeComponent();
        }

        public void act()
        {
            dataGridViewQuartier.DataSource = q.GetList();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            act();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Quartier> lstf = new List<Quartier>();
            foreach (var item in q.GetList())
            {
                if (item.Id==Convert.ToInt32(TxtFind.Text))
                {
                    lstf.Add(item);
                }
            }
            dataGridViewQuartier.DataSource = null;
            dataGridViewQuartier.DataSource = lstf;
        }
    }
}
