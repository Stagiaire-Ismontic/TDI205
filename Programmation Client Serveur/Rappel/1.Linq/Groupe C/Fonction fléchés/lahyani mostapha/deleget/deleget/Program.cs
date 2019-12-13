using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleget
{
    class Program
    {
       
        delegate int NumberChanger(int n);
        delegate int somme(int a,int b);
        static void Main(string[] args)
        {
            //delegete
            NumberChanger nc1 = new NumberChanger(Program.AddNum);
            Console.WriteLine(nc1(25));
            //expression lambda
            somme s = new somme ((a,b)=>a+b);
            Console.WriteLine(s(12, 3));
            //expression lambda comme paramétre de méthode
            Add(14, 6, (a, b) => a + b);
            Console.ReadKey();

        }
        //delegete
        static int n = 10;

        public static int AddNum(int p)
        {
            n += p;
            return n;
        }
        //expression lambda comme paramétre de méthode
        public static void Add(int a,int b,Func<int,int,int>A)
        {
            Console.WriteLine(A(a,b));
        }
    }
}
