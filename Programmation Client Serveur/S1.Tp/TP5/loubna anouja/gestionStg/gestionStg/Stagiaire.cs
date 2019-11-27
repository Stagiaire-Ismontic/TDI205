using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionStg
{
    class Stagiaire
    {
        int id;
        string nom;
        string prenom;

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
        public Stagiaire(){}
        public Stagiaire(int id, string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
        }
    }
}
