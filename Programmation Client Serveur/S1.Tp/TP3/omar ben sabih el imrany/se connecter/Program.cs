using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace se_connecter
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection C = new SqlConnection(@"Server = DESKTOP-NENV9L2\SQLEXPRESS; Database= GestionProjet; Integrated Security = true ;");
            SqlCommand Commande;
            C.Open();
            Commande = new SqlCommand("insert into Stagiaire(Nom,Prenom) values ('ben sabih','omar')", C);
            Commande.ExecuteNonQuery();
            C.Close();
            Console.ReadLine();
        }
    }
}
