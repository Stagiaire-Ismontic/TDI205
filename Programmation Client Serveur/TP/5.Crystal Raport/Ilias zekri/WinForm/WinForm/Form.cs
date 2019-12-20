using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            using (ModelCrRe C=new ModelCrRe())
            {
                C.ListP.Add(new Produit(1,"Produit1",400));
                C.ListP.Add(new Produit(2,"Produit2",400));
                C.ListP.Add(new Produit(3, "Produit3", 400));
                C.ListP.Add(new Produit(4, "Produit4", 400));
                C.SaveChanges();
                CrystalReport cr = new CrystalReport();
                cr.SetDataSource(C.ListP);
                crystalReportViewer1.ReportSource = cr;

            }
        }
    }
}
