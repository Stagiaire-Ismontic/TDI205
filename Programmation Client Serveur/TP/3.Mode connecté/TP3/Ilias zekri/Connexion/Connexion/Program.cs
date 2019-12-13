using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connexion
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Con = new SqlConnection(@"Server = DESKTOP-T03IVK2\SQLEXPRESS; Database= StagiareTest; Integrated Security = true ;");
            SqlCommand Comd;
       
            Con.Open();
            Comd = new SqlCommand("INSERT INTO Test(Nom,Prenom) VALUES ('ilias','zekri')", Con);
            Comd.ExecuteNonQuery();
            Con.Close();
            Console.ReadKey();
        }
    }
}
