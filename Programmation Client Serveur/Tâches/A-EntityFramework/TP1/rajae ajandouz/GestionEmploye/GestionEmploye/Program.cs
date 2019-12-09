using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            // ajouter 
            using (var context = new GestionEmployeEntities())
            {
                var item = new Employe
                {
                    IdE = 2,
                    Nom = "rajae",
                    Prenom = "ajan",
                    tel = 54545878,
                    adresse = "fhuklgjgmgfyughj",
                    IDS = 1
                };
                context.Employes.Add(item);
                context.SaveChanges();

            }


            // dalete 
            using (var context = new GestionEmployeEntities())
            {
                var empl = context.Employes.SingleOrDefault(Leg => Leg.IdE == 1);
                context.Employes.Remove(empl);
                Console.WriteLine($"vous aver sup avec succes employe: {empl.IdE} {empl.Nom} {empl.Prenom} {empl.tel} {empl.adresse} {empl.IDS}");
                context.SaveChanges();
            }

            // modifiier 
            using (var context = new GestionEmployeEntities())
            {
                var empl = context.Employes.SingleOrDefault(Leg => Leg.IdE == 2);
                empl.Nom = "loli";
                context.SaveChanges();
            }

            // afichier
            using (GestionEmployeEntities GE = new GestionEmployeEntities())
            {
                List<Employe> listEmploye = GE.Employes.ToList();
                foreach(var item in listEmploye)
                {
                    Console.WriteLine(item.ToString() );
                }
                

        
            }
           
            Console.ReadKey();

        }
        
    }
}
