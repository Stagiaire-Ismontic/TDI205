using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_object
{
    class Program
    {
        static void Main(string[] args)
        {




            List<Employe> employes = new List<Employe>()
            {
                new Employe(){Id=1, Nom="loubna",Prenom="nn",Age=24},
                new Employe(){Id=2, Nom="halima",Prenom="hre",Age=45},
                new Employe(){Id=3, Nom="hatim",Prenom="gdj",Age=19},
                new Employe(){Id=4, Nom="mostapha",Prenom="gj",Age=35},
                new Employe(){Id=5, Nom="rajae",Prenom="gagudn",Age=20},
                new Employe(){Id=6, Nom="amine",Prenom="dhidnn",Age=25},
            };

            
            var myLinqQuery = from emp in employes
                              where emp.Age>20
                              select emp.Nom;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");

            Console.ReadKey();
        }
    }
}
      
