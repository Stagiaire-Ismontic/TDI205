using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqmethode
{
    class Program
    {
        public class stagiare
        {
            int id;
            string nom;
            int Age;

            public int Id { get => id; set => id = value; }
            public string Nom { get => nom; set => nom = value; }
            public int Age1 { get => Age; set => Age = value; }
        }
        static void Main(string[] args)
        {
            List<stagiare> ST = new List<stagiare>()
            {
            new stagiare(){ Id=1 , Nom="amine" , Age1=20},
            new stagiare() { Id = 1, Nom = "karim", Age1 = 20 },
            new stagiare() { Id = 2, Nom = "Anass", Age1 = 30 },
            };
            var stag = from S in ST where S.Age1 > 12 && S.Age1 < 30 select new { nom = S.Nom };
            stag.ToList().ForEach(s => Console.WriteLine(s.nom));
            Console.ReadKey();
        }
    }
}
