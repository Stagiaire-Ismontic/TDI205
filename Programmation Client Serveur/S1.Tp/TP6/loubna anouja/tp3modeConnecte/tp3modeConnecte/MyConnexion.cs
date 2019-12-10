using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3modeConnecte
{
    public static class MyConnexion
    {
        private static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=loubna;Integrated Security=True");
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
            // cnx.Close();
            return commande.ExecuteReader();

        }

        public static void Close()
        {
            cnx.Close();
        }
    }
}