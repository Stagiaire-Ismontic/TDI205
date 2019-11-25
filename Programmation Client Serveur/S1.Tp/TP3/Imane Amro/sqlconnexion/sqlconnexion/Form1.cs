using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlconnexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection conn1 = new connection();
            conn1.bachtconnecta();
            SqlCommand comd = new SqlCommand();
            comd.Connection = connection.conn;
            comd.CommandText = "insert into nom(nom) values('"+textBox1.Text+"')";
                 
            comd.Parameters.AddWithValue("@nom", textBox1.Text);
            comd.ExecuteNonQuery();
            connection.conn.Close();
            MessageBox.Show("vous avez enregistre avec succes", "ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
