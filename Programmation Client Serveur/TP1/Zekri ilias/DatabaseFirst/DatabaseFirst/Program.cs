using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GestionControleEntities())
            {

                ////Ajouter
                //context.Controles.Add(new Controle() { Id = 1, Nom = "ilias", Note = 15 });
                //context.SaveChanges();

                ////Supprimer
                //Controle C = context.Controles.SingleOrDefault(s => s.Id == 1);
                //context.Controles.Remove(C);
                //context.SaveChanges();

                ////Modifier
                //Controle C = context.Controles.SingleOrDefault(s => s.Id == 1);
                //C.Nom = "Zekri";
                //C.Note = 17;
                //context.SaveChanges();

                ////Afficher
                //foreach (var item in context.Controles.ToList())
                //{
                //    Console.WriteLine(item.Id + "  " + item.Nom+"  "+item.Note);
                //}

            }
            Console.ReadKey();
        }
    }
}
