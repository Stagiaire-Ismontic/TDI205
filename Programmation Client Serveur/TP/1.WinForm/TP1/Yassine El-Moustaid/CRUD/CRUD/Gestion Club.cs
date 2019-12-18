using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Gestion_Club : Form
    {
        public Gestion_Club()
        {
            InitializeComponent();
        }

        private void btn_gstEntraineur_Click(object sender, EventArgs e)
        {
            Form1 ge = new Form1();
            ge.ShowDialog();
        }

        private void btn_GestSalle_Click(object sender, EventArgs e)
        {
            Gestion_Salle gs = new Gestion_Salle();
            gs.ShowDialog();
        }
    }
}
