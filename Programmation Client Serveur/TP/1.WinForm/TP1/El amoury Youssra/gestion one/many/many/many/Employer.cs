using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace many
{
     public class Employer
    {
        private int id;
        private string nom;
        private string prenom;
        private Entreprise entreprise;
 
  

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

        public Entreprise Entreprise
        {
            get
            {
                return entreprise;
            }

            set
            {
                entreprise = value;
            }
        }

        public Employer(int id,string nom,string prenom,Entreprise entreprise )
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.entreprise = entreprise;
        }
        public Employer()
        {

        }

      
    }
}
