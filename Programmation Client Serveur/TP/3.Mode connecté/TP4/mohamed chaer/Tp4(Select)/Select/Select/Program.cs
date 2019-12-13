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
            SqlConnection Cn = new SqlConnection(@"Server = DESKTOP-T03IVK2\SQLEXPRESS; Database=Test; Integrated Security = true ;");
            SqlDataReader Read;
            SqlCommand Cmd = new SqlCommand("Select * from Test", Cn);
            Cn.Open();
            Read = Cmd.ExecuteReader();
            while (Read.Read())
            {
                Console.WriteLine((string)Read[0]);
                Console.WriteLine((string)Read[1]);
            }
            Cn.Close();
        }
    }
}
