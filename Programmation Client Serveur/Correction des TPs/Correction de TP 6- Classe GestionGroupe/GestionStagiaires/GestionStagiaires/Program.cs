using GestionStagiaires.PackageGroupes;
using GestionStagiaires.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionStagiaires
{
    class Program
    {
        static void Main(string[] args)
        {
            // TD - CRUD avec MyConnexion

            GestionGroupes gestion = new GestionGroupes();

            // Ajouter
            //Groupe g = new Groupe();
            //g.Nom = "Groupe 1";
            //g.Id = 1;

            //gestion.Ajouter(g);
            //g.Id = 2;
            //gestion.Ajouter(g);

            //// Supprimer
            gestion.Supprimer_Par_Code("1");

            //// Modifier
            //g.Nom = "Groupe Modifier";
            //gestion.Modifier(g);

            //// Afficher

            foreach (Groupe item in gestion.Afficher())
            {
                Console.WriteLine(
                    string.
                    Format(
                        "Groupe {0},{1}",
                    item.Id, item.Nom));
            }

            Console.Read();

   
        }
    }
}
