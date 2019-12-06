using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Etablissment.Entity
{
    
    public class Formateur
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tele { get; set; }
        public override string ToString()
        {
            return $"Nom de formateur {Nom} {Prenom} ";
        }
    }
}
