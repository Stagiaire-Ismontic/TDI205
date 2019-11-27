using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cruud
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* GestionStagaires gs = new GestionStagaires();
            Stagiaire s = new Stagiaire(55, "lbna", "aa");
            //gs.ajouter(s);
            s.Nom = "loulou";
            s.Prenom = "anouja";
            gs.modifier(s);
            //gs.supprimer(55);
            Console.ReadLine();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
