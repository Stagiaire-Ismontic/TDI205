using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_1
{
	public partial class Gestion_Form : Form
	{
		public Gestion_Form()
		{
			InitializeComponent();
		}

		private void btnGstT_Click(object sender, EventArgs e)
		{
			Gestion_Teams_Form gtf = new Gestion_Teams_Form();
			gtf.ShowDialog();

		}

		private void btnGstP_Click(object sender, EventArgs e)
		{
			Gestion_Players_Form gpf = new Gestion_Players_Form();
			gpf.ShowDialog();
		}
	}
}
