using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.MesClasses
{
    public class Contrat
    {
        public int id { get; set; }
        public DateTime Date_Contrat { get; set; }
        public double Prix_Mensuelle { get; set; }
        public Bien_Immobilier bien_immo { get; set; }
        public Syndic syndic { get; set; }
        public string Etat { get; set; }
        public Contrat()
        {

        }
        public Contrat(int id, DateTime Date_Contrat, double Prix_Mensuelle, Bien_Immobilier bien_immo, Syndic syndic, string Etat)
        {
            this.id = id;
            this.Date_Contrat = Date_Contrat;
            this.Prix_Mensuelle = Prix_Mensuelle;
            this.bien_immo = bien_immo;
            this.syndic = syndic;
            this.Etat = Etat;
        }
    }
}
