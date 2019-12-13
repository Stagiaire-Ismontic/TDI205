using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3modeConnecte
{
    public class commande
    {
        int id;
        string code;
        string nom;

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

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
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
        public commande() { }
        public commande(int id, string c, string n)
        {
            Id = id;
            Code = c;
            Nom = n;
        }
    }
}
