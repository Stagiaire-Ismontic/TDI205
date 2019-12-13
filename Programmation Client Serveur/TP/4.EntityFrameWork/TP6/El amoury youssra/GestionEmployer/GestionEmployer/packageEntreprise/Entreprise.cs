using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployer
{
   public  class Entreprise
    {
        private int id;
        private string nom;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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
        public Entreprise()
        {

        }
        public Entreprise(int id,string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
