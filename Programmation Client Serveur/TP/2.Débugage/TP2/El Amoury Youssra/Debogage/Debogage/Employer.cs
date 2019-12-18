using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debogage
{
  public   class Employer
    {
        private int id;
        private string nom;
        private string prenom;

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
        public Employer(int id,string nom,string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public override string ToString()
        {
            string str = "id= " + this.id + ", le nom= " + this.nom + " ,le prenom= " + this.prenom;
            return str;
        }
    }
}
