using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var mylinqQ = from l in list where l > 2 select l;

            foreach (var q in mylinqQ)
                Console.WriteLine(q + Environment.NewLine);

            Console.ReadKey();
        }
    }
}
