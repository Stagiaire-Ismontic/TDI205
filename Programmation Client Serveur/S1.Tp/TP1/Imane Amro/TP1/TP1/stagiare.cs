using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class stagiare
    {
        int id;
        string nom;
        string prenom;
        

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
        
        public stagiare(int i, string n, string p)
        {
            this.Id = i;
            this.Nom = n;
            this.Prenom = p;
            
        }
        public stagiare()
        { }
    }
}
