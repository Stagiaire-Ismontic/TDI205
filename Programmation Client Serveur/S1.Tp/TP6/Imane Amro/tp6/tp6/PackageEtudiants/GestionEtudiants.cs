using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tp6.PackageEtudiants
{

    public class GestionEtudiant
    {
        string requete;

        public GestionEtudiant()
        {

        }


        public void Ajouter(Etudiant s)
        {
            requete = "insert into stagiaire (id,nom,prenom,age)Values(" + s.Id + ",'" + s.Nom + "','" + s.Prenom + "'," + s.Age + ")";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer(int id)
        {
            requete = "Delete from stagiaire  where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Modifier(Etudiant s)
        {
            requete = "Update stagiaire  set nom = '" + s.Nom + "',prenom='" + s.Prenom + "',age = " + s.Age + " where id=" + s.Id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public List<Etudiant> Afficher()
        {
            List<Etudiant> listesStagiaires = new List<Etudiant>();
            requete = "Select * from stagiaire";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                Etudiant g = new Etudiant(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), int.Parse(dr[3].ToString()));
                listesStagiaires.Add(g);
            }
            MyConnexion.Close();
            return listesStagiaires;
        }

    }
}
