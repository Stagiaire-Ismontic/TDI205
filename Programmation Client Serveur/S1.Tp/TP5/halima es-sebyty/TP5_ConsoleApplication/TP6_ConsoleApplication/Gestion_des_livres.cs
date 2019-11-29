using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TP6_ConsoleApplication
{
    class Gestion_des_livres
    {
       

        string Requete;
        //methode d'ajouter
        public void Ajouter(Livre l)
        {
            if (l.Id > 0)
            {
                Requete = $"insert into Livre values({l.Id},'{l.Titre}','{l.Categorie}','{l.Nom_auteur}')";
                new My_connection().Execute_SQL(Requete);
                Console.WriteLine("l'ajoute termain avec socces");
            }
            else
            {
                Console.WriteLine("echece d'ajoute");
            }
        }
        //methode supprimer
        public void Supprimer(int id)
        {
            if(Recherche(id)!=-1)
            { 
               Requete = $"Delete from Livre where id={id}";
               new My_connection().Execute_SQL(Requete);

                Console.WriteLine("la supprition termain avec socces");
            }
            else
            {
                Console.WriteLine("le livre n'existe pas !!!!");
            }
        }
        //methode modifier

        public void Modifier(Livre l)
        {
            if (Recherche(l.Id) != -1)
            {
                Requete = $"Update Livre set titre='{l.Titre}',categorie='{l.Categorie}',nom_auteur='{l.Nom_auteur}' where id={l.Id}";
                new My_connection().Execute_SQL(Requete);
                Console.WriteLine("la modification termain avec socces");
            }
            else
            {
                Console.WriteLine("le livre n'existe pas !!!!");
            }
        }

        //methode Affichier

        public void Affichier()
        {
            Requete = "select * from Livre";
            SqlDataReader rd = new My_connection().Execute_Select(Requete);
            while (rd.Read())
            {
                Console.WriteLine("{0},{1},{2},{3}",rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3));
            }

            new My_connection().SQL_Close();
            
        }

        //methode de recherche
        public int Recherche(int id)
        {
            Requete = $"select * from Livre where id={id}";

            SqlDataReader rd = new My_connection().Execute_Select(Requete);
            while (rd.HasRows)
            {
                return 1;
            }
            new My_connection().SQL_Close();
            return -1;
        }


    }
}
