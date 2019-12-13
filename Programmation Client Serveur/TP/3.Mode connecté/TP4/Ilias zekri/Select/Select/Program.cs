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
            SqlConnection Con = new SqlConnection(@"Server = DESKTOP-T03IVK2\SQLEXPRESS; Database=Test; Integrated Security = true ;");
            SqlDataReader Read;
            SqlCommand Comd = new SqlCommand("Select * from Test", Con);
            Con.Open();
            Read = Comd.ExecuteReader();
            while (Read.Read())
            {
                Console.WriteLine((string)Read[0]);
                Console.WriteLine((string)Read[1]);
            }
            Con.Close();
        }
    }
}
