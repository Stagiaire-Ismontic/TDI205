using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CRYSTALE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            using (DBaa db = new DBaa())
            {
                Crystale_Repport_Persone cr = new Crystale_Repport_Persone();
                cr.SetDataSource(db.Persone);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
