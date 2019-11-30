using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion_Stagiaires
{
    public class GestionnaireStagiairescs
    {
        SqlCommand Cmd;
        string Chaine=@"Data Source = .\; Initial Catalog = GestionStagiaires; Integrated Security = True";
        

        public Stagiaire Recherche(int id)
        {
            SqlConnection Cnx = new SqlConnection(Chaine);
            Cnx.Open();
            Cmd = new SqlCommand("Select * from Stagiaire s where s.Id="+id,Cnx);
            SqlDataReader Rd = Cmd.ExecuteReader();
            if (Rd.HasRows)
            {
                Stagiaire S = new Stagiaire(Rd.GetInt32(0), Rd.GetString(1), Rd.GetString(2));
                return S;
            }
            return null;
        }

    

        public bool Ajouter(Stagiaire St)
        {
            using (SqlConnection Cnx = new SqlConnection(Chaine))
            {
                if (Recherche(St.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Insert into Stagiaire(Id,Cin,Nom) values(" + St.Id + ",'" + St.Cin + "','" + St.Nom + "')", Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }

        public bool Supprimer(Stagiaire St)
        {

            using (SqlConnection Cnx = new SqlConnection(Chaine))
            {
                if (Recherche(St.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Delete * from Stagiaire where Id=" + St.Id, Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;

            }
        }

        public bool Modifier(Stagiaire Sta)
        {

            using (SqlConnection Cnx = new SqlConnection(Chaine))
            {
                if (Recherche(Sta.Id) != null)
                {
                    Cnx.Open();
                    Cmd = new SqlCommand("Update Stagiaire set Nom= '" + Sta.Nom + "',Cin='" + Sta.Cin + "' where Id=" + Sta.Id, Cnx);
                    Cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
        }


        public List<Stagiaire> Afficher()
        {
            using (SqlConnection Cnx = new SqlConnection(Chaine))
            {
                List<Stagiaire> LstStagiaires = new List<Stagiaire>();
                Cnx.Open();
                Cmd = new SqlCommand("Select * from Stagiaire", Cnx);
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    LstStagiaires.Add(new Stagiaire(Rd.GetInt32(0), Rd.GetString(1), Rd.GetString(2)));
                }
                return LstStagiaires;
            }
        }

        
    }
}
