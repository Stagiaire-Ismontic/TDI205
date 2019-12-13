using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace requete_select
{
    class Program
    {
        private static void Main(string[] args, object GetInt32)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=GestionStagiaireEtGroupe;Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("Select id,nom from Groupe",conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1}",reader.GetInt32(0), reader.GetString(1));
                }      
            }
            conn.Close();
        }

    }
    
}
