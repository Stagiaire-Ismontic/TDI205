using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] q = { 1, 3, 6, 2, 9 };
            IEnumerable<int> qry1 =from num in q where num % 2 == 0
            select num;

            foreach (int i in qry1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine(System.Environment.NewLine);
            Console.ReadLine();
        }
    }
}
