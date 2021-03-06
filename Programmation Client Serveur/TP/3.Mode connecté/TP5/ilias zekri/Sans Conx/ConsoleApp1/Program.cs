﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionFac gestion = new GestionFac();
            GestionCli gest = new GestionCli();

           // Ajouter
            gest.Ajouter(new Client(2, "ilias"));
            gestion.Ajouter(new Facture(2, "Titre1", 4000, new Client(2, "ilias")));


            //Supprimer
            gestion.Supprimer(new Facture() { Id = 2 });



           // Modifier
            gestion.Modifier(new Facture(1, "Titre2", 5000, new Client(1, "Zekri")));


           // Afficher
            List<Facture> lst = new List<Facture>();
            lst = gestion.Afficher();
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }


            Console.ReadLine();
        }
    }
}
