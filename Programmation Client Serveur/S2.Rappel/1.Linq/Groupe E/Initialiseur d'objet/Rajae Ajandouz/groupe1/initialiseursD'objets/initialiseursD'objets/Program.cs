using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initialiseursD_objets
{
    class Program
    {
        static void Main(string[] args)
        {
            objet o = new objet { Age = 20, Name = "rajae" };
            Console.WriteLine(o);
        }
    }
}
