using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.DataSet1TableAdapters;

namespace TP2
{
    public partial class Gestion_Editeur : Form
    {
        public Gestion_Editeur()
        {
            InitializeComponent();
        }

        private void btn_rehce_edt_Click(object sender, EventArgs e)
        {
            dataGV_edt.DataSource = null;
            DataSet1 ds = new DataSet1();
            new editeurTableAdapter().FillBynom(ds.editeur,text_Rech_edt.Text);
            dataGV_edt.DataSource = ds.editeur.ToList<DataSet1.editeurRow>();
        }

        private void btnQtr_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
