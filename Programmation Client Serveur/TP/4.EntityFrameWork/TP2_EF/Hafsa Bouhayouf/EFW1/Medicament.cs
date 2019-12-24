using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW1
{
   public class Medicament
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public int Prix { get; set; }
       

        public Pharmacie pharmacie { get; set; }
    }
}
