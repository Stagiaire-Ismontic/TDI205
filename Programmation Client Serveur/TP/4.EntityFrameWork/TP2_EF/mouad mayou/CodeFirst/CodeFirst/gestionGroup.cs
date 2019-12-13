using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class gestionGroup
    {
        public static void afficheGroup(context context)
        {
            foreach (group a in context.groups)
            {
                Console.WriteLine(a.Id + " " + a.Nom + "  ");
            }
            if (context.groups.Count() == 0)
            {
                Console.WriteLine("la liste est vide");
            }
        }
        //ajouter admin
        public static void AjouterGroup(group a, context context)
        {
            if (context.groups.Find(a.Id) == null)
            {
                context.groups.Add(a);
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("this id doesnt exist");
            }
        }
        //delete admin
        public static void deleteGroup(int id, context context)
        {
            if (context.groups.Find(id) != null)
            {
                context.groups.Remove(context.groups.Find(id));
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
        //update admin
        public static void UpdateGroup(group a, context context)
        {
            if (context.groups.Find(a.Id) != null)
            {
                group aa = context.groups.Where(aaa => a.Id == aaa.Id).FirstOrDefault();
                aa.Nom = a.Nom;

                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
    }
}
