using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppel_c
{
    class Program
    {
        static void Main(string[] args)
        {
            etudiant e = new etudiant(1) { Name = "loubna" };
            Console.WriteLine(e.Id + e.Name);
            //inference de type var
            var x = "louulou";
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
