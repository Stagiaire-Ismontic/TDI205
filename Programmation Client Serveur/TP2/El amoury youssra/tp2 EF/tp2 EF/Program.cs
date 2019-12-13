using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Threading.Tasks;

namespace tp2_EF
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Exemple d'insertion de votre objet dans la base de données ( Create )

          using (var context = new AppContext())
           {
              var emp = new Employer()
                {
                      Nom = "youssrea",
                     prenom = "hhhhhh",
                      IdEntreprise = 1

               };
               context.Employer.Add(emp);

               context.SaveChanges();
                 Console.WriteLine("ajouter avec succes");
              }
             //2.Exemple de mise à jour(Update)
         // using (var context = new AppContext())
          // {
            //  var emp = context.Employer.First<Employer>();
              //  emp.Nom = "amouryyyyyy";

              //context.SaveChanges();
               //Console.WriteLine("modifier avec succes");

            //}

           // using (var context = new AppContext())
           // {
               // var e = context.Employer.First<Employer>();
               // context.Employer.Remove(e);

              //  context.SaveChanges();
               // Console.WriteLine("supprimer avec succes");
           // }

            Console.ReadLine();

        }


    
    }

}
