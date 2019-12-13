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
        private Groupe gr;
        private DateTime date;

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
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public Groupe Gr
        {
            get
            {
                return gr;
            }

            set
            {
                gr = value;
            }
        }

        public Stagiaire()
        {

        }

        public Stagiaire(int id,string cin,string nom,Groupe gr,DateTime date)
        {
            this.id = id;
            this.cin = cin;
            this.nom = nom;
            this.gr = gr;
            this.date = date;
        }

        public override string ToString()
        {
            return  "Id :"+id+"  Cin :"+cin + "  Nom : " + nom+"  Groupe :"+gr+"  Date :"+date;
        }


    }
}
