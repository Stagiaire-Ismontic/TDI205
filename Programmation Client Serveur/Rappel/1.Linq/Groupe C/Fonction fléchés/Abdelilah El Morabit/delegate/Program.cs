using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        public delegate int calculator(int x, int y);
        public delegate int d1(int x, int y);

        static void Main(string[] args)
        {
            //delegate
            calculator c = new calculator(somme);
            Console.WriteLine(c(15, 30));
            //lambda expression
            d1 d = new d1(((a, b) => a - b));
            Console.WriteLine(d(20, 10));
            //lambda expression as a parameter
            add(20, 20, ((a, b) => a * b));
            Console.Read();
        }
        static int somme(int x, int y)
        {
            return x + y;
        }
        static void add(int a, int b, Func<int, int, int> lmbd)
        {
            Console.WriteLine(lmbd(a, b));
        }
    }
    }
}
