using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6.PackageEtudiants
{
   public  class Etudiant
    {
        int id;
        string nom;
        string prenom;
        int age;

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
        public Etudiant(int i,string n,string p,int a)
        {
            this.Id = i;
            this.Nom = n;
            this.Prenom = p;
            this.Age = a;
        }
        public Etudiant()
        { }
    }
}
