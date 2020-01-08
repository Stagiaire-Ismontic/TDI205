using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormation.Classes
{
    public class Ville
    {
        public int VilleId { get; set; }
        public string NomVille { get; set; }
        public Region Regien { get; set; }
        public double TotalVille { get; set; }

        public Ville()
        {

        }

        public Ville(int VilleId, string NomVille, Region Regien, double TotalVille)
        {
            this.VilleId = VilleId;
            this.NomVille = NomVille;
            this.Regien = Regien;
            this.TotalVille = TotalVille;
        }
    }
}
