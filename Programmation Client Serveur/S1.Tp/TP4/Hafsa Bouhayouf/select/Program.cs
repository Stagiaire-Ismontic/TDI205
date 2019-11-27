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
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-CT98AF6\SQLEXPRESS;database=test;Integrated security=true;");
            string str = "select * from Test";
            SqlCommand Cmd = new SqlCommand(str, con);
            SqlDataReader R;
            con.Open();
            R = Cmd.ExecuteReader();
            while (R.Read())
            {
                Console.WriteLine((int)R[0]);
            }
            con.Close();
            Console.ReadLine();
        }
    }
}
