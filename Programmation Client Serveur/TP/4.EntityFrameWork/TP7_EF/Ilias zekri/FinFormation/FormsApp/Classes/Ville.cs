using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Classes
{
    public class Ville
    {
        public int Id { get; set; }
        public string NomVille { get; set; }
        public virtual Region Region { get; set; }
        public double TotalVille { get; set; }

        public Ville()
        {

        }

        public Ville(int Id, string NomVille, Region Region, double TotalVille)
        {
            this.Id = Id;
            this.NomVille = NomVille;
            this.Region = Region;
            this.TotalVille = TotalVille;
        }
        public override string ToString()
        {
            return NomVille;
        }
    }
}
