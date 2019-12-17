using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
   public  class Employer
    {
        private int id;
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

        public Employer( int id ,string nom,string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;

        }
        public Employer (int id)
        {
            this.Id = id;
        }
    }
}
