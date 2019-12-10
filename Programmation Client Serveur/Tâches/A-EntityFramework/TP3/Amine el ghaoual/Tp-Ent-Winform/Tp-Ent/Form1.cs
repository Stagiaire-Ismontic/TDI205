using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Ent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbsimpleEntities context;
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBox1.Text);
            var per = context.Persones.Where(c => c.ID == id).Count();
            if(per==0)
            {
                Persone p = new Persone();
                p.ID = int.Parse(textBox1.Text);
                p.Name = textBox2.Text;
                p.Passw = textBox3.Text;
                context.Persones.Add(p);
                context.SaveChanges();
                MessageBox.Show("ajouter valider");
            }
            else
            {
                MessageBox.Show("ID existe deja");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                Persone per = context.Persones.Where(c => c.ID == id).First();
                per.Name = textBox2.Text;
                per.Passw=textBox3.Text;
                context.SaveChanges();
                MessageBox.Show("modification succes");
            }
            catch
            {
                MessageBox.Show("personne n'existe pas");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
            int id = int.Parse(textBox1.Text);
            Persone per = context.Persones.Where(c => c.ID == id).First();
            context.Persones.Remove(per);
            context.SaveChanges();
            MessageBox.Show("Suppresion succes");
            }
            catch
            {
                MessageBox.Show("personne n'existe pas");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
              context = new dbsimpleEntities();
            {
                dataGridView1.DataSource = context.Persones.Select(p => new { ID = p.ID, Nam = p.Name, password = p.Passw }).ToList();
            
            }
        }
    }
}
