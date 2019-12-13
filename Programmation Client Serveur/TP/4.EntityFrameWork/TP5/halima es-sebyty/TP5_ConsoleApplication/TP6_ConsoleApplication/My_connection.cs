using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_ConsoleApplication
{
    class My_connection
    {

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Livre_TP6;Integrated Security=True");
        SqlCommand cmd;
       
        //methode de connection


        public void Execute_SQL(string requete)
        {
            
            cmd = new SqlCommand(requete, conn);

            conn.Open();

           cmd.ExecuteNonQuery(); 

            conn.Close();
            
        }

        public SqlDataReader Execute_Select(string requete)
        {
            cmd = new SqlCommand(requete, conn);
            conn.Open();
            return cmd.ExecuteReader();

        }

        public void SQL_Close()
        {
            conn.Close();
        }

    }
}
