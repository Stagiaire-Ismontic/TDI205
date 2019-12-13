using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionStagaires g = new GestionStagaires();

            g.ajouter(new Stagiaire(2, "azerty", "qwerty"));
            g.modifier(new Stagiaire(1, "moha", "hamadi"));
            g.suprimer(1);

            foreach (Stagiaire s in g.affiche())
            {
                Console.WriteLine(s.Id + " " + s.Nom + " " + s.Prenom);
            }

            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
    }


