using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GestionGroupe
{
    class Personne
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

        private string nom;
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
        private int age;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

    }
}
