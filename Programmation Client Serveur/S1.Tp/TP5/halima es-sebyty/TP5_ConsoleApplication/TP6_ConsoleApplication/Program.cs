using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre l = new Livre(1,"livre1","rrr","rrrr");

            new Gestion_des_livres().Ajouter(l);

            new Gestion_des_livres().Supprimer(1);

            Livre lm = new Livre(2, "ddddd", "dddd", "ddd");

            new Gestion_des_livres().Modifier(lm);

            int trouve = new Gestion_des_livres().Recherche(3);
            if (trouve != -1)
            {
                Console.WriteLine("le livre existe dans la bibliotheque");
            }
            else
            {
                Console.WriteLine("le livre n'existe pas !!!!");
            }

           
            new Gestion_des_livres().Affichier();


            Console.ReadKey();

        }
    }
}
