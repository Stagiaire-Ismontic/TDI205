using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Produit
    {
        public int ProduitId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }

        public Produit()
        {

        }

        public Produit(int ProduitId, string Nom, double Prix)
        {
            this.ProduitId = ProduitId;
            this.Nom = Nom;
            this.Prix = Prix;
        }
    }
}
