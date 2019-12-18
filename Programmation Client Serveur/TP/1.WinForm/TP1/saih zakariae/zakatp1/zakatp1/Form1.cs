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
    public partial class Form1 : Form
    {
        private Library library = new Library("MediaThèque");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                this.library.AddBook(int.Parse(txt_id.Text), txt_name.Text, txt_author.Text, dateTimePicker1.Value);
                this.AddGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Book bk in this.library.Books)
            {
                this.dataGridView1.Rows.Add(bk.Name, bk.Author, bk.Dateofrelease, bk.Id);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AddGrid();
            this.dataGridView1.ReadOnly = true;
        }
         public void Refresh()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = library.Books;

        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                this.library.RemoveBook(int.Parse(txt_id.Text));
                this.AddGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                this.library.ModifyBook(int.Parse(txt_id.Text), txt_name.Text, txt_author.Text, dateTimePicker1.Value);
                this.AddGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this.library);
            f.Show();
        }
    }
}
