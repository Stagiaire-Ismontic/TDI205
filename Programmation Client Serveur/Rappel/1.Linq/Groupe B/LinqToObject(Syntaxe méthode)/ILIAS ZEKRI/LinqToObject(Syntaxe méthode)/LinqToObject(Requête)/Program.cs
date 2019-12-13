using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject_Requête_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 3, 6, 2, 9 };
            IEnumerable<int> Qur = x.Where(num => num % 2 == 0);
            Qur.ToList().ForEach(n=>Console.WriteLine(n));
            Console.ReadKey();
        }
    }
}
