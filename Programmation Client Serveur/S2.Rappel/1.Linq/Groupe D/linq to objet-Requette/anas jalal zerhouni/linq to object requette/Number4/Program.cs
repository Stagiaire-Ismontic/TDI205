using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var NumQuery = from num in number where (num % 2) == 0 select num;
            foreach (int n in NumQuery)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
