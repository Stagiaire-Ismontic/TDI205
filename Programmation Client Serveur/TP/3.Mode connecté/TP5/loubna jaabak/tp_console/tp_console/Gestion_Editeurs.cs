using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_console
{
   public class Gestion_Editeurs
    {
        string requete;
        public Gestion_Editeurs()
        {
        }
        public void Ajouter(Editeur E)
        {
            requete = $"insert into Editeur (id,nom,categorie) Values({E.Id},'{E.Nom}','{ E.Categorie}')";
            My_Connexion.ExecuteSQL(requete);
        }
        public void Supprimer(int id)
        {
            requete = "Delete from Editeur where id=" + id + "";
            My_Connexion.ExecuteSQL(requete);
        }
        public void Modifier(Editeur E)
        {
            requete = $"Update Editeur set nom ='{E.Nom} ',categorie = '{E.Categorie}' where id={E.Id} ";
            My_Connexion.ExecuteSQL(requete);
        }
        public List<Editeur> Afficher()
        {
            List<Editeur> listesEditeur = new List<Editeur>();
            requete = "Select * from Editeur";
            SqlDataReader dr = My_Connexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                listesEditeur.Add(new Editeur(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            My_Connexion.Close();
            return listesEditeur;
        }
        public int getEditeur(int id)
        {
            requete = "Select * from Editeur  where id=" + id + "";
            SqlDataReader dr = My_Connexion.ExecuteSelect(requete);
            while (dr.HasRows)
            {
                return 1;
            }
            My_Connexion.Close();
            return -1;
        }
    }
}
