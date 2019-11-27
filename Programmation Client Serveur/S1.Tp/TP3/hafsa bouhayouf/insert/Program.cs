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
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-T03IVK2\SQLEXPRESS;database=test;Integrated security=true;");
            string str = "select * from Test";
            SqlCommand cmd = new SqlCommand(str,con);
            SqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            while(r.Read())
            {
                Console.WriteLine((int)r[0]);
                
            }
            con.Close();
            Console.ReadLine();
        }
    }
}
