using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args) 
        {
            SqlConnection cnn;
            cnn = new SqlConnection("Data Source=DESKTOP-T03IVK2;Initial Catalog=GestionProjet;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into projet(id,titre=values(12,'Madaniii')", cnn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("ca marche");
            cnn.Close();
            Console.ReadKey();
        }
    }
}
