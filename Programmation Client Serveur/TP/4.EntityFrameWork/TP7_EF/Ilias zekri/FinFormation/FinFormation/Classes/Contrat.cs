using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormation.Classes
{
    public class Contrat
    {
        public int ContratId { get; set; }
        public DateTime DateContrat { get; set; }
        public double PrixMensuel { get; set; }
        public BienImmobilier Bien { get; set; }
        public Syndic Syndic { get; set; }
        public string Etat { get; set;  }

        public Contrat()
        {

        }

        public Contrat(int ContratId, DateTime DateContrat, double PrixMensuel, BienImmobilier Bien, Syndic Syndic, string Etat)
        {
            this.ContratId = ContratId;
            this.DateContrat = DateContrat;
            this.PrixMensuel = PrixMensuel;
            this.Bien = Bien;
            this.Syndic = Syndic;
            this.Etat = Etat;
        }


    }
}
