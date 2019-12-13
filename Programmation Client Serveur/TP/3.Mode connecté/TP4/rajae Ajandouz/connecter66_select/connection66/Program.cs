using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace connection66
{
    class Program

    {
        static void Main(string[] args)
        {


            ////select
            SqlConnection con = new SqlConnection("server=DESKTOP-DVUEC26;Database=ConnectionDb;integrated security=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("select id ,nom from Test", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0},{1}", reader.GetInt32(0), reader.GetString(1));

            }

           reader.Close();
            con.Close();
            Console.ReadKey();

        }



    }
}
