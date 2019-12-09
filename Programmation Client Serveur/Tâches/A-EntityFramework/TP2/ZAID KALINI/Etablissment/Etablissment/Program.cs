using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etablissment.Entity;

namespace Etablissment
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionEtablissement gestion = new GestionEtablissement();
            // ajouter formateurs
            List<Formateur> formateurs = new List<Formateur>()
            {
                new Formateur {Id=1,Nom="Litt",Prenom="Luis" },
            new Formateur {Id =2,Nom ="Specter",Prenom="Harvey" },
            new Formateur {Id =3,Nom ="Pearson",Prenom="Jeassica" },
            };
            foreach (var item in formateurs)
            {
                gestion.Ajouter(item);
            }
            //Afficher
            Console.WriteLine("after Added");
            var lst = gestion.Afficher();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            //Modiffier 
            Formateur newFormateur = new Formateur() { Id = 1, Nom = "Ross", Prenom = "Mike" };
            gestion.Modifier(newFormateur, 1);
            //Afficher
            Console.WriteLine("after Editing");
            lst = gestion.Afficher();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            //Suprimer
            gestion.Suprimer(3);
            //Afficher
            Console.WriteLine("after deleting");
             lst = gestion.Afficher();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
