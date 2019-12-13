using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdminsEntities context = new AdminsEntities())
            {
                afficheAdmin(context);              
                UpdateAdmin(new admin() { Id = 101, nom = "Amine", prenom = "Am",age="18", password = "123456" }, context);
                afficheAdmin(context);
                Console.ReadLine();

            }
        }
        public static void afficheAdmin(AdminsEntities context)
        {
            foreach (admin a in context.admins)
            {
                Console.WriteLine(a.Id + " " + a.nom + "  " + a.prenom + " " + a.password);
            }
        }

        public static void AjouterAdmin(admin a, AdminsEntities context)
        {
            if (context.admins.Find(a.Id) == null)
            {
                context.admins.Add(a);
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("id don't existe");
            }
        }

        public static void deleteAdmin(int id, AdminsEntities context)
        {
            if (context.admins.Find(id) != null)
            {
                context.admins.Remove(context.admins.Find(id));
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }

        public static void UpdateAdmin(admin a, AdminsEntities context)
        {
            if (context.admins.Find(a.Id) != null)
            {
                admin ad = context.admins.Where(aaa => a.Id == aaa.Id).FirstOrDefault();
                ad.nom = a.nom;
                ad.prenom = a.prenom;
                ad.password = a.password;
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
