using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonctions_fleches
{
    class Program
    {
        static void Main(string[] args)
        {
            toto t = new toto(somme);
            Console.WriteLine("entrer a et b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("la somme de a et b :" + t(a, b));
            t += new toto((x, y) => x / y);
            Console.WriteLine("la division de a et b :" + t(a, b));
            t += new toto(division);
            Console.WriteLine("la division de a et b :" + t(a, b));
            Console.ReadKey();
        }
        public delegate int toto(int a, int b);

        public static int somme(int a, int b) { return a + b; }

        public static int division(int a, int b) { return a / b; }
    }
}
}
