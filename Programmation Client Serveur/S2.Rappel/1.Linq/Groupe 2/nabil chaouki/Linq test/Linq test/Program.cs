using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_test
{
    class Program
    {
        public delegate int Toto(int a, int b);
        public static int somme(int a ,int b)
        {
            return a + b;

        }
        public static int div(int a, int b)
        {
            return a / b;

        }
        static void Main(string[] args)
        {
            Toto titi = new Toto(somme);
           
            Console.WriteLine("oh my good");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(titi(a, b)  );

            titi += new Toto((x, y) => x / y);
            Console.WriteLine(titi(a, b));
            Console.ReadKey();
        }
    }
}
