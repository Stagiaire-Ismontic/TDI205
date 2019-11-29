using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple
{
    public class Projets
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

        public Projets()
        {

        }

        public Projets(int id,string nom)
        {
            this.id = id;
            this.nom = nom;
        }

    }
}
