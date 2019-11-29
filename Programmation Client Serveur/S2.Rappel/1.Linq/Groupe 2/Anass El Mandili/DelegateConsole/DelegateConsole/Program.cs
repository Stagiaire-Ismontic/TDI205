using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsole
{
    //Declaration Delegate
    public delegate int Traitement(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //Utilusation de Delegate
            Traitement T = new Traitement(Somme);
            Console.WriteLine(T(10,10));
            //Expression lambda(Fonction Fléches)
            T = new Traitement((a, b) => a + b);
            Console.WriteLine(T(2,8));
            //Sending lambda Expression as parametre
            Calcul(10, 5, (a, b) => a > b);
            Console.ReadLine();

        }
        public static int Somme(int a,int b)
        {
            return a + b;
        }
        public static void Calcul(int a, int b,Func<int,int,bool> RetBack)
        {
            Console.WriteLine($"Is {a} bigger than {b} :"+RetBack(a,b));
        }
    }
}
