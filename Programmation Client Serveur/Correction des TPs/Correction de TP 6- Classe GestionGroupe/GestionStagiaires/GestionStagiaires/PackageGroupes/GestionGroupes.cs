using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionStagiaires.Service;
using System.Data.SqlClient;
namespace GestionStagiaires.PackageGroupes
{
    /// <summary>
    /// TD 6 : 
    /// </summary>
    public class GestionGroupes
    {
        string requete;

        /// <summary>
        /// Insertion de l'objet groupe dans la base de données
        /// </summary>
        /// <param name="groupe"></param>
        public int Ajouter(Groupe groupe)
        {
            requete = "insert into groupes Values("+groupe.Id+",'"+groupe.Nom+"')";
            return MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer(int id)
        {
            requete = "Delete from groupes where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer_Par_Code(string Code)
        {
            requete = "Delete from groupes where Code='" + Code + "'";
            MyConnexion.ExecuteSQL(requete);
        }


        public void Modifier(Groupe g)
        {
            requete = "Update groupes set nom = '" + g.Nom + "' where id=" + g.Id + "";
            MyConnexion.ExecuteSQL(requete);
        }


        public List<Groupe> Afficher()
        {
            List<Groupe> listesGroupes = new List<Groupe>();
            requete = "Select * from Groupes";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                listesGroupes.Add(new Groupe(int.Parse(dr[0].ToString()), dr[1].ToString()));
            }
            MyConnexion.Close();
            return listesGroupes;
        }


        public Groupe getGroupe(int id)
        {

            requete = "Select * from groupes where id="+id+"";

            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            dr.Read();
            Groupe g = new Groupe(int.Parse(dr[0].ToString()), dr[1].ToString());
            MyConnexion.Close();
            return g;
        }

    }
}
