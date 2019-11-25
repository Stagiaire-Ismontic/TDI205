using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-0QKOJIC;Initial Catalog=GestionProjets;Integrated Security=True");
            SqlDataReader read;
            SqlCommand cmd = new SqlCommand("select * from projets", cnn);
            cnn.Open();
            read = cmd.ExecuteReader();
            while(read.Read())
            {
                Console.WriteLine((string)read[0]);
                Console.WriteLine((string)read[1]);
            }
            cnn.Close();
        }
    }
}
