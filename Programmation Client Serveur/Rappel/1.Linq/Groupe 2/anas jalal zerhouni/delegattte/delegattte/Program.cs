using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegattte
{
    class Program
    {
        public delegate int calculator(int x, int y);
        public delegate int d1(int x, int y);

        static void Main(string[] args)
        {
            //delegate
            calculator c = new calculator(somme);
            //lambda expression
            d1 d = new d1(((a, b) => a - b));
            //lambda expression as a parameter
            List<string> items = new List<string> { "Adam", "By", "Cecil" };
            //console.writeline();
            Console.WriteLine(c(5, 2));
            Console.WriteLine(d(10, 13));
            printString(items, x => x.Length >= 3);
            Console.ReadLine();
        }
        static int somme(int x, int y)
        {
            return x + y;
        }
        static void printString(List<string> list, Func<string, bool> lmbd)
        {
            var selecetedItems = list.Where(lmbd);
            foreach (var x in selecetedItems)
            {
                Console.WriteLine(x);
            }
        }
    }
}
