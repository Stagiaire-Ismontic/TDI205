using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegrate

{   
    //Declaration Delegate
    public delegate int deleg(int a, int b);
    
    class Program
    {
        //Utilusation de Delegate
        public static int Sommme(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            deleg calcule = new deleg(Sommme);
            Console.WriteLine(calcule(x,y));
            Console.ReadKey();
            //Expression lambda(Fonction Fléches)
            calcule  = new deleg((a, b) => a + b);
            Console.WriteLine(calcule);
            //Sending lambda Expression as parametre
            Calcule(1,2,(a,b) => a + b);
            Console.ReadLine();

        }
        public static void Calcule(int a, int b,Func<int,int,int> A)
        {
            Console.WriteLine($"Is {a} Equal {b} :"+A(a,b));
        }


    }
}
