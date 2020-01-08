using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Classes
{
    public class BienImmobilier
    {

        public int Id { get; set; }
        public string AdresseBienImmobilier { get; set; }
        public int NumEnregistrement { get; set; }
        public int Superficie { get; set; }
        public string Type { get; set; }
        public virtual Quartier Quartier { get; set; }
        public DateTime DateConstruction { get; set; }

        public BienImmobilier()
        {

        }

        public BienImmobilier(int Id, string AdresseBienImmobilier, int NumEnregistrement, int Superficie, string Type, Quartier Quartier, DateTime DateConstruction)
        {
            this.Id = Id;
            this.AdresseBienImmobilier = AdresseBienImmobilier;
            this.NumEnregistrement = NumEnregistrement;
            this.Superficie = Superficie;
            this.Type = Type;
            this.Quartier = Quartier;
            this.DateConstruction = DateConstruction;
        }
    }
}
