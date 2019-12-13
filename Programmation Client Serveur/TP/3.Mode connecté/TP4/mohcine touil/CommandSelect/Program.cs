using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommandSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Connection  
            String connectionString = "data source=PC-MOHCINE; database=Exercice1; integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            // writing sql query
            SqlCommand cmd = new SqlCommand("select *from Musiciens",connection);
            // Opening Connection
            connection.Open();
            // Executing the SQL query 
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine(sdr["Num_mus"]+" "+sdr["Nom_mus"]+" "+sdr["Num_Rep"]);
            }
            Console.ReadLine();

        }
    }
}
