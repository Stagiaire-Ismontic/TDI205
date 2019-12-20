using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    public class GestionCli
    {
        SqlCommand Cmd;

        string X = @"data source=(localdb)\MSSQLLocalDB;initial catalog=GestionFacture;integrated security=True";

        public Client Recherche(int id)
        {
            SqlConnection Cnx = new SqlConnection(X);
            Cnx.Open();
            Cmd = new SqlCommand("Select * from Client s where s.IdClient=" + id, Cnx);
            SqlDataReader Rd = Cmd.ExecuteReader();
            Client S = new Client();
            if (Rd.HasRows)
            {
                while (Rd.Read())
                {
                    S = new Client(Rd.GetInt32(0), Rd.GetString(1));
                }

                Cnx.Close();
                return S;
            }
            Cnx.Close();
            return null;

        }

        public bool Ajouter(Client St)
        {
            using (SqlConnection Cnx = new SqlConnection(X))
            {
                if (Recherche(St.Id) == null)
                {
                    Cnx.Open();

                    Cmd = new SqlCommand("Insert into Client values(" + St.Id + ",'" + St.Nom + "')", Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public bool Supprimer(Client St)
        {
            using (SqlConnection Cnx = new SqlConnection(X))
            {
                if (Recherche(St.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Delete from Client where IdClient=" + St.Id, Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public bool Modifier(Client St)
        {

            using (SqlConnection Cnx = new SqlConnection(X))
            {
                if (Recherche(St.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Update Client set Nom= '" + St.Nom + "' where IdClient=" + St.Id, Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public List<Client> Afficher()
        {
            using (SqlConnection Cnx = new SqlConnection(X))
            {
                List<Client> listClient = new List<Client>();
                Cnx.Open();
                Cmd = new SqlCommand("Select * from Client", Cnx);
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    listClient.Add(new Client(Rd.GetInt32(0), Rd.GetString(1)));

                }
                return listClient;
            }
        }

    }
}
