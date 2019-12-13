using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tp2_EF.Program;

namespace tp2_EF
{
  public  class Employer
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }
        public Nullable<int> IdEntreprise { get; set; }

        public virtual Entreprise Entreprise { get; set; }
       //public void Ajouter()
       // {
     
       //    using (var context = new GestionEmployerEntities())
       //     {
       // var    e= new Employer()
       //           {
       //            Nom = "youssrea",
       //              prenom = "hhhhhh",
       //               IdEntreprise = 1

       //        };
       //        context.Employer.Add(e);

       //          context.SaveChanges();
       //          Console.WriteLine("ajouter avec succes");
       //        }
       // }


       // public void Modifier()
       // {
       //     using (var context = new GestionEmployerEntities())
       //    {
       //       var  e = context.Employer.First<Employer>();
       //           e.Nom = "amouryyyyyy";

       //           context.SaveChanges();
       //              Console.WriteLine("modifier avec succes");

       //       }
       // }

       // public void Supprimer()
       // {
       //     using (var context = new GestionEmployerEntities())
       //     {
       //         var e = context.Employer.First<Employer>();
       //         context.Employer.Remove(e);

       //         context.SaveChanges();
       //         Console.WriteLine("supprimer avec succes");
       //     }
       // }
    }
}
