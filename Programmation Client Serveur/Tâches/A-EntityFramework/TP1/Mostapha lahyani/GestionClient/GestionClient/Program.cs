using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GestionClientEntities Gs = new GestionClientEntities())
            {


                ////Insert into Table Student
                //using (var context = new GestionClientEntities())
                //{
                //    Client Cl = new Client() { IdClient = 1, Cin = "koko", Nom="Inco" , Prenom="nnu" };
                //    context.Clients.Add(Cl);
                //    context.SaveChanges();
                //}


                ////Delete from table Student
                //using (var context = new GestionClientEntities())
                //{
                //    var Cl = context.Clients.SingleOrDefault(s => s.IdClient == 1);
                //    context.Clients.Remove(Cl);
                //    context.SaveChanges();
                //}


                ////Update into table Student
                //using (var context = new GestionClientEntities())
                //{
                //    var Cl = context.Clients.SingleOrDefault(s => s.IdClient == 1);
                //    Cl.IdClient = 2;
                //    Cl.Nom = "ok";
                //    context.SaveChanges();
                //}

                ////Select from Table Student
                //List<Client> lst = Gs.Clients.ToList();
                //foreach (var I in lst)
                //{
                //    Console.WriteLine(I.Cin + "   " + I.IdClient);
                //}


                Console.ReadKey();
            }
        }
    }
}
