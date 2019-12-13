using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deboguer
{
    class Program
    {
        public static void Main(string[] args)
        {
            int y = 0;
            int z = 0;
            int x = 0;

            x = 3;
            y = x - 4;
            z = x + y;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
