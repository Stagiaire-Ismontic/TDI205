using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonctionFleche
{
    class Program
    {
        public delegate int sum(int a, int b);
        static void Main(string[] args)
        {
            //delegate
            sum s = new sum(somme);
            Console.WriteLine(s(18, 11));
            //fonction fleche
            s1 = new sum((a + b)=>a + b);
            Console.WriteLine(s1(11, 15));
            somme(19, 1, (a + b)=>a + b);
            Console.ReadLine();
        }
        public static int somme(int a,int b)
        {
            return a + b;
        }
        //fontion fleche farnc
        public static void sum(int a,int b ,func<int,int,int>A)
        {
            Console.WriteLine(A(a, b));
        }
       
    }
}
