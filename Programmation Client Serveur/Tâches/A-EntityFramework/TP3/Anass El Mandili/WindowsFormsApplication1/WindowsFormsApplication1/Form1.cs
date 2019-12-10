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
        Gestionnaire Gs = new Gestionnaire();
      
        public Form1()
        {
            InitializeComponent();
            Actualiser();
           
        }
        public void Actualiser()
        {
           
            // dataGridView1.DataSource = Gs.DB.Etudiant.Select(s => new { Etudiant_Id = s.Id ,Etudiant_Name=s.Etud_Name,Etudiant_Tel=s.Etud_Tel}).ToList();
            dataGridView1.DataSource = Gs.DB.Etudiant.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var i = textBox1.Text;
            var name = textBox2.Text;
            var tel = textBox3.Text;
            Etudiant E = new Etudiant(int.Parse(i), name, tel);
            Gs.AddEtudiant(E);
           
            Actualiser();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var i = int.Parse(textBox1.Text);
            var name = textBox2.Text;
            var tel = textBox3.Text;

            Etudiant E = new Etudiant(i, name, tel);
            Gs.UpdateEtudiant(E);
            Actualiser();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gs.DeleteEtudiant(int.Parse(textBox1.Text));
            Actualiser();
        }

       
    }
}
