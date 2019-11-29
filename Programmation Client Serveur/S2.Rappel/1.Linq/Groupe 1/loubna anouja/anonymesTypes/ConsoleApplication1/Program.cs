using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new { firstProperty = "First", secondProperty = 2, thirdProperty = true };

            Console.WriteLine(myAnonymousType.GetType().ToString());
            Console.ReadLine();
        }
        
    }
    }

