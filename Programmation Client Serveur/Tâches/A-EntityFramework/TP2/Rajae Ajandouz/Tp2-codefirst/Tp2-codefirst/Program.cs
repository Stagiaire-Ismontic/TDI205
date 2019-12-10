using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Modelcodefirst Em = new Modelcodefirst())
            {
                AjouterEmploye(new Employe() { id=100, Nom="br", Prenom="chaayba",Adress="azerty"  },Em);
                afficheEmploye(Em);
                deleteEmploye(100, Em);

            }
            Console.Read();
        }

        //affiche tout les admins
        public static void afficheEmploye(Modelcodefirst context )
        {
            foreach (Employe E in context.Employe)
            {
                Console.WriteLine( E.id+ " " + E.Nom + "  " + E.Prenom + " " + E.Adress);
            }
            if (context.Employe.Count() == 0)
            {
                Console.WriteLine("la liste est vide");
            }
        }
        //ajouter admin
        public static void AjouterEmploye(Employe E, Modelcodefirst context)
        {
            if (context.Employe.Find(E.id) == null)
            {
                context.Employe.Add(E);
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("this id doesnt exist");
            }
        }
        //delete admin
        public static void deleteEmploye(int id, Modelcodefirst context)
        {
            if (context.Employe.Find(id) != null)
            {
                context.Employe.Remove(context.Employe.Find(id));
                Console.WriteLine("Done");
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id doesnt exist");
            }
        }
        //update admin
        public static void UpdatEmploye(Employe E,Modelcodefirst context)
        {
            if (context.Employe.Find(E.id) != null)
            {
                Employe Ee = context.Employe.Where(aaa => E.id ==aaa.id).FirstOrDefault();
                Ee.Nom = E.Nom;
                Ee.Prenom = E.Prenom;
                Ee.Adress= E.Adress;
               
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
