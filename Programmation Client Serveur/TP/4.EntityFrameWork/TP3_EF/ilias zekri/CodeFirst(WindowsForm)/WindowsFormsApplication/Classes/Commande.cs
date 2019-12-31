using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Classes
{
    public class Commande
    {
        public int CommandeId { get; set; }
        public string Descriptions { get; set; }
        public double Prix { get; set; }
        
        public virtual Produit Produit { get; set; }

        public Commande()
        {

        }

        public Commande(string Descriptions, double Prix, Produit Produit)
        {
            this.Descriptions = Descriptions;
            this.Prix = Prix;
            this.Produit = Produit;
        }
        public Commande(int CommandeId,string Descriptions, double Prix, Produit Produit)
        {
            this.CommandeId = CommandeId;
            this.Descriptions = Descriptions;
            this.Prix = Prix;
            this.Produit = Produit;
        }
    }
}
