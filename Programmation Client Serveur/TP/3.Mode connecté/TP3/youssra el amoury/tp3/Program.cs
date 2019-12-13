using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T03IVK2\\SQLEXPRESS;Initial Catalog=ConnectionD;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into test(id,nom)values(44,'gghh')", con);

            cmd.ExecuteNonQuery();
            Console.WriteLine("bravoooo");
            con.Close();
            Console.ReadKey();


        }





    }
    }
