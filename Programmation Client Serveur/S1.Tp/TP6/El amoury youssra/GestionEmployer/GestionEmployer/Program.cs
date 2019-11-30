
using GestionEmployer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GestionEmployer
{
    class Program
    {
        private static object e;

        static void Main(string[] args)
        {
            // TD - CRUD avec MyConnexion

            GestionEntreprise gestion = new GestionEntreprise();

            // Ajouter
          Entreprise e = new Entreprise();
          //e.Nom = "Entreprise 4";
          // e.Id = 3;

          // gestion.Ajouter(e);
           //e.Id = 2;
           //gestion.Ajouter(e);

           //Supprimer
           // gestion.Supprimer_Par_Code("4");

            //// Modifier
          // e.Nom = "Entreprise Modifier";
          // gestion.Modifier(e);

            //// Afficher

          foreach (Entreprise item in gestion.Afficher())
            {
             Console.WriteLine(
                  string.
                    Format(
                      "Entreprise {0},{1}",
                   item.Id, item.Nom));
         }

            Console.Read();


        }
    }
}