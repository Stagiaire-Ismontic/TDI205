using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.MesClasses
{
    public class Bien_Immobilier
    {
        public int id { get; set; }
        public string Addresse { get; set; }
        public int Num_enregistrement { get; set; }
        public int Superficie { get; set; }
        public string Type { get; set; }
        public Quartier quartier { get; set; }
        public DateTime Date_construction { get; set; }
        public Bien_Immobilier()
        {

        }
        public Bien_Immobilier(int id,string Addresse, int Num_enregistrement, int Superficie, string Type, Quartier quartier, DateTime Date_construction)
        {
            this.id = id;
            this.Addresse = Addresse;
            this.Num_enregistrement = Num_enregistrement;
            this.Superficie = Superficie;
            this.Type = Type;
            this.quartier = quartier;
            this.Date_construction = Date_construction;
        }
    }
}
