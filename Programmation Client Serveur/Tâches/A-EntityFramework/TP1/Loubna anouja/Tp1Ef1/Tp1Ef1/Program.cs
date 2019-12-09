using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Ef1
{
    class Program
    {
        static void Main(string[] args)
        {//show
            using (loubnaEntities db = new loubnaEntities())
            {
                List<commande> listCom = db.commandes.ToList();
                foreach(var items in listCom)
                {
                    Console.WriteLine(items.Nom);
                }
            }
            //create
            using (var context = new loubnaEntities())
            {
                var cmd = new commande()
                {
                    Id = 1,
                    Code = "excelo",
                    Nom = "biggy"
                };
                context.commandes.Add(cmd);
                context.SaveChanges();
            }
            //update
            using (var context = new loubnaEntities())
            {
                var cmd = context.commandes.First<commande>();
                cmd.Id = 1;
                context.SaveChanges();
            }
            //delete
            using (var context = new loubnaEntities())
            {
                var cmd = context.commandes.First<commande>();
                context.commandes.Remove(cmd);

                context.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
