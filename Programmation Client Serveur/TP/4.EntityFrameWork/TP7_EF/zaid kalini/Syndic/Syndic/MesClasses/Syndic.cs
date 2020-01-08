using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndic.MesClasses
{
    public class Syndic
    {
        public int id { get; set; }
        public string Nom_syndic { get; set; }
        public string Prenom_syndic { get; set; }
        public string Telephone { get; set; }
        public string Mot_de_passe { get; set; }
        public Syndic()
        {
                
        }
        public Syndic( int id,string Nom_syndic, string Prenom_syndic,string Telephone, string Mot_de_passe)
        {
            this.id = id;
            this.Nom_syndic = Nom_syndic;
            this.Prenom_syndic = Prenom_syndic;
            this.Telephone = Telephone;
            this.Mot_de_passe = Mot_de_passe;
        }

    }
}
