using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_console
{
 public   class Editeur
    {
        private int id;

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

        private string nom;
        private string categorie;
        public Editeur() { }
        public Editeur(int id, string nom, string categorie)
        {
            this.id = id;
            this.nom = nom;
            this.categorie = categorie;

        }
        public override string ToString()
        {
            return this.id + " / " + this.nom  + " / " + this.categorie;
        }


    }
}
