using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosutmOrders
{
    public partial class Form3 : Form
    {
        GestionOrders GO = new GestionOrders();
        GestionCostumers GC = new GestionCostumers();
        Form1 f;
        Form2 f2;
        public Form3()
        {
            InitializeComponent();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Form1(this,GO,GC);
            f.Show();
            this.Hide();
        }

        private void costumersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this,GC);
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
