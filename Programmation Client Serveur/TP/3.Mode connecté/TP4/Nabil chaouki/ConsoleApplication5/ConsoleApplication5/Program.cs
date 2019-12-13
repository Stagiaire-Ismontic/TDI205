using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn=new SqlConnection(@"data source=LAPTOP-T74VUB02\MSSQLSERVE;Initial catalog=test; integrated security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from Pers", conn);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                Console.WriteLine("{0},{1}", red.GetString(0), red.GetString(1));
            }
            red.Close();
            conn.Close();
        }
    }
}
