using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (stgchihajaEntities context = new stgchihajaEntities())

            {
                groupe g = new groupe() { Id = 21, nom = "TDI205" };
                stgr s = new stgr() { Id = 22, nom = "ali gr", groupid = 21 };
                Ajouter(g, context);
                Ajouter(s, context);
                affiche(context);
                modifier(s, context);
                modifier(g, context);
                affiche(context);
                SupprimerGroupe(g.Id, context);
                SupprimerStagiaire(s.Id, context);
                affiche(context);
                Console.ReadKey();
                //SupprimerGroupe(context)
            }
        }
        public static void affiche(stgchihajaEntities context)
        {
            foreach(stgr s in context.stgrs)
            { Console.WriteLine(s.Id+""+s.nom+""+s.groupid); }
            foreach(groupe g in context.groupes)
            {
                Console.WriteLine(g.Id+""+g);
            }
        }
        public static void Ajouter(stgr s,stgchihajaEntities context)
        {
            
            if (context.stgrs.Find(s.Id) == null)
            {
                context.stgrs.Add(s);
                context.SaveChanges();
                Console.WriteLine("le stagiaire a ete ajouté avec succes");
            }
        }
        public static void Ajouter(groupe g,stgchihajaEntities context)
        {
            if (context.groupes.Find(g.Id) == null)
            {
                context.groupes.Add(g);
                context.SaveChanges();

                Console.WriteLine("le groupe a ete ajouté avec succes");
            }
        }
        public static void SupprimerStagiaire(int id, stgchihajaEntities stg)
        {
            if (stg.stgrs.Find(id) != null)
            {
                stg.stgrs.Remove(stg.stgrs.Find(id));
               

                Console.WriteLine("supprimer avec succes");
            }
            else
            {
                Console.WriteLine("id de stg existe pas");
            }
            stg.SaveChanges();
        }
        public static void SupprimerGroupe(int id, stgchihajaEntities grp)
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
        public static void modifier(stgr s,stgchihajaEntities strgp)
        {
            if (strgp.stgrs.Find(s.Id) != null)
            {
                stgr stg = strgp.stgrs.Find(s.Id);
                stg.nom = s.nom;
                stg.groupid = s.groupid;
                strgp.SaveChanges();
            }
        }
        public static void modifier(groupe g,stgchihajaEntities strgp)
        {
            if(strgp.groupes.Find(g.Id)!=null)
            {
                groupe grp = strgp.groupes.Find(g.Id);
                grp.nom = g.nom;
                strgp.SaveChanges();
            }
        }
    }
}
