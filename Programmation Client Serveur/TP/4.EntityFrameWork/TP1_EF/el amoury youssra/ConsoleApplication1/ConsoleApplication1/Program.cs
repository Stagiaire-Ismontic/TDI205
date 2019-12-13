using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GestionEmployerEntities db = new GestionEmployerEntities())
            {
                List<Employer> lisEmpl = db.Employer.ToList();
                foreach(var items in lisEmpl)
                {
                    Console.WriteLine(items.Nom);
                }
            }
            //1.Exemple d'insertion de votre objet dans la base de données ( Create )

            // using (var context = new GestionEmployerEntities())
            //{
            //      var emp = new Employer()
            //       {
            //          Nom = "youssrea",
            //            prenom = "hhhhhh",
            //           IdEntreprise = 1

            //     };
            //      context.Employer.Add(emp);

            //      context.SaveChanges();
            //        Console.WriteLine("ajouter avec succes");
            //   }
            //  2.Exemple de mise à jour(Update)
            //using (var context = new GestionEmployerEntities())
            // {
            //    var emp = context.Employer.First<Employer>();
            //      emp.Nom = "amouryyyyyy";

            //     context.SaveChanges();
            //      Console.WriteLine("modifier avec succes");

            //  }

            //3.Exemple de suppression ( Delete)
            using (var context = new GestionEmployerEntities())
            {
                var std = context.Employer.First<Employer>();
                context.Employer.Remove(std);

                context.SaveChanges();
                Console.WriteLine("supprimer avec succes");
            }



            Console.ReadLine();
        }
    }
}
