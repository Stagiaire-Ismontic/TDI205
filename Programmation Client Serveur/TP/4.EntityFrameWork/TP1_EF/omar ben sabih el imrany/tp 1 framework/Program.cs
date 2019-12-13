using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GestionBanqueEntities Gs = new GestionBanqueEntities())
            {


                ////Insert into Table Compte
                //using (var context = new GestionBanqueEntities())
                //{
                //    Compte cm = new Compte() { id = 1, solde = 3000 };
                //    context.Comptes.Add(cm);
                //    context.SaveChanges();
                //}


                ////Delete from table Compte
                //using (var context = new GestionBanqueEntities())
                //{
                //    var cm = context.Comptes.SingleOrDefault(s => s.id == 1);
                //    context.Comptes.Remove(cm);
                //    context.SaveChanges();
                //}


                ////Update into table Compte
                //using (var context = new GestionBanqueEntities())
                //{
                //    var Cm = context.Comptes.SingleOrDefault(s => s.id == 1);
                //    Cm.solde = 2000;
                //    context.SaveChanges();
                //}


                //Select from Table Compte
                List<Compte> lst = Gs.Comptes.ToList();
                foreach (var i in lst)
                {
                    Console.WriteLine(i.solde + "   " + i.id);
                }


                Console.ReadKey();
            }
        }
    }
}
