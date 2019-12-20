using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Client()
        {

        }

        public Client(int Id,string Nom)
        {
            this.Id = Id;
            this.Nom = Nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
