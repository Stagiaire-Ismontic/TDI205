using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionStagaires gs = new GestionStagaires();

            gs.ajouter(new Stagiaire(482,"patista","jalala"));
            gs.modifier(new Stagiaire(482,"hmed","hmed"));
            gs.suprimer(482);

            foreach (Stagiaire s in gs.affiche()) {
                Console.WriteLine(s.Id+" "+s.Nom+" "+s.Prenom);
            }
            
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
