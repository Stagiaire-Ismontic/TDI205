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
            using (test2Entities db = new test2Entities())
            {
                List<etudiantt> listCom = db.etudiantt.ToList();
                foreach(var items in listCom)
                {
                    Console.WriteLine(items.nom);
                }
            }
            //create
            using (var context = new test2Entities())
            {
                var cmd = new etudiantt()
                {
                    id = 1,
                    nom = "excelo",
                  prenom = "biggy"
                };
                context.etudiantt.Add(cmd);
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
