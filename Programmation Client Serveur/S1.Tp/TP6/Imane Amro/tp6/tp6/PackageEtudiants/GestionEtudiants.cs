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
            requete = "insert into etudiantt  (id,nom,prenom,cin)Values(" + s.Id + ",'" + s.Nom + "','" + s.Prenom + "','" + s.Cin + "')";
            MyConnexion.ExecuteSQL(requete);
            
        }

        public void Supprimer(int id)
        {
            requete = "Delete from etudiantt  where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Modifier(Etudiant s)
        {
            requete = "Update etudiantt  set nom = '" + s.Nom + "',prenom='" + s.Prenom + "',cin = '" + s.Cin + "' where id=" + s.Id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public List<Etudiant> Afficher()
        {
            List<Etudiant> listesStagiaires = new List<Etudiant>();
            requete = "Select * from etudiantt";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                Etudiant g = new Etudiant(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                listesStagiaires.Add(g);
            }
            MyConnexion.Close();
            return listesStagiaires;
        }

    }
}
