using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace GestionEmployer.Service
{
    /// <summary>
    /// TD 8
    /// </summary>
    public class MyConnexion
    {
        private static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-T03IVK2\SQLEXPRESS;Initial Catalog=GestionEmployer;Integrated Security=True");
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