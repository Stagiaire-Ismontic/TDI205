using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6
{
    public class connexion
    {
        // Declaration des objets sql
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        // declaration de la methode connecter
        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=LAPTOP-T74VUB02\MSSQLSERVE;Initial Catalog=;Integrated Security=True";
                con.Open();
            }
        }

        // declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {

                con.Close();
            }
        }
    }
}
