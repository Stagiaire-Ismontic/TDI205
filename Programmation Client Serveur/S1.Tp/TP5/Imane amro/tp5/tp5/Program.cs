using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                GestionStagiaire gs = new GestionStagiaire();
                stagiaire s = new stagiaire(1, "imane", "amro");
              // gs.ajouter(s);
              // gs.supprimer(1);
                gs.modifier(s);
                Console.ReadLine();
            }
        }
    }
}
