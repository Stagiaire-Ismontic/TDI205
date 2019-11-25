using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1.PL
{
    class Formateur
    {
        public int NumFormateur { get; set; }
        public string NomFormateur { get; set; }
        public string PrenomFormateur { get; set; }
        public int Age { get; set; }
        public string sexe { get; set; }
        public string situation { get; set; }
        public Formateur()
        {

        }

        public Formateur(int NumFormateur, string NomFormateur, string PrenomFormateur, int Age, string sexe, string situation)
        {
            this.NumFormateur = NumFormateur;
            this.NomFormateur = NomFormateur;
            this.PrenomFormateur = PrenomFormateur;
            this.Age = Age;
            this.sexe = sexe;
            this.situation = situation;
        }

    }
}
