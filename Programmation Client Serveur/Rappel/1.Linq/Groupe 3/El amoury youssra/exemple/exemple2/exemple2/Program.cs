using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stagiaire> ls = new List<Stagiaire>() { new Stagiaire("madani", "el amoury") ,new Stagiaire("madani","ali")};
            //la requete de declaration
            var query = from s in ls where s.Nom == "madani" select s;
            var q = query.ToList();
            Console.WriteLine("les stagiaire dont le nom est = 'madani ' sont: ");
            //la requete d'execution 
            Console.WriteLine(q);
            //foreach (Stagiaire s in ls)
            //    {
            //    Console.WriteLine(s.ToString());
            //    }
              Console.ReadLine();
        }
    }
}
