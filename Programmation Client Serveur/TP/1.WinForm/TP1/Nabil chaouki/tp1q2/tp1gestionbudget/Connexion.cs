using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1gestionbudget
{
   public class Connexion
    {
        private SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-T74VUB02\MSSQLSERVE;Initial Catalog=bidget;user = sa; password = admintp4");
        private SqlCommand commande;

        public void ExecuteSQL(string requete)
        {
            commande = new SqlCommand(requete, cnx);
            cnx.Open();
            commande.ExecuteNonQuery();
            cnx.Close();
        }

        public SqlDataReader ExecuteSelect(string requete)
        {
            commande = new SqlCommand(requete, cnx);
            cnx.Open();
            return commande.ExecuteReader();

        }

        public void Close()
        {
            cnx.Close();
        }
    }
}

