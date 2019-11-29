using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_WindowsForm
{
    class Gestion_de_livre
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Livre_TP6;Integrated Security=True");
        SqlCommand cmd;
        //methode de connection
        public int Execute_SQL(string requete)
        {
            cmd = new SqlCommand(requete, conn);

            conn.Open();

           int value= cmd.ExecuteNonQuery();

            conn.Close();
            return value;
           

        }

        public  SqlDataReader Execute_Select(string requete)
        {
            cmd = new SqlCommand(requete, conn);
            conn.Open();
            return cmd.ExecuteReader();

        }

        public  void SQL_Close()
        {
            conn.Close();
        }




        string Requete;
//methode d'ajouter
        public void Ajouter(Livre l)
        {
            Requete = $"insert into Livre values({l.Id},'{l.Titre}','{l.Categorie}','{l.Nom_auteur}')";
            Execute_SQL(Requete);

        }
//methode supprimer
        public void Supprimer(int id)
        {
            Requete = $"Delete from Livre where id={id}";
            Execute_SQL(Requete);
        }
//methode modifier

        public void Modifier(Livre l)
        {
            Requete = $"Update Livre set titre='{l.Titre}',categorie='{l.Categorie}',nom_auteur='{l.Nom_auteur}' where id={l.Id}";
            Execute_SQL(Requete);
        }
   
//methode Affichier

        public List<Livre> Affichier()
        {
            List<Livre> list_livre = new List<Livre>();
            Requete = "select * from Livre";
            SqlDataReader rd = Execute_Select(Requete);
            while(rd.Read())
            {
                list_livre.Add(new Livre(rd.GetInt32(0),rd.GetString(1), rd.GetString(2), rd.GetString(3)));
            }

            SQL_Close();

            return list_livre;
        }

        //methode de recherche
        public int Recherche(int id)
        {
            Requete = $"select * from Livre where id={id}";

            SqlDataReader rd = Execute_Select(Requete);
            while(rd.HasRows)
            {
                return 1;
            }
            SQL_Close();
            return -1;
        }




    }
}
