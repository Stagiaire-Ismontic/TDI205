using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp2_datase.CostumerAndOrdersTableAdapters;
namespace Tp2_datase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'costumerAndOrders.orders'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ordersTableAdapter.Fill(this.costumerAndOrders.orders);
            this.actualiser();
            this.comboBox1.DataSource = new costumersTableAdapter().GetData();
            this.textBox1.DataBindings.Add("Text", bindingSource1, "Id");
            this.comboBox1.DataBindings.Add("Text",bindingSource1,"CostumerId");
        }

        void actualiser()
        {
            
            CostumerAndOrders co = new CostumerAndOrders();
            new costumersTableAdapter().Fill(co.costumers)  ;
            new ordersTableAdapter().Fill(co.orders); 
            this.bindingSource1.DataSource = co.orders.ToList<CostumerAndOrders.ordersRow>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordersTableAdapter ot = new ordersTableAdapter();
            int num = int.Parse(this.textBox1.Text);
            string nom = this.textBox2.Text;
            int idco = (int)this.comboBox1.SelectedValue;
            ot.Insert(num,nom,idco);
            actualiser();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CostumerAndOrders.ordersRow a = new ordersTableAdapter().GetData().FindById(int.Parse(this.textBox1.Text));
            a.Name = this.textBox2.Text;
            a.CostumerId =(int)this.comboBox1.SelectedValue;
            new ordersTableAdapter().Update(a);
            actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CostumerAndOrders.ordersRow a = new ordersTableAdapter().GetData().FindById(int.Parse(this.textBox1.Text));
            a.Delete();
            new ordersTableAdapter().Update(a);
            actualiser();
        }
    }
}
