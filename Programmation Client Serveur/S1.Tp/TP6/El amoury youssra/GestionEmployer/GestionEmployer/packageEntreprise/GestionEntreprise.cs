using GestionEmployer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEmployer
{
   public class GestionEntreprise
    {
        string requete;

        public string Id { get; private set; }

        /// <summary>
        /// Insertion de l'objet groupe dans la base de données
        /// </summary>
        /// <param name="Entreprise"></param>
        public int Ajouter(Entreprise Entreprise)
        {
            requete = "insert into Entreprise Values('" + Entreprise.Nom + "')";
            return MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer(int id)
        {
            requete = "Delete from Entreprise where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer_Par_Code(string Nom)
        {
            requete = "Delete from Entreprise where Nom='" + Id + "'";
            MyConnexion.ExecuteSQL(requete);
        }


        public void Modifier(Entreprise en)
        {
            requete = "Update Entreprise set nom = '" + en.Nom + "' where id=" + en.Id + "";
            MyConnexion.ExecuteSQL(requete);
        }


        public List<Entreprise> Afficher()
        {
            List<Entreprise> listesEntreprise = new List<Entreprise>();
            requete = "Select * from Entreprise";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
                listesEntreprise.Add(new Entreprise(int.Parse(dr[0].ToString()), dr[1].ToString()));
            }
            MyConnexion.Close();
            return listesEntreprise;
        }


        public Entreprise getEntreprise(int id)
        {

            requete = "Select * from Entreprise where id=" + id + "";

            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            dr.Read();
            Entreprise en  = new Entreprise(int.Parse(dr[0].ToString()), dr[1].ToString());
            MyConnexion.Close();
            return en;
        }

    }
}
