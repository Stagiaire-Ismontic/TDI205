using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakatp1
{
    public partial class Form2 : Form
    {
        private Library library;
        public Form2(Library library)
        {
            this.library = library;
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                this.library.AddCustomer(int.Parse(txt_id.Text), txt_fullname.Text, dateTimePicker1.Value);
                this.AddGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void AddGrid()
        {
            dataGridView1.Rows.Clear();
            foreach(Customer customer in this.library.Customers)
            {
                this.dataGridView1.Rows.Add(customer.Id, customer.Fullname, customer.Age);
            }
        }

       

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            try
            {
                this.library.RemoveCustomer(int.Parse(txt_id.Text));
                this.AddGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                this.library.ModifyCustomer(int.Parse(txt_id.Text), txt_fullname.Text, dateTimePicker1.Value);
                this.AddGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
