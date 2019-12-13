using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
   public class Editeur
    {
        private int id;


        private string nom;

        private string categorie;

       

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

        public int Id { get => id; set => id = value; }

        public Editeur() { }
        public Editeur(int id, string nom, string categorie)
        {
            this.Id = id;
            this.nom = nom;
            this.categorie = categorie;


        }
        public override string ToString()
        {
            return this.Id + "  /  " + this.nom + "  /  " + this.categorie + "  /  ";
        }
    }
}
