using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livre> list = new List<Livre>()
            {
                new Livre() {ID=1,Titre="livre1",categorie="c1"},
                 new Livre() {ID=2,Titre="livre2",categorie="c2"},
                  new Livre() {ID=3,Titre="livre3",categorie="c3" },
                   new Livre() {ID=4,Titre="livre4",categorie="c4"},
                    new Livre() {ID=5,Titre="livre5",categorie="c5"}
            };

            var mylinqQ = from l in list where l.ID>2 select l.ID+ " " +l.Titre+ " " + l.categorie;

            foreach (var t in mylinqQ)
                Console.WriteLine(t + " ");


            Console.ReadKey();

         }
 
     }
     
}

