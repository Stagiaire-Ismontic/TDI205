using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidKalini
{
    internal class Voiture
    {
        public int id { get; set; }
        public string Marque { get; set; }
        //type auto gere
        public string Type { get; internal set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //declaration type anonyme
            var personne = new { nom = "Zaid", prenom = "kalini" };
            
            Voiture v = new Voiture { id = 1, Marque = "renault", Type = "Decapotable" };

            Console.WriteLine(personne);
            Console.WriteLine(v.id+" "+v.Marque+" "+v.Type );
            //Linq 
            Console.WriteLine("Linq to Objet");
            List<Voiture> Voitures = new List<Voiture>(){ new Voiture { id = 1, Marque = "renault", Type = "Decapotable" },
            new Voiture { id = 2, Marque = "mercedez", Type = "Decapotable" },new Voiture { id = 3, Marque = "Audi", Type = null} };
            var myLinq = Voitures.Where(vo => vo.Type == "Decapotable");
            foreach(Voiture item in myLinq)
            {
                Console.WriteLine(item.id + " " + item.Marque + " " +item.Type);
            }
            // linq requete
            var s =(from Voiture ite in Voitures where ite.Type == null select ite).ToList();
            foreach (Voiture item in s)
            {
                Console.WriteLine(item.id + " " + item.Marque + " " + item.Type);
            }
            Console.ReadKey();
        }
    }
}
