using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class GestionFac
    {
        SqlCommand Cmd;  

        string X= @"data source=(localdb)\MSSQLLocalDB;initial catalog=GestionFacture;integrated security=True";

        public Facture Recherche(int id)
        {
                SqlConnection Cnx = new SqlConnection(X);
                Cnx.Open();
                Cmd = new SqlCommand("Select * from Facture s where s.IdFacture=" + id, Cnx);
                SqlDataReader Rd = Cmd.ExecuteReader();
                  Facture S = new Facture() ;
            if (Rd.HasRows)
            {
               
                while (Rd.Read())
                {

                     S = new Facture(Rd.GetInt32(0), Rd.GetString(1),double.Parse( Rd.GetDecimal(2).ToString()), new Client() { Id = Rd.GetInt32(3) });
                }
                 
                Cnx.Close();
                return S;
                }
            Cnx.Close();
            return null;
        
        }

        public bool Ajouter(Facture St)
        {
            using (SqlConnection Cnx = new SqlConnection(X))
            {
                if (Recherche(St.Id) == null)
                {
                    Cnx.Open();
                    
                    Cmd = new SqlCommand("Insert into Facture values(" + St.Id + ",'" + St.Titre + "',"+St.Somme+","+St.Client.Id+")", Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public bool Supprimer(Facture St)
        {
            using (SqlConnection Cnx = new SqlConnection(X))
            {
                if (Recherche(St.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Delete from Facture where IdFacture=" + St.Id, Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public bool Modifier(Facture St)
        {

            using (SqlConnection Cnx = new SqlConnection(X))
            {
                if (Recherche(St.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Update Facture set Titre= '" + St.Titre + "',Somme=" + St.Somme + ",ClientId=" + St.Client.Id + " where IdFacture=" + St.Id, Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public List<Facture> Afficher()
        {
            using (SqlConnection Cnx = new SqlConnection(X))
            {
                List<Facture>listFacture = new List<Facture>();
                Cnx.Open();
                Cmd = new SqlCommand("Select * from Facture", Cnx);
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    listFacture.Add(new Facture(Rd.GetInt32(0), Rd.GetString(1), double.Parse(Rd.GetDecimal(2).ToString()), new Client() { Id = Rd.GetInt32(3) }));
     
                }
                return listFacture;
            }
        }


    }
}

