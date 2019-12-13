using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple2
{
   public  class Stagiaire
    {
        private string nom;
        private string prenom;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        public Stagiaire()
        {

        }
        public Stagiaire(string nom,string prenom)
        {
            this.nom = nom;
            this.Prenom = prenom;

        }
        public override string ToString()
        {
            string str = "le nom: "+this.Nom +","+"le prenom:"+ this.Prenom;
            return str;
        }
    }
}
