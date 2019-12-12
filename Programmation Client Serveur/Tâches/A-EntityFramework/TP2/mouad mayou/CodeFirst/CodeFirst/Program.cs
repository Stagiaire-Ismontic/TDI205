using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            context c = new context();
            gestionGroup.AjouterGroup(new group(2, "jjergerj"), c);
            gestionGroup.afficheGroup(c);
            gestionGroup.deleteGroup(1, c);
            gestionGroup.afficheGroup(c);
            gestionGroup.UpdateGroup(new group(2, "gggg"), c);
            gestionGroup.afficheGroup(c);
            Console.ReadKey();
        }
    }
}
