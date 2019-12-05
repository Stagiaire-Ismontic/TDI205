using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSta
{
    public class Groupe
    {
        private string nom;
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

        public Groupe()
        {

        }

        public Groupe(string nom)
        {
            this.nom = nom;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
