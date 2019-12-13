using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_livre
{
  public  class Stagiaire
    {
        private int id;
        private string nom;
        private string prenom;
        private string groupe;

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

        public string Groupe
        {
            get
            {
                return groupe;
            }

            set
            {
                groupe = value;
            }
        }


    }
}
