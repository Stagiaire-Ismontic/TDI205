using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Classes
{
    public class Produit
    {
        public int ProduitId { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }

        public Produit()
        {

        }

        public Produit( string Nom, double Prix)
        {
            this.Nom = Nom;
            this.Prix = Prix;
        }

        public Produit(int ProduitId,string Nom, double Prix)
        {
            this.ProduitId = ProduitId;
            this.Nom = Nom;
            this.Prix = Prix;
        }
        public override string ToString()
        {
            return this.Nom; 
        }
    }
}
