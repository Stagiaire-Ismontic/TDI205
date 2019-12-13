using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mode_Connecter
{
    public class GestionStagaires
    {
        string requete;
        public GestionStagaires()
        {

        }
        public int Ajouter(Stagiaire s)
        {
            requete = "insert into Stagiaire (Id,Nom,Prenom)Values(" + s.Id + ",'" + s.Nom + "','" + s.Prenom + "')";
            return Connection.ExecuteSQL(requete);
        }

        public int Supprimer(int id)
        {
            requete = "Delete from Stagiaire where id=" + id + "";
           return Connection.ExecuteSQL(requete);
        }

        public int Modifier(Stagiaire s)
        {
            requete = "Update Stagiaire set Nom = '" + s.Nom + "',Prenom='" + s.Prenom + "' where id=" + s.Id + "";
            return Connection.ExecuteSQL(requete);
        }

        public List<Stagiaire> Afficher()
        {
            List<Stagiaire> listesStagiaires = new List<Stagiaire>();
            requete = "Select * from Stagiaire";
            SqlDataReader dr = Connection.ExecuteSelect(requete);
            while (dr.Read())
            {
               
                listesStagiaires.Add(new Stagiaire(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            Connection.Close();
            return listesStagiaires;
        }

        public Stagiaire getStagiaire(int id)
        {

            requete = "Select * from Stagiaire";

            SqlDataReader dr = Connection.ExecuteSelect(requete);
            dr.Read();
            Stagiaire s = new Stagiaire(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            Connection.Close();
            return s;
        }
    }
}
