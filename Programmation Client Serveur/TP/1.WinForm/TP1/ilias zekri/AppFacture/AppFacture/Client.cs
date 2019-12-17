using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacture
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nom { get; set; }

        public Client()
        {

        }

        public Client(string Nom)
        {
            this.Nom = Nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
