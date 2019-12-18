using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Entraineur
    {
        private int id;
        private string nom;
        private string prenom;


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
        public Entraineur() { }
        public Entraineur(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
