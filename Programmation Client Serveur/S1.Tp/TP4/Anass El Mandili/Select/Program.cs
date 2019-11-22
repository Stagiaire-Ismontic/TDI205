using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            string connections = @"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=GestionStagiaireEtGroupe;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connections);
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT * FROM Groupe;",
                  connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }

            Console.Read();
        }
    }
}
