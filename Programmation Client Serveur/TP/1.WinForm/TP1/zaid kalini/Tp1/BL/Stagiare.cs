using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    [Serializable]
    public class Stagiare
    {
        public int NumStagiare { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string sexe { get; set; }
        public string situation { get; set; }
        public Stagiare()
        {

        }

        public Stagiare (int NumStagiare, string Nom, string Prenom, int Age, string sexe, string situation)
        {
            this.NumStagiare = NumStagiare;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Age = Age;
            this.sexe = sexe;
            this.situation = situation;
        }

    }
}
