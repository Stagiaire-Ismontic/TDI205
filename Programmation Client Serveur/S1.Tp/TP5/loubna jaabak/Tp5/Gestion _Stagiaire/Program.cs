using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion__Stagiaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Gestion_Stagiaire sg = new Gestion_Stagiaire();
            Stagiaire S = new Stagiaire();
            /*   S.Id =6;
               S.Nom = "popo";
               S.Prenom = "hoho";
               S.Note = 15;
               S.Id_group = "TDI_101";
               S.Ville = "laarache";
               sg.Add(S);*/
            /*   S.Id = 7;
               S.Nom = "dodo";
               S.Prenom = "ddi";
               S.Note = 18;
               S.Id_group = "TDI_205";
               S.Ville = "Tetouan";
               sg.Add(S);*/
               sg.Afficher();
            // sg.Delete(7);
           /* S.Id =5;
            S.Nom = "ALI";
            S.Prenom = "JAABAK";
            S.Note = 19;
            S.Id_group = "TDI_205";
            S.Ville = "TANGER";
            sg.Modifier(S);*/
            Console.ReadLine();
        }
    }
}
