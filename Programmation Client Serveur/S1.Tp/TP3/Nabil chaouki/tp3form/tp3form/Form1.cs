using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tp3form
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
            conn1.Connectionsql();
            SqlCommand comm = new SqlCommand();
            comm.Connection = connection.conn;
            comm.CommandText = "insert into Pers values(@Nom)";
            comm.Parameters.AddWithValue("@Nom", textBox1.Text);
            comm.ExecuteNonQuery();
            connection.conn.Close();
            MessageBox.Show(textBox1.Text + "Message important", "ajouter evec succes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

 