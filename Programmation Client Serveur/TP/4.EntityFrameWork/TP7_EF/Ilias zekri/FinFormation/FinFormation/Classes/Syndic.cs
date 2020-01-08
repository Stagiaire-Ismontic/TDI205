using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormation.Classes
{
    public class Syndic
    {
        public int SyndicId { get; set; }
        public string NomSyndic { get; set; }
        public string PrenomSyndic { get; set; }
        public string Telephone { get; set; }
        public string MotDePasse { get; set; }
        
        public Syndic()
        {

        }

        public Syndic(int SyndicId, string NomSyndic, string PrenomSyndic, string Telephone, string MotDePasse)
        {
            this.SyndicId = SyndicId;
            this.NomSyndic = NomSyndic;
            this.PrenomSyndic = PrenomSyndic;
            this.Telephone = Telephone;
            this.MotDePasse = MotDePasse;
        }

    }
}
