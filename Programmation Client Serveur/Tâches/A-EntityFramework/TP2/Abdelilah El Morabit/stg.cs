using System;
using System.Collections.Generic;
namespace TP2

{

    
    public partial class stg
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int groupeid { get; set; }
    
        public virtual groupe groupe { get; set; }
    }
}
