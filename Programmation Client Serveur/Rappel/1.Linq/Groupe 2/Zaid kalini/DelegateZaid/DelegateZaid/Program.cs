using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateZaid
{
    class Program
    {
        delegate void StringFormat(string text);
        delegate int ChangeNumber(int a, int b);
        static void TextCase(string text)
        {
            if (text == text.ToUpper())
            {
                Console.WriteLine("le texte est Majuscule");
            }
            else if (text == text.ToLower())
            {
                Console.WriteLine("le texte est Miniscule");
            }
            else
                Console.WriteLine("le texte est Mixe");
        }
        static void Main(string[] args)
        {
            StringFormat format = new StringFormat(TextCase);
            Console.WriteLine("Donner un text");
            format(Console.ReadLine());
            ChangeNumber number = new ChangeNumber((x, y) => x + y);
            Console.WriteLine("Expression lambda somme de 5+6 = " + number(5, 6));
            Console.ReadKey();
        }
    }
}
