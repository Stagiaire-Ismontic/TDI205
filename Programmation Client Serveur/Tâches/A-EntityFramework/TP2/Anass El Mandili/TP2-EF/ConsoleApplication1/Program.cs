using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Model1())
            {
                AddEtudiant(new Etudiant() { Id = 2, Etud_Name = "Samir", Etud_Tel = "0758741258" }, context);
                UpdateEtudiant(new Etudiant() { Id = 1, Etud_Name = "Madani", Etud_Tel = "0555545458" }, context);
                DeleteEtudiant(context, 3);
                Console.WriteLine("\n");
                ShowDetail(context);
                context.SaveChanges();
            }

            Console.ReadLine();
        }
        public static void ShowDetail(Model1 SO)
        {
            foreach (Etudiant E in SO.Etudiant)
            {
                Console.WriteLine(E.Id + "  " + E.Etud_Name + "  " + E.Etud_Tel);
            }
        }
        public static void UpdateEtudiant(Etudiant E, Model1 SO)
        {
            if (SO.Etudiant.Find(E.Id) != null)
            {
                Etudiant Et = SO.Etudiant.Find(E.Id);
                Et.Id = E.Id;
                Et.Etud_Name = Et.Etud_Name;
                Et.Etud_Name = E.Etud_Name;
                SO.SaveChanges();
            }
        }
        public static void AddEtudiant(Etudiant E, Model1 context)
        {
            int test = 0;
            if (context.Etudiant.Find(((Etudiant)E).Id) == null)
            {
                context.Etudiant.Add(E as Etudiant);
                test = 1;
            }
            context.SaveChanges();
            if (test == 1)
            {
                Console.WriteLine("Etudiant is Added a Succesfuly");
            }
            else Console.WriteLine("This Etudiant Is Exist! You Can't Added it");
        }
        public static void DeleteEtudiant(Model1 SO, int Id)
        {
            if (SO.Etudiant.Find(Id) != null)
            {
                SO.Etudiant.Remove(SO.Etudiant.Find(Id));
                Console.WriteLine("This one is Deleted");
                SO.SaveChanges();
            }
            else
            {
                Console.WriteLine("This One Is Exist! You can't delete it");
            }
        }
    }

}
