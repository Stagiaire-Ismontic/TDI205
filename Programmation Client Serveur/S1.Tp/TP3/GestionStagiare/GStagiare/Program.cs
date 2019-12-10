using GestionStagiare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GStagiare
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionStagiare.GestionStagiare gestion = new GestionStagiare.GestionStagiare();
            
            Stagiare st = new Stagiare();
            //Console.WriteLine("Donner id,nom, cin de stagiare ");
            //st.id = int.Parse(Console.ReadLine());
            //st.Nom = Console.ReadLine();
            //st.Prenom = Console.ReadLine();
            //st.CIN = Console.ReadLine();
            //gestion.Ajouter(st);
            ////Modifier
            //Console.WriteLine("Donner  id, nom, prenom, cin de stagiare Que vous voulez modifier ");
            //st.id = int.Parse(Console.ReadLine());
            //st.Nom = Console.ReadLine();
            //st.Prenom = Console.ReadLine();
            //st.CIN = Console.ReadLine();
            //gestion.Modifier(st);


            Console.Write(gestion.Afficher()[0].ToString());
            Console.ReadKey(true);
            
        }
    }
}
