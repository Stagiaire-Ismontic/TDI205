using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst
{
    
    class Program
    {
        static void Main(string[] args)
        {
            using (adminsContext a = new adminsContext())
            {
                //AjouterAdmins(new Admins() { Id=100, Nom="br", Prenom="chaayba", Passwsord="123456" },a);
                afficheAdmins(a);
                deleteAdmin(100, a);
                
            }
            Console.Read();
        }

        //affiche tout les admins
        public static void afficheAdmins(adminsContext context)
        {
            foreach (Admins a in context.Admins)
            {
                Console.WriteLine(a.Id + " " + a.Nom + "  " + a.Prenom + " " + a.Passwsord);
            }
            if (context.Admins.Count() == 0)
            {
                Console.WriteLine("la liste est vide");
            }
        }
        //ajouter admin
        public static void AjouterAdmins(Admins a, adminsContext context)
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
        //delete admin
        public static void deleteAdmin(int id, adminsContext context)
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
        //update admin
        public static void UpdateAdmins(Admins a, adminsContext context)
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
