using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassConx
{
    public class Connexion
    {
        private SqlConnection cnx = new SqlConnection(@"Data Source=.\;Initial Catalog=GestionStagiaire;Integrated Security = True");
        private SqlCommand commande;

        public int ExecuteSQL(string requete)
        {
            commande = new SqlCommand(requete, cnx);
            cnx.Open();
            int return_value = commande.ExecuteNonQuery();
            cnx.Close();
            return return_value;
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
