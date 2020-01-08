using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormation.Classes
{
    public class BienImmobilier
    {
        public int BienId { get; set; }
        public string AdresseBien { get; set; }
        public int NumEnregistrement { get; set; }
        public int Superficie { get; set; }
        public string Type { get; set; }
        public Quartier Quartier { get; set; }
        public DateTime DateConstruction { get; set; }

        public BienImmobilier()
        {

        }

        public BienImmobilier(int BienId, string AdresseBien, int NumEnregistrement, int Superficie, string Type, Quartier Quartier, DateTime DateConstruction)
        {
            this.BienId = BienId;
            this.AdresseBien = AdresseBien;
            this.NumEnregistrement = NumEnregistrement;
            this.Superficie = Superficie;
            this.Type = Type;
            this.Quartier = Quartier;
            this.DateConstruction = DateConstruction;
        }



    }
}
