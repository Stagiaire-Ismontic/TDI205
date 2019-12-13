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
            //TP 1 
            Objet Ob = new Objet() { Nom1 = "Anas" };
            Console.WriteLine(Ob.Nom1);
            var x = "Anonyme";
            Console.WriteLine(x);
            var Anonyme = new { Id = 1, Nom = "Anony" };
            Console.WriteLine(Anonyme.Id + "  " + Anonyme.Nom);
            Console.ReadKey();
        }
    }
}
