using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Classes
{
    public class Region
    {
        public int Id { get; set; }
        public string NomRegion { get; set; }
        public int Population { get; set; }
        public double TotalRegion { get; set; }

        public Region()
        {

        }

        public Region(int Id, string NomRegion, int Population, double TotalRegion)
        {
            this.Id = Id;
            this.NomRegion = NomRegion;
            this.Population = Population;
            this.TotalRegion = TotalRegion;
        }

        public override string ToString()
        {
            return NomRegion;
        }
    }
}
