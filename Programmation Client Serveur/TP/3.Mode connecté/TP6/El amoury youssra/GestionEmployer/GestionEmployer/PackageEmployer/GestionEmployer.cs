using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionEmployer.Service;

namespace GestionEmployer
{
 public   class GestionEmployer
    {


        string requete;
        private object listesEmployer;

        public GestionEmployer()
        {

        }

        public void Ajouter(Employer e)
        {
            requete = "insert into Employer (Id,Nom,Prenom,IdEntreprise)Values(" + e.Id + ",'" + e.Nom + "','" + e.Prenom + "'," + e.Entreprise1.Id + ")";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Supprimer(int id)
        {
            requete = "Delete from Employer where id=" + id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public void Modifier(Employer e)
        {
            requete = "Update Employer set nom = '" + e.Nom + "',prenom='" + e.Prenom + "',Id_groupe = " + e.Entreprise1.Id + " where id=" + e.Id + "";
            MyConnexion.ExecuteSQL(requete);
        }

        public List<Employer> Afficher()
        {
            List<Employer> listesEmloyer = new List<Employer>();
            requete = "Select * from Employer e , Entreprise en where e.entreprise.id = en.Id";
            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            while (dr.Read())
            {
               Entreprise en = new Entreprise(int.Parse(dr[5].ToString()), dr[6].ToString());
                listesEmloyer.Add(new Employer(dr.GetInt32(0), dr.GetString(1), dr.GetString(3)));
            }
            MyConnexion.Close();
            return listesEmloyer;
        }

        public Employer getEmployer(int id)
        {

            requete = "Select * from Employer e , Entreprise  en where e.id=" + id + " and e.Entreprise.id = en.Id";

            SqlDataReader dr = MyConnexion.ExecuteSelect(requete);
            dr.Read();
            Entreprise en = new Entreprise(int.Parse(dr[7].ToString()), dr[8].ToString());
           Employer e = new Employer(dr.GetInt32(0), dr.GetString(1), dr.GetString(5));
            MyConnexion.Close();
            return e;
        }

    }
}
