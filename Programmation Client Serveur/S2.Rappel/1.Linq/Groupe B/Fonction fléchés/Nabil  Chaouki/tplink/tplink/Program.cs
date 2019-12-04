using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tplink
{
    class Program
    {

        internal class Avion
        {
            public int id { get; set; }
            public string Marque { get; set; }
            //type auto gere
            public string Type { get; internal set; }
        }
        static void Main(string[] args)
        { // declaration type 
            var client = new { nom = "emirates", zone = "pays du golf" };
            Avion a = new Avion { id = 1, Marque = "C-130", Type = "Militaire" };
            Console.WriteLine(client);
            Console.WriteLine(a.id + "" + a.Marque + "" + a.Type);
            //linq
            Console.WriteLine("Linq to Objet");
            List<Avion> Avions = new List<Avion>(){ new Avion { id = 1, Marque = "c-130", Type = "Militaire" },
            new Avion { id = 2, Marque = "c-17", Type = "transport" },new Avion { id = 3, Marque = "F-15", Type = "chasse"} };
            var myLinq = Avions.Where(vo => vo.Type == "transpot");

            //
            foreach (Avion item in myLinq)
            {
                Console.WriteLine(item.id + " " + item.Marque + " " + item.Type);
            }

            // linq requete
            var s = (from Avion ite in Avions where ite.Type == "chasse" select ite).ToList();
            foreach (Avion item in s)
            {
                Console.WriteLine(item.id + " " + item.Marque + " " + item.Type);
            }
            Console.ReadKey();
        }
    }
}
