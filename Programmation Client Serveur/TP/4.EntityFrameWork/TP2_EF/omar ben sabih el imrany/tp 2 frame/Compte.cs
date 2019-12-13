using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace tp_2_frame
{
    public partial class Compte
    {
        public int id { get; set; }
        public Nullable<int> solde { get; set; }
    }
}
