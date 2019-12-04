using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace EF4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdminsEntities context = new AdminsEntities())
            {
                afficheAdmins(context);
                Console.WriteLine("----------------------------------");
                //AjouterAdmins(new Admins() { Id = 101, Nom = "essaa", Prenom = "small", Passwsord = "4959875416" }, context);
                //AjouterAdmins(new Admins() { Id = 102, Nom = "esa", Prenom = "gra", Passwsord = "495545416" }, context);
                //afficheAdmins(context);
                Console.WriteLine("----------------------------------");
                //deleteAdmin(102, context);
                //afficheAdmins(context);
                Console.WriteLine("---------------------------------------");
                UpdateAdmins(new Admins() { Id = 101, Nom = "brahim", Prenom = "brahim", Passwsord = "123456" },context);
                afficheAdmins(context);
                Console.ReadLine();

            }

        }
        public static void afficheAdmins(AdminsEntities context)
        {
            foreach (Admins a in context.Admins)
            {
                Console.WriteLine(a.Id + " " + a.Nom + "  " + a.Prenom + " " + a.Passwsord );
            }
        }

        public static void AjouterAdmins(Admins a, AdminsEntities context)
        {
            if (context.Admins.Find(a.Id) == null)
            {
                context.Admins.Add(a);
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("this id doesnt exist");
            }
        }

        public static void deleteAdmin(int id, AdminsEntities context)
        {
            if (context.Admins.Find(id) != null)
            {
                context.Admins.Remove(context.Admins.Find(id));
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }

        public static void UpdateAdmins(Admins a, AdminsEntities context)
        {
            if (context.Admins.Find(a.Id) != null)
            {
                Admins aa = context.Admins.Where(aaa => a.Id == aaa.Id).FirstOrDefault();
                aa.Nom = a.Nom;
                aa.Prenom = a.Prenom;
                aa.Passwsord = a.Passwsord;
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
