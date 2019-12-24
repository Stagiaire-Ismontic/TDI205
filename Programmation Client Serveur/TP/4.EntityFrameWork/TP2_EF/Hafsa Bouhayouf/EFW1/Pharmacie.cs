using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW1
{
   public class Pharmacie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adress { get; set; }

        public ICollection<Medicament> medicaments { get; set; }
    }
}
