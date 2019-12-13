using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public partial class gestionEtidiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }
        public Nullable<int> IdEntreprise { get; set; }

        public virtual Etudiant Etudiant { get; set; }
    }

}
