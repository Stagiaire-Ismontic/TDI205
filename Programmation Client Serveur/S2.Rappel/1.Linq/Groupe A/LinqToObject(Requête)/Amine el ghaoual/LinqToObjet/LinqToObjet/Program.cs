using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Ls = new List<string>()
            {"Amine","Anass","Ahmed" };

            var Res = from stagiare in Ls
                      where Ls.Contains("Amine")
                      select Ls;
        }
    }
}
