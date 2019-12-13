
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionEmployer ge = new GestionEmployer();

            ge.ajouter(new Employer(482, "madani", "ali"));
            ge.modifier(new Employer(482, "salim", "salam"));
            ge.suprimer(482);

            foreach (Employer a in ge.affiche())
            {
                Console.WriteLine(a.Id + " " + a.Nom + " " + a.Prenom);
            }

            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}