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
            //initilisateur d'objet
            Stagiaire s = new Stagiaire(1) { Nom = "youssra" };
            Console.WriteLine(s.Nom);
            //le type var
            var x = "hhh";
            Console.WriteLine(x.GetType());
            //le type anonyme
            var a = new { nom = "jjj", prenom = "hhhh" };
            Console.WriteLine(a.nom + "," + a.prenom);
            Console.ReadLine();

        }
    }
}
