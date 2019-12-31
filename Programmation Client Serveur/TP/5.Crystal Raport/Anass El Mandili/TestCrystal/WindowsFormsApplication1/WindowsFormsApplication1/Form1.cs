using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            using (CrystalRepEntities context = new CrystalRepEntities())
            {
                CrystalReport1 crpt = new CrystalReport1();
                crpt.SetDataSource(context.Person.ToList());
                crystalReportViewer1.ReportSource = crpt;
            }
        }
    }
}
