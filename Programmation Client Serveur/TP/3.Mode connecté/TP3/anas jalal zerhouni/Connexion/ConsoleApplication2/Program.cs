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
            cnn = new SqlConnection("Data Source=DESKTOP-0QKOJIC;Initial Catalog=GestionProjets;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into projets(id,titre=values(12,'Ahmed')", cnn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("its Working");
            cnn.Close();
            Console.ReadKey();
        }
    }
}
