using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployer
{
  public  class Employer

    {
        private int id;
        private string nom;
        private string prenom;
        private Entreprise Entreprise;

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

       

        internal Entreprise Entreprise1
        {
            get
            {
                return Entreprise;
            }

            set
            {
                Entreprise = value;
            }
        }

        public Employer()
        {}

        public Employer(int id,string nom,string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Entreprise = Entreprise;
        }


    }
}
