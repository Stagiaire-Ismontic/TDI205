using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class Commande
    {
        public int CommandeId { get; set; }
        public string Description { get; set; }
        public double Somme { get; set; }
        public List<Produit> ListProduit { get; set; }

        public Commande()
        {

        }

        public Commande(string Description,double Somme, List<Produit> ListProduit)
        {
            this.Description = Description;
            this.Somme = Somme;
            this.ListProduit = ListProduit;
        }

        public Commande(int CommandeId,string Description, double Somme, List<Produit> ListProduit)
        {
            this.CommandeId = CommandeId;
            this.Description = Description;
            this.Somme = Somme;
            this.ListProduit = ListProduit;
        }
    }
}
