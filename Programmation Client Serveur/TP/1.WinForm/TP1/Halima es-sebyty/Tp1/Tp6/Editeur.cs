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

        private int id_livre;


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

        public int Id_livre
        {
            get
            {
                return id_livre;
            }

            set
            {
                id_livre = value;
            }
        }

        public Editeur() { }
        public Editeur(int id, string nom, string categorie, int id_livre)
        {
            this.id = id;
            this.nom = nom;
            this.categorie = categorie;
            this.id_livre = id_livre;

        }
        public override string ToString()
        {
            return this.id + "  /  " + this.nom + "  /  " + this.categorie + "  /  " + this.id_livre;
        }
    }
}
