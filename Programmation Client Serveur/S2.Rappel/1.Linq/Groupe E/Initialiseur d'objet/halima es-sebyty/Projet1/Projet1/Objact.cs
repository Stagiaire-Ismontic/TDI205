using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Objact
    {

            private int id;
            private string nom;

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


        public Objact()
        {

        }

        public Objact(int id,string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return "  "+this.id+"  " + this.nom;
        }




    }
}
