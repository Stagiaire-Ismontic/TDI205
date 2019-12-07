using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Windows
{
    public class commande:livraison
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
        public commande(int id, string c, string n,int il,DateTime d):base(il,d)
        {
            Id = id;
            Code = c;
            Nom = n;
        }
    }
}
