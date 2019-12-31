using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaidKalini.CrystalReport
{
    public partial class PrintViewer : Form
    {
        public PrintViewer()
        {
            InitializeComponent();
            
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void PrintViewer_Load(object sender, EventArgs e)
        {
            CrystalReport1 crp = new CrystalReport1();
            crp.SetDataSource(Program.Modules);
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
