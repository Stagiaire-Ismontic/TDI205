using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Classes
{
    public class Syndic
    {
        public int Id { get; set; }
        public string NomSyndic { get; set; }
        public string PrenomSyndic { get; set; }
        public string Telephone { get; set; }
        public string MotdePasse { get; set; }

        public Syndic()
        {

        }

        public Syndic(int Id, string NomSyndic, string PrenomSyndic, string Telephone, string MotdePasse)
        {
            this.Id = Id;
            this.NomSyndic = NomSyndic;
            this.PrenomSyndic = PrenomSyndic;
            this.Telephone = Telephone;
            this.MotdePasse = MotdePasse;
        }
    }
}
