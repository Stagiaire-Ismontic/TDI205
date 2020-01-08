using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormation.Classes
{
    public class Quartier
    {
        public int QuartierId { get; set; }
        public string NomQuartier { get; set; }
        public int Population { get; set; }
        public Ville Ville { get; set; }
        public double TotalQuartier { get;set; }

        public Quartier()
        {

        }

        public Quartier(int QuartierId, string NomQuartier, int Population, Ville Ville, double TotalQuartier)
        {
            this.QuartierId = QuartierId;
            this.NomQuartier = NomQuartier;
            this.Population = Population;
            this.Ville = Ville;
            this.TotalQuartier = TotalQuartier;
        }
        
    }
}
