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
            Console.ReadKey();
        }
    }
}
