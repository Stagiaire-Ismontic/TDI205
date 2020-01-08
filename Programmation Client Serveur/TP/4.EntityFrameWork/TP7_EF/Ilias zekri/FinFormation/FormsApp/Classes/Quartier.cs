using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Classes
{
    public class Quartier
    {
        public int Id { get; set; }
        public string NomQuartier { get; set; }
        public int Population { get; set; }
        public virtual Ville Ville { get; set; }
        public double TotalQuartier { get;set; }

        public Quartier()
        {

        }

        public Quartier(int Id, string NomQuartier, int Population, Ville Ville, double TotalQuartier)
        {
            this.Id = Id;
            this.NomQuartier = NomQuartier;
            this.Population = Population;
            this.Ville = Ville;
            this.TotalQuartier = TotalQuartier;
        }
        
    }
}
