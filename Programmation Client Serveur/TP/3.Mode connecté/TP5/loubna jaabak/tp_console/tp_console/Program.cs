using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_console
{
    class Program
    {
        static void Main(string[] args)
        {

            // TD - CRUD avec MyConnexion
            Gestion_Editeurs gestion = new Gestion_Editeurs();
            //Ajouter
            Editeur E = new Editeur();
            E.Id = 6;
            E.Nom = "kkk";
            E.Categorie = "drama";
            gestion.Ajouter(E);
            //E.Id = 2;
            //gestion.Ajouter(E);

            //// Supprimer
            //gestion.Supprimer(5);

            // Modifier
            E.Id = 3;
            E.Nom = "ppppp";
            gestion.Modifier(E);
            //// Afficher
            foreach (Editeur item in gestion.Afficher())
            {
                Console.WriteLine(
                    string.
                    Format(
                        "Editeur {0},{1},{2}",
                    item.Id, item.Nom,item.Categorie));
            }
            Console.Read();

        }
    }
}
