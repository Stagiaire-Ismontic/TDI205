using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class livre
    {
        public int iD { get; set; }
        public string titre { get; set; }
        public string categorie { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            List<livre> list = new List<livre>();
            {
                new livre() { iD = 1, titre = "livre1", categorie = "c1" };
                new livre() { iD = 2, titre = "livre2", categorie = "c2" };
                new livre() { iD = 3, titre = "livre3", categorie = "c3" };
            };
            var myLinQ = from l in list where l.iD > 2 select new { iD = l.iD, titre = l.titre, };
            foreach(var l in myLinQ)
            {
                Console.WriteLine(l);
            }
            Console.ReadLine();
        }
    }
}
