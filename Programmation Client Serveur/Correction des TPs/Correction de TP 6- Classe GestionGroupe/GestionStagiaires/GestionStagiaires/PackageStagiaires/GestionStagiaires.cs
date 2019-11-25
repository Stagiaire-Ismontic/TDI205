using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using GestionStagiaires.Service;
using GestionStagiaires.PackageGroupes;
namespace GestionStagiaires.PackageStagiaires
{
    public class GestionStagiaires
    {
        string requete;

        public GestionStagiaires()
        {

        }

        public void Ajouter(Stagiaire s)
        {
            requete = "insert into Stagiaires (Id,Nom,Prenom,Id_groupe)Values(" + s.Id + ",'" + s.Nom + "','" + s.Prenom + "',"+s.Groupe.Id+")";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer(int id)
        {
            requete = "Delete from Stagiaires where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Modifier(Stagiaire s)
        {
            requete = "Update Stagiaires set nom = '" + s.Nom + "',prenom='" + s.Prenom + "',Id_groupe = "+s.Groupe.Id+" where id=" + s.Id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public List<Stagiaire> Afficher()
        {
            List<Stagiaire> listesStagiaires = new List<Stagiaire>();
            requete = "Select * from Stagiaires s , groupes g where s.Id_groupe = g.Id";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                Groupe g = new Groupe(int.Parse(dr[5].ToString()), dr[6].ToString());
                listesStagiaires.Add(new Stagiaire(dr.GetInt32(0), dr.GetString(1), dr.GetString(3),g));
            }
            MyConnexion.Close();
            return listesStagiaires;
        }

        public Stagiaire getStagiaire(int id)
        {

            requete = "Select * from Stagiaires s , Groupes g where s.id=" + id + " and s.Id_groupe = g.Id";

            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            dr.Read();
            Groupe g = new Groupe(int.Parse(dr[7].ToString()), dr[8].ToString());
            Stagiaire s = new Stagiaire(dr.GetInt32(0), dr.GetString(1), dr.GetString(5),g);
            MyConnexion.Close();
            return s;
        }
    }
}
