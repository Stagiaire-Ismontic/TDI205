using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_En_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionStagiaires gs = new GestionStagiaires();

            gs.ajouter(new Stagiaire(482, "madani", "ali"));
            gs.modifier(new Stagiaire(482, "salim", "salam"));
            gs.suprimer(482);

            foreach (Stagiaire s in gs.affiche())
            {
                Console.WriteLine(s.Id + " " + s.Nom + " " + s.Prenom);
            }

            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
  }
