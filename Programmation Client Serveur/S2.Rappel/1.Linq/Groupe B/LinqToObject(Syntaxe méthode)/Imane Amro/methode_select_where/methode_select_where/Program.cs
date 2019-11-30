using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methode_select_where
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 5, 6, 3, 2 };
            IEnumerable<int> q = t.Where(num => num %2== 0);
            foreach(int i in t)
            {
                Console.WriteLine(i+" ");
            }
            Console.ReadKey();
        }
    }
}
