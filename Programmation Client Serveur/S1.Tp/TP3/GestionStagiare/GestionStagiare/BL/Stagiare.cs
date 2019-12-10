using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStagiare
{
    public class Stagiare
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }

        public Stagiare() { }
        public Stagiare(int id, string Nom, String Prenom, string CIN)
        {
            this.id = id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.CIN = CIN;
        }

        public override string ToString()
        {
            return Nom+" "+Prenom+" "+" CIN "+CIN;
        }
      
    }
}
