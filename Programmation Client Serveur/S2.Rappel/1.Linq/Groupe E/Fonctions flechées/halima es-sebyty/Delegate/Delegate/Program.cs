using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleg
{
    class Program
    {

        //fonction retourne une chaine de caractaire

        delegate string MyDelegate(string ch);

        public static string Myfunction(string text)
        {
            if (text == text.ToLower())
                return "le text en miniscule";
            else if (text == text.ToUpper())
                return "le text en majuscule";

            return "le text mixed";
        }
        //fonction de calcule

        delegate int somme(int a,int b);
        delegate int produit(int a, int b);
        delegate int saustra(int a, int b);

        static void Main(string[] args)
        {
            
            MyDelegate del = new MyDelegate(Program.Myfunction);
            
            Console.WriteLine(del("hello world"));
            Console.WriteLine(del("HELLO WORLD"));
            Console.WriteLine(del("HeLLo WorLd"));



            somme s = new somme((a,b)=>a+b);
            Console.WriteLine("la somme de a et b est :  "+s(3,3));

            produit p = new produit((a, b) => a * b);
            Console.WriteLine("le produit de a et b est :  "+p(3, 3));

            saustra saus = new saustra((a, b) => a - b);
            Console.WriteLine("la saustraction de a et b est :  "+saus(3, 3));


            Console.ReadKey();
        }
    }
}
