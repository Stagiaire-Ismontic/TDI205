using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
       

        delegate string mydelegate(string text);

        static void Main(string[] args)
        {

            mydelegate tc = new mydelegate(Texcase);
            string rs = tc("hFFFkkLLLyy");


        }
        public static string Texcase(string text)
        {
            if (text == text.ToUpper())
            {
                return "text est  majuscule";
            }
            else if (text == text.ToLower())
            {
                return "text est minuscale ";
            }
            else
                return "text est mix";

        }
    }
}
