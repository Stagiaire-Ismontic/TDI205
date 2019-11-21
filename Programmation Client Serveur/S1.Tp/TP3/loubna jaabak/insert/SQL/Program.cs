using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer code :");
            int CodeMat = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer Nom :");
            string NomMat = Console.ReadLine();
            Console.WriteLine("Entrer code_Mat :");
            int CoefMat = int.Parse(Console.ReadLine());
            SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = ETUDIANT; Integrated Security = True");
            conn.Open();
            SqlCommand SQ = new SqlCommand($"insert into MATIERE values ({CodeMat},'{NomMat}',{CoefMat})", conn);
            SQ.ExecuteNonQuery();

    


        }
    }
}
