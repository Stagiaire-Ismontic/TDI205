using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Objet
    {
        private int id;
        private string Nom;

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

        public string Nom1
        {
            get
            {
                return Nom;
            }

            set
            {
                Nom = value;
            }
        }
    }
}
