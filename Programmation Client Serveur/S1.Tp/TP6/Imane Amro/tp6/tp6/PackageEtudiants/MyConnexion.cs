using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6.PackageEtudiants
{
    class MyConnexion
    {
        private static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PIUCF0K\SQLEXPRESS;Initial Catalog=test1;Integrated Security=True");
        private static SqlCommand commande;

        public static int ExecuteSQL(string requete)
        {
            commande = new SqlCommand(requete, cnx);
            cnx.Open();
            int return_value = commande.ExecuteNonQuery();
            cnx.Close();
            return return_value;
        }

        public static SqlDataReader ExecuteSelect(string requete)
        {
            commande = new SqlCommand(requete, cnx);
            cnx.Open();
            return commande.ExecuteReader();

        }

        public static void Close()
        {
            cnx.Close();
        }
    }
}
