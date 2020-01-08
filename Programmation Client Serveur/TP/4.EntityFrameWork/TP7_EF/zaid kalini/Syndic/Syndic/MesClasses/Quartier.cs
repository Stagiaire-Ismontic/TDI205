using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.MesClasses
{
    public class Quartier
    {
        public int id { get; set; }
        public string Nom_quartier { get; set; }
        public int Population_quartier { get; set; }
        public Ville ville { get; set; }
        public int Total_quartier { get; set; }
        public Quartier()
        {
                
        }
        public Quartier(int id, string Nom_quartier,int Population_quartier,Ville ville, int Total_quartier)
        {
            this.id = id;
            this.Nom_quartier = Nom_quartier;
            this.Population_quartier = Population_quartier;
            this.ville = ville;
            this.Total_quartier = Total_quartier;
        }
    }
}
