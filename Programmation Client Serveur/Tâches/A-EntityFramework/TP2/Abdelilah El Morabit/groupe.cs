using System;
using System.Collections.Generic;

namespace TP2
{

    
    public partial class groupe
    {

    
        public int Id { get; set; }
        public string nom { get; set; }
        public virtual ICollection<stg> stgs { get; set; }
    }
}
