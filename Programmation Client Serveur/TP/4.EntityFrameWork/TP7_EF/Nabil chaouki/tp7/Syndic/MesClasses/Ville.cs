using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.MesClasses
{
    public class Ville
    {
        public int id { get; set; }
        public string Nom_ville { get; set; }
        public Region region { get; set; }
        public int Total_ville { get; set; }
        public Ville()
        {
            
        }
        public Ville(int id, string Nom_Ville, Region region, int Total_ville)
        {
            this.id = id;
            this.Nom_ville = Nom_ville;
            this.region = region;
            this.Total_ville = Total_ville;
        }
    }
  
}
