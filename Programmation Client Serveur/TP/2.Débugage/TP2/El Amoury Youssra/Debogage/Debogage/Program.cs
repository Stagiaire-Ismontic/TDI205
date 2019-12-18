using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debogage
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer e1 = new Employer(1, "madani", "ali");
            Employer e2 = new Employer(2, "youssra", "amoury");
            Employer e3 = new Employer(3, "loubna", "anouja");
            Employer e4 = new Employer(4, "imane", "amro");
            Console.WriteLine("le prenom de employer 2 est:");
            Console.WriteLine(e1.Prenom);
            Console.WriteLine(e2.ToString());

            Console.ReadLine();

        }
    }
}
