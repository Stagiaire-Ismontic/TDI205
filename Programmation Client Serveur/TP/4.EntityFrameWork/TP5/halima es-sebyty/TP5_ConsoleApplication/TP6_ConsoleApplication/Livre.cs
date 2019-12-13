using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_ConsoleApplication
{
    class Livre
    {
        private int id;
        private string titre;
        private string categorie;
        private string nom_auteur;

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

        public string Nom_auteur
        {
            get
            {
                return nom_auteur;
            }

            set
            {
                nom_auteur = value;
            }
        }

        public Livre(int id, string titre, string catg, string nom_aut)
        {
            this.Id = id;
            this.Titre = titre;
            this.Categorie = catg;
            this.Nom_auteur = nom_aut;
        }


    }
}
