using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsF.Classes
{
    public class Facture
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public double Somme { get; set; }
        public Client Client { get; set; }

        public Facture()
        {

        }
        public Facture(int Id,string Titre, double Somme, Client Client)
        {
            this.Id = Id;
            this.Titre = Titre;
            this.Somme = Somme;
            this.Client = Client;
        }
        public Facture(string Titre,double Somme,Client Client)
        {
            this.Titre = Titre;
            this.Somme = Somme;
            this.Client = Client;
        }

        public override string ToString()
        {
            return Id+Titre+Somme+Client;
        }
    }
}
