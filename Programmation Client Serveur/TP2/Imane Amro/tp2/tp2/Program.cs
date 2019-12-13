using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    class Program
    {
        public static List<Employer> lstEmp;
        static void Main(string[] args)
        {
            using (Model1 db = new Model1())
            {
                lstEmp = db.employers.ToList();
                foreach (var items in lstEmp)
                {
                    Console.WriteLine(items.Nom);
                }
                Employer e = new Employer();
                ////e.Id = 1;
                //e.Nom = "imane";
                //e.prenom = "amro";
                //db.Employers.Add(e);
                //Ajouter(new Employer() { Id =55, Nom = "hamud", prenom = "amro", IdEntreprise = 9 }, db);
                afficher(db);
                //UpdateUser(new Employer() { Id = 1, Nom = "laila", prenom= "lolo",  }, db);

                //delete(10, db);







                Console.ReadLine();
            }
        }
        public static void afficher(Model1 db)
        {
            foreach (Employer s in lstEmp)
            {
                Console.WriteLine(s.Id + "" + s.Nom + "  " + s.prenom + " ");
            }


        }
        public static void Ajouter(Employer a, Model1 db)
        {
            if (db.employers.Find(a.Id) == null)
            {
                db.employers.Add(a);
                Console.WriteLine("accomplished ");

            }
            else
            {
                Console.WriteLine("this id doesnt exist");
            }
        }
        public static void delete(int Id, Model1 db)
        {
            if (db.employers.Find(Id) != null)
            {
                db.employers.Remove(db.employers.Find(Id));
                Console.WriteLine("Done");
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
        public static void UpdateUser(Employer a, Model1 db)
        {
            if (db.employers.Find(a.Id) != null)
            {
                db.employers.Where(aa => a.Id == aa.Id).ToList().ForEach(aa => aa = a);
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

