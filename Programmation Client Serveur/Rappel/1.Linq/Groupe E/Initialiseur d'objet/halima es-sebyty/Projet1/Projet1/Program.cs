using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
 
    
    class Program
    {
      
        static void Main(string[] args)
        {
            //initialisation d'object

            Objact ob = new Objact { Id = 1, Nom="halima"};
            Console.WriteLine(ob);

            //Type anonyme 

            var Livre = new { id = 1, titre = "livre1", nom_auteur = "ana" };
          
            Console.WriteLine(Livre.id+"  "+Livre.titre+"  "+Livre.nom_auteur);

            //Inference De Type

            var id = 3;
            var nom = "halima";
            Console.WriteLine(id+"   "+nom);


            Console.ReadKey();

        }
    }
}
