using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.MesClasses
{
    public class Region
    {
        public int id { get; set; }
        public string Nom_region { get; set; }
        public int Population_total { get; set; }
        public int Total_Region { get; set; }
        public Region()
        {

        }
        public Region(int id, string Nom_region, int Population_total, int Total_Region)
        {
            this.id = id;
            this.Nom_region = Nom_region;
            this.Population_total = Population_total;
            this.Total_Region = Total_Region;
        }
    }
}
