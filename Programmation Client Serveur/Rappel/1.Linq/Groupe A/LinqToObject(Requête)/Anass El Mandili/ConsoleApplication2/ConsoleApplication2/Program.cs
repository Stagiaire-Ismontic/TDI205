using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListeString = new List<string>() { "ali", "salim", "ahmed", "karim" };
            var result = from S in ListeString where S.Contains("salim") select S;
            foreach (var affich in result)
            {
                Console.WriteLine(affich);
            }
            Console.ReadKey();
        }
    }
}
