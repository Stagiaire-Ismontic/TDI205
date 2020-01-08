using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormation.Classes
{
    public class Region
    {
        public int RegionId { get; set; }
        public string NomRegion { get; set; }
        public int Population { get; set; }
        public double TotalRegion { get; set; }

        public Region()
        {

        }

        public Region(int RegionId, string NomRegion, int Population, double TotalRegion)
        {
            this.RegionId = RegionId;
            this.NomRegion = NomRegion;
            this.Population = Population;
            this.TotalRegion = TotalRegion;
        }

    }
}
