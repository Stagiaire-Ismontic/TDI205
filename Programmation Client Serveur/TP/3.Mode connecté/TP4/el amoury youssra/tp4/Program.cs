using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-T03IVK2\\SQLEXPRESS;Initial Catalog=ConnectionD;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[test] ", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + "\t" + reader[1]);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}

