using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mon_class_connnecion
{
    class Program
    {
        static void Main(string[] args)
        {
           

                SqlConnection conn = new SqlConnection("server=LENOVO-PC;Initial catalog=mon_class_connecion;integrated security=true");
                conn.Open();
           

            SqlCommand cmmd = new SqlCommand("select id,nom,prenom from stagiaire", conn);
            SqlDataReader reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0},{1},{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }

            reader.Close();
            conn.Close();
            Console.ReadLine();
        }
    }
}
