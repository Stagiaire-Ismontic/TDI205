using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnx = new SqlConnection(@"Server=DESKTOP-CT98AF6\SQLEXPRESS;database=test;Integrated security=true;");
            string str = "select * from Test";
            SqlCommand cmd = new SqlCommand(str,cnx);
            SqlDataReader r;
            cnx.Open();
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                Console.WriteLine((int)r[0]);
                
            }
            cnx.Close();
            Console.ReadLine();
        }
    }
}
