using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacture
{
    public class Facture
    {
        private int id;
        private string titre;
        private double somme;
        private DateTime date;
        private Client client;

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
        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }
        public double Somme
        {
            get
            {
                return somme;
            }

            set
            {
                somme = value;
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
        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public Facture()
        {

        }

        public Facture(string titre,double somme,DateTime date,Client client)
        {
            this.titre = titre;
            this.somme = somme;
            this.date = date;
            this.client = client;
        }
    }
}
