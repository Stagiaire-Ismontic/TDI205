﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConx
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionnaireStagiaires gestion = new GestionnaireStagiaires();


            ////Ajouter
            //gestion.Ajouter(new Stagiaire(1, "K530814", "ilias", "TDI205"));


            ////Supprimer 
            //gestion.Supprimer(new Stagiaire(1, "K530814", "ilias", "TDI205"));



            ////Modifier
            //gestion.Modifier(new Stagiaire(1, "K530814", "ilias Zekri", "TDI205"));


            ////Afficher
            //List<Stagiaire> lst = new List<Stagiaire>();
            //lst = gestion.Afficher();
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}


            Console.ReadLine();
        }
    }
}
