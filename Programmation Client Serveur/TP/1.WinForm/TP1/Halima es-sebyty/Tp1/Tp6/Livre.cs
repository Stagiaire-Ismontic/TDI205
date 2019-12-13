using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
  public  class Livre
    {
        private int id;

        private string titre;

        private string categorie;


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

        public string Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }

        public Livre() { }

        public Livre(int id,string titre,string categorie)
        {
            this.id = id;
            this.titre = titre;
            this.categorie = categorie;
        }

        public override string ToString()
        {
            return this.id + "  /  " + this.titre + "  /  " + this.categorie;
        }
    }
}
