using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static List<Employer> lstEmp;
        static void Main(string[] args)
        {
            using (GestionEmployerEntities db = new GestionEmployerEntities())
            {
                lstEmp = db.Employers.ToList();
                foreach (var items in lstEmp)
                {
                    Console.WriteLine(items.Nom);
                }
                Employer e = new Employer();
                e.Id = 1;
                e.Nom = "imane";
                e.prenom = "amro";
                //db.Employers.Add(e);
                //Ajouter(new Employer() { Id = 12, Nom = "aymane", prenom = "amro" },db);
              //afficher(db);
            //UpdateUser(new Employer() { Id = 1, Nom = "laila", prenom= "lolo",  }, db);
                
                delete(1, db);







                Console.ReadLine();
            } }
        public static void afficher(GestionEmployerEntities db)
        {
            foreach (Employer s in lstEmp)
            {
                Console.WriteLine(s.Id + "" + s.Nom + "  " + s.prenom + " " );
            }


        }
        public static void Ajouter(Employer a,GestionEmployerEntities db)
        {
            if (db.Employers.Find(a.Id) == null)
            {
                db.Employers.Add(a);
                Console.WriteLine("accomplished ");

            }
            else
            {
                Console.WriteLine("this id doesnt exist");
            }
        }
        public static void delete(int Id, GestionEmployerEntities db)
        {
            if (db.Employers.Find(Id) != null)
            {
                db.Employers.Remove(db.Employers.Find(Id));
                Console.WriteLine("Done");
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
        public static void UpdateUser(Employer a, GestionEmployerEntities db)
        {
            if (db.Employers.Find(a.Id) != null)
            {
                db.Employers.Where(aa => a.Id == aa.Id).ToList().ForEach(aa => aa = a);
                Console.WriteLine("Done");
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
    }
}
