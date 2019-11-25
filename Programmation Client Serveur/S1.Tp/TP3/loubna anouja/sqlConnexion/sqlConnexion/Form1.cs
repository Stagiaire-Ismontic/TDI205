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

namespace sqlConnexion
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"data source=DESKTOP-CT98AF6\STAGIAIRESQL;Initial Catalog=sqlConnection;Integrated security=true");
            con.Open();
            cmd = new SqlCommand("insert into Table(nom,prenom,age,cin,filiere) values(@nom,@prenom,@age,@cin,@filiere)", con);
            cmd.Parameters.AddWithValue("@nom", textBox1.Text);
            cmd.Parameters.AddWithValue("@prenom", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@cin", textBox4.Text);
            cmd.Parameters.AddWithValue("@filiere", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Stagiaire ajoute avec succees","enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
