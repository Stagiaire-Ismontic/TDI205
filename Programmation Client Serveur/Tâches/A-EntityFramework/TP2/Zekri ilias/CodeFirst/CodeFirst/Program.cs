using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Gestion())
            {
                ////Ajouter
                //context.lst.Add(new Controle(1,"ilias",15));
                //context.SaveChanges();

                ////Modifier
                //Controle C=context.lst.SingleOrDefault(s => s.Id == 1);
                //C.Nom = "Zekri";
                //C.Note = 18;
                //context.SaveChanges();

                //////Supprimer
                //Controle C = context.lst.SingleOrDefault(s => s.Id == 1);
                //context.lst.Remove(C);
                //context.SaveChanges();

                ////Afficher
                //foreach (var item in context.lst)
                //{
                //    Console.WriteLine(item.Id+"  "+item.Nom+"  "+item.Note);
                //}
            }
            Console.ReadKey();
        }
    }
}
