using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionTaches.GestionProjets
{
    public class Projets
    {
        int id;
        string titre;
        string description;
        DateTime DateCreation;
        DateTime DateModification;

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

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime DateCreation1
        {
            get
            {
                return DateCreation;
            }

            set
            {
                DateCreation = value;
            }
        }

        public DateTime DateModification1
        {
            get
            {
                return DateModification;
            }

            set
            {
                DateModification = value;
            }
        }
    }
}
