using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apah
{
    class Program
    {
        static void Main(string[] args)
        {
            using (stagrpEntities1 context = new stagrpEntities1())
            {
                groupe g = new groupe() { Id = 21, nomgrp = "TDI205" };
                Stagiaire s = new Stagiaire() { Id = 22, nomComplet = "ali gr", Idgrp = 21 };
                //ajouter groupe
                Ajouter(g, context);
                // ajouter stagiaire
                Ajouter(s, context);
                affiche(context);
                //modifier stagiaire
                modifier(s, context);
                //modifier groupe
                modifier(g, context);
                affiche(context);
                // supprimer groupe
                SupprimerGroupe(g.Id, context);
                //supprimer stagiaire
                SupprimerStagiaire(s.Id, context);
                affiche(context);
                Console.ReadKey();
                //SupprimerGroupe(context)
            }
        }
        // Methode Afficher
        public static void affiche(stagrpEntities1 context)
        {
            foreach(Stagiaire s in context.Stagiaires)
            { Console.WriteLine(s.Id+""+s.nomComplet+""+s.Idgrp); }
            foreach(groupe g in context.groupes)
            {
                Console.WriteLine(g.Id+""+g.nomgrp);
            }
        }
        // Methode Ajouter stagiaire
        public static void Ajouter(Stagiaire s,stagrpEntities1 context)
        {
            
            if (context.Stagiaires.Find(s.Id) == null)
            {
                context.Stagiaires.Add(s);
                context.SaveChanges();
                Console.WriteLine("le stagiaire a ete ajouté avec succes");
            }
        }
        // Methode Ajouter groupe
        public static void Ajouter(groupe g,stagrpEntities1 context)
        {
            if (context.groupes.Find(g.Id) == null)
            {
                context.groupes.Add(g);
                context.SaveChanges();

                Console.WriteLine("le groupe a ete ajouté avec succes");
            }
        }
        // Methode Supprimer Stagiaire
        public static void SupprimerStagiaire(int id, stagrpEntities1 stg)
        {
            if (stg.Stagiaires.Find(id) != null)
            {
                stg.Stagiaires.Remove(stg.Stagiaires.Find(id));
               

                Console.WriteLine("supprimer avec succes");
            }
            else
            {
                Console.WriteLine("id de stg existe pas");
            }
            stg.SaveChanges();
        }
        // Methode Supprimer groupe
        public static void SupprimerGroupe(int id, stagrpEntities1 grp)
        {
            if (grp.groupes.Find(id) != null)
            {
                grp.groupes.Remove(grp.groupes.Find(id));
                Console.WriteLine("groupe supprimer");
            }
            else
            {
                Console.WriteLine("id de grp existe pas");
            }
            grp.SaveChanges();
        }
        // Methode modifier Stagiaire
        public static void modifier(Stagiaire s,stagrpEntities1 strgp)
        {
            if (strgp.Stagiaires.Find(s.Id) != null)
            {
                Stagiaire stg = strgp.Stagiaires.Find(s.Id);
                stg.nomComplet = s.nomComplet;
                stg.Idgrp = s.Idgrp;
                strgp.SaveChanges();
            }
        }
        // Methode Modifier groupe
        public static void modifier(groupe g,stagrpEntities1 strgp)
        {
            if(strgp.groupes.Find(g.Id)!=null)
            {
                groupe grp = strgp.groupes.Find(g.Id);
                grp.nomgrp = g.nomgrp;
                strgp.SaveChanges();
            }
        }
    }
}
