using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] q = { 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> query1 = from num in q where(num % 2 == 0) 
                select num ;
            IEnumerable<int> query2 = q.Where(num => num % 2 == 0);
          
            foreach(int i in query1)
            {
                Console.WriteLine(i + "");

            }
            Console.WriteLine(System.Environment.NewLine);
            foreach(int i in query2)
            {
                Console.WriteLine(i + "");
            }
            Console.ReadLine();
        }
    }
}
