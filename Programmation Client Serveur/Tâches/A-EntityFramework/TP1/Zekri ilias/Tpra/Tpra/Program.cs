using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpra
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GestionFactureEntities Gs = new GestionFactureEntities())
            {


                ////Insert into Table Student
                //using (var context = new GestionFactureEntities())
                //{
                //    facture st = new facture() { IdFac = 1, Nom = "koko" };
                //    context.factures.Add(st);
                //    context.SaveChanges();
                //}


                //Delete from table Student
                //using (var context = new GestionFactureEntities())
                //{
                //    var st = context.factures.SingleOrDefault(s => s.IdFac == 1);
                //    context.factures.Remove(st);
                //    context.SaveChanges();
                //}


                ////Update into table Student
                //using (var context = new GestionFactureEntities())
                //{
                //    var st = context.factures.SingleOrDefault(s => s.IdFac == 1);
                //    st.IdFac = 2;
                //    st.Nom = "ok";
                //    context.SaveChanges();
                //}

                ////Select from Table Student
                //List<facture> lst = Gs.factures.ToList();
                //foreach (var I in lst)
                //{
                //    Console.WriteLine(I.Nom+"   "+I.IdFac);
                //}


                Console.ReadKey();
            }
        }
    }
}
