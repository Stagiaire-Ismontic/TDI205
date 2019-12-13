using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyali
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DBSchoolEntities1 context = new DBSchoolEntities1())
            {
                /*affichage de Stagiaires et groupes */ 
                affiche(context);
                /*Ajouter un groupe*/
                addYaStgYaGrp(new groupe() { Id = 2, nom = "grp2" }, context);
                /*Ajouter un stagiaire*/
                //addYaStgYaGrp(new stg() {Id=19,nom="666",prenom="nabil", groupeid=1 } , context);
                /*supprimer un groupe*/
                //deleteGroupe(context, 19);
                /*supprimer un stagiaire*/
                //deleteStagiaire(context, 6);
                /*modifier un stagiaire*/
                modifier(new stg() {Id=19, nom="br",prenom="brahim", groupeid=1 }, context);
                /*modifier un groupe*/
                modifier(new groupe() { Id = 1, nom = "td" },context);
                affiche(context);
                Console.ReadLine();
            }
        }
        /*methode afficher*/
        public static void affiche(DBSchoolEntities1 context)
        {
            foreach (stg s in context.stgs)
            {
                Console.WriteLine(s.Id + " " + s.nom + "  " + s.prenom + " " + s.groupeid);
            }
            foreach (groupe s in context.groupes)
            {
                Console.WriteLine(s.Id + " " + s.nom);
            }
        }
        /*methode ajouter*/
        public static void addYaStgYaGrp(object o, DBSchoolEntities1 context) 
        {
            int b = 0;
            if (o is stg &&  context.stgs.Find(((stg)o).Id)==null) {
                context.stgs.Add(o as stg);
                b = 1;
            }
            else if(o is groupe && context.groupes.Find(((groupe)o).Id) == null)
            {
                context.groupes.Add(o as groupe);
                b = 2;
            }
            context.SaveChanges();
            if (b == 1)
            {
                Console.WriteLine("stg a ete ajouter avec succes");
            }
            else if (b == 2) {
                Console.WriteLine("grp a ete ajouter succes");
            }
            else Console.WriteLine("ya un souçis");
        }
        /*methode suprimmer stagiaire*/
        public static void deleteStagiaire(DBSchoolEntities1 db ,int id) {
            if (db.stgs.Find(id) != null)
            {
                db.stgs.Remove(db.stgs.Find(id));
                Console.WriteLine("il est plus la");
            }
            else
            {
                Console.WriteLine("il existe plus ce id");
            }
            db.SaveChanges();
        }
        /*methode suprimmer groupe*/
        public static void deleteGroupe(DBSchoolEntities1 db, int id)
        {
            if (db.groupes.Find(id) != null)
            {
                db.groupes.Remove(db.groupes.Find(id));
                Console.WriteLine("il est plus la");
            }
            else
            {
                Console.WriteLine("il existe plus ce id");
            }
            db.SaveChanges();
        }
        /*methode modifier stagiaire*/
        static void modifier(stg s,DBSchoolEntities1 co)
        {
            if (co.stgs.Find(s.Id) != null)
            {
                stg ss = co.stgs.Find(s.Id);
                ss.nom = s.nom;
                ss.prenom = s.prenom;
                ss.groupeid = s.groupeid;
                co.SaveChanges();
            }
        }
        /*methode modifier groupe*/
        static void modifier(groupe g, DBSchoolEntities1 co)
        {
            if (co.groupes.Find(g.Id) != null)
            {
                groupe ss = co.groupes.Find(g.Id);
                ss.nom = g.nom;
                co.SaveChanges();
            }
        }
    }
}
