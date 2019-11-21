using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnn = new SqlConnection("Data Source =.; Initial Catalog = ETUDIANT; Integrated Security = True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select CodeMat, NomMat, CoefMat from MATIERE", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["CodeMat"] + "  " + reader["NomMat"] + " " + reader["CoefMat"]);
            }
            cnn.Close();
            Console.ReadLine();
        }
    }
}
