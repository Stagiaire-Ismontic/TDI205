using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
   public class Etudiant
    {
        int id;
        string nom;
        string prenom;
        string cin;

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
        public string Cin { get => cin; set => cin = value; }
        public Etudiant(int i, string n, string p, string cin)
        {
            this.Id = i;
            this.Nom = n;
            this.Prenom = p;
            this.Cin = cin;

        }
        public Etudiant()
        { }
    }
}