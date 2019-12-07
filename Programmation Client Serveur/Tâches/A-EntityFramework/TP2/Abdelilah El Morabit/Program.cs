using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (stgrp context = new stgrp())
            {
                affiche(context);
                addYaStgYaGrp(new groupe() { Id = 2, nom = "grp2" }, context);
                addYaStgYaGrp(new stg() {Id=19,nom="666",prenom="nabil", groupeid=2 } , context);
                affiche(context);
                
                modifier(new stg() { Id = 19, nom = "br", prenom = "brhm", groupeid = 1 }, context);
                modifier(new groupe() { Id = 1, nom = "td" }, context);
                affiche(context);
                deleteGroupe(context, 1);
                deleteStagiaire(context, 19);
                affiche(context);
                Console.ReadLine();
            }
        }
        public static void affiche(stgrp context)
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
        public static void addYaStgYaGrp(object o, stgrp context)
        {
            int b = 0;
            if (o is stg && context.stgs.Find(((stg)o).Id) == null)
            {
                context.stgs.Add(o as stg);
                b = 1;
            }
            else if (o is groupe && context.groupes.Find(((groupe)o).Id) == null)
            {
                context.groupes.Add(o as groupe);
                b = 2;
            }
            context.SaveChanges();
            if (b == 1)
            {
                Console.WriteLine("stg a ete ajouter avec succes");
            }
            else if (b == 2)
            {
                Console.WriteLine("grp a ete ajouter avec succes");
            }
            else Console.WriteLine("id exist deja");
        }
        public static void deleteStagiaire(stgrp db, int id)
        {
            if (db.stgs.Find(id) != null)
            {
                db.stgs.Remove(db.stgs.Find(id));
                Console.WriteLine("le stagiaier a ete suprimmer avec succes");
            }
            else
            {
                Console.WriteLine("id n exist pas");
            }
            db.SaveChanges();
        }
        public static void deleteGroupe(stgrp db, int id)
        {
            if (db.groupes.Find(id) != null)
            {
                db.groupes.Remove(db.groupes.Find(id));
                Console.WriteLine("la  groupe a ete supremmer avec succes");
            }
            else
            {
                Console.WriteLine("id n exsist pas");
            }
            db.SaveChanges();
        }
        static void modifier(stg s, stgrp co)
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
        static void modifier(groupe g, stgrp co)
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

