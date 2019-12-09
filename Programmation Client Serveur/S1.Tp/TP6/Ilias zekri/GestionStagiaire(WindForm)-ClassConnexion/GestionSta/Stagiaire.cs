using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSta
{
    public class Stagiaire
    {
        private int id;
        private string cin;
        private string nom;
        private string groupe;

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

        public string Groupe
        {
            get
            {
                return groupe;
            }

            set
            {
                groupe = value;
            }
        }

        public Stagiaire()
        {

        }
        public Stagiaire(int id, string cin, string nom, string groupe)
        {
            this.id = id;
            this.Nom = nom;
            this.cin = cin;
            this.groupe = groupe;
        }

        public override string ToString()
        {
            return "Id : " + id + " Cin : " + cin + " Nom : " + nom + " Groupe : " + groupe;
        }

    }
}
