using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Commande
    {
        public int CommandeId { get; set; }
        public string Descriptions { get; set; }
        public double Prix { get; set; }
        public Produit Produit { get; set; }

        public Commande()
        {

        }

        public Commande(int CommandeId, string Descriptions, double Prix, Produit Produit)
        {
            this.CommandeId = CommandeId;
            this.Descriptions = Descriptions;
            this.Prix = Prix;
            this.Produit = Produit;
        }
    }
}
