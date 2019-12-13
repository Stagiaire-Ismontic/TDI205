using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sqlConnexion_et_sqlCommand
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Person;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tblPerson]", conn);
                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Console.WriteLine(Reader[0] + "\t" + Reader[1] + "\t" + Reader[2] + "\t" + Reader[3] + "\t" + Reader[4]);
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");


            Console.ReadKey();
        }
    }
}
