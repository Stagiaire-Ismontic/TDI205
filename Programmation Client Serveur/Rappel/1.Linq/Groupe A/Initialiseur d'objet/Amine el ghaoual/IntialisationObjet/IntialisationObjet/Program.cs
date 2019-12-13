using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntialisationObjet
{
    class Program
    {
        public class Stagiare
        {
            //initialisation d'objet
            int id;
            string nom;
            public int Id { get => id; set => id = value; }
            public string Nom { get => nom; set => nom = value; }

            public Stagiare()
            {

            }
            public Stagiare(int id)
            {
                this.id = id;
            }
        }
        static void Main(string[] args)
        {
            Stagiare St = new Stagiare(1)
            { Nom = "Amine" };
            Console.WriteLine(St.Id+St.Nom);
            //infereces de var x
            var x = "inconnu";
            Console.WriteLine(x);
            //objet anonyme
            var S = new { id = 1, Nom = "Amine" };
            Console.WriteLine(S.id+S.Nom);
            Console.ReadKey();
        }
       
    }
}
