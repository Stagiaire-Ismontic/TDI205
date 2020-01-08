using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Classes
{
    public class Contrat
    {
        public int Id { get; set; }
        public DateTime DateContrat { get; set; }
        public double PrixMensuel { get; set; }
        public virtual BienImmobilier Bien { get; set; }
        public virtual Syndic Syndic { get; set; }
        public string Etat { get; set; }

        public Contrat()
        {

        }

        public Contrat(int Id, DateTime DateContrat, double PrixMensuel, BienImmobilier Bien, Syndic Syndic, string Etat)
        {
            this.Id=Id;
            this.DateContrat = DateContrat;
            this.PrixMensuel = PrixMensuel;
            this.Bien = Bien;
            this.Syndic = Syndic;
            this.Etat = Etat;
        }
    }
}
