using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_groupe4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> er = new List<int> { 9, 92, 17, 54 };
            var q = from score in er where score > 50 select score;
            foreach (int i in q)
            {
                Console.WriteLine(i + Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
