using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection C = new SqlConnection(@"Server = DESKTOP-NENV9L2\SQLEXPRESS; Database=GestionProjet; Integrated Security = true ;");
            SqlDataReader Lire;
            SqlCommand Commande = new SqlCommand("Select * from Stagiaire", C);
            C.Open();
            Lire = Commande.ExecuteReader();
            while (Lire.Read())
            {
                Console.WriteLine((string)Lire[0]);
                Console.WriteLine((string)Lire[1]);
            }
            C.Close();
        }
    }
}
