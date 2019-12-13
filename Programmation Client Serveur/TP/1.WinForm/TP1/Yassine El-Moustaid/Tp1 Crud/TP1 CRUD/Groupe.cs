using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CRUD
{
    public class Groupe
    {
        private string nom;
        private int ID;

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

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public Groupe(int ID,string nom)
        {
            this.ID1 = ID;
            this.Nom = nom;
        }
    }
}
