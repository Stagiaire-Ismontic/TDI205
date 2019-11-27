using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionStg
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionStagaires gs = new GestionStagaires();
            Stagiaire s = new Stagiaire(55, "lbna", "aa");
            //gs.ajouter(s);
            s.Nom = "loubna";
            s.Prenom = "anouja";
            gs.modifier(s);
            //gs.supprimer(55);
            Console.ReadLine();
        }
    }
}
