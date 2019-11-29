using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_object
{
    class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom ; }
            set { prenom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
