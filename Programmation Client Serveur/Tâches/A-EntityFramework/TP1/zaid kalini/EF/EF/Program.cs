using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new GestionProjetsEntities();
            Projets p = new Projets();
            p.Id_Projets = 150;
            p.Nombre_Jours_Realisation = 10;
            p.Titre = "First project";
            p.Tache = null;
            context.Projets.Add(p);
            context.SaveChanges();
            Console.WriteLine($"vous avez ajoute avec succes le projet : {p.Id_Projets} {p.Nombre_Jours_Realisation} {p.Titre}");
            ///
            Projets p1 = new Projets();
            p1.Id_Projets = 100;
            p1.Nombre_Jours_Realisation = 10;
            p1.Titre = "Second project";
            p1.Tache = null;
            context.Projets.Add(p1);
            context.SaveChanges();
            Console.WriteLine($"vous avez ajoute avec succes le projet : {p1.Id_Projets} {p1.Nombre_Jours_Realisation} {p1.Titre}");
            ////

            var projet = context.Projets.SingleOrDefault(pp => pp.Id_Projets == 100);
            context.Projets.Remove(projet);
            Console.WriteLine($"vous avez suprimer avec succes le projet : {projet.Id_Projets} {projet.Nombre_Jours_Realisation} {projet.Titre}");
            context.SaveChanges();
            //////
            var pj = context.Projets.SingleOrDefault(pr => pr.Id_Projets == 150);
            pj.Titre = "new title";
            context.SaveChanges();
            Console.WriteLine($"vous avez modifier avec succes le projet : {pj.Id_Projets} {pj.Nombre_Jours_Realisation} {pj.Titre}");
            //affichage
            var Proje = (from Projets proj in context.Projets select proj).ToList();
            Console.WriteLine("Affichage");
            foreach (var item in Proje)
            {
                Console.WriteLine($"Projet : {item.Id_Projets} {item.Nombre_Jours_Realisation} {item.Titre}");
            }
            Console.ReadKey();
        }
    }
}
