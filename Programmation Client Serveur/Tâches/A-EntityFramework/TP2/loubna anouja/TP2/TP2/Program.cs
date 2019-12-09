using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        public static List<commande> listcmd;
        static void Main(string[] args)
        {
            using (Model1 db = new Model1())
            {
                listcmd = db.commandes.ToList();
                foreach (var item in listcmd)
                {
                    Console.WriteLine(item.Nom);
                }
                commande cmd = new commande();
                //cmd.Id = 4;
                //cmd.Code = "hhj";
                //cmd.Nom = "break";
                //db.commandes.Add(cmd);
                //ajouter(new commande() { Id = 3, Code = "yyy", Nom = "ppp" }, db);
                //supprimer(1,db);
                modifier(new commande() { Id = 3, Code = "sds", Nom = "manti" }, db);
                afficher(db);
                Console.ReadLine();
            }
        }
        public static void afficher(Model1 db)
        {
            foreach (commande c in listcmd)
            {
                Console.WriteLine(c.Id + " " + " " + c.Code + " " + c.Nom);
            }
        }
        public static void ajouter(commande c, Model1 db)
        {
            if (db.commandes.Find(c.Id) == null)
            {
                db.commandes.Add(c);
                Console.WriteLine("ajoutée avec succes ");
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("n'existe pas!!");
            }
        }
        public static void supprimer(int Id, Model1 db)
        {
            if (db.commandes.Find(Id) != null)
            {
                db.commandes.Remove(db.commandes.Find(Id));
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("n'existe pas!!");
            }
        }
        public static void modifier(commande c, Model1 db)
        {
            if (db.commandes.Find(c.Id) != null)
            {
                db.commandes.Where(newcmd => c.Id == newcmd.Id).ToList().ForEach(newcmd => newcmd = c);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("n'existe pas!!");
            }
        }
    }
}


