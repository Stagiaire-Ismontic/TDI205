using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaidKaliniEF.Entity;

namespace ZaidKaliniEF
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionEtablissment gestion = new GestionEtablissment();
            // ajouter formateurs
            List<Formateur> formateurs = new List<Formateur>()
            {
                new Formateur {IdFormateur=1,Nom="Litt",Prenom="Luis" },
            new Formateur {IdFormateur =2,Nom ="Specter",Prenom="Harvey" },
            new Formateur {IdFormateur =3,Nom ="Pearson",Prenom="Jeassica" },
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
            Formateur newFormateur = new Formateur() { IdFormateur = 1, Nom = "Ross", Prenom = "Mike" };
            gestion.Modifier(newFormateur,1);
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
