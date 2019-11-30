using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConx
{
    public class Stagiaire
    {
        private int id;
        private string cin;
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
        public string Cin
        {
            get
            {
                return cin;
            }

            set
            {
                cin = value;
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

        public Stagiaire()
        {

        }
        public Stagiaire(int id, string cin, string nom)
        {
            this.id = id;
            this.Nom = nom;
            this.cin = cin;
        }

        public override string ToString()
        {
            return "Id : " + id + " CIN : " + cin + " Nom : " + nom;
        }
    }
}
